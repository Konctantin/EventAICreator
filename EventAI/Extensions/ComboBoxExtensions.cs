using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventAI
{
    public enum DataSet
    {
        Emote,
        Fraction,
        Area,
        Skill,
    };
    public static class ComboBoxExtensions
    {
        public static void SetDbcData(this ComboBox cb, DataSet ds)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");
            switch(ds)
            {
                case DataSet.Emote:
                    {
                        foreach (var str in DBC.Emotes.Values)
                        {
                            dt.Rows.Add(new Object[] 
                            { 
                                str.ID,
                                "(" + (str.ID).ToString("000") + ") " + str.Name
                            });
                        }
                    }
                    break;
                case DataSet.Fraction:
                    {
                        foreach (var str in DBC.Faction.Values)
                        {
                            dt.Rows.Add(new Object[] 
                            { 
                                str.ID,
                                "(" + (str.ID).ToString("0000") + ") " + str.Name
                            });
                        }
                    }
                    break;
                case DataSet.Area:
                    {
                        foreach (var str in DBC.AreaTable.Values)
                        {
                            dt.Rows.Add(new Object[] 
                            { 
                                str.ID,
                                "(" + (str.ID).ToString("0000") + ") " + str.Name
                            });
                        }
                    }
                    break;
                case DataSet.Skill:
                    {
                        foreach (var str in DBC.SkillLine.Values)
                        {
                            dt.Rows.Add(new Object[] 
                            { 
                                str.ID,
                                "(" + (str.ID).ToString("000") + ") " + str.Name
                            });
                        }
                    }
                    break;
            }

            cb.Size = new System.Drawing.Size(238, 21);
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void SetDbcData<T>(this ComboBox cb, Dictionary<uint, T> dict) where T : struct
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            foreach (var str in dict)
            {
                dt.Rows.Add(new Object[] 
                { 
                    str.Key,
                    "(" + (str.Key).ToString("000") + ") " + str.Value.GetType().GetProperty("Name").GetValue(str,null).ToString()
                });
            }

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void SetVal(this ComboBox cb, Object val)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");
            dt.Rows.Add(new Object[] { val.ToInt32(), val.ToString() });
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetVal(this ComboBox cb, Object menderval, Object visibleval)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");
            dt.Rows.Add(new Object[] { menderval.ToInt32(), visibleval.ToString() });
            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static int GetVal(this ComboBox cb)
        {
            return cb.ValueMember.ToInt32();
        }

        public static int GetVal(this TextBox tb)
        {
            return tb.Text.ToInt32();
        }
    }
}
