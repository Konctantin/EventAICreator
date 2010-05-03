using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    class AIException : Exception
    {
        public AIException(string message, params object[] arg0)
            : base(String.Format(message, arg0))
        {
            MessageBox.Show(String.Format(message, arg0), 
                String.Format("{0} ERROR", DBC.VERSION), 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }
    }
}
