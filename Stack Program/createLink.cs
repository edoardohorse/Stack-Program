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
    public partial class createLink : Form
    {
        public createLink()
        {
            InitializeComponent();
        }

        private void createLink_Load(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
         {
            if(textBox1.Text != "")
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                OK.Enabled = true;
                this.AcceptButton = OK;
                OK.DialogResult = DialogResult.OK;
            }
            else
            {
                OK.Enabled = false;
                this.AcceptButton = null;
                OK.DialogResult = DialogResult.Retry;
            }
        }


    }
}
