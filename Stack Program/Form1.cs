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


namespace Stack_Program
{
    public partial class Form1 : Form
    {

        List<File> files = new List<File>();
        DataGridView grid;
        bool areButtonsEnabled = false;



        bool isSettedGrid = false;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sende, EventArgs e)
        {
            grid = this.Controls.Find("dataGridView", false).FirstOrDefault() as DataGridView;
            setGrid();


        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.RestoreDirectory = true;
            d.Multiselect = true;
            d.DereferenceLinks = false;
            //d.SupportMultiDottedExtensions = true;
            d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            d.Filter = "Programmi|*.exe| Collegamenti|*.lnk";
            d.ShowDialog();
            for (var i = 0; i < d.FileNames.Length; i++)
            {

                files.Add(new File(d.FileNames[i]));
                addFileToGUI(files.Last<File>());
            }
            if (d.FileNames.Length > 0)
                enableButtons();



        }

        private void addFileToGUI(File temp)
        {

            if (!isSettedGrid)
            {
                setGrid();
            }



            int i = 0;
            grid.Rows.Add();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = files.Count.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.name.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.dir.ToString();





        }

        private void setGrid()
        {

            //File f = new File("");

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.ShowCellToolTips = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToOrderColumns = true;


            grid.ColumnCount = 3;//f.GetType().GetFields().Length + 1;
            int i = 0;
            grid.Columns[i++].Name = "#";
            grid.Columns[i++].Name = "Nome";
            grid.Columns[i++].Name = "Directory";



            grid.Columns[0].Width = 50;


            isSettedGrid = true;
        }

        private void runApp_Click(object sender, EventArgs e)
        {
            File.Start(files[grid.SelectedRows[0].Index]);

            /* ProcessStartInfo myProcess = new ProcessStartInfo();

             try
             {

                 // You can start any process, HelloWorld is a do-nothing example.
                 myProcess.FileName = temp.dir;
                 myProcess.CreateNoWindow = false;
                 myProcess.UseShellExecute = false;
                 myProcess.WindowStyle = ProcessWindowStyle.Hidden;
                 Process.Start(myProcess);
                 // This code assumes the process you are starting will terminate itself. 
                 // Given that is is started without a window so you cannot terminate it 
                 // on the desktop, it must terminate itself or you can do it programmatically
                 // from this application using the Kill method.
             }
             catch (Exception err)
             {
                 Console.WriteLine(err.Message);
             }*/
        }

        private void searchApp_Click(object sender, EventArgs e)
        {

            Form searchAppForm = new Stack_Program.searchAppForm();
            searchAppForm.Show();
        }

        private void runAll_Click(object sender, EventArgs e)
        {
            foreach (File temp in files)
            {
                temp.Start();
            }
        }

        private void deleteApp_Click(object sender, EventArgs e)
        {
            int index = grid.SelectedRows[0].Index;
            files.Remove(files[index]);
            grid.Rows.RemoveAt(index);

            updateIndex();

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
                files.Clear();
                disableButtons();
            }


        }

        private void updateIndex()
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void enableButtons()
        {
            areButtonsEnabled = deleteAll.Enabled = deleteApp.Enabled = runAll.Enabled = runApp.Enabled = true;
        }

        private void disableButtons()
        {
            areButtonsEnabled = deleteAll.Enabled = deleteApp.Enabled = runAll.Enabled = runApp.Enabled = false;
        }

        private void toggleEnableButtons()
        {
            if (areButtonsEnabled)
                disableButtons();
            else
                enableButtons();


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

    }
}




//C:\Program Files (x86)\ClipX  C:\Program Files (x86)\Brackets\Brackets.exe