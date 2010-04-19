using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EventAI
{
    public class LoadData
    {
        public static DataTable DataForEventType()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn();
            dt.Columns.Add("Код");
            dt.Columns.Add("Название", typeof(String));

            dt.Rows.Add(0, "По таймеру в бою");
            dt.Rows.Add(1, "По таймеру вне боя");
            dt.Rows.Add(2, "При значении жизни");
            dt.Rows.Add(3, "При значении маны");
            dt.Rows.Add(4, "При агре цели");
            dt.Rows.Add(5, "При убийстве цели");
            dt.Rows.Add(6, "При смерти");
            dt.Rows.Add(7, "При уходе в невидимость");
            dt.Rows.Add(8, "При уроне заклинанием");
            dt.Rows.Add(9, "При дистанции");
            dt.Rows.Add(10, "При появлении в зоне видимости");
            dt.Rows.Add(11, "При спавне");
            dt.Rows.Add(12, "При значении жизни цели");
            dt.Rows.Add(13, "Если цель читает заклинание");
            dt.Rows.Add(14, "При значении жизни друж. цели");
            dt.Rows.Add(15, "Если друж. цель под контролем");
            dt.Rows.Add(16, "Если теряет бафф");
            dt.Rows.Add(17, "При спавне существа");
            dt.Rows.Add(18, "При значении манны у цели");
            dt.Rows.Add(19, "Не используется");
            dt.Rows.Add(20, "Не используется");
            dt.Rows.Add(21, "По возвращению в точку спавна");
            dt.Rows.Add(22, "При получении эмоции");
            dt.Rows.Add(23, "При значении баффа");
            dt.Rows.Add(24, "При значении баффа цели");

            return dt;
        }

    }
}
