using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EventAI.Properties;

namespace EventAI
{
    public static class MySQLConnenct
    {
        private static MySqlConnection _conn;
        private static MySqlCommand _command;

        public static bool Connected { get; private set; }

        public static List<ScriptAI> AIScript = new List<ScriptAI>();
        public static List<TextAI> AIText = new List<TextAI>();
        public static List<SummonAI> AISummon = new List<SummonAI>();

        private static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.Host,
                    Settings.Default.Port,
                    Settings.Default.User,
                    Settings.Default.Pass,
                    Settings.Default.Db_mangos);
            }
        }

        public static void SelectAIScript(string query)
        {
            TestConnect();
            if (!Connected) 
                return;

            using (_conn = new MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                AIScript.Clear();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ScriptAI script = new ScriptAI();

                        script.ID                = reader[0].ToInt32();
                        script.NpcEntry          = reader[1].ToInt32();
                        script.EventType         = reader[2].ToInt32();
                        script.Phase             = reader[3].ToInt32();
                        script.Chance            = reader[4].ToInt32();
                        script.Flags             = reader[5].ToInt32();

                        script.EventParam[0]     = reader[6].ToInt32();
                        script.EventParam[1]     = reader[7].ToInt32();
                        script.EventParam[2]     = reader[8].ToInt32();
                        script.EventParam[3]     = reader[9].ToInt32();

                        script.ActionType[0]     = reader[10].ToInt32();
                        script.ActionParam[0, 0] = reader[11].ToInt32();
                        script.ActionParam[0, 1] = reader[12].ToInt32();
                        script.ActionParam[0, 2] = reader[13].ToInt32();

                        script.ActionType[1]     = reader[14].ToInt32();
                        script.ActionParam[1, 0] = reader[15].ToInt32();
                        script.ActionParam[1, 1] = reader[16].ToInt32();
                        script.ActionParam[1, 2] = reader[17].ToInt32();

                        script.ActionType[2]     = reader[18].ToInt32();
                        script.ActionParam[2, 0] = reader[19].ToInt32();
                        script.ActionParam[2, 1] = reader[20].ToInt32();
                        script.ActionParam[2, 2] = reader[21].ToInt32();

                        script.Comment           = reader[22].ToString();

                        AIScript.Add(script);
                    }
                }
            }
        }

        public static void SelectAIText()
        {
            TestConnect();
            if (!Connected)
                return;
            string query = "SELECT * FROM creature_ai_texts;";
            using (_conn = new MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                AIText.Clear();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TextAI script = new TextAI();

                        script.ID               = reader[0].ToInt32();
                        script.ContentDefault   = reader[1].ToString();

                        script.ContentLocale[0] = reader[2].ToString();
                        script.ContentLocale[1] = reader[3].ToString();
                        script.ContentLocale[2] = reader[4].ToString();
                        script.ContentLocale[3] = reader[5].ToString();
                        script.ContentLocale[4] = reader[6].ToString();
                        script.ContentLocale[5] = reader[7].ToString();
                        script.ContentLocale[6] = reader[8].ToString();
                        script.ContentLocale[7] = reader[9].ToString();

                        script.Sound            = reader[10].ToInt32();
                        script.Type             = reader[11].ToInt32();
                        script.Lenguage         = reader[12].ToInt32();
                        script.Emote            = reader[13].ToInt32();

                        script.Comment          = reader[14].ToString();

                        AIText.Add(script);
                    }
                }
            }
        }

        public static void SelectAISummon()
        {
            TestConnect();
            if (!Connected)
                return;
            string query = "SELECT * FROM creature_ai_summons;";
            using (_conn = new MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                AISummon.Clear();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SummonAI script;

                        script.ID               = reader[0].ToInt32();
                        script.PositionX        = reader.GetFloat(1);
                        script.PositionY        = reader.GetFloat(2);
                        script.PositionZ        = reader.GetFloat(3);
                        script.Orientation      = reader.GetFloat(4);
                        script.SpawnTimeSecs    = reader[5].ToInt32();
                        script.Comment          = reader[6].ToString();

                        AISummon.Add(script);
                    }
                }
            }
        }

        public static void Insert(string query)
        {
            TestConnect();
            if (!Connected) 
                return;

            try
            {
                _conn = new MySqlConnection(ConnectionString);
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                _command.ExecuteNonQuery();
                _command.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Данные не записаны " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void TestConnect()
        {
            if (!Settings.Default.UseDbConnect)
            {
                Connected = false;
                return;
            }

            try
            {
                _conn = new MySqlConnection(ConnectionString);
                _conn.Open();
                _conn.Close();
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }
    }
}
