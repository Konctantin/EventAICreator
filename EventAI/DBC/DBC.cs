using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAI
{
    static class DBC
    {
        public const string VERSION = "EventAI Constructor 3.3.3a (11723)";
        public const int MAX_DBC_LOCALE = 16;
        public const string DBC_PATH = @"dbc\";

        //Spells
        public static Dictionary<uint, SpellEntry> Spell;
        public static Dictionary<uint, SpellRadiusEntry> SpellRadius;
        public static Dictionary<uint, SpellCastTimesEntry> SpellCastTimes;
        public static Dictionary<uint, SpellRangeEntry> SpellRange;
        public static Dictionary<uint, SpellDurationEntry> SpellDuration;
        public static Dictionary<uint, SkillLineAbilityEntry> SkillLineAbility;
        public static Dictionary<uint, SkillLineEntry> SkillLine;

        public static Dictionary<uint, string> _SpellStrings      = new Dictionary<uint, string>();
        public static Dictionary<uint, string> _SkillLineStrings  = new Dictionary<uint, string>();
        public static Dictionary<uint, string> _SpellRangeStrings = new Dictionary<uint, string>();
        public static Dictionary<uint, string> _EmotesStrings     = new Dictionary<uint, string>();
        public static Dictionary<uint, string> _FactionStrings    = new Dictionary<uint, string>();
        
        // 
        public static Dictionary<uint, EmotesEntry> Emotes;
        public static Dictionary<uint, FactionEntry> Faction;


        // Locale
        public static LocalesDBC Locale { get; set; }
    }

    public enum LocalesDBC
    {
        enUS,
        koKR,
        frFR,
        deDE,
        zhCN,
        zhTW,
        esES,
        esMX,
        ruRU
    };
}
