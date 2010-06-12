using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace EventAI
{
    /// <summary>
    /// Определяет структуру для хранения данных из таблицы creature_ai_scripts
    /// </summary>
    public class ScriptAI
    {
        /// <summary>
        /// Номер скрипта
        /// </summary>
        public int ID;
        /// <summary>
        /// Номер существа из creature_template, для которого создано событие
        /// </summary>
        public int NpcEntry;
        /// <summary>
        /// Тип события
        /// </summary>
        public int EventType;
        /// <summary>
        /// Фаза, в которой будет происходить событие
        /// </summary>
        public int Phase;
        /// <summary>
        /// Шанс срабатывания
        /// </summary>
        public int Chance;
        /// <summary>
        /// Флаг события
        /// </summary>
        public int Flags;
        /// <summary>
        /// Прпметр для србытия, массив [4]
        /// </summary>
        public int[] EventParam;
        /// <summary>
        /// Тип действия, массив [3]
        /// </summary>
        public int[] ActionType;
        /// <summary>
        /// Параметр для указаного типа действия, массив [3, 3]
        /// </summary>
        public int[,] ActionParam;
        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment;
        /// <summary>
        /// Объявляет новый экземпляр класса
        /// </summary>
        public ScriptAI()
        {
            EventParam = new int[4];
            ActionType = new int[3];
            ActionParam = new int[3, 3];
        }
        /// <summary>
        /// Представляет члены класса в виде массива строк
        /// </summary>
        /// <returns></returns>
        public string[] ToArray()
        {
            return new[]
            {
                ID.ToString(), 
                NpcEntry.ToString(), 
                EventType.ToString(), 
                Phase.ToString(), 
                Chance.ToString(), 
                Flags.ToString(),
                EventParam[0].ToString(), 
                EventParam[1].ToString(), 
                EventParam[2].ToString(), 
                EventParam[3].ToString(),
                ActionType[0].ToString(), 
                ActionParam[0, 0].ToString(), 
                ActionParam[0, 1].ToString(), 
                ActionParam[0, 2].ToString(),
                ActionType[1].ToString(), 
                ActionParam[1, 0].ToString(), 
                ActionParam[1, 1].ToString(), 
                ActionParam[1, 2].ToString(),
                ActionType[2].ToString(),
                ActionParam[2, 0].ToString(), 
                ActionParam[1, 1].ToString(), 
                ActionParam[2, 2].ToString(),
                Comment
            };            
        }
    };


    public class TextAI
    {
        public int      ID;
        public string   ContentDefault;
        public string[] ContentLocale;
        public int      Sound;
        public int      Type;
        public int      Lenguage;
        public int      Emote;
        public string   Comment;

        public TextAI()
        {
            ContentLocale = new string[8];
        }

        public string[] ToArray()
        {
            return new[]
            {
                ID.ToString(), 
                ContentDefault,
                ContentLocale[0], 
                ContentLocale[1], 
                ContentLocale[2], 
                ContentLocale[3], 
                ContentLocale[4], 
                ContentLocale[5], 
                ContentLocale[6], 
                ContentLocale[7],
                Sound.ToString(), 
                Type.ToString(), 
                Lenguage.ToString(), 
                Emote.ToString(), 
                Comment
            };
        }
    };

    public struct SummonAI
    {
        public int      ID;
        public float    PositionX;
        public float    PositionY;
        public float    PositionZ;
        public float    Orientation;
        public int      SpawnTimeSecs;
        public string   Comment;

        public string[] ToArray()
        {
            return new[] 
            { 
                ID.ToString(), 
                PositionX.ToString(), 
                PositionY.ToString(), 
                PositionZ.ToString(), 
                Orientation.ToString(), 
                SpawnTimeSecs.ToString(), 
                Comment 
            };
        }
    };

    public struct Creature
    {
        public uint   ID;
        public string Name;
        public string SubName;
        public uint   Type;
        public uint   NpcFlag;
        public uint   Rank;
        public uint   Family;
    };

    public struct Quest
    {
        public uint   ID;
        public string Name;
    };

    public struct ItemTemplate
    {
        public uint ID;
        public string Name;
        public string Description;
    };
}
