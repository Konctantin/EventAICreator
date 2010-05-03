using System;
using System.Windows.Forms;
using System.Threading;

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
            
            DBC.Spell = DBCReader.ReadDBC<SpellEntry>(DBC._SpellStrings);
            new Thread(RunOther).Start();
            DBC.Locale = DetectedLocale;
            
            Application.Run(new FormMain());
        }

        private static void RunOther()
        {
            DBC.SkillLine = DBCReader.ReadDBC<SkillLineEntry>(DBC._SkillLineStrings);
            DBC.SpellRange = DBCReader.ReadDBC<SpellRangeEntry>(DBC._SpellRangeStrings);
            DBC.Emotes = DBCReader.ReadDBC<EmotesEntry>(DBC._EmotesStrings);
            DBC.Faction = DBCReader.ReadDBC<FactionEntry>(DBC._FactionStrings);
            DBC.AreaTable = DBCReader.ReadDBC<AreaTableEntry>(DBC._AreaTableStrings);

            DBC.SpellDuration = DBCReader.ReadDBC<SpellDurationEntry>(null);
            DBC.SkillLineAbility = DBCReader.ReadDBC<SkillLineAbilityEntry>(null);
            DBC.SpellRadius = DBCReader.ReadDBC<SpellRadiusEntry>(null);
            DBC.SpellCastTimes = DBCReader.ReadDBC<SpellCastTimesEntry>(null);
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
