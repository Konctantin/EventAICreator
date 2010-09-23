using System;

namespace EventAI
{
    [Flags]
    public enum Phase
    {
        ФАЗА_1,
        ФАЗА_2,
        ФАЗА_3,
        ФАЗА_4,
        ФАЗА_5,
        ФАЗА_6,
        ФАЗА_7,
        ФАЗА_8,
        ФАЗА_9,
        ФАЗА_10,
        ФАЗА_11,
        ФАЗА_12,
        ФАЗА_13,
        ФАЗА_14,
        ФАЗА_15,
        ФАЗА_16,
        ФАЗА_17,
        ФАЗА_18,
        ФАЗА_19,
        ФАЗА_20,
        ФАЗА_21,
        ФАЗА_22,
        ФАЗА_23,
        ФАЗА_24,
        ФАЗА_25,
        ФАЗА_26,
        ФАЗА_27,
        ФАЗА_28,
        ФАЗА_29,
        ФАЗА_30,
        ФАЗА_31,
    };

    public enum EventType
    {
        /// <summary>
        /// 0
        /// </summary>
        ПО_ТАЙМЕРУ_В_БОЮ                        = 0,
        /// <summary>
        /// 1
        /// </summary>
        ПО_ТАЙМЕРУ_ВНЕ_БОЯ                      = 1,
        /// <summary>
        /// 2
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_ЖИЗНИ                      = 2,
        /// <summary>
        /// 3
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_МАНЫ                       = 3,
        /// <summary>
        /// 4
        /// </summary>
        ПРИ_АГРЕ_ЦЕЛИ                           = 4,
        /// <summary>
        /// 5
        /// </summary>
        ПРИ_УБИЙСТВЕ_ЦЕЛИ                       = 5,
        /// <summary>
        /// 6
        /// </summary>
        ПРИ_СМЕРТИ                              = 6,
        /// <summary>
        /// 7
        /// </summary>
        ПРИ_УХОДЕ_В_НЕВИДИМОСТЬ                 = 7,
        /// <summary>
        /// 8
        /// </summary>
        ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ                   = 8,
        /// <summary>
        /// 9
        /// </summary>
        ПРИ_ДИСТАНЦИИ                           = 9,
        /// <summary>
        /// 10
        /// </summary>
        ПРИ_ПОЯВЛЕНИИ_В_ЗОНЕ_ВИДИМОСТИ          = 10,
        /// <summary>
        /// 11
        /// </summary>
        ПРИ_СПАВНЕ                              = 11,
        /// <summary>
        /// 12
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ                 = 12,
        /// <summary>
        /// 13
        /// </summary>
        ЕСЛИ_ЦЕЛЬ_ЧИТАЕТ_ЗАКЛИНАНИЕ             = 13,
        /// <summary>
        /// 14
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ДРУЖЕСТВЕННОЙ_ЦЕЛИ   = 14,
        /// <summary>
        /// 15
        /// </summary>
        ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ПОД_КОНТРОЛЕМ   = 15,
        /// <summary>
        /// 16
        /// </summary>
        ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ТЕРЯЕТ_БАФФ     = 16,
        /// <summary>
        /// 17
        /// </summary>
        ПРИ_ВЫЗОВЕ_СУЩЕСТВА                     = 17,
        /// <summary>
        /// 18
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_МАНЫ_У_ЦЕЛИ                = 18,
        /// <summary>
        /// 21
        /// </summary>
        ПО_ВОЗВРАЩЕНИЮ_В_ТОЧКУ_СПАВНА           = 21,
        /// <summary>
        /// 22
        /// </summary>
        ПРИ_ПОЛУЧЕНИИ_ЭМОЦИИ                    = 22,
        /// <summary>
        /// 23
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_АУРЫ                       = 23,
        /// <summary>
        /// 24
        /// </summary>
        ПРИ_ЗНАЧЕНИИ_АУРЫ_ЦЕЛИ                  = 24,
        /// <summary>
        /// 25
        /// </summary>
        ПРИ_СМЕРТИ_ВЫЗВАННОГО_СУЩЕСТВА          = 25,
        /// <summary>
        /// 26
        /// </summary>
        ПРИ_ИСЧЕЗНОВЕНИИ_ВЫЗВАННОГО_СУЩЕСТВА    = 26,
        /// <summary>
        /// 27
        /// </summary>
        ПРИ_ОТСУТСТВИИ_АУРЫ                     = 27,
        /// <summary>
        /// 28
        /// </summary>
        ПРИ_ОТСУТСТВИИ_АУРЫ_ЦЕЛИ                = 28,
    };

