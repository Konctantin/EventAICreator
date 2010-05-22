using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace EventAI
{
    /// <summary>
    /// 
    /// </summary>
    public class ScriptAI
    {
        public uint ID;
        public uint NpcEntry;

        public int EventType;

        public int Phase;
        public int Chance;
        public int Flags;

        public int[] EventParam;

        public int[] ActionType;
        public int[,] ActionParam;

        public string Comment;

        public ScriptAI()
        {
            EventParam = new int[4];
            ActionType = new int[3];
            ActionParam = new int[3, 3];
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22}",
                ID,
                NpcEntry,
                EventType,
                Phase,
                Chance,
                Flags,

                EventParam[0],
                EventParam[1],
                EventParam[2],
                EventParam[3],

                ActionType[0],
                ActionParam[0, 0],
                ActionParam[0, 1],
                ActionParam[0, 2],

                ActionType[1],
                ActionParam[1, 0],
                ActionParam[1, 1],
                ActionParam[1, 2],

                ActionType[2],
                ActionParam[2, 0],
                ActionParam[1, 1],
                ActionParam[2, 2],
                Comment
            );
        }
    };


    public struct _ScriptAI
    {
        public uint ID;
        public uint NpcEntry;

        public int EventType;
        
        public int Phase;
        public int Chance;
        public int Flags;

        public int EventParam1;
        public int EventParam2;
        public int EventParam3;
        public int EventParam4;

        public int Action1Type;
        public int Action1Param1;
        public int Action1Param2;
        public int Action1Param3;

        public int Action2Type;
        public int Action2Param1;
        public int Action2Param2;
        public int Action2Param3;

        public int Action3Type;
        public int Action3Param1;
        public int Action3Param2;
        public int Action3Param3;

        public string Comment;

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22}",
                ID,
                NpcEntry,
                EventType,
                Phase,
                Chance,
                Flags,

                EventParam1,
                EventParam2,
                EventParam3,
                EventParam4,

                Action1Type,
                Action1Param1,
                Action1Param2,
                Action1Param3,

                Action2Type,
                Action2Param1,
                Action2Param2,
                Action2Param3,

                Action3Type,
                Action3Param1,
                Action3Param2,
                Action3Param3,
                Comment
            );
        }
    };

    public struct TextAI
    {
        //public int Entry;
    };

    public struct SummonIA
    {
        public int ID;
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public float Orientation;
        public int SpawnTimeSecs;
        public string Comment;
    };

    public struct Creature
    { };

    public struct Quest
    { };

    // todo:
}
