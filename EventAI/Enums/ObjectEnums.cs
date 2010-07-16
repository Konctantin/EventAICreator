using System;

namespace EventAI
{
    public enum EUnitFields
    {
        UNIT_FIELD_CHARM                                      = 0x0006 + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_SUMMON                                     = 0x0006 + 0x0002, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CRITTER                                    = 0x0006 + 0x0004, // Size: 2, Type: LONG, Flags: PRIVATE
        UNIT_FIELD_CHARMEDBY                                  = 0x0006 + 0x0006, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_SUMMONEDBY                                 = 0x0006 + 0x0008, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CREATEDBY                                  = 0x0006 + 0x000A, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_TARGET                                     = 0x0006 + 0x000C, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CHANNEL_OBJECT                             = 0x0006 + 0x000E, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CHANNEL_SPELL                              = 0x0006 + 0x0010, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BYTES_0                                    = 0x0006 + 0x0011, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_HEALTH                                     = 0x0006 + 0x0012, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER1                                     = 0x0006 + 0x0013, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER2                                     = 0x0006 + 0x0014, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER3                                     = 0x0006 + 0x0015, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER4                                     = 0x0006 + 0x0016, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER5                                     = 0x0006 + 0x0017, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER6                                     = 0x0006 + 0x0018, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER7                                     = 0x0006 + 0x0019, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXHEALTH                                  = 0x0006 + 0x001A, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER1                                  = 0x0006 + 0x001B, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER2                                  = 0x0006 + 0x001C, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER3                                  = 0x0006 + 0x001D, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER4                                  = 0x0006 + 0x001E, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER5                                  = 0x0006 + 0x001F, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER6                                  = 0x0006 + 0x0020, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER7                                  = 0x0006 + 0x0021, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER                  = 0x0006 + 0x0022, // Size: 7, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER      = 0x0006 + 0x0029, // Size: 7, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_LEVEL                                      = 0x0006 + 0x0030, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_FACTIONTEMPLATE                            = 0x0006 + 0x0031, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_VIRTUAL_ITEM_SLOT_ID                       = 0x0006 + 0x0032, // Size: 3, Type: INT, Flags: PUBLIC
        UNIT_FIELD_FLAGS                                      = 0x0006 + 0x0035, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_FLAGS_2                                    = 0x0006 + 0x0036, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_AURASTATE                                  = 0x0006 + 0x0037, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BASEATTACKTIME                             = 0x0006 + 0x0038, // Size: 2, Type: INT, Flags: PUBLIC
        UNIT_FIELD_RANGEDATTACKTIME                           = 0x0006 + 0x003A, // Size: 1, Type: INT, Flags: PRIVATE
        UNIT_FIELD_BOUNDINGRADIUS                             = 0x0006 + 0x003B, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_COMBATREACH                                = 0x0006 + 0x003C, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_DISPLAYID                                  = 0x0006 + 0x003D, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_NATIVEDISPLAYID                            = 0x0006 + 0x003E, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MOUNTDISPLAYID                             = 0x0006 + 0x003F, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MINDAMAGE                                  = 0x0006 + 0x0040, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER, PARTY_LEADER
        UNIT_FIELD_MAXDAMAGE                                  = 0x0006 + 0x0041, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER, PARTY_LEADER
        UNIT_FIELD_MINOFFHANDDAMAGE                           = 0x0006 + 0x0042, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER, PARTY_LEADER
        UNIT_FIELD_MAXOFFHANDDAMAGE                           = 0x0006 + 0x0043, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER, PARTY_LEADER
        UNIT_FIELD_BYTES_1                                    = 0x0006 + 0x0044, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_PETNUMBER                                  = 0x0006 + 0x0045, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_PET_NAME_TIMESTAMP                         = 0x0006 + 0x0046, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_PETEXPERIENCE                              = 0x0006 + 0x0047, // Size: 1, Type: INT, Flags: OWNER
        UNIT_FIELD_PETNEXTLEVELEXP                            = 0x0006 + 0x0048, // Size: 1, Type: INT, Flags: OWNER
        UNIT_FIELD_DYNAMIC_FLAGS                              = 0x0006 + 0x0049, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_FIELD_MOD_CAST_SPEED                             = 0x0006 + 0x004A, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_CREATED_BY_SPELL                           = 0x0006 + 0x004B, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_DYNAMIC_FLAGS_2                            = 0x0006 + 0x004C, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_FIELD_EMOTESTATE                                 = 0x0006 + 0x004D, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_STAT0                                      = 0x0006 + 0x004E, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_STAT1                                      = 0x0006 + 0x004F, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_STAT2                                      = 0x0006 + 0x0050, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_STAT3                                      = 0x0006 + 0x0051, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_STAT4                                      = 0x0006 + 0x0052, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT0                                   = 0x0006 + 0x0053, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT1                                   = 0x0006 + 0x0054, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT2                                   = 0x0006 + 0x0055, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT3                                   = 0x0006 + 0x0056, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT4                                   = 0x0006 + 0x0057, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT0                                   = 0x0006 + 0x0058, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT1                                   = 0x0006 + 0x0059, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT2                                   = 0x0006 + 0x005A, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT3                                   = 0x0006 + 0x005B, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT4                                   = 0x0006 + 0x005C, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_RESISTANCES                                = 0x0006 + 0x005D, // Size: 7, Type: INT, Flags: PRIVATE, OWNER, PARTY_LEADER
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE                 = 0x0006 + 0x0064, // Size: 7, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE                 = 0x0006 + 0x006B, // Size: 7, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_BASE_MANA                                  = 0x0006 + 0x0072, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BASE_HEALTH                                = 0x0006 + 0x0073, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_BYTES_2                                    = 0x0006 + 0x0074, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_ATTACK_POWER                               = 0x0006 + 0x0075, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_ATTACK_POWER_MODS                          = 0x0006 + 0x0076, // Size: 1, Type: TWO_SHORT, Flags: PRIVATE, OWNER
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER                    = 0x0006 + 0x0077, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER                        = 0x0006 + 0x0078, // Size: 1, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER_MODS                   = 0x0006 + 0x0079, // Size: 1, Type: TWO_SHORT, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER             = 0x0006 + 0x007A, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_MINRANGEDDAMAGE                            = 0x0006 + 0x007B, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_MAXRANGEDDAMAGE                            = 0x0006 + 0x007C, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POWER_COST_MODIFIER                        = 0x0006 + 0x007D, // Size: 7, Type: INT, Flags: PRIVATE, OWNER
        UNIT_FIELD_POWER_COST_MULTIPLIER                      = 0x0006 + 0x0084, // Size: 7, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_MAXHEALTHMODIFIER                          = 0x0006 + 0x008B, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER
        UNIT_FIELD_HOVERHEIGHT                                = 0x0006 + 0x008C, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_PADDING                                    = 0x0006 + 0x008D, // Size: 1, Type: INT, Flags: NONE
    };
	
