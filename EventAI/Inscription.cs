using System.Windows.Forms;

namespace EventAI
{
    public static class Inscription
    {
        public static void ShowActionParametrInscription(ComboBox cb, Label lActionParam1, Label lActionParam2, Label lActionParam3,
            Button bSelectActionParam1, Button bSelectActionParam2, Button bSelectActionParam3,
            ComboBox cbActionParam1, ComboBox cbActionParam2, ComboBox cbActionParam3)
        {
            lActionParam3.Text = "";
            lActionParam2.Text = "";
            lActionParam3.Text = "";
            try
            {
                switch ((ActionType)cb.SelectedValue)
                {
                    case ActionType.ТЕКСТ:
                        {
                            lActionParam1.Text = "ID текста 1";
                            lActionParam2.Text = "ID текста 2";
                            lActionParam3.Text = "ID текста 3";
                         }
                        break;
                    case ActionType.УСТАНОВИТЬ_ФРАКЦИЮ:
                        {
                            lActionParam1.Text = "ID фракции";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_МОДЕЛЬ_СУЩЕСТВА:
                        {
                            lActionParam1.Text = "ID существа";
                            lActionParam3.Text = "ID модели";
                         }
                        break;
                    case ActionType.ЗВУК:
                        {
                            lActionParam1.Text = "ID звука";
                        }
                        break;
                    case ActionType.ЭМОЦИЯ:
                        {
                            lActionParam1.Text = "ID эмоции";
                        }
                        break;
                    case ActionType.СЛУЧАЙНЫЙ_ЗВУК:
                        {
                            lActionParam1.Text = "ID звука 1";
                            lActionParam2.Text = "ID звука 2";
                            lActionParam3.Text = "ID звука 3";
                        }
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ЭМОЦИЯ:
                        {
                            lActionParam1.Text = "ID эмоции 1";
                            lActionParam2.Text = "ID эмоции 2";
                            lActionParam3.Text = "ID эмоции 3";
                        }
                        break;
                    case ActionType.ЧТЕНИЕ_ЗАКЛИНАНИЯ:
                        {
                            lActionParam1.Text = "ID спелла";
                            lActionParam2.Text = "Цель";
                            lActionParam3.Text = "Флаг каста";
                        }
                        break;
                    case ActionType.ПРИЗЫВ:
                        {
                            lActionParam1.Text = "ID существа";
                            lActionParam2.Text = "Цель";
                            lActionParam3.Text = "Продолжительность (мс)";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ:
                        {
                            lActionParam1.Text = "Угроза %";
                            lActionParam2.Text = "Цель";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ_ДЛЯ_ВСЕХ:
                        {
                            lActionParam1.Text = "Угроза %";
                        }
                        break;
                    case ActionType.ВЫПОЛНИТЬ_УСЛОВИЕ_КВЕСТА:
                        {
                            lActionParam1.Text = "ID квеста";
                            lActionParam2.Text = "Цель";
                        } break;
                    case ActionType.ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ:
                        {
                            lActionParam1.Text = "ID существа";
                            lActionParam2.Text = "ID спелла";
                            lActionParam3.Text = "Цель";
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FIELD:
                        lActionParam1.Text = "Номер поля Data";
                        lActionParam2.Text = "Значение";
                        lActionParam3.Text = "Цель";
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FLAG:
                        lActionParam1.Text = "Флаг существа";
                        lActionParam2.Text = "Цель";
                        break;
                    case ActionType.УБРАТЬ_UNIT_FLAG:
                        lActionParam1.Text = "Флаг существа";
                        lActionParam2.Text = "Цель";
                        break;
                    case ActionType.АВТО_АТАКА_БЛИЖНЕГО_БОЯ:
                        lActionParam1.Text = "Разрешить атаку в ближнем бою";
                        break;
                    case ActionType.ДВИЖЕНИЕ_В_БОЮ:
                        lActionParam1.Text = "Разрешить движение в бою";
                        lActionParam2.Text = "Остановить, стартовать режим боя";
                        break;
                    case ActionType.УСТАНОВИТЬ_ФАЗУ:
                        lActionParam1.Text = "Фаза";
                         break;
                    case ActionType.ПОВЫСИТЬ_ФАЗУ:
                        lActionParam1.Text = "Значение";
                        break;
                    case ActionType.ЗАВЕРШИТЬ_КВЕСТ_ДЛЯ_ГРУППЫ:
                        lActionParam1.Text = "ID квеста";
                        break;
                    case ActionType.ЗАСЧИТАТЬ_ЧТЕНИЕ_ЗАКЛИНАНИЯ_ДЛЯ_ГРУППЫ:
                        lActionParam1.Text = "ID квеста";
                        lActionParam2.Text = "ID спелла";
                        break;
                    case ActionType.УБРАТЬ_С_ЦЕЛИ_АУРУ:
                        lActionParam1.Text = "Цель";
                        lActionParam2.Text = "ID спелла";
                         break;
                    case ActionType.УДАЛИТСЯ_ОТ_ЦЕЛИ:
                        lActionParam1.Text = "Дистанция";
                        lActionParam2.Text = "Под углом";
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФРАЗА:
                        lActionParam1.Text = "ID фазы 1";
                        lActionParam2.Text = "ID фазы 2";
                        lActionParam3.Text = "ID фазы 3";
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФАЗА_С_ПАРАМЕТРОМ:
                        lActionParam1.Text = "Минимальный номер фазы";
                        lActionParam2.Text = "Максимальный номер фазы";
                        break;
                    case ActionType.ПРИЗЫВ_В_ОПРЕДЕЛЕННУЮ_ТОЧКУ:
                        lActionParam1.Text = "ID существа";
                        lActionParam2.Text = "Цель";
                        lActionParam3.Text = "ID из creature_ai_summons";
                        break;
                    case ActionType.ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА:
                        lActionParam1.Text = "ID существа";
                        lActionParam2.Text = "Цель";
                        break;
                    case ActionType.SET_INST_DATA:
                        lActionParam1.Text = "Поле";
                        lActionParam2.Text = "Значение";
                        break;
                    case ActionType.SET_INST_DATA64:
                        lActionParam1.Text = "Поле";
                        lActionParam2.Text = "Цель";
                        break;
                    case ActionType.ИЗМЕНИТЬ_ПАРАМЕТРЫ_СУЩЕСТВА:
                        lActionParam1.Text = "Номер из creature_template";
                        lActionParam2.Text = "Команда:";
                        break;
                    case ActionType.ОБРАТИТЬСЯ_ЗА_ПОМОЩЬЮ:
                        lActionParam1.Text = "В радиусе:";
                        break;
                    case ActionType.ВИЗУАЛИЗАЦИЯ_ДЕЙСТВИЯ_С_ОРУЖИЕМ:
                        lActionParam1.Text = "Действие";
                         break;
                    case ActionType.ПРИНУДИТЕЛЬНО_ДЕСПАВНИТЬ:
                        break;
                    case ActionType.НЕВОЗМОЖНОСТЬ_АТАКОВАТЬ:
                        lActionParam1.Text = "При значении жизни";
                        break;
                }
            }
            catch
            {
                return;
            }
            cbActionParam1.Visible = lActionParam1.Text != "";
            cbActionParam2.Visible = lActionParam2.Text != "";
            cbActionParam3.Visible = lActionParam3.Text != "";
         }

        public static void ShowEventTypeInscription(ComboBox comboEventType, 
            Label lEventType1, Label lEventType2, Label lEventType3, Label lEventType4,
            ComboBox _cbEventParametr1, ComboBox _cbEventParametr2, ComboBox _cbEventParametr3, ComboBox _cbEventParametr4,
            Button _bEventParam1, Button _bEventParam2, Button _bEventParam3, Button _bEventParam4)
        {
            lEventType1.Text = lEventType2.Text = lEventType3.Text = lEventType4.Text = "";
            _bEventParam1.Visible = _bEventParam2.Visible = _bEventParam3.Visible = _bEventParam4.Visible = false;
            //_bEventParam2.Dispose();

            try
            {
                switch ((EventType)comboEventType.SelectedValue)
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
                            _bEventParam2.Click += new System.EventHandler(_bEventParam4_Click);
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

        static void _bEventParam4_Click(object sender, System.EventArgs e)
        {
            //CalculateData dialog = new CalculateData();
            //dialog.ShowDialog();
            MessageBox.Show("");
        }

        public static void ShowActionTyteCondition(ComboBox cEventParamCondition, Label lEventType3, Label lEventType4, 
            TextBox EventParam3, TextBox EventParam4)
        {
            lEventType3.Text = "";
            lEventType4.Text = "";

            switch ((ConditionType)cEventParamCondition.SelectedIndex)
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
