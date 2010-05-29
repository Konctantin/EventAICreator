using System;
using System.Windows.Forms;

namespace EventAI
{
    public static class Default
    {
        public static void Reset(this GroupBox gb)
        {
            for (int i = 0; i < 4; i++)
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
                        if (cb.Name.IndexOf("_cbActionType") == -1 && cb.Name.IndexOf("_cbEventType") == -1)
                        {
                            cb.Reset();
                        }
                    }

                    else if(ctrl is Button)
                    {
                        gb.Controls.Remove((Button)ctrl);
                    }
                }
            }
        }

        public static void ResetButton(this GroupBox gb)
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (var ctrl in gb.Controls)
                {
                    if (ctrl is Button)
                    {
                        gb.Controls.Remove((Button)ctrl);
                    }
                }
            }
        }

        public static void Reset(this ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.Simple;
            cb.DataSource = null;
            cb.Size = new System.Drawing.Size(238, 21);
            cb.Text = String.Empty;
        }
    }
}
