using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Stack_Program {

    public partial class TestBind : Form {



        public TestBind() {
            InitializeComponent();

            List<Persona> ls = new List<Persona>();
            ls.Add(new Persona("Edoardo", "Cavallo"));
            ls.Add(new Persona("Tiziano", "Cavallo"));
            ls.Add(new Persona("Raffaele", "Cavallo"));


            TreeNode nodeParent = new TreeNode("Prova");
            

            nodeParent.Tag = ls;

            foreach (var i in ls) {
                TreeNode n = new TreeNode(i.name);
                n.Tag = i;
                nodeParent.Nodes.Add(n);
            }

            
            treeView1.Nodes.Add(nodeParent);

        }


        private void treeView1_Checked(object sender, TreeViewEventArgs e) {
            Persona temp =(Persona) e.Node.Tag;
            Debug.WriteLine(temp.name +" "+temp.surname);
        }
    }

    public class Persona {
        

        public string name { get; set; }
        public string surname { get; set; }

        public Persona(string n, string s){
            name = n;
            surname = s;
        }
       

    }

    
}
