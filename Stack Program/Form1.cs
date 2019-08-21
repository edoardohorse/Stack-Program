using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using IWshRuntimeLibrary;
using System.Management;
using System.Management.Instrumentation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stack_Program
{
    public partial class Form1 : Form
    {

        
        Grid grid;
        
        bool areButtonsEnabled = false;
        List<Profile> profiles = new List<Stack_Program.Profile>();
        Profile tempProfile;
        Profile selectedProfile;
        FileInfo fileAppData;
        string dirAppData;
        string previousPath = "";
        bool isClosedAppAfterRunAll = false;
        //        public delegate void returnGrid();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sende, EventArgs e)
        {
            bool fileExists = false;
            grid = this.Controls.Find("grid1", false).FirstOrDefault() as Grid;
            grid.setGrid();


            dirAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create) + "\\Stack Program";
            fileAppData = new FileInfo(dirAppData + "\\stack_program.json");
            if( Directory.Exists(dirAppData))
            {
                if( fileAppData.Exists)
                {
                    fileExists = true;
                    StreamReader fp = new StreamReader(fileAppData.FullName);
                    string str = fp.ReadToEnd();
                    restoreProfileFromJson( str );
                    fp.Close();
                }
            }
            else
            {
                Directory.CreateDirectory(dirAppData);
            }

            if (fileExists && profiles != null)
            {
                selectedProfile = profiles[0];
                enableButtons();
            }
            else
            {
                profiles = new List<Profile>();
                this.tempProfile = new Profile("temp");
                selectedProfile = this.tempProfile;
            }
            
            

        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog d = new OpenFileDialog();
            d.RestoreDirectory = true;
            d.Multiselect = true;
            d.DereferenceLinks = false;
            //d.SupportMultiDottedExtensions = true;
            if ( previousPath == "" )
                d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            d.Filter = "Programmi|*.exe|Collegamenti|*.lnk|Application Reference|*.appref-ms";
            d.ShowDialog();
            for (var i = 0; i < d.FileNames.Length; i++)
            {
                File temp = new File(d.FileNames[i]);
                if (selectedProfile.containsFile(temp))
                    MessageBox.Show("Il programma "+ temp.name +"è già presente in questo profilo");
                else
                    selectedProfile.addFile(temp, this);
                
            }
            if( d.FileName !=  "" )
                previousPath = Path.GetDirectoryName(d.FileNames[0]);
            //selectedProfile.addProfileToGrid();

            if (d.FileNames.Length > 0)
                enableButtons();



        }

        
        

        private void runApp_Click(object sender, EventArgs e)
        {
            if(grid.SelectedRows.Count == 1)
                selectedProfile.runApp(grid.SelectedRows[0].Index);
        }

        private void searchApp_Click(object sender, EventArgs e)
        {
            using(var searchAppForm = new Stack_Program.searchAppForm(selectedProfile.files)){

                var result = searchAppForm.ShowDialog();
                if( result == DialogResult.OK)
                {
                    List<File> temp =  searchAppForm.selectedPrograms;

                    List<File> toRemove = selectedProfile.files.Except(temp).ToList();
                    temp = temp.Except(toRemove).ToList();

                    if (toRemove.Count > 0) {
                        foreach (File r in toRemove) {
                            selectedProfile.removeFile(r, this);
                        }
                    }


                    foreach (File f in temp)
                    {
                        if (!selectedProfile.containsFile(f))
                            selectedProfile.addFile( f, this );
                    }

                    enableButtons();
                    
                }
            }
            
            
            
        }

        private void runAll_Click(object sender, EventArgs e)
        {
            selectedProfile.runAll();

            if (isClosedAppAfterRunAll)
                this.Close();
        }

        private void deleteApp_Click(object sender, EventArgs e)
        {
            
            if ( grid.Rows.Count == 1 )
            {
                grid.Rows.Clear();
                selectedProfile.clearFiles();
                disableButtons();
            }
            else
            {
                int index = grid.SelectedRows[0].Index;
                selectedProfile.removeFile(index);
                grid.Rows.RemoveAt(index);
                grid.updateIndex();
            }

            

        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            string message = "Eliminare tutti i programmi in lista?";
            string caption = "Attenzione";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result.ToString() == "Yes")
            {
                grid.Rows.Clear();
                selectedProfile.clearFiles();
                disableButtons();
            }


        }

        

        private void enableButtons()
        {
            areButtonsEnabled = deleteAllBtn.Enabled =
                deleteAppBtn.Enabled = runAllBtn.Enabled = addProfileBtn.Enabled =
                disableAppBtn.Enabled = enableAppBtn.Enabled =          true;
        }

        private void disableButtons()
        {
            areButtonsEnabled = deleteAllBtn.Enabled =
               deleteAppBtn.Enabled = runAllBtn.Enabled =
                   /*addProfile.Enabled =*/
               disableAppBtn.Enabled = enableAppBtn.Enabled = false;
        }

        private void toggleEnableButtons()
        {
            if (areButtonsEnabled)
                disableButtons();
            else
                enableButtons();


        }


        private void addProfile_Click(object sender, EventArgs e)
        {
            if( selectedProfile.countFiles > 0 && profiles.Count == 0)
            {
                DialogResult result = MessageBox.Show("Vuoi aggiungire i " + selectedProfile.countFiles+" programmi già presenti in questo profilo.\nSe no i programmi aggiunti verrano persi",
                    "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if( result == DialogResult.Yes)
                {
                    inputMessage testDialog = new inputMessage();

                    
                    if (testDialog.ShowDialog(this) == DialogResult.OK)
                    {
                    
                        selectedProfile.name = testDialog.textBox1.Text ;
                        listProfiles.Items.Add( selectedProfile.name );
                        profiles.Add(selectedProfile);
                        testDialog.Dispose();

                    }
                    else
                    {
                        listProfiles.Items.Add(testDialog.textBox1.Text);
                        profiles.Add(new Profile(testDialog.textBox1.Text));
                    }
                    
                }

            }
            else
            {
                inputMessage testDialog = new inputMessage();

                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Read the contents of testDialog's TextBox.
                    listProfiles.Items.Add(testDialog.textBox1.Text);
                    profiles.Add(new Profile(testDialog.textBox1.Text));
                    //profiles.Add(testDialog.textBox1.Text);


                    grid.Rows.Clear();
                    selectedProfile = profiles.Last<Profile>();
                    listProfiles.SelectedIndex = profiles.IndexOf(selectedProfile);
                }
                testDialog.Dispose();
            }
            


            if( listProfiles.Items.Count > 0 )
                removeProfileBtn.Enabled = true;


            

        }

        private void removeProfile_Click(object sender, EventArgs e)
        {

            int index = listProfiles.SelectedIndex;
            if (listProfiles.SelectedIndex != -1)
            {

                profiles.RemoveAt(index);
                listProfiles.Items.RemoveAt(index);
                
            }
            if (listProfiles.Items.Count == 0)
                removeProfileBtn.Enabled = false;
            else
                listProfiles.SelectedIndex = index-1;
        }

        private void saveProfiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveProfiles();    

        }
        
        private void saveProfiles()
        {
            string str = JsonConvert.SerializeObject(profiles);

            StreamWriter ft = new StreamWriter(fileAppData.FullName);
            ft.Write(str);
            ft.Close();
        }

        private void listProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( listProfiles.SelectedIndex == -1)
            {
                grid.Rows.Clear();
                this.tempProfile = new Profile("temp");
                selectedProfile = this.tempProfile;
            }
            else
            {
                selectedProfile = profiles[listProfiles.SelectedIndex];
                selectedProfile.addProfileToGrid(this);
            }
            
        }

        public void restoreProfileFromJson( string str )
        {

            profiles = JsonConvert.DeserializeObject<List<Profile>>(str);

            if (profiles == null || profiles.Count == 0) {
                profiles = null;
                return;
            }
            foreach( Profile temp in profiles)
            {
                listProfiles.Items.Add(temp.name);
            }

            profiles[0].addProfileToGrid(this);
            listProfiles.SelectedIndex = 0;
            removeProfileBtn.Enabled = true;
        }

        public Grid returnGrid()
        {
            return grid;
        }

        public static string CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string[] stringSeparators = new string[] { " --" };
            string[] arguments = targetFileLocation.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            targetFileLocation = arguments[0].Replace("\"","");
            arguments = arguments.Skip(1).ToArray();
            
            string shortcutLocation = System.IO.Path.Combine(shortcutPath + "\\Stack Program", shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            foreach (string arg in arguments)
            {
                shortcut.Arguments += " --"+arg;
            }
            
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
            return shortcutLocation;
        }

        private void createInk_Click(object sender, EventArgs e)
        {
            
            createLink newLink = new createLink();
            string shortcutDir = "";

            if (newLink.ShowDialog(this) == DialogResult.OK)
            {
                shortcutDir = CreateShortcut(newLink.textBox1.Text, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), newLink.textBox2.Text);
                newLink.Dispose();
                File s = new File(shortcutDir);
                selectedProfile.addFile(s, this);
            }
            

        }

        private void closeAfterCb_CheckedChanged(object sender, EventArgs e)
        {
            isClosedAppAfterRunAll = (sender as CheckBox).Checked;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            saveProfiles();
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "File JSON|*.json";
            d.Title = "Salva il file di configurazione";
            d.ShowDialog();

            string newLocation = d.FileName;
            if(newLocation != "")
               fileAppData.CopyTo(newLocation, true);
        }

        private void enableAppBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow rowSelected in grid.SelectedRows) {
                toggleEnableDisableApp(rowSelected, true);
                selectedProfile.enaleFile(rowSelected.Index);
            }
        }
                

        private void disableRowBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowSelected in grid.SelectedRows) {
                toggleEnableDisableApp(rowSelected, false);
                selectedProfile.disableFile(rowSelected.Index);
            }
        }

        public void toggleEnableDisableApp(DataGridViewRow row, bool enabled)
        {
            if (enabled) {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            else {
                row.DefaultCellStyle.BackColor = Color.LightGray;
                
            }

            row.Selected = false;
        }

        /*
        private void grid_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                   
                    DragDropEffects dropEffect = grid.DoDragDrop(
                             grid.Rows[rowIndexFromMouseDown],
                             DragDropEffects.Move);
                }
            }
        }

        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = grid.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.               
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                                        dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void grid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void grid_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be
            // converted to client coordinates.
            Point clientPoint = grid.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below.
            rowIndexOfItemUnderMouseToDrop =
                grid.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                             typeof(DataGridViewRow)) as DataGridViewRow;
                grid.Rows.RemoveAt(rowIndexFromMouseDown);
                grid.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }
        */

        private void grid1_SelectionChanged(object sender, EventArgs e)
        {
            switch (grid.SelectedRows.Count)
            {
                case 0:
                {
                    runAppBtn.Enabled = false;
                    break;
                }
                case 1:{
                    runAppBtn.Enabled = true;
                    break;
                }
            }
            
            
        }
    }
    public class Grid: DataGridView
    {
        private bool _isSettedGrid = false;

        public bool isSettedGrid
        {
            get { return _isSettedGrid; }
            set { _isSettedGrid = value; }
        }

        public void setGrid() {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.AllowUserToResizeRows = false;
            this.ShowCellToolTips = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = true;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AllowUserToOrderColumns = true;


            this.ColumnCount = 3;//f.GetType().GetFields().Length + 1;
            int i = 0;
            this.Columns[i++].Name = "#";
            this.Columns[i++].Name = "Nome";
            this.Columns[i++].Name = "Directory";



            this.Columns[0].Width = 50;


            isSettedGrid = true;
        }

        public void updateIndex()
        {
            foreach (DataGridViewRow row in this.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        


    }
}




//C:\Program Files (x86)\ClipX  C:\Program Files (x86)\Brackets\Brackets.exe