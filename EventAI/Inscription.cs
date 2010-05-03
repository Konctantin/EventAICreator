using System.Windows.Forms;

namespace EventAI
{
    public static class Inscription
    {
        public static void ShowActionParametrInscription(ComboBox cb, Label l1, Label l2, Label l3, ComboBox cb1, ComboBox cb2, ComboBox cb3, Button b1, Button b2, Button b3, GroupBox gr)
        {
            gr.Reset();
          
            try
            {
                switch ((ActionType)cb.SelectedValue.ToUInt32())
                {
                    case ActionType.ТЕКСТ:
                        {
                            l1.Text = "ID текста 1";
                            l2.Text = "ID текста 2";
                            l3.Text = "ID текста 3";
                         }
                        break;
                    case ActionType.УСТАНОВИТЬ_ФРАКЦИЮ:
                        {
                            l1.Text = "ID фракции";
                            cb1.SetDbcData(DataSet.Fraction);
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_МОДЕЛЬ_СУЩЕСТВА:
                        {
                            l1.Text = "ID существа";
                            l3.Text = "ID модели";
                         }
                        break;
                    case ActionType.ЗВУК:
                        {
                            l1.Text = "ID звука";
                        }
                        break;
                    case ActionType.ЭМОЦИЯ:
                        {
                            l1.Text = "ID эмоции";
                            cb1.SetDbcData(DataSet.Emote);
                        }
                        break;
                    case ActionType.СЛУЧАЙНЫЙ_ЗВУК:
                        {
                            l1.Text = "ID звука 1";
                            l2.Text = "ID звука 2";
                            l3.Text = "ID звука 3";
                        }
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ЭМОЦИЯ:
                        {
                            l1.Text = "ID эмоции 1";
                            l2.Text = "ID эмоции 2";
                            l3.Text = "ID эмоции 3";
                        }
                        break;
                    case ActionType.ЧТЕНИЕ_ЗАКЛИНАНИЯ:
                        {
                            l1.Text = "ID спелла";
                            l2.Text = "Цель";
                            l3.Text = "Флаг каста";
                            b1.Visible = b3.Visible = true;
                            cb2.SetEnumValues<CastTarget>();
                        }
                        break;
                    case ActionType.ПРИЗЫВ:
                        {
                            l1.Text = "ID существа";
                            l2.Text = "Цель";
                            l3.Text = "Продолжительность (мс)";
                            cb2.SetEnumValues<CastTarget>();
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ:
                        {
                            l1.Text = "Угроза %";
                            l2.Text = "Цель";
                            cb2.SetEnumValues<CastTarget>();
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ_ДЛЯ_ВСЕХ:
                        {
                            l1.Text = "Угроза %";
                        }
                        break;
                    case ActionType.ВЫПОЛНИТЬ_УСЛОВИЕ_КВЕСТА:
                        {
                            l1.Text = "ID квеста";
                            l2.Text = "Цель";
                            cb2.SetEnumValues<CastTarget>();
                        } break;
                    case ActionType.ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ:
                        {
                            l1.Text = "ID существа";
                            l2.Text = "ID спелла";
                            l3.Text = "Цель";
                            cb3.SetEnumValues<CastTarget>();
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FIELD:
                        l1.Text = "Номер поля Data";
                        l2.Text = "Значение";
                        l3.Text = "Цель";
                        cb3.SetEnumValues<CastTarget>();
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FLAG:
                        l1.Text = "Флаг существа";
                        l2.Text = "Цель";
                        cb2.SetEnumValues<CastTarget>();
                        break;
                    case ActionType.УБРАТЬ_UNIT_FLAG:
                        l1.Text = "Флаг существа";
                        l2.Text = "Цель";
                        cb2.SetEnumValues<CastTarget>();
                        break;
                    case ActionType.АВТО_АТАКА_БЛИЖНЕГО_БОЯ:
                        l1.Text = "Разрешить атаку в ближнем бою";
                        cb1.SetEnumValues<YesNO>();
                        break;
                    case ActionType.ДВИЖЕНИЕ_В_БОЮ:
                        l1.Text = "Разрешить движение в бою";
                        l2.Text = "Остановить, стартовать режим боя";
                        cb1.SetEnumValues<YesNO>();
                        break;
                    case ActionType.УСТАНОВИТЬ_ФАЗУ:
                        l1.Text = "Фаза";
                         break;
                    case ActionType.ПОВЫСИТЬ_ФАЗУ:
                        l1.Text = "Значение";
                        break;
                    case ActionType.ЗАВЕРШИТЬ_КВЕСТ_ДЛЯ_ГРУППЫ:
                        l1.Text = "ID квеста";
                        break;
                    case ActionType.ЗАСЧИТАТЬ_ЧТЕНИЕ_ЗАКЛИНАНИЯ_ДЛЯ_ГРУППЫ:
                        l1.Text = "ID квеста";
                        l2.Text = "ID спелла";
                        break;
                    case ActionType.УБРАТЬ_С_ЦЕЛИ_АУРУ:
                        l1.Text = "Цель";
                        cb1.SetEnumValues<CastTarget>();
                        l2.Text = "ID спелла";
                         break;
                    case ActionType.УДАЛИТСЯ_ОТ_ЦЕЛИ:
                        l1.Text = "Дистанция";
                        l2.Text = "Под углом";
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФРАЗА:
                        l1.Text = "ID фазы 1";
                        l2.Text = "ID фазы 2";
                        l3.Text = "ID фазы 3";
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФАЗА_С_ПАРАМЕТРОМ:
                        l1.Text = "Минимальный номер фазы";
                        l2.Text = "Максимальный номер фазы";
                        break;
                    case ActionType.ПРИЗЫВ_В_ОПРЕДЕЛЕННУЮ_ТОЧКУ:
                        l1.Text = "ID существа";
                        l2.Text = "Цель";
                        cb2.SetEnumValues<CastTarget>();
                        l3.Text = "ID из creature_ai_summons";
                        break;
                    case ActionType.ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА:
                        l1.Text = "ID существа";
                        l2.Text = "Цель";
                        cb2.SetEnumValues<CastTarget>();
                        break;
                    case ActionType.SET_INST_DATA:
                        l1.Text = "Поле";
                        l2.Text = "Значение";
                        break;
                    case ActionType.SET_INST_DATA64:
                        l1.Text = "Поле";
                        l2.Text = "Цель";
                        cb2.SetEnumValues<CastTarget>();
                        break;
                    case ActionType.ИЗМЕНИТЬ_ПАРАМЕТРЫ_СУЩЕСТВА:
                        l1.Text = "Номер из creature_template";
                        l2.Text = "Команда:";
                        break;
                    case ActionType.ОБРАТИТЬСЯ_ЗА_ПОМОЩЬЮ:
                        l1.Text = "В радиусе:";
                        break;
                    case ActionType.ВИЗУАЛИЗАЦИЯ_ДЕЙСТВИЯ_С_ОРУЖИЕМ:
                        l1.Text = "Действие";
                         break;
                    case ActionType.ПРИНУДИТЕЛЬНО_ДЕСПАВНИТЬ:
                        break;
                    case ActionType.НЕВОЗМОЖНОСТЬ_АТАКОВАТЬ:
                        l1.Text = "При значении жизни";
                        break;
                }
            }
            catch
            {
                return;
            }
            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
         }


        public static void ShowEventTypeInscription(ComboBox cb, Label l1, Label l2, Label l3, Label l4,
            ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, Button b1, Button b2, Button b3, Button b4, GroupBox gr)
        {
            gr.Reset();

            try
            {
                switch ((EventType)cb.SelectedValue.ToUInt32())
                {
                    case EventType.ПО_ТАЙМЕРУ_В_БОЮ:
                    case EventType.ПО_ТАЙМЕРУ_В_НЕ_БОЯ:
                        l1.Text = "Минимальное время до срабатывания (мс)";
                        l2.Text = "Максимальное время до срабатывания (мс)";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                        l1.Text = "Максимальное значение жизни %";
                        l2.Text = "Минимальное значение жизни %";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                    case EventType.ПРИ_ЗНАЧЕНИИ_МАННЫ_У_ЦЕЛИ:
                        l1.Text = "Максимальное значение маны %";
                        l2.Text = "Минимальное значение маны %";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_УБИЙСТВЕ_ЦЕЛИ:
                    case EventType.ЕСЛИ_ЦЕЛЬ_ЧИТАЕТ_ЗАКЛИНАНИЕ:
                        l1.Text = "Минимальное время до повтора (мс)";
                        l2.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ:
                        {
                            l1.Text = "Укажите ID спелла";
                            l2.Text = "Школа спелов";
                            l3.Text = "Минимальное время до повтора (мс)";
                            l4.Text = "Максимальное время до повтора (мс)";
                            b2.Visible = b1.Visible = true;
                        }
                        break;
                    case EventType.ПРИ_ДИСТАНЦИИ:
                        l1.Text = "Минимальная дистанция до цели";
                        l2.Text = "Максимальная дистанция до цели";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ПОЯВЛЕНИИ_В_ЗОНЕ_ВИДИМОСТИ:
                        l1.Text = "Дружественная цель:";
                        l2.Text = "Максимальная дистанция до цели";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ДРУЖЕСТВЕННОЙ_ЦЕЛИ:
                        l1.Text = "Дефицит жизни дружественной цели";
                        l2.Text = "В радиусе";
                        l3.Text = "Минимальное время до повтора (мс)";
                        l4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ПОД_КОНТРОЛЕМ:
                        {
                            l1.Text = "Тип диспелла";
                            cb1.SetEnumValues<DispelType>("DISPEL_");
                            l2.Text = "В радиусе";
                            l3.Text = "Минимальное время до повтора (мс)";
                            l4.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                    case EventType.ЕСЛИ_ТЕРЯЕТ_БАФФ:
                        {
                            l1.Text = "ID спелла (заклинания)";
                            l2.Text = "В радиусе";
                            l3.Text = "Минимальное время до повтора (мс)";
                            l4.Text = "Максимальное время до повтора (мс)";
                            b1.Visible = true;
                        }
                        break;
                    case EventType.ПРИ_СПАВНЕ_СУЩЕСТВА:
                        {
                            l1.Text = "ID существа";
                            b1.Visible = true;
                            l2.Text = "Минимальное время до повтора (мс)";
                            l3.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                    case EventType.ПРИ_ПОЛУЧЕНИИ_ЭМОЦИИ:
                        {
                            l1.Text = "ID эмоции";
                            l2.Text = "Условие";
                            cb1.SetDbcData(DataSet.Emote);
                            cb2.SetEnumValues<ConditionType>();
                        }
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_БАФФА:
                    case EventType.ПРИ_ЗНАЧЕНИИ_БАФФА_ЦЕЛИ:
                        {
                            l1.Text = "ID спелла";
                            b1.Visible = true;
                            l2.Text = "Количество";
                            l3.Text = "Минимальное время до повтора (мс)";
                            l4.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                }
            }
            catch
            {
                return;
            }
            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
         }

        public static void ShowActionTyteCondition(ComboBox cb, Label l3, Label l4, ComboBox cb3, ComboBox cb4, Button b3, Button b4)
        {
            l3.Text = l4.Text = string.Empty;
            cb3.DataSource = cb4.DataSource = null;
            b3.Visible = b4.Visible = false;
            b3.Text = b4.Text = string.Empty;

            switch ((ConditionType)cb.SelectedValue.ToUInt32())
            {
                case ConditionType.ПРИ_НАЛИЧИИ_АУРЫ:
                    l3.Text = "ID спелла";
                    b3.Visible = true;
                    b3.Text = "Найти";
                    l4.Text = "Время до повтора (мс)";
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_ПРЕЕДМЕТА:
                case ConditionType.ЕСЛИ_ПРЕДМЕТ_НА_ПЕРСОНАЖЕ:
                    l3.Text = "ID предмета";
                    b3.Visible = true;
                    b3.Text = "Найти";
                    l4.Text = "Количество";
                    break;
                case ConditionType.ЕСЛИ_НАХОДИТСЯ_В_ЗОНЕ:
                    l3.Text = "ID зоны";
                    cb3.SetDbcData(DataSet.Area);
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_РЕПУТАЦИИ:
                    l3.Text = "ID фракции";
                    cb3.SetDbcData(DataSet.Fraction);
                    l4.Text = "Минимальный ранг";
                    break;
                case ConditionType.КОМАНДА:
                    l3.Text = "Команда";
                    cb3.SetEnumValues<Team>();
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_УМЕНИЯ:
                    l3.Text = "ID умения";
                    cb3.SetDbcData(DataSet.Skill);
                    l4.Text = "Минимальный уровень прокачки";
                    break;
                case ConditionType.ЕСЛИ_КВЕСТ_СДАН:
                case ConditionType.ЕСЛИ_КВЕСТ_НЕ_СДАН:
                    l3.Text = "ID квеста";
                    b3.Visible = true;
                    b3.Text = "Найти";
                    break;
                case ConditionType.ПРИ_АКТИВНОМ_ЭВЕНТЕ:
                    l3.Text = "ID эвента";
                    b3.Visible = true;
                    b3.Text = "Найти";
                    break;
            }

            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
        }
    }
}
