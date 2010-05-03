using System.Windows.Forms;

namespace EventAI
{
    public static class Inscription
    {
        public static void ShowActionParametrInscription(ComboBox cb, Label l1, Label l2, Label l3, ComboBox cb1, ComboBox cb2, ComboBox cb3, GroupBox gr)
        {
            Default.Reset(gr);

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
                            cb1.SetDbcData(DataSet.Emote);
                            cb2.SetDbcData(DataSet.Emote);
                            cb3.SetDbcData(DataSet.Emote);
                        }
                        break;
                    case ActionType.ЧТЕНИЕ_ЗАКЛИНАНИЯ:
                        {
                            l1.Text = "ID спелла";
                            l2.Text = "Цель";
                            l3.Text = "Флаг каста";
                        }
                        break;
                    case ActionType.ПРИЗЫВ:
                        {
                            l1.Text = "ID существа";
                            l2.Text = "Цель";
                            l3.Text = "Продолжительность (мс)";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ:
                        {
                            l1.Text = "Угроза %";
                            l2.Text = "Цель";
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
                        } break;
                    case ActionType.ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ:
                        {
                            l1.Text = "ID существа";
                            l2.Text = "ID спелла";
                            l3.Text = "Цель";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FIELD:
                        l1.Text = "Номер поля Data";
                        l2.Text = "Значение";
                        l3.Text = "Цель";
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FLAG:
                        l1.Text = "Флаг существа";
                        l2.Text = "Цель";
                        break;
                    case ActionType.УБРАТЬ_UNIT_FLAG:
                        l1.Text = "Флаг существа";
                        l2.Text = "Цель";
                        break;
                    case ActionType.АВТО_АТАКА_БЛИЖНЕГО_БОЯ:
                        l1.Text = "Разрешить атаку в ближнем бою";
                        break;
                    case ActionType.ДВИЖЕНИЕ_В_БОЮ:
                        l1.Text = "Разрешить движение в бою";
                        l2.Text = "Остановить, стартовать режим боя";
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
                        l3.Text = "ID из creature_ai_summons";
                        break;
                    case ActionType.ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА:
                        l1.Text = "ID существа";
                        l2.Text = "Цель";
                        break;
                    case ActionType.SET_INST_DATA:
                        l1.Text = "Поле";
                        l2.Text = "Значение";
                        break;
                    case ActionType.SET_INST_DATA64:
                        l1.Text = "Поле";
                        l2.Text = "Цель";
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
            cb1.Visible = l1.Text != "";
            cb2.Visible = l2.Text != "";
            cb3.Visible = l3.Text != "";
         }


        public static void ShowEventTypeInscription(ComboBox comboEventType, 
            Label lEventType1, Label lEventType2, Label lEventType3, Label lEventType4,
            ComboBox _cbEventParametr1, ComboBox _cbEventParametr2, ComboBox _cbEventParametr3, ComboBox _cbEventParametr4,
            Button _bEventParam1, Button _bEventParam2, Button _bEventParam3, Button _bEventParam4)
        {
            lEventType1.Text = lEventType2.Text = lEventType3.Text = lEventType4.Text = "";
            _bEventParam1.Visible = _bEventParam2.Visible = _bEventParam3.Visible = _bEventParam4.Visible = false;

            try
            {
                switch ((EventType)comboEventType.SelectedValue.ToUInt32())
                {
                    case EventType.ПО_ТАЙМЕРУ_В_БОЮ:
                    case EventType.ПО_ТАЙМЕРУ_В_НЕ_БОЯ:
                        lEventType1.Text = "Минимальное время до срабатывания (мс)";
                        lEventType2.Text = "Максимальное время до срабатывания (мс)";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                        lEventType1.Text = "Максимальное значение жизни %";
                        lEventType2.Text = "Минимальное значение жизни %";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                    case EventType.ПРИ_ЗНАЧЕНИИ_МАННЫ_У_ЦЕЛИ:
                        lEventType1.Text = "Максимальное значение маны %";
                        lEventType2.Text = "Минимальное значение маны %";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_УБИЙСТВЕ_ЦЕЛИ:
                    case EventType.ЕСЛИ_ЦЕЛЬ_ЧИТАЕТ_ЗАКЛИНАНИЕ:
                        lEventType1.Text = "Минимальное время до повтора (мс)";
                        lEventType2.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ:
                        {
                            lEventType1.Text = "Укажите ID спелла";
                            lEventType2.Text = "Школа спелов";
                            lEventType3.Text = "Минимальное время до повтора (мс)";
                            lEventType4.Text = "Максимальное время до повтора (мс)";
                            _bEventParam2.Visible = true;
                        }
                        break;
                    case EventType.ПРИ_ДИСТАНЦИИ:
                        lEventType1.Text = "Минимальная дистанция до цели";
                        lEventType2.Text = "Максимальная дистанция до цели";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ПОЯВЛЕНИИ_В_ЗОНЕ_ВИДИМОСТИ:
                        lEventType1.Text = "Дружественная цель:";
                        lEventType2.Text = "Максимальная дистанция до цели";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ДРУЖЕСТВЕННОЙ_ЦЕЛИ:
                        lEventType1.Text = "Дефицит жизни дружественной цели";
                        lEventType2.Text = "В радиусе";
                        lEventType3.Text = "Минимальное время до повтора (мс)";
                        lEventType4.Text = "Максимальное время до повтора (мс)";
                        break;
                    case EventType.ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ПОД_КОНТРОЛЕМ:
                        {
                            lEventType1.Text = "Тип диспелла";
                            lEventType2.Text = "В радиусе";
                            lEventType3.Text = "Минимальное время до повтора (мс)";
                            lEventType4.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                    case EventType.ЕСЛИ_ТЕРЯЕТ_БАФФ:
                        {
                            lEventType1.Text = "ID спелла (заклинания)";
                            lEventType2.Text = "В радиусе";
                            lEventType3.Text = "Минимальное время до повтора (мс)";
                            lEventType4.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                    case EventType.ПРИ_СПАВНЕ_СУЩЕСТВА:
                        {
                            lEventType1.Text = "ID существа";
                            lEventType2.Text = "Минимальное время до повтора (мс)";
                            lEventType3.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                    case EventType.ПРИ_ПОЛУЧЕНИИ_ЭМОЦИИ:
                        {
                            lEventType1.Text = "ID эмоции";
                            lEventType2.Text = "Условие";
                        }
                        break;
                    case EventType.ПРИ_ЗНАЧЕНИИ_БАФФА:
                    case EventType.ПРИ_ЗНАЧЕНИИ_БАФФА_ЦЕЛИ:
                        {
                            lEventType1.Text = "ID спелла";
                            lEventType2.Text = "Количество";
                            lEventType3.Text = "Минимальное время до повтора (мс)";
                            lEventType4.Text = "Максимальное время до повтора (мс)";
                        }
                        break;
                }
            }
            catch
            {
                return;
            }
            _cbEventParametr1.Visible = lEventType1.Text != "";
            _cbEventParametr2.Visible = lEventType2.Text != "";
            _cbEventParametr3.Visible = lEventType3.Text != "";
            _cbEventParametr4.Visible = lEventType4.Text != "";
         }

        public static void ShowActionTyteCondition(ComboBox cEventParamCondition, Label lEventType3, Label lEventType4, 
            TextBox EventParam3, TextBox EventParam4)
        {
            lEventType3.Text = "";
            lEventType4.Text = "";

            switch ((ConditionType)cEventParamCondition.SelectedValue.ToUInt32())
            {
                case ConditionType.ПРИ_НАЛИЧИИ_АУРЫ:
                    lEventType3.Text = "ID спелла";
                    lEventType4.Text = "Время до повтора (мс)";
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_ПРЕЕДМЕТА:
                    lEventType3.Text = "ID предмета";
                    lEventType4.Text = "Количество";
                    break;
                case ConditionType.ЕСЛИ_ПРЕДМЕТ_НА_ПЕРСОНАЖЕ:
                    lEventType3.Text = "ID предмета";
                    lEventType4.Text = "Количество";
                    break;
                case ConditionType.ЕСЛИ_НАХОДИТСЯ_В_ЗОНЕ:
                    lEventType3.Text = "ID зоны";
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_РЕПУТАЦИИ:
                    lEventType3.Text = "ID фракции";
                    lEventType4.Text = "Минимальный ранг";
                    break;
                case ConditionType.КОМАНДА:
                    lEventType3.Text = "Укажите команду (Орда/Альянс):";
                    break;
                case ConditionType.ПРИ_НАЛИЧИИ_УМЕНИЯ:
                    lEventType3.Text = "ID умения";
                    lEventType4.Text = "Минимальный уровень прокачки";
                    break;
                case ConditionType.ЕСЛИ_КВЕСТ_СДАН:
                    lEventType3.Text = "ID квеста";
                    break;
                case ConditionType.ЕСЛИ_КВЕСТ_НЕ_СДАН:
                    lEventType3.Text = "ID квеста";
                    break;
                case ConditionType.ПРИ_АКТИВНОМ_ЭВЕНТЕ:
                    lEventType3.Text = "ID эвента";
                    break;
            }
        }
    }
}