    public enum ActionType
    { 
        БЕЗ_ДЕЙСТВИЯ                            = 0,
        /// <summary>
        /// 0
        /// </summary>
        ТЕКСТ                                   = 1,
        /// <summary>
        /// 1
        /// </summary>
        УСТАНОВИТЬ_ФРАКЦИЮ                      = 2,
        /// <summary>
        /// 3
        /// </summary>
        ИЗМЕНИТЬ_МОДЕЛЬ_СУЩЕСТВА                = 3,
        /// <summary>
        /// 4
        /// </summary>
        ЗВУК                                    = 4,
        /// <summary>
        /// 5
        /// </summary>
        ЭМОЦИЯ                                  = 5,
        /// <summary>
        /// 6
        /// </summary>
        СЛУЧАЙНАЯ_ФРАЗА                         = 6,
        /// <summary>
        /// 7
        /// </summary>
        СЛУЧАЙНЫЙ_КРИК                          = 7,
        /// <summary>
        /// 8
        /// </summary>
        СЛУЧАЙНАЯ_ТЕКСТОВАЯ_ЭМОЦИЯ              = 8,
        /// <summary>
        /// 9
        /// </summary>
        СЛУЧАЙНЫЙ_ЗВУК                          = 9,
        /// <summary>
        /// 10
        /// </summary>
        СЛУЧАЙНАЯ_ЭМОЦИЯ                        = 10,
        /// <summary>
        /// 11
        /// </summary>
        ЧТЕНИЕ_ЗАКЛИНАНИЯ                       = 11,
        /// <summary>
        /// 12
        /// </summary>
        ПРИЗЫВ                                  = 12,
        /// <summary>
        /// 13
        /// </summary>
        ИЗМЕНИТЬ_УГРОЗУ                         = 13,
        /// <summary>
        /// 14
        /// </summary>
        ИЗМЕНИТЬ_УГРОЗУ_ДЛЯ_ВСЕХ                = 14,
        /// <summary>
        /// 15
        /// </summary>
        ВЫПОЛНИТЬ_УСЛОВИЕ_КВЕСТА                = 15,
        /// <summary>
        /// 16
        /// </summary>
        ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ             = 16,
        /// <summary>
        /// 17
        /// </summary>
        ИЗМЕНИТЬ_UNIT_FIELD                     = 17,
        /// <summary>
        /// 18
        /// </summary>
        ИЗМЕНИТЬ_UNIT_FLAG                      = 18,
        /// <summary>
        /// 19
        /// </summary>
        УБРАТЬ_UNIT_FLAG                        = 19,
        /// <summary>
        /// 20
        /// </summary>
        АВТО_АТАКА_БЛИЖНЕГО_БОЯ                 = 20,
        /// <summary>
        /// 21
        /// </summary>
        ДВИЖЕНИЕ_В_БОЮ                          = 21,
        /// <summary>
        /// 22
        /// </summary>
        УСТАНОВИТЬ_ФАЗУ                         = 22,
        /// <summary>
        /// 23
        /// </summary>
        ПОВЫСИТЬ_ФАЗУ                           = 23,
        /// <summary>
        /// 24
        /// </summary>
        УЙТИ_В_НЕВИДИМОСТЬ                      = 24,
        /// <summary>
        /// 25
        /// </summary>
        ПОБЕГО_С_ПОЛЯ_БОЯ                       = 25,
        /// <summary>
        /// 26
        /// </summary>
        ЗАВЕРШИТЬ_КВЕСТ_ДЛЯ_ГРУППЫ              = 26,
        /// <summary>
        /// 27
        /// </summary>
        ЗАСЧИТАТЬ_ЧТЕНИЕ_ЗАКЛИНАНИЯ_ДЛЯ_ГРУППЫ  = 27,
        /// <summary>
        /// 28
        /// </summary>
        УБРАТЬ_С_ЦЕЛИ_АУРУ                      = 28,
        /// <summary>
        /// 29
        /// </summary>
        УДАЛИТСЯ_ОТ_ЦЕЛИ                        = 29,
        /// <summary>
        /// 30
        /// </summary>
        СЛУЧАЙНАЯ_ФАЗА                          = 30,
        /// <summary>
        /// 31
        /// </summary>
        СЛУЧАЙНАЯ_ФАЗА_С_ПАРАМЕТРОМ             = 31,
        /// <summary>
        /// 32
        /// </summary>
        ПРИЗЫВ_В_ОПРЕДЕЛЕННУЮ_ТОЧКУ             = 32,
        /// <summary>
        /// 33
        /// </summary>
        ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА             = 33,
        /// <summary>
        /// 34
        /// </summary>
        SET_INST_DATA                           = 34,
        /// <summary>
        /// 35
        /// </summary>
        SET_INST_DATA64                         = 35,
        /// <summary>
        /// 36
        /// </summary>
        ИЗМЕНИТЬ_ПАРАМЕТРЫ_СУЩЕСТВА             = 36,
        /// <summary>
        /// 37
        /// </summary>
        СМЕРТЬ_СУЩЕСТВА                         = 37,
        /// <summary>
        /// 38
        /// </summary>
        ВВЕСТИ_ВСЕХ_ИГРОКОВ_ЗОНЫ_В_БОЙ          = 38,
        /// <summary>
        /// 39
        /// </summary>
        ОБРАТИТЬСЯ_ЗА_ПОМОЩЬЮ                   = 39,
        /// <summary>
        /// 40
        /// </summary>
        ВИЗУАЛИЗАЦИЯ_ДЕЙСТВИЯ_С_ОРУЖИЕМ         = 40,
        /// <summary>
        /// 41
        /// </summary>
        ПРИНУДИТЕЛЬНО_ДЕСПАВНИТЬ                = 41,
        /// <summary>
        /// 42
        /// </summary>
        НЕВОЗМОЖНОСТЬ_АТАКОВАТЬ                 = 42,
        /// <summary>
        /// 43
        /// </summary>
        ОСЕДЛАТЬ_МАУНТА_ПО_ENTRY_ИЛИ_ИД_МОДЕЛИ  = 43,
    };

