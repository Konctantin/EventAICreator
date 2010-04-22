using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace EventAI
{
    public struct StriptAI
    {
        public int ID;
        public int NpcEntry;

        public ActionType EventType;
        
        public int Phase;
        public int Chance;
        public int Flags;

        public int EventParam1;
        public int EventParam2;
        public int EventParam3;
        public int EventParam4;

        public ActionType Action1Type;
        public int Action1Param1;
        public int Action1Param2;
        public int Action1Param3;

        public ActionType Action2Type;
        public int Action2Param1;
        public int Action2Param2;
        public int Action2Param3;

        public ActionType Action3Type;
        public int Action3Param1;
        public int Action3Param2;
        public int Action3Param3;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public string Comment;
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public string Comment;
    };

    public struct Creature
    { };

    public struct Quest
    { };

    // todo:
}
