using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Stack_Program
{
    [Serializable]
    class Profile
    {
        public string name;
        public bool isSelected = false;
        public List<File> files = new List<File>();
        public int countFiles;

        public Profile( string name)
        {
            this.name = name;
            
        }

        public void addFile( File toAdd, Form1 main)
        {
            
            files.Add(toAdd);

            Grid grid = main.returnGrid();

            int i = 0;
            grid.Rows.Add();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = files.Count.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = toAdd.name.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = toAdd.dir.ToString();

            countFiles = files.Count;
        }

        public void addProfileToGrid(Form1 main)
        {
            
            Grid grid = main.returnGrid();

            grid.Rows.Clear();

            foreach( File temp in files)
            {
                int i = 0;
                int indexAdded = grid.Rows.Add();
                DataGridViewRow row = grid.Rows[indexAdded];
                row.Cells[i++].Value = "";
                row.Cells[i++].Value = temp.name.ToString();
                row.Cells[i++].Value = temp.dir.ToString();

                if (!temp.enabled)   // Se disabilitato
                    main.toggleEnableDisableApp(row, false);

                grid.updateIndex();
            }
        }

        public void runAll()
        {
            foreach( File temp in files)
            {
                temp.Start();
            }
        }

        public void runApp( int index )
        {
            files[index].Start();
        }

        public void clearFiles()
        {
            files.Clear();
        }

        public void removeFile(int index)
        {
            this.files.Remove(this.files[index]);
        }

        public void removeFile(File toRemove, Form1 main)
        {
            Grid grid = main.returnGrid();

            foreach(DataGridViewRow row in grid.Rows) {
                if(row.Cells[1].Value.Equals(toRemove.name) ) {
                    grid.Rows.Remove(row);
                }
            }

            this.files.Remove(toRemove);



            countFiles = files.Count;
        }

        public string serialize()
        {
           return JsonConvert.SerializeObject( files );
        }

        public void enaleFile(int index)
        {
            files[index].enabled = true;
        }

        public void disableFile(int index)
        {
            files[index].enabled = false;
        }

        

        public bool containsFile(File temp)
        {
            foreach (File t in files)
            {
                if (temp.file.FullName == t.file.FullName)
                    return true;
            }
            return false;
        }
    }
}
