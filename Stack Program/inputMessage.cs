using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Program
{
    public partial class inputMessage : Form
    {

        List<string> profiles = new List<string>();
        

        public inputMessage( )
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.AcceptButton = OK;
                OK.DialogResult = DialogResult.OK;
            }
            else
            {
                this.AcceptButton = null;
                OK.DialogResult = DialogResult.Retry;
            }
                
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Inserisci il nome del profilo");
            }
            else
            {
                if( profiles.Contains( textBox1.Text ))
                {
                    this.AcceptButton = null;
                    OK.DialogResult = DialogResult.Retry;
                    MessageBox.Show(
                              "Questo profilo è già esistente",
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation,
                              MessageBoxDefaultButton.Button1);


                }
                else { 
                    this.Close();
                    }
            }

                
        }

        private void inputMessage_Load(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            //this.profiles = f1.profiles;
        }
    }
}
