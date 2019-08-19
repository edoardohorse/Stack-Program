using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Program {

    public partial class TestBind : Form {


        ds prop;
        List<Profile2> list = new List<Profile2>
           {
                new Profile2("Boopathi","NPD",1),
                new Profile2("Stephan","Luxstone",1),
                new Profile2("Sri","DellAsap",1)
            };

        public TestBind() {
            InitializeComponent();



            prop = new ds("Ciao");



            button1.DataBindings.Add(new Binding("Text", prop, "Text"));
            button2.DataBindings.Add(new Binding("Text", prop, "Text"));

            TreeNode n = new TreeNode();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Tree";
            dt.Columns.Add("Name");
            dt.Columns.Add("Project");
            dt.Columns.Add("Experience");

           

            var query = from s in list.AsEnumerable()
                        where s.Experience == 1
                        select s;


            



            
            foreach (var t in query) {
                DataRow dr = dt.NewRow();
                
                dr["Name"] = t.Name;
                dr["Project"] = t.Project;
                dr["Experience"] = t.Experience;
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            TreeNode root = new TreeNode("Root Node");
            foreach (DataRow row in ds.Tables[0].Rows) {
                TreeNode NewNode = new TreeNode(row["Name"].ToString());
                
                root.Nodes.Add(NewNode);
            }

            
            treeView1.Nodes.Add(root);

            //treeView1.DataBindings.Add(new Binding("Nodes", ds, ""))
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            prop.Text = textBox1.Text;
            list[0].Name = textBox1.Text;
        }
    }

    class ds : INotifyPropertyChanged {
        private string text;

        public string Text {
            get { return this.text; }
            set {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public ds(string t) {
            this.text = t;
        }

        protected virtual void OnPropertyChanged(string property) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

    class Profile2 {
        public string Name;
        public string Project;
        public int Experience;

        public Profile2(string n, string p, int e) {
            Name = n;
            Project = p;
            Experience = e;
        }
    }


    
}
