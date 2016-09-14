using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Program
{
    public class Grid : DataGridView
    {
        private bool _isSetted;

        public string isSetted(bool value)
        {
            get { return this._isSetted; }
            set { this._isSetted = value }
        }
    }
}