    public enum ConditionType
    {
        /// <summary>
        /// 0
        /// </summary>
        НЕТ_ДЕЙСТВИЯ                = 0,
        /// <summary>
        /// 1
        /// </summary>
        ПРИ_НАЛИЧИИ_АУРЫ            = 1,
        /// <summary>
        /// 2
        /// </summary>
        ПРИ_НАЛИЧИИ_ПРЕЕДМЕТА       = 2,
        /// <summary>
        /// 3
        /// </summary>
        ЕСЛИ_ПРЕДМЕТ_НА_ПЕРСОНАЖЕ   = 3,
        /// <summary>
        /// 4
        /// </summary>
        ЕСЛИ_НАХОДИТСЯ_В_ЗОНЕ       = 4,
        /// <summary>
        /// 5
        /// </summary>
        ПРИ_НАЛИЧИИ_РЕПУТАЦИИ       = 5,
        /// <summary>
        /// 6
        /// </summary>
        КОМАНДА                     = 6,
        /// <summary>
        /// 7
        /// </summary>
        ПРИ_НАЛИЧИИ_УМЕНИЯ          = 7,
        /// <summary>
        /// 8
        /// </summary>
        ЕСЛИ_КВЕСТ_СДАН             = 8,
        /// <summary>
        /// 9
        /// </summary>
        ЕСЛИ_КВЕСТ_НЕ_СДАН          = 9,
        /// <summary>
        /// 12
        /// </summary>
        ПРИ_АКТИВНОМ_ЭВЕНТЕ         = 12,
    };

