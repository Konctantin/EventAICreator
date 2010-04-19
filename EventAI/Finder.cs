using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    public class Finder
    {
        private FindToBase m_FindToBase;
        public static void DataFind(string who, TextBox data)
        {
            Finder f = new Finder();
            f.ViewForm();
        }
        void ViewForm()
        {
            if (m_FindToBase == null || m_FindToBase.IsDisposed)
                m_FindToBase = new FindToBase();

            if (!m_FindToBase.Visible)
                m_FindToBase.Show();
        }

    }
}
