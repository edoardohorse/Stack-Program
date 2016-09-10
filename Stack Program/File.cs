using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace Stack_Program
{
    public class File
    {
        public FileInfo file;
        public string fileName;
        public string name;
        public string dir;
        public string parentDir;

        public File(string dir)
        {
            this.file = new FileInfo(dir);
            this.dir = dir;
            //this.parentDir;
            this.fileName = this.file.Name;
            this.name = this.fileName.Substring(0, this.fileName.LastIndexOf("."));


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
