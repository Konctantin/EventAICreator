using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EventAI.Properties;

namespace EventAI
{
    class MySQLClass
    {
        static MySqlConnection _conn;
        static MySqlCommand _command;

        static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port=3306;Uid={1};Pwd={2};Database=mangos;Connection Timeout=10",
                    Settings.Default.host,
                    //Settings.Default.Port,
                    Settings.Default.user,
                    Settings.Default.pass
                    //Settings.Default.Db_mangos
                    );
            }
        }

        public DataTable AI { get { return TextTable; } } 
        private DataTable TextTable;
        
        public static List<ListViewItem> SelectProc(string query)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            _conn = new MySqlConnection(ConnectionString);
            _command = new MySqlCommand(query, _conn);
            _conn.Open();

            var reader = _command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ListViewItem(new[]
                {
                    reader[0].ToString(),                   // 0  Entry 
                    //GetSpellName(reader[0]),              // 1  Name
                    reader[1].ToString(),                   // 2  School Mask
                    reader[2].ToString(),                   // 3  Spell Family Name
                    reader[3].ToString(),                   // 4  Spell Family Mask 0
                    reader[4].ToString(),                   // 5  Spell Family Mask 1
                    reader[5].ToString(),                   // 6  Spell Family Mask 2
                    reader[6].ToString(),                   // 7  Proc Flags
                    reader[7].ToString(),                   // 8  Proc Ex
                    reader[8].ToString(),                   // 9  PPM Rate
                    reader[9].ToString(),                   // 10 Chance
                    reader[10].ToString()                   // 11 Cooldown
                }));
            }
            reader.Close();
            _conn.Close();

            return list;
        }
    }
}
