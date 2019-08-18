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

        public TestBind() {
            InitializeComponent();



            prop = new ds("Ciao");



            button1.DataBindings.Add(new Binding("Text", prop, "Text"));
            button2.DataBindings.Add(new Binding("Text", prop, "Text"));
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            prop.Text = textBox1.Text;
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


    
}
