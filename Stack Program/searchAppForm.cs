using System;
using System.Collections;
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


        List<File> lnkList = new List<File>();
        Dictionary<string, List<File>> lnkDictionaryByFolder = new Dictionary<string, List<File>>();
        Dictionary<string, List<File>> lnkDictionaryByFirstLetter = new Dictionary<string, List<File>>();
        List<String> lnkArrayAlphabet = new List<string>();

        public class NodeSorterAZ : IComparer
        {

            public int Compare(object x, object y)
            {
                TreeNode tx = x as TreeNode;
                TreeNode ty = y as TreeNode;

                string txText = tx.Text.ToString();
                string tyText = ty.Text.ToString();



                return String.Compare(txText, tyText);


            }
        }

        public class NodeSorterZA : IComparer
        {

            public int Compare(object x, object y)
            {
                TreeNode tx = x as TreeNode;
                TreeNode ty = y as TreeNode;

                string txText = tx.Text.ToString();
                string tyText = ty.Text.ToString();



                return String.Compare(tyText, txText);


            }
        }


        public searchAppForm(List<File> filesAlreadyInProfile)
        {
            InitializeComponent();

            selectedPrograms.AddRange(filesAlreadyInProfile);
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



        private void searchAppForm_Shown(object sender, EventArgs e)
        {
            searchTB.Focus();
            Console.WriteLine("iniziato");
            // backgroundWorker1.RunWorkerAsync();
           

            getInstalledApps();

            populateTree(lnkDictionaryByFirstLetter, tree);

            tree.Visible = true;
        //    provaDraw();

        }

        private void searchBox_Focus(object sender, EventArgs e)
        {
            searchTB.Text = "";
            searchTB.ForeColor = Color.Black;

        }

        private void searchBox_Blur(object sender, EventArgs e)
        {
            if(searchTB.Text == "") {
                searchTB.Text = "Cerca";
                searchTB.ForeColor = Color.LightGray;
            }

        }


        public void getInstalledApps()
        {


            const string PathStartMenu  = "C:\\ProgramData\\Start Menu\\Programs";
            string[] paths = Directory.GetDirectories(PathStartMenu);
            string[] pathStartMenuSplit = PathStartMenu.Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

            appendPathToList(new string[1] { PathStartMenu}, false);
            appendPathToList(paths, true);
            lnkList.Sort((x, y) => string.Compare(x.name, y.name));

            void appendPathToList(string[] pathsToAppend, bool recursive = false)
            {

                               
                foreach (string path in pathsToAppend) {

                    if (!System.IO.Directory.Exists(path))
                        continue;

                    if (recursive) {
                        string[] subfolders = Directory.GetDirectories(path);

                        if (subfolders.Length > 0) {
                            appendPathToList(subfolders);
                        }
                    }
                    

                    string[] t = Directory.GetFiles(path);



                    foreach (string c in t) {
                        FileInfo temp1 = new FileInfo(c);
                        if (temp1.Extension == ".lnk") {
                            IWshShell shell = new WshShell();
                            var lnk = shell.CreateShortcut(c) as IWshShortcut;

                            if (lnk.TargetPath.EndsWith(".exe") || lnk.TargetPath.EndsWith(".EXE")) {
                                File temp = new Stack_Program.File(c);

                                string[] fullPathSplit = c.Split(new[] {"\\"}, StringSplitOptions.RemoveEmptyEntries);

                                fullPathSplit = fullPathSplit.Skip(pathStartMenuSplit.Length).ToArray();

                                temp.parentDir = fullPathSplit[0] == temp.fileName ? "Programmi" : fullPathSplit[0];

                                lnkList.Add(temp);
                            }

                            continue;
                        }

                        if (temp1.Extension == ".appref-ms") {
                            File temp = new Stack_Program.File(c);
                            temp.parentDir = c.Split(new[] { PathStartMenu }, StringSplitOptions.RemoveEmptyEntries)[0];
                            if (temp.parentDir != null)
                                temp.parentDir = c.Split(new[] { PathStartMenu }, StringSplitOptions.RemoveEmptyEntries)[0];

                            lnkList.Add(temp);
                        }


                    }

                }
                

            }

            linkFoundLbl.Text = $"{lnkList.Count} programmi trovati";


            string[] keys = lnkList.Select(l => l.parentDir).Distinct().ToArray();
            Array.Sort(keys);

            foreach (string key in keys) {
                lnkDictionaryByFolder[key] = lnkList.Where(lnk => lnk.parentDir == key).ToList();
            }

            string[] alphabet = lnkList.Select(
                lnk => lnk.name
            ).Distinct().ToArray();

            
            foreach (string word in alphabet)
            {
                string letter = word.Substring(0, 1).ToString().ToUpperInvariant();
                lnkDictionaryByFirstLetter[letter] =
                    lnkList.Where(lnk => lnk.name.StartsWith(letter, true, null) ).ToList();

                lnkArrayAlphabet.Add(word);
            }



        }

        private void populateTree( Dictionary<string, List<File>> dict, My.Examples.UserControls.TriStateTreeView tree)
        {

            tree.Visible = false;
            bool alreadyAdded = false;
            int nAlreayAdded = selectedPrograms.Count;

            foreach (KeyValuePair<string, List<File>> pair in dict)
            {

                if (nAlreayAdded <= 0) {
                    alreadyAdded = true;
                }

                TreeNode nodeParent = new TreeNode(pair.Key);
                int nChecked = 0;
                

                pair.Value.ForEach(lnk => {
                    TreeNode child = new TreeNode(lnk.name);

                    if (selectedPrograms.Count > 0 && !alreadyAdded) { 

                         File[] fileAlreadyInProfile = selectedPrograms.Where(
                                                            s => s.name.Equals(lnk.name)).ToArray();

                        if (fileAlreadyInProfile.Length > 0) {
                            child.Checked = true;
                            nChecked++;
                        }

                        
                    }


                    child.ToolTipText = lnk.dir.ToString();
                    nodeParent.Nodes.Add(child);
                
                    
                });


                nAlreayAdded -= nChecked;

                if (nodeParent.Nodes.Count == nChecked) {
                    nodeParent.Checked = true;
                }
                else if(nChecked > 0){
                    nodeParent.StateImageIndex = 2;
                }

                tree.Nodes.Add(nodeParent);



            }

            tree.ExpandAll();
            if(tree.Nodes.Count > 0)
                tree.Nodes[0].EnsureVisible();
            tree.Visible = true;

        }

        private void searchDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void addProgramToSelection(object sender, TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown) {

                if (e.Node.Level == 0) {
                    foreach (TreeNode n in e.Node.Nodes) {
                        n.Checked = e.Node.Checked;
                        addProgramm(n);
                    }
                }
                else {
                    addProgramm(e.Node);
                }
            
                

            }

            void addProgramm(TreeNode n)
            {

                if (n.Checked) {
                    File temp = lnkList.Find(lnk => lnk.name == n.Text);
                    if(selectedPrograms.Find(lnk => lnk.name == temp.name) == null)
                        selectedPrograms.Add(temp);
                }
                else {
                    File temp = selectedPrograms.Find(lnk => lnk.name == n.Text);
                    bool res = selectedPrograms.Remove(temp);


                }
                    
            }
            
        }

        private void expandeAllTree_Click(object sender, EventArgs e)
        {
            tree.ExpandAll();
            tree.Nodes[0].EnsureVisible();
        }

        private void collapseAllTree_Click(object sender, EventArgs e)
        {
            tree.CollapseAll();
        }

        private void sortByAZBtn_Click(object sender, EventArgs e)
        {
            sortTree(true);
        }

        private void sortByZABtn_Click(object sender, EventArgs e)
        {
            
            sortTree(false);
        }

        private void sortTree(bool asc = true)
        {
            tree.Visible = false;

            if(asc)
                tree.TreeViewNodeSorter = new NodeSorterAZ();
            else
                tree.TreeViewNodeSorter = new NodeSorterZA();

            tree.Nodes[0].EnsureVisible();
            tree.Visible = true;
        }

        private void listFolderCb_CheckedChanged(object sender, EventArgs e)
        {
            tree.Nodes.Clear();


            // Se vero, organizza in cartelle
            if ((sender as CheckBox).Checked)
            {
                populateTree(lnkDictionaryByFolder, tree);
            }
            else  // altrimenti alfabeticamente
            {
                populateTree(lnkDictionaryByFirstLetter,tree);
            }
            
            
            
        }

        private void searchTB_TextChanged(object sender, EventArgs e) {
            string textSearch = searchTB.Text;
            if (textSearch == "" || textSearch == "Cerca") {
                treeSearch.Visible = false;
                return;
            }

            List<string> toSearch =
                lnkArrayAlphabet.Where(
                    lnk => lnkArrayAlphabet.Any(
                    f => lnk.StartsWith(textSearch, true, null)
                    )
                ).ToList();


            treeSearch.Nodes.Clear();
            TreeNode nodeParent = new TreeNode("Nessun risultato");

            if (toSearch.Count > 0) {
                treeSearch.Visible = true;
                nodeParent.Text = textSearch;

                foreach (var s in toSearch) {

                    TreeNode n = new TreeNode(s);

                    nodeParent.Nodes.Add(n);

                }

                nodeParent.Expand();
            }
            
                   
            treeSearch.Nodes.Add(nodeParent);
            
            
        }
        
    }

}
