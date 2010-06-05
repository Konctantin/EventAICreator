using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EventAI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!Directory.Exists(DBC.DBC_PATH))
            {
                MessageBox.Show("dbc directiry not exist",
                "EventAI ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            DBC.Spell = DBCReader.ReadDBC<SpellEntry>(DBC._SpellStrings);
            new Thread(RunOther).Start();
            DBC.Locale = DetectedLocale;
            
            Application.Run(new FormMain());
        }

        private static void RunOther()
        {
            DBC.SkillLine           = DBCReader.ReadDBC<SkillLineEntry>(DBC._SkillLineStrings);
            DBC.SpellRange          = DBCReader.ReadDBC<SpellRangeEntry>(DBC._SpellRangeStrings);
            DBC.Emotes              = DBCReader.ReadDBC<EmotesEntry>(DBC._EmotesStrings);
            DBC.Faction             = DBCReader.ReadDBC<FactionEntry>(DBC._FactionStrings);
            DBC.AreaTable           = DBCReader.ReadDBC<AreaTableEntry>(DBC._AreaTableStrings);
            DBC.HolidayNames        = DBCReader.ReadDBC<HolidayNamesEntry>(DBC._HolidayNamesStrings);
            DBC.CreatureFamily      = DBCReader.ReadDBC<CreatureFamilyEntry>(DBC._CreatureFamilyStrings);
            DBC.CreatureType        = DBCReader.ReadDBC<CreatureTypeEntry>(DBC._CreatureTypeStrings);

            DBC.SpellDuration       = DBCReader.ReadDBC<SpellDurationEntry>();
            DBC.SkillLineAbility    = DBCReader.ReadDBC<SkillLineAbilityEntry>();
            DBC.SpellRadius         = DBCReader.ReadDBC<SpellRadiusEntry>();
            DBC.SpellCastTimes      = DBCReader.ReadDBC<SpellCastTimesEntry>();
        }

        private static LocalesDBC DetectedLocale
        {
            get
            {
                byte locale = 0;
                while (DBC.Spell[1].GetName(locale) == String.Empty)
                {
                    ++locale;

                    if (locale >= DBC.MAX_DBC_LOCALE)
                        throw new AIException("Detected unknown locale index {0}", locale);
                }
                return (LocalesDBC)locale;
            }
        }
    }
}