    public enum ConditionTeam
    {
        /// <summary>
        /// 496
        /// </summary>
        АЛЬЯНС = 469,
        /// <summary>
        /// 67
        /// </summary>
        ОРДА   =  67,
    };

    public enum Team
    {
        /// <summary>
        /// 0
        /// </summary>
        АЛЬЯНС = 0,
        /// <summary>
        /// 1
        /// </summary>
        ОРДА   = 1,
    };

    public enum ValueType
    {
        /// <summary>
        /// 0
        /// </summary>
        ЗНАЧЕНИЕ = 0,
        /// <summary>
        /// 1
        /// </summary>
        ПРОЦЕНТ  = 1,
    };

    public enum YesNO
    {
        /// <summary>
        /// 0
        /// </summary>
        НЕТ = 0,
        /// <summary>
        /// 1
        /// </summary>
        ДА  = 1,
    };

    public enum TargetFrends
    {
        /// <summary>
        /// 0
        /// </summary>
        ВРАЖДЕБНАЯ_ЦЕЛЬ    = 0,
        /// <summary>
        /// 1
        /// </summary>
        ДРУЖЕСТВЕННАЯ_ЦЕЛЬ = 1,
    }

    public enum SheathState
    {
        /// <summary>
        /// 0
        /// </summary>
        БЕЗ_ОРУЖИЯ      = 0,
        /// <summary>
        /// 1
        /// </summary>
        В_БЛИЖНЕМ_БОЮ   = 1,
        /// <summary>
        /// 2
        /// </summary>
        В_ДАЛЬНЕМ_БОЮ   = 2,
    };

    public enum InstantData
    {
        /// <summary>
        /// 0
        /// </summary>
        NOT_STARTED = 0,
        /// <summary>
        /// 1
        /// </summary>
        IN_PROGRESS = 1,
        /// <summary>
        /// 2
        /// </summary>
        FAIL        = 2,
        /// <summary>
        /// 3
        /// </summary>
        DONE        = 3,
        /// <summary>
        /// 4
        /// </summary>
        SPECIAL     = 4,
    };

    public enum CastFlags
    { 
        /// <summary>
        /// 1
        /// </summary>
        ПРЕРЫВАЕТ_ПРЕДЫДУЩЕЕ            = 1,
        /// <summary>
        /// 2
        /// </summary>
        МОМЕНТАЛЬНО_БЕЗ_УСЛОВИЙ         = 2,
        /// <summary>
        /// 4
        /// </summary>
        БЕЗ_ТРЕБОВАНИЯ_РАСТОЯНИЯ_И_МАНЫ = 4,
        /// <summary>
        /// 8
        /// </summary>
        ЗАПРЕТ_НАЧАЛА_МИЛИ_АТАКИ        = 8,
        /// <summary>
        /// 16
        /// </summary>
        КАСТ_ЭТОГО_ЗАКЛИНАНИЯ_ЦЕЛЬЮ     = 16,
        /// <summary>
        /// 32
        /// </summary>
        НАКЛАДЫВАТЬ_НА_СЕБЯ_ЕСЛИ_НЕТУ   = 32,
    };

    public enum School
    { 
        /// <summary>
        /// 0
        /// </summary>
        ОБЫЧНАЯ     = 0,
        /// <summary>
        /// 1
        /// </summary>
        СВЯТАЯ      = 1,
        /// <summary>
        /// 2
        /// </summary>
        ОГНЕННАЯ    = 2,
        /// <summary>
        /// 3
        /// </summary>
        ПРИРОДНАЯ   = 3,
        /// <summary>
        /// 4
        /// </summary>
        ЛЕДЯНАЯ     = 4,
        /// <summary>
        /// 5
        /// </summary>
        ТЕМНАЯ      = 5,
        /// <summary>
        /// 6
        /// </summary>
        ТАЙНАЯ      = 6,
    };

