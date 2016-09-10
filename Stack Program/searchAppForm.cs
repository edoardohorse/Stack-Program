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

        List<String> programs = new List<string>();
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

        }


        public void GetInstalledApps()
        {
            string path = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu))[1];
            string path2 = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu))[1];

            var dir = Directory.GetDirectories(path);
            var dir2 = Directory.GetDirectories(path2);
            string[] concat = new string[dir.Length + dir2.Length];
            dir.CopyTo(concat, 0);
            dir2.CopyTo(concat, dir.Length);

            var f = Directory.GetFiles(path, "*.lnk");


            foreach (string i in concat)
            {
                var t = Directory.GetFiles(i, "*.lnk");
                foreach (string c in t)
                {
                    //FileInfo temp = new FileInfo(c);
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

            }
            treeLnk.Sort((x, y) => string.Compare(x.name, y.name));





        }

        public void populateTree()
        {

            List<String> alphabet = new List<String>();

            tree.Nodes.Clear();
            int lastIndex = 0 ;

            for (int i = 0; i < treeLnk.Count; i++)
            {

                string t = treeLnk[i].name.Substring(0, 1).ToString().ToUpper();

                //TreeNode temp = new TreeNode();
                //temp.Name = t;
                if (!tree.Nodes.ContainsKey(t))
                {
                    tree.Nodes.Insert(i, t, t);
                    alphabet.Add( t );
                }
                    


                
            }
            int c=0;

            for (int i = 0; i < alphabet.Count; i++)
            {

                for (; c < treeLnk.Count; c++)
                {
                    if (treeLnk[c].name.ToUpper().StartsWith( alphabet[i] ))
                    {
                        tree.Nodes[i].Nodes.Add(treeLnk[ c ].name);
                    }
                    else
                        break;
                }

                    

               
            }

            tree.ExpandAll();

        }


        /*
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = 0;
            
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product"); //  Where Name='iTunes'
            ManagementObjectCollection collection = mos.Get();
            foreach (ManagementObject mo in collection)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Console.WriteLine(mo["Name"]);
                    if( mo["Name"] != null && mo["InstallLocation"] != null)
                        programs.Add(mo["InstallLocation"].ToString()+mo["Name"].ToString()+".exe" );
                    worker.ReportProgress(i++);
                    

                }
            }

        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if( e.ProgressPercentage < 100 )
                barSearch.Value = e.ProgressPercentage;
           
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Console.WriteLine("Canceled!");
            }
            else if (e.Error != null)
            {
                Console.WriteLine("Error: " + e.Error.Message);
            }
            else
            {
                Console.WriteLine("Done!");
                barSearch.Visible = false;
                lbInfo.Visible = false;

                foreach( var i in programs)
                {
                    gridSearch.Rows.Add();
                    gridSearch.Rows[gridSearch.RowCount - 1].Cells[0].Value = i;
                }

                gridSearch.Sort(gridSearch.Columns[0], ListSortDirection.Ascending);
                
            }
        }

        private void cancelAsync(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }*/
    }
}
