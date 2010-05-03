using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    class Default
    {
        public static void Reset(GroupBox gb)
        {
            foreach (var ctrl in gb.Controls)
            {
                if (ctrl is Label)
                {
                    ((Label)ctrl).Text = String.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    if (cb.Name.IndexOf("_cbActionType") == -1)
                    {
                        cb.DropDownStyle = ComboBoxStyle.Simple;
                        cb.DataSource = null;
                    }
                }
                else if (ctrl is Button)
                {
                    Button b = (Button)ctrl;
                    b.Visible = false;
                }
            }
        }
    }
}
