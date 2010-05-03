using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    class ButtonHandler
    {
        public static void SetActionToButton(Form form, ComboBox cbAT, Button b, int index, ComboBox cb1, ComboBox cb2, ComboBox cb3)
        {
            int bindex = b.Name.Substring(b.Name.Length - 1, 1).ToInt32();
            try
            {
                switch ((ActionType)cbAT.SelectedValue.ToUInt32())
                {
                    case ActionType.ТЕКСТ:
                        {
                            if (bindex == 1)
                            {}
                            else if(bindex==2)
                            {}
                            else if (bindex == 3)
                            {}
                        }
                        break;
                    case ActionType.УСТАНОВИТЬ_ФРАКЦИЮ:
                        {
                            //cb1.SetDbcData<FactionEntry>(DBC.Faction);
                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_МОДЕЛЬ_СУЩЕСТВА:
                        {

                        }
                        break;
                    case ActionType.ЗВУК:
                        {

                        }
                        break;
                    case ActionType.ЭМОЦИЯ:
                        {

                        }
                        break;
                    case ActionType.СЛУЧАЙНЫЙ_ЗВУК:
                        {

                        }
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ЭМОЦИЯ:
                        {

                        }
                        break;
                    case ActionType.ЧТЕНИЕ_ЗАКЛИНАНИЯ:
                        {
                            FormSearchSpell f = new FormSearchSpell(Who.Spell);
                            f.ShowDialog(form);
                            cb1.Text = f.Spell.ID.ToString();
                            f.Dispose();
                        }
                        break;
                    case ActionType.ПРИЗЫВ:
                        {

                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ:
                        {

                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_УГРОЗУ_ДЛЯ_ВСЕХ:
                        {

                        }
                        break;
                    case ActionType.ВЫПОЛНИТЬ_УСЛОВИЕ_КВЕСТА:
                        {

                        } break;
                    case ActionType.ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ:
                        {

                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FIELD:
                        {

                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_UNIT_FLAG:
                        {

                        }
                        break;
                    case ActionType.УБРАТЬ_UNIT_FLAG:
                        {

                        }
                        break;
                    case ActionType.АВТО_АТАКА_БЛИЖНЕГО_БОЯ:
                        {

                        }
                        break;
                    case ActionType.ДВИЖЕНИЕ_В_БОЮ:
                        {

                        }
                        break;
                    case ActionType.УСТАНОВИТЬ_ФАЗУ:
                        {

                        }
                        break;
                    case ActionType.ПОВЫСИТЬ_ФАЗУ:
                        {

                        }
                        break;
                    case ActionType.ЗАВЕРШИТЬ_КВЕСТ_ДЛЯ_ГРУППЫ:
                        {

                        }
                        break;
                    case ActionType.ЗАСЧИТАТЬ_ЧТЕНИЕ_ЗАКЛИНАНИЯ_ДЛЯ_ГРУППЫ:
                        {

                        }
                        break;
                    case ActionType.УБРАТЬ_С_ЦЕЛИ_АУРУ:
                        {

                        }
                        break;
                    case ActionType.УДАЛИТСЯ_ОТ_ЦЕЛИ:
                        {

                        }
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФРАЗА:
                        {

                        }
                        break;
                    case ActionType.СЛУЧАЙНАЯ_ФАЗА_С_ПАРАМЕТРОМ:
                        {

                        }
                        break;
                    case ActionType.ПРИЗЫВ_В_ОПРЕДЕЛЕННУЮ_ТОЧКУ:
                        {

                        }
                        break;
                    case ActionType.ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА:
                        {

                        }
                        break;
                    case ActionType.SET_INST_DATA:
                        {

                        }
                        break;
                    case ActionType.SET_INST_DATA64:
                        {

                        }
                        break;
                    case ActionType.ИЗМЕНИТЬ_ПАРАМЕТРЫ_СУЩЕСТВА:
                        {

                        }
                        break;
                    case ActionType.ОБРАТИТЬСЯ_ЗА_ПОМОЩЬЮ:
                        {

                        }
                        break;
                    case ActionType.ВИЗУАЛИЗАЦИЯ_ДЕЙСТВИЯ_С_ОРУЖИЕМ:
                        {

                        }
                        break;
                    case ActionType.ПРИНУДИТЕЛЬНО_ДЕСПАВНИТЬ:
                        {

                        }
                        break;
                    case ActionType.НЕВОЗМОЖНОСТЬ_АТАКОВАТЬ:
                        {

                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
