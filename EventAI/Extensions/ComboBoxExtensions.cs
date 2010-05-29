using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventAI
{
    public static class ComboBoxExtensions
    {
        private static System.Drawing.Size ComboboxSize
        {
            get { return new System.Drawing.Size(238, 21); }
        }

        public static void SetDbcData<T>(this ComboBox cb, Dictionary<uint, T> dict) where T : struct
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            foreach (var str in dict.Values)
            {
                uint ID = str.GetType().GetField("ID").GetValue(str).ToUInt32();
                var Name = str.GetType().GetProperty("Name").GetValue(str, null);
               
                dt.Rows.Add(new Object[] { ID, "(" + ID.ToString("000") + ") " + Name });
            }

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Size = ComboboxSize;
        }

        public static void SetValue(this ComboBox cb, Object value)
        {
            if (cb.DataSource == null)
            {
                cb.Text = value.ToString();
            }
            else
            {
                cb.SelectedValue = value;
            }
        }

        public static int GetIntValue(this ComboBox cb)
        {
            if (cb.Items.Count > 0)
                return cb.SelectedValue.ToInt32();
            else
                return cb.Text.ToInt32();
        }

        public static int GetIntValue(this TextBox tb)
        {
            return tb.Text.ToInt32();
        }

        public static void SetEnumValues<T>(this ComboBox cb) where T : struct
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            foreach (var str in Enum.GetValues(typeof(T)))
            {
                dt.Rows.Add(new Object[] 
                { 
                    (int)str, 
                    "(" + ((int)str).ToString("00") + ") " + str.ToString().NormaliseString(String.Empty) 
                });
            }

            cb.Size = new System.Drawing.Size(238, 21);
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetEnumValues<T>(this ComboBox cb, string remove) where T : struct
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            foreach (var str in Enum.GetValues(typeof(T)))
            {
                dt.Rows.Add(new Object[] 
                { 
                    (int)str, 
                    "(" + ((int)str).ToString("00") + ") " + str.ToString().NormaliseString(remove) 
                });
            }

            cb.Size = new System.Drawing.Size(238, 21);
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetEnumValues(this ComboBox cb, Type enums, string NoValue, string remove)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            dt.Rows.Add(new Object[] { -1, NoValue });

            foreach (var str in Enum.GetValues(enums))
            {
                dt.Rows.Add(new Object[] 
                { 
                    (int)str, 
                    "(" + ((int)str).ToString("00") + ") " + str.ToString().NormaliseString(remove) 
                });
            }

            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }
    }
}
