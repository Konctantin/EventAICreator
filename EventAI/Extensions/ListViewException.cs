using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace EventAI
{
    public static class ListViewException
    {
        public static void SetColumns<T>(this ListView lv)
        {
            lv.Columns.Clear();
            lv.View = View.Details;

            foreach (FieldInfo element in typeof(T).GetFields())
            {
                ColumnHeader ch = new ColumnHeader();
                ch.Width = element.FieldType.FullName == "System.String" ? 300 : 80;
                ch.Name = typeof(T).Name + "_" + element.Name;
                ch.Text = element.Name;

                lv.Columns.Add(ch);
            }
        }
    }
}
