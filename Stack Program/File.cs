using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace Stack_Program
{
    [Serializable]
    public class File
    {
        public FileInfo file;
        public string fileName;
        public string name;
        public string dir;
        public string parentDir;

        public File(string dir)
        {
            if( dir != null)
            {
                this.file = new FileInfo(dir);
                this.fileName = this.file.Name;
                this.name = this.fileName.Substring(0, this.fileName.LastIndexOf("."));
            }
                
            this.dir = dir;
            //this.parentDir;
            


        }

        public void Start()
        {
            Process.Start(@dir);
        }

        public static void Start(File temp)
        {
            Process.Start(@temp.dir);
        }
        

    }
}
