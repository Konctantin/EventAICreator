﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    public enum DataSet
    {
        Emote,
        Fraction,
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
    }
}