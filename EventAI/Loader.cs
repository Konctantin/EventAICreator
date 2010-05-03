using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventAI
{
    class Loader
    {
        public Loader()
        {
            DBC.Spell = DBCReader.ReadDBC<SpellEntry>(DBC._SpellStrings);

            new Thread(RunOther).Start();

            DBC.Locale = DetectedLocale;
        }

        private void RunOther()
        {
            DBC.SkillLine        = DBCReader.ReadDBC<SkillLineEntry>(DBC._SkillLineStrings);
            DBC.SpellRange       = DBCReader.ReadDBC<SpellRangeEntry>(DBC._SpellRangeStrings);
            DBC.Emotes           = DBCReader.ReadDBC<EmotesEntry>(DBC._EmotesStrings);
            DBC.Faction          = DBCReader.ReadDBC<FactionEntry>(DBC._FactionStrings);
            DBC.AreaTable        = DBCReader.ReadDBC<AreaTableEntry>(DBC._AreaTableStrings);

            DBC.SpellDuration    = DBCReader.ReadDBC<SpellDurationEntry>(null);
            DBC.SkillLineAbility = DBCReader.ReadDBC<SkillLineAbilityEntry>(null);
            DBC.SpellRadius      = DBCReader.ReadDBC<SpellRadiusEntry>(null);
            DBC.SpellCastTimes   = DBCReader.ReadDBC<SpellCastTimesEntry>(null);
        }

        private LocalesDBC DetectedLocale
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