	// Value masks for UNIT_FIELD_FLAGS
	[Flags]
	public enum UnitFlags : uint
	{
		UNIT_FLAG_UNK_0                 = 0x00000001,
		UNIT_FLAG_NON_ATTACKABLE        = 0x00000002,           // not attackable
		UNIT_FLAG_DISABLE_MOVE          = 0x00000004,
		UNIT_FLAG_PVP_ATTACKABLE        = 0x00000008,           // allow apply pvp rules to attackable state in addition to faction dependent state
		UNIT_FLAG_RENAME                = 0x00000010,
		UNIT_FLAG_PREPARATION           = 0x00000020,           // don't take reagents for spells with SPELL_ATTR_EX5_NO_REAGENT_WHILE_PREP
		UNIT_FLAG_UNK_6                 = 0x00000040,
		UNIT_FLAG_NOT_ATTACKABLE_1      = 0x00000080,           // ?? (UNIT_FLAG_PVP_ATTACKABLE | UNIT_FLAG_NOT_ATTACKABLE_1) is NON_PVP_ATTACKABLE
		UNIT_FLAG_OOC_NOT_ATTACKABLE    = 0x00000100,           // 2.0.8 - (OOC Out Of Combat) Can not be attacked when not in combat. Removed if unit for some reason enter combat (flag probably removed for the attacked and it's party/group only)
		UNIT_FLAG_PASSIVE               = 0x00000200,           // makes you unable to attack everything. Almost identical to our "civilian"-term. Will ignore it's surroundings and not engage in combat unless "called upon" or engaged by another unit.
		UNIT_FLAG_LOOTING               = 0x00000400,           // loot animation
		UNIT_FLAG_PET_IN_COMBAT         = 0x00000800,           // in combat?, 2.0.8
		UNIT_FLAG_PVP                   = 0x00001000,           // changed in 3.0.3
		UNIT_FLAG_SILENCED              = 0x00002000,           // silenced, 2.1.1
		UNIT_FLAG_UNK_14                = 0x00004000,           // 2.0.8
		UNIT_FLAG_UNK_15                = 0x00008000,
		UNIT_FLAG_UNK_16                = 0x00010000,           // removes attackable icon
		UNIT_FLAG_PACIFIED              = 0x00020000,           // 3.0.3 ok
		UNIT_FLAG_STUNNED               = 0x00040000,           // 3.0.3 ok
		UNIT_FLAG_IN_COMBAT             = 0x00080000,
		UNIT_FLAG_TAXI_FLIGHT           = 0x00100000,           // disable casting at client side spell not allowed by taxi flight (mounted?), probably used with 0x4 flag
		UNIT_FLAG_DISARMED              = 0x00200000,           // 3.0.3, disable melee spells casting..., "Required melee weapon" added to melee spells tooltip.
		UNIT_FLAG_CONFUSED              = 0x00400000,
		UNIT_FLAG_FLEEING               = 0x00800000,
		UNIT_FLAG_PLAYER_CONTROLLED     = 0x01000000,           // used in spell Eyes of the Beast for pet... let attack by controlled creature
		UNIT_FLAG_NOT_SELECTABLE        = 0x02000000,
		UNIT_FLAG_SKINNABLE             = 0x04000000,
		UNIT_FLAG_MOUNT                 = 0x08000000,
		UNIT_FLAG_UNK_28                = 0x10000000,
		UNIT_FLAG_UNK_29                = 0x20000000,           // used in Feing Death spell
		UNIT_FLAG_SHEATHE               = 0x40000000,
		UNIT_FLAG_UNK_31                = 0x80000000            // set skinnable icon and also changes color of portrait
	};

