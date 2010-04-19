using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace EventAI
{
    /// <summary>
    /// Класс содержит специальные функции ЕвентАИ
    /// </summary>
    public static class EAI
    {
        public static string RegexReplace(TextBox tb)
        {
            return tb.Text.Replace(@"'", @"\'").Replace("\"", "\\\"");
        }

        /// <summary>
        /// Функция отмечает елементы в CheckedListBox исходя из бит маски (2 в степени)
        /// </summary>
        /// <param name="_name">Имя CheckedListBox, в котором следует отметить элементы</param> 
        /// <param name="_value">Число, которое являеться составляющим колекции отмеченных элементов</param>
        public static void GetCheckedItem(CheckedListBox _name, int _value)
        {

            for (int i = 0; i < _name.Items.Count; ++i)
            {
                var pow = Math.Pow(2, i);
                var x = (int)Math.Truncate(_value / pow);
                var check = (x % 2) != 0;
                _name.SetItemChecked(i, check);
            }
        }

        public static void WriteToFiles(RichTextBox QueryOutput, String fileName)
        {
            StreamWriter writetext = new StreamWriter(fileName, true, Encoding.UTF8);
            using (writetext)
            {
                writetext.WriteLine(QueryOutput.Text);
            }
            writetext.Close();
        }

        public static void SetEnumValues(ComboBox cb, Type enums)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", enums);
            dt.Columns.Add("NAME");

            foreach (var str in Enum.GetValues(enums))
                dt.Rows.Add(new Object[] { (int)str, ((int)str) + "-" + str });

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }
    }
}