    public enum CastTarget
    {
        /// <summary>
        /// 0
        /// </summary>
        САМО_СУЩЕСТВО                       = 0,
        /// <summary>
        /// 1
        /// </summary>
        ТЕКУЩАЯ_ЦЕЛЬ                        = 1,
        /// <summary>
        /// 2
        /// </summary>
        ВТОРАЯ_ЦЕЛЬ_В_АГРОЛИСТЕ             = 2,
        /// <summary>
        /// 3
        /// </summary>
        ПОСЛЕДНИЙ_УБИТЫЙ                    = 3,
        /// <summary>
        /// 4
        /// </summary>
        СЛУЧАЙНАЯ_ЦЕЛЬ_ИЗ_АГРОЛИСТА         = 4,
        /// <summary>
        /// 5
        /// </summary>
        СЛУЧАЙНАЯ_НЕ_ПЕРВАЯ_ПО_АГРО_ЦЕЛЬ    = 5,
        /// <summary>
        /// 6
        /// </summary>
        ВЫЗВАВШИЙ_СОБЫТИЕ                   = 6,
    };

    public enum MessageType
    { 
        /// <summary>
        /// 0
        /// </summary>
        SAY             = 0,
        /// <summary>
        /// 1
        /// </summary>
        YELL            = 1,
        /// <summary>
        /// 2
        /// </summary>
        TEXT_EMOTE      = 2,
        /// <summary>
        /// 3
        /// </summary>
        BOSS_EMOTE      = 3,
        /// <summary>
        /// 4
        /// </summary>
        WHISPER         = 4,
        /// <summary>
        /// 5
        /// </summary>
        BOSS_WHISPER    = 5,
        /// <summary>
        /// 6
        /// </summary>
        ZONE_YELL       = 6,
    };

    public enum Lenguage
    { 
        /// <summary>
        /// 0
        /// </summary>
        УНИВЕРСАЛЬНЫЙ           = 0,
        /// <summary>
        /// 1
        /// </summary>
        ЯЗЫК_ОРКОВ_ВСЕ          = 1,
        /// <summary>
        /// 2
        /// </summary>
        ЯЗЫК_НОЧНЫХ_ЭЛЬФОВ      = 2,
        /// <summary>
        /// 3
        /// </summary>
        ЯЗЫК_ТАУРЕНОВ           = 3,
        /// <summary>
        /// 6
        /// </summary>
        ЯЗЫК_ДВОРФОВ            = 6,
        /// <summary>
        /// 7
        /// </summary>
        ЯЗЫК_ЛЮДЕЙ_ВСЕ          = 7,
        /// <summary>
        /// 8
        /// </summary>
        ЯЗЫК_ДЕМОНОВ            = 8,
        /// <summary>
        /// 9
        /// </summary>
        ЯЗЫК_ТИТАНОВ            = 9,
        /// <summary>
        /// 10
        /// </summary>
        ЯЗЫК_КРОВАВЫХ_ЭЛЬФОВ    = 10,
        /// <summary>
        /// 11
        /// </summary>
        ЯЗЫК_ДРАКОНОВ           = 11,
        /// <summary>
        /// 12
        /// </summary>
        ЯЗЫК_ЭЛЕМЕНТАЛОВ        = 12,
        /// <summary>
        /// 13
        /// </summary>
        ЯЗЫК_ГНОМОВ             = 13,
        /// <summary>
        /// 14
        /// </summary>
        ЯЗЫК_ТРОЛЕЙ             = 14,
        /// <summary>
        /// 33
        /// </summary>
        ЯЗЫК_НЕЖИТИ             = 33,
        /// <summary>
        /// 35
        /// </summary>
        ЯЗЫК_ДРЕНЕЙ             = 35,
        /// <summary>
        /// 36
        /// </summary>
        ЯЗЫК_ЗОМБИ              = 36,
        /// <summary>
        /// 37
        /// </summary>
        ЯЗЫК_ГНОМОВ_БИНАРНЫЙ    = 37,
        /// <summary>
        /// 38
        /// </summary>
        ЯЗЫК_ГОБЛИНОВ_БИНАРНЫЙ  = 38,
    };

    public enum Locales
    {
        enUS = 0,
        koKR = 1,
        frFR = 2,
        deDE = 3,
        zhCN = 4,
        zhTW = 5,
        esES = 6,
        esMX = 7,
        ruRU = 8,
    };
}