    public enum QuestFlags
    {
        // Flags used at server and sent to client
        QUEST_FLAGS_NONE                = 0x00000000,
        QUEST_FLAGS_STAY_ALIVE          = 0x00000001,                // Not used currently
        QUEST_FLAGS_PARTY_ACCEPT        = 0x00000002,                // If player in party, all players that can accept this quest will receive confirmation box to accept quest CMSG_QUEST_CONFIRM_ACCEPT/SMSG_QUEST_CONFIRM_ACCEPT
        QUEST_FLAGS_EXPLORATION         = 0x00000004,                // Not used currently
        QUEST_FLAGS_SHARABLE            = 0x00000008,                // Can be shared: Player::CanShareQuest()
        //QUEST_FLAGS_NONE2               = 0x00000010,                // Not used currently
        QUEST_FLAGS_EPIC                = 0x00000020,                // Not used currently - 1 quest in 3.3
        QUEST_FLAGS_RAID                = 0x00000040,                // Not used currently
        QUEST_FLAGS_TBC                 = 0x00000080,                // Not used currently: Available if TBC expansion enabled only
        QUEST_FLAGS_UNK2                = 0x00000100,                // Not used currently: _DELIVER_MORE Quest needs more than normal _q-item_ drops from mobs
        QUEST_FLAGS_HIDDEN_REWARDS      = 0x00000200,                // Items and money rewarded only sent in SMSG_QUESTGIVER_OFFER_REWARD (not in SMSG_QUESTGIVER_QUEST_DETAILS or in client quest log(SMSG_QUEST_QUERY_RESPONSE))
        QUEST_FLAGS_AUTO_REWARDED       = 0x00000400,                // These quests are automatically rewarded on quest complete and they will never appear in quest log client side.
        QUEST_FLAGS_TBC_RACES           = 0x00000800,                // Not used currently: Blood elf/Draenei starting zone quests
        QUEST_FLAGS_DAILY               = 0x00001000,                // Daily quest. Can be done once a day. Quests reset at regular intervals for all players.
        QUEST_FLAGS_FLAGS_PVP           = 0x00002000,                // activates PvP on accept
        QUEST_FLAGS_UNK4                = 0x00004000,                // ? Membership Card Renewal
        QUEST_FLAGS_WEEKLY              = 0x00008000,                // Weekly quest. Can be done once a week. Quests reset at regular intervals for all players.
        QUEST_FLAGS_AUTOCOMPLETE        = 0x00010000,                // auto complete
        QUEST_FLAGS_UNK5                = 0x00020000,                // has something to do with ReqItemId and SrcItemId
        QUEST_FLAGS_UNK6                = 0x00040000,                // use Objective text as Complete text
        QUEST_FLAGS_AUTO_ACCEPT         = 0x00080000,                // quests in starting areas

        // Mangos flags for set SpecialFlags in DB if required but used only at server
        QUEST_MANGOS_FLAGS_REPEATABLE   = 0x01000000,   // Set by 1 in SpecialFlags from DB
        QUEST_MANGOS_FLAGS_EXPLORATION_OR_EVENT = 0x02000000,   // Set by 2 in SpecialFlags from DB (if required area explore, spell SPELL_EFFECT_QUEST_COMPLETE casting, table `*_script` command SCRIPT_COMMAND_QUEST_EXPLORED use, set from script DLL)
        QUEST_MANGOS_FLAGS_DB_ALLOWED   = 0xFFFFFF | QUEST_MANGOS_FLAGS_REPEATABLE | QUEST_MANGOS_FLAGS_EXPLORATION_OR_EVENT,

        // Mangos flags for internal use only
        QUEST_MANGOS_FLAGS_DELIVER      = 0x04000000,   // Internal flag computed only
        QUEST_MANGOS_FLAGS_SPEAKTO      = 0x08000000,   // Internal flag computed only
        QUEST_MANGOS_FLAGS_KILL_OR_CAST = 0x10000000,   // Internal flag computed only
        QUEST_MANGOS_FLAGS_TIMED        = 0x20000000,   // Internal flag computed only
    };
}
