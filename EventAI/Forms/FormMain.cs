using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace EventAI
{
    public partial class FormMain : Form
    {
        private DataTable Scripts { get; set; }

        private List<ScriptAI> _scriptList = new List<ScriptAI>();

        public FormMain()
        {
            InitializeComponent();

            _cbEventType.SetEnumValues<EventType>();
            _cbActionType1.SetEnumValues<ActionType>();
            _cbActionType2.SetEnumValues<ActionType>();
            _cbActionType3.SetEnumValues<ActionType>();

            _cbFilteEventType.SetEnumValues(typeof(EventType), "Тип события", "");
            _cbFilteActionType.SetEnumValues(typeof(ActionType), "Тип действия", "");

            _cbEventType.SelectedValue = 1;
        }

        private bool err = false;

        private void button1_Click(object sender, EventArgs e)
        {
            rtbScriptOut.Clear();
            CreateQueryScripts();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAboutBox().ShowDialog();
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((ComboBox)sender).Text.Contains('-'))
            {
                if (!((Char.IsDigit(e.KeyChar) && ((ComboBox)sender).SelectionStart > 0) || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else
                if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((ComboBox)sender).SelectionStart == 0)))
                    e.Handled = true;
        }

        private void NumberScripts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
                e.Handled = true;
        }

        private void bCreateTextQuery_Click(object sender, EventArgs e)
        {
            rtbTextOut.Clear();
            CreateQueryTetxs();
        }

        private void bClearTextQuery_Click(object sender, EventArgs e)
        {
            rtbTextOut.Clear();
        }

        private void comboEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscription.ShowEventTypeInscription(_cbEventType, lEventType1, lEventType2, lEventType3, lEventType4,
                _cbEventParametr1, _cbEventParametr2, _cbEventParametr3, _cbEventParametr4);
        }       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Inscription.ShowActionParametrInscription(_cbActionType1, lActionParam1_1, lActionParam1_2, lActionParam1_3,
                _cbActionParam1_1, _cbActionParam1_2, _cbActionParam1_3);
        }

        private void ActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscription.ShowActionParametrInscription(_cbActionType2, lActionParam2_1, lActionParam2_2, lActionParam2_3,
                _cbActionParam2_1, _cbActionParam2_2, _cbActionParam2_3);
         }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Inscription.ShowActionParametrInscription(_cbActionType3, lActionParam3_1, lActionParam3_2, lActionParam3_3,
                _cbActionParam3_1, _cbActionParam3_2, _cbActionParam3_3);
        }

        private void ActionTyteCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscription.ShowActionTyteCondition(_cbEventParametr2, lEventType3, lEventType4, _cbEventParametr3, _cbEventParametr4);
        }

        public void CreateQueryScripts()
        {
            err = false;
            rtbScriptOut.ForeColor = Color.Blue;
            int nNumberScripts = NumberScripts.Text.ToInt32();
            int nIDCreature = EntryNpc.Text.ToInt32();
            int nEventChance = _tbShance.Text.ToInt32();
            int nEventType = 0;

            int nId = (nIDCreature * 100) + (50 + nNumberScripts);

            //if (nNumberScripts<1)
                 //ConsoleScritpOut("Номен скрипта должен быть больше 0!", MsgStatus.ERROR);

            //if (nEventChance == 0 || nEventChance > 100)
                //ConsoleScritpOut("Шанс срабатывания должен быть 0 и не больше 100%!", MsgStatus.ERROR);

            //if (_clbEventFlag.SelectedIndex == 5 || _clbEventFlag.SelectedIndex == 6)
                //ConsoleScritpOut("Вы питаетесь использовать зарезервированый флаг события!", MsgStatus.ERROR);

            switch ((EventType)nEventType)
            {
                case   EventType.ПО_ТАЙМЕРУ_В_БОЮ :
                case   EventType.ПО_ТАЙМЕРУ_В_НЕ_БОЯ:
                    //if (nEventParam1_def > nEventParam2_def)
                    //    ConsoleScritpOut("Минимальное время до срабатывания не может быть больше максимального!");
                    //if (nEventParam3_def > nEventParam4_def)
                    //    ConsoleScritpOut("Минимальное время до повтора не может быть больше максимального!");
                    //break;
                case   EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_МАННЫ_У_ЦЕЛИ:
                    //if (nEventParam1_def > 100 || nEventParam2_def > 100)
                    //    ConsoleScritpOut("Параметр 1 или 2 не могут быть болше 100%!");
                    //if (nEventParam1_def > nEventParam2_def)
                    //    ConsoleScritpOut("Минимальное значение жизни(маны) не может быть больше максимального!");
                    //if (nEventParam3_def > nEventParam4_def)
                    //    ConsoleScritpOut("Минимальное время до повтора не может быть больше максимального!");
                //    break;
                //case 4:
                //case 6:
                //case 7:
                //case 11:
                //case 19:
                //case 20:
                //case 21:// 
                    //if (nEventParam1_def != 0 || nEventParam2_def != 0 || nEventParam3_def != 0 || nEventParam4_def != 0)
                    //    ConsoleScritpOut("Этот тип действия не имеет параметров!");
                    break;/*
                case   7:// EVENT_T_RANGE:
                case   8:// EVENT_T_OOC_LOS:
                case   9:// EVENT_T_SPAWNED:
                case   10:// EVENT_T_FRIENDLY_HP:
                case   11:// EVENT_T_FRIENDLY_IS_CC:
                case   12:// EVENT_T_FRIENDLY_MISSING_BUFF:
                case   13:// EVENT_T_KILL:
                case   14:// EVENT_T_TARGET_CASTING:
                case   15:// EVENT_T_SUMMONED_UNIT:
                case   16:// EVENT_T_QUEST_ACCEPT:
                case   17:// EVENT_T_QUEST_COMPLETE:
                case   18:// EVENT_T_AGGRO:
                case   19:// EVENT_T_DEATH:
                case   20:// EVENT_T_EVADE:
                case   21:// EVENT_T_REACHED_HOME:
                case   22:// EVENT_T_RECEIVE_EMOTE:
                case   23:// EVENT_T_BUFFED:
                case   24:// EVENT_T_TARGET_BUFFED:*/
                default: break;
			}

            if (err)
            {
                //ConsoleScritpOut("Операция не выполнена", MsgStatus.ERROR);
                return;
            }
            ////Сформируем строку запроса
            //var sQuery = (rbReplaceScript.Checked) ? "REPLACE INTO" : "INSERT IGNORE INTO";
            //var scriptUpdate = String.Format("UPDATE `creature_template` SET `AIName` = 'EventAI' WHERE `entry` = '{0}';");
            //var script = String.Format("{0} `creature_ai_scripts` VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}');",
            //    EAI.RegexReplace(_tbComment));

            //rtbScriptOut.Text = script +"\r\n"+ scriptUpdate;

        }
        
        public void CreateQueryTetxs()
        {
            int ntNumberAITexts = tNumberAITexts.Text.ToInt32();
            int ntNumberAISound = tNumberAISound.Text.ToInt32();
            int ntNumberAIEmote = tNumberAIEmote.Text.ToInt32();

            var sCommentsAITexts = tCommentAITexts.Text.RemExc();
            var stContentDefault = tContentDefault.Text.RemExc();
            var sContentLocales = tContentLocales.Text.RemExc();

            var loc = new string[cLocalisationText.Items.Count];
            loc[cLocalisationText.SelectedIndex] = sContentLocales;
       
            int[] arr = { 0, 1, 2, 3, 6, 7, 8, 9, 10, 11, 12, 13, 14, 33, 35, 36, 37, 38 };
            int ncLenguageText = arr[cLenguageText.SelectedIndex];

            if (tContentDefault.Text == "" && tContentLocales.Text == "") 
                return;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormatLine("DELETE FROM `creature_ai_texts` WHERE entry IN (-{0});", ntNumberAITexts);
            sb.AppendFormatLine("INSERT INTO `creature_ai_texts` VALUES ('-{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');",
                ntNumberAITexts, stContentDefault, loc[0], loc[1], loc[2], loc[3], loc[4], loc[5], loc[6], loc[7],
                ntNumberAISound, cTypeText.SelectedIndex, ncLenguageText, ntNumberAIEmote, sCommentsAITexts);

            rtbTextOut.Text = sb.ToString();
        }

        private void clbEventFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_clbEventFlag.SelectedIndex == 5 || _clbEventFlag.SelectedIndex == 6)
            {
                _clbEventFlag.SetItemChecked(5, false);
                _clbEventFlag.SetItemChecked(6, false);
                MessageBox.Show("Нельзя использовать зарезирвированые флаги!");
            }
        }

        private void UnselectALL_Click(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Name)
            {
                case "UnselectALL":
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, false);
                    break;
                case "SelectAll" :
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, true);
                    break;
                case "Revert":
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, !_clbPhase.GetItemChecked(i));
                    break;
            }
        }

        private void _lvScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvScripts.SelectedIndices.Count > 0)
            {
                ParseScriptsData(_scriptList[_lvScripts.SelectedIndices[0]]);
            }
        }

        private void ParseScriptsData(ScriptAI script)
        {
            NumberScripts.Text = script.ID.ToString();
            EntryNpc.Text = script.NpcEntry.ToString();
            _tbShance.Text = script.Chance.ToString();

            _clbEventFlag.SetCheckedItemFromFlag((uint)script.Flags);
            _clbPhase.SetCheckedItemFromFlag((uint)script.Phase);
            
            _cbEventType.SelectedValue = script.EventType;
            _cbEventParametr1.SelectedValue = script.EventParam[0];
            _cbEventParametr2.SelectedValue = script.EventParam[1];
            _cbEventParametr3.SelectedValue = script.EventParam[2];
            _cbEventParametr4.SelectedValue = script.EventParam[3];

            _cbActionType1.SelectedValue = script.ActionType[0];
            _cbActionParam1_1.SelectedValue = script.ActionParam[0, 0];
            _cbActionParam1_2.SelectedValue = script.ActionParam[0, 1];
            _cbActionParam1_3.SelectedValue = script.ActionParam[0, 2];

            _cbActionType2.SelectedValue = script.ActionType[1];
            _cbActionParam2_1.SelectedValue = script.ActionParam[1, 0];
            _cbActionParam2_2.SelectedValue = script.ActionParam[1, 1];
            _cbActionParam2_3.SelectedValue = script.ActionParam[1, 2];

            _cbActionType3.SelectedValue = script.ActionType[2];
            _cbActionParam3_1.SelectedValue = script.ActionParam[2, 0];
            _cbActionParam3_2.SelectedValue = script.ActionParam[2, 1];
            _cbActionParam3_3.SelectedValue = script.ActionParam[2, 2];

            _tbComment.Text = script.Comment;
        }

        private void Revert1_Click(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Name)
            {
                case "UnselectALL1":
                    for (int i = 0; i < _clbEventFlag.Items.Count; i++)
                        if (i != 6 && i != 5)
                            _clbEventFlag.SetItemChecked(i, false);
                    break;
                case "SelectAll1":
                    for (int i = 0; i < _clbEventFlag.Items.Count; i++)
                        if (i != 6 && i != 5)
                            _clbEventFlag.SetItemChecked(i, true);
                    break;
                case "Revert1":
                    for (int i = 0; i < _clbEventFlag.Items.Count; i++)
                        if (i != 6 && i != 5)
                            _clbEventFlag.SetItemChecked(i, !_clbEventFlag.GetItemChecked(i));
                    break;
            }
        }

        private void _clbPhase_SelectedValueChanged(object sender, EventArgs e)
        {
            _gbPhase.Text = "Фаза " + ((CheckedListBox)sender).GetFlagsValue();
        }

        private void _clbEventFlag_SelectedValueChanged(object sender, EventArgs e)
        {
            _gbEventFlag.Text = "Флаг события " + ((CheckedListBox)sender).GetFlagsValue();
        }

        private void CreateQuery()
        {
            int id = _tbFilterNum.GetVal();
            int creature = _tbFilterCreat.GetVal();
            int etype = _cbFilteEventType.GetVal();
            int atype = _cbFilteActionType.GetVal();

            string fquery = "SELECT * FROM `creature_ai_scripts` WHERE ";
            string squery = "";
            squery += (id > 0) ? String.Format("id = {0} || ", id) : "";
            squery += (creature > 0) ? String.Format("creature_id = {0} || ", creature) : "";
            squery += (etype > -1) ? String.Format("event_type = {0} || ", etype) : "";
            squery += (atype > -1) ? String.Format("action1_type = {0} || action2_type = {0} || action3_type = {0} || ", atype) : "";

            string query = (squery.Length == 0) ? fquery.Remove(fquery.Length - 6) : fquery + squery.Remove(squery.Length - 3);
        }

        private void _tbFilterNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CreateQuery();
        }

        private void _cbFilteEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > 0)
                CreateQuery();
        }

        private void _bFind_Click(object sender, EventArgs e)
        {
            CreateQuery();
        }

        private void EventParametr_TextChanged(object sender, EventArgs e)
        {
            //if ((EventType)_cbEventType.SelectedValue.ToInt32() == EventType.ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ)
            //{
            //    if(((ComboBox)sender) == _cbEventParametr1)
            //        _cbEventParametr2.Text = "-1";
            //    else if(((ComboBox)sender) == _cbEventParametr2)
            //        _cbEventParametr1.Text = "-1";
            //}
        }

        private void _lvScripts_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(_scriptList[e.ItemIndex].ToString().Split(' '));
        }    
    }
}
