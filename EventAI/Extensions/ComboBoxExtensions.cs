using System;
using System.Data;
using System.Reflection;
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
            return cb.Items.Count > 0 ? cb.SelectedValue.ToInt32() : cb.Text.ToInt32();
        }

        public static int GetIntValue(this TextBox tb)
        {
            return tb.Text.ToInt32();
        }

        public static void SetEnumValues<T>(this ComboBox cb, string noValue = "", string remove = "", bool size = true)
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("enumeratedType must be an enum");

            Array enumeratedType = Enum.GetValues(typeof(T));
            
            if (enumeratedType == null)
                throw new NullReferenceException();

            var list = new List<KeyValuePair<int, string>>();
            if (noValue != "")
                list.Add(new KeyValuePair<int, string>(-1, noValue));

            foreach (var value in enumeratedType)
                list.Add(new KeyValuePair<int, string>((int)value, 
                    "(" + ((int)value).ToString("00") + ") " + value.ToString().NormaliseString(remove)));

            if (size) cb.Size = new System.Drawing.Size(238, 21);
            cb.DropDownStyle  = ComboBoxStyle.DropDownList;
            cb.DataSource     = list;
            cb.ValueMember    = "Key";
            cb.DisplayMember  = "Value";
        }

        public static void SetDbcData<T>(this ComboBox cb, Dictionary<uint, T> dict, string noValue = null)
        {
            if (dict == null)
                return;
            
            var list = new List<KeyValuePair<int, string>>();

            if (noValue != null)
                list.Add(new KeyValuePair<int, string>(-1, noValue));

            foreach (var str in dict.Values)
            {
                int ID = str.GetType().GetField("ID").GetValue(str).ToInt32();
                var Name = str.GetType().GetProperty("Name").GetValue(str, null).ToString();

                list.Add(new KeyValuePair<int, string>(ID, string.Format("({0:000}) {1}", ID, Name)));
            }

            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Size = ComboboxSize;
            cb.DataSource = list;
            cb.ValueMember = "Key";
            cb.DisplayMember = "Value";
        }
    }
}
