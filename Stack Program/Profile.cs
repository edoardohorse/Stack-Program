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

        public void addFile( File temp, Form1 main)
        {
            
            files.Add(temp);

            Grid grid = main.returnGrid();

            int i = 0;
            grid.Rows.Add();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = files.Count.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.name.ToString();
            grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.dir.ToString();

            countFiles = files.Count;
        }

        public void addProfileToGrid(Form1 main)
        {
            
            Grid grid = main.returnGrid();

            grid.Rows.Clear();

            foreach( File temp in files)
            {
                int i = 0;
                grid.Rows.Add();
                grid.Rows[grid.RowCount - 1].Cells[i++].Value = "";
                grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.name.ToString();
                grid.Rows[grid.RowCount - 1].Cells[i++].Value = temp.dir.ToString();

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

        public string serialize()
        {

            return JsonConvert.SerializeObject( files );
        }

    }
}
