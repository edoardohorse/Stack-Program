using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Threading;
using IWshRuntimeLibrary;
using System.IO;

namespace Stack_Program
{
    public partial class searchAppForm : Form
    {

        public List<File> selectedPrograms = new List<File>();


        List<File> treeLnk = new List<File>();

        public searchAppForm()
        {
            InitializeComponent();
            //lbInfo.BackColor = Color.Transparent;
            // backgroundWorker1.WorkerReportsProgress = true;
            // backgroundWorker1.WorkerSupportsCancellation = true;
        }



        private delegate void DelegateSearchDone();

        private void searchApp_load(object sender, EventArgs e)
        {

            this.Activate();
            /* gridSearch.AllowUserToAddRows = false;
             gridSearch.AllowUserToDeleteRows = false;
             gridSearch.ReadOnly = true;
             gridSearch.RowHeadersVisible = false;
             gridSearch.AllowUserToResizeRows = false;
             gridSearch.ShowCellToolTips = true;
             gridSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             gridSearch.MultiSelect = false;
             gridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
             gridSearch.AllowUserToOrderColumns = true;
             gridSearch.ColumnCount = 20;*/

            /*gridSearch.Columns[0].Name = "Nome";
            gridSearch.Columns[1].Name = "Dir";
            gridSearch.Columns[2].Name = "Icon";*/
            

        }



        private void saerchAppForm_Shown(object sender, EventArgs e)
        {

            Console.WriteLine("iniziato");
            // backgroundWorker1.RunWorkerAsync();
           

            GetInstalledApps();
            populateTree();
            tree.Visible = true;
        //    provaDraw();

        }


        public void GetInstalledApps()
        {
            string path = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu))[1];
            string path2 = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu))[1];

            var dir = Directory.GetDirectories(path);
            var dir2 = Directory.GetDirectories(path2);
            string[] concat = new string[dir.Length + dir2.Length +2 ];
            dir.CopyTo(concat, 0);
            dir2.CopyTo(concat, dir.Length);


            concat[concat.Length - 2] = path;
            concat[concat.Length - 1] = path2;

            foreach (string i in concat)
            {
                string[] t = Directory.GetFiles(i);

                

                foreach (string c in t)
                {
                    FileInfo temp1 = new FileInfo(c);
                    if (temp1.Extension == ".lnk")
                    {
                        IWshShell shell = new WshShell();
                        var lnk = shell.CreateShortcut(c) as IWshShortcut;

                        if (lnk.TargetPath.EndsWith(".exe"))
                        {
                            File temp = new Stack_Program.File(c);
                            temp.parentDir = c.Split(new[] { path }, StringSplitOptions.RemoveEmptyEntries)[0];
                            if (temp.parentDir != null)
                                temp.parentDir = c.Split(new[] { path2 }, StringSplitOptions.RemoveEmptyEntries)[0];

                            treeLnk.Add(temp);
                        }

                    }

                    if( temp1.Extension == ".appref-ms")
                    {
                        File temp = new Stack_Program.File(c);
                        temp.parentDir = c.Split(new[] { path }, StringSplitOptions.RemoveEmptyEntries)[0];
                        if (temp.parentDir != null)
                            temp.parentDir = c.Split(new[] { path2 }, StringSplitOptions.RemoveEmptyEntries)[0];

                        treeLnk.Add(temp);
                    }
                    
                    
                }

            }
            treeLnk.Sort((x, y) => string.Compare(x.name, y.name));





        }

        public void populateTree()
        {

            List<String> alphabet = new List<String>();

            tree.Nodes.Clear();

            for (int i = 0; i < treeLnk.Count; i++)
            {

                string t = treeLnk[i].name.Substring(0, 1).ToString().ToUpperInvariant();

                //TreeNode temp = new TreeNode();
                //temp.Text = t;
                
                if (!tree.Nodes.ContainsKey(t))
                {
                    tree.Nodes.Insert(i, t, t);

                    

                    //tree.Nodes[i].StateImageIndex = 
                    alphabet.Add( t );
                }
                    


                
            }
            int c=0;

            for (int i = 0; i < alphabet.Count; i++)
            {

                for (; c < treeLnk.Count; c++)
                {
                    if (treeLnk[c].name.ToUpperInvariant().StartsWith( alphabet[i] ))
                    {
                        tree.Nodes[i].Nodes.Add(treeLnk[ c ].name);
                        tree.Nodes[i].Nodes[tree.Nodes[i].Nodes.Count -1].ToolTipText = treeLnk[c].dir.ToString();
                        
                    }
                    else
                        break;
                }

                    

               
            }

            tree.ExpandAll();
            tree.Nodes[0].EnsureVisible();
        }

        public void provaDraw()
        {
         /*   System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            Point p = new Point();
            p.X = 20;
            p.Y = 20;

            Graphics theGraphics = Graphics.FromHwnd(this.Handle);

            Bitmap img = new Bitmap(100, 100, theGraphics);
            this.DrawToBitmap(img, new Rectangle(20,20));


            //formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 10, 10));
            myBrush.Dispose();
            formGraphics.Dispose();*/
        }

        private void searchDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void addProgramToSelection(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
                selectedPrograms.Add(treeLnk.Find(delegate (File temp) { return temp.name == e.Node.Text; }));
            else
                selectedPrograms.Remove(treeLnk.Find(delegate (File temp) { return temp.name == e.Node.Text; }));
        }

      
    }

}
