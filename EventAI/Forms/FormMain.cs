using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace EventAI
{
    public partial class FormMain : Form
    {
        private DataTable Scripts { get; set; }

        public FormMain()
        {
            InitializeComponent();
             // 1 page
            _cbEventType.SetEnumValues<EventType>();
            _cbActionType1.SetEnumValues<ActionType>();
            _cbActionType2.SetEnumValues<ActionType>();
            _cbActionType3.SetEnumValues<ActionType>();

            _cbFilteEventType.SetEnumValues(typeof(EventType), "Тип события", "");
            _cbFilteActionType.SetEnumValues(typeof(ActionType), "Тип действия", "");
             // 2 page
            _cbTextEmote.SetDbcData<EmotesEntry>(DBC.Emotes);
            _cbMessageType.SetEnumValues<MessageType>();
            _cbLenguage.SetEnumValues<Lenguage>();
            _cbLocale.DataSource = Enum.GetValues(typeof(Locales));
             // 3 page

             // def
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
            Inscription.ShowActionTyteCondition(_cbEventType, _cbEventParametr2, _cbEventParametr3, _cbEventParametr4, lEventType3, lEventType4);
        }

        public void CreateQueryScripts()
        {
            err = false;
            rtbScriptOut.ForeColor = Color.Blue;
            
            ScriptAI script = new ScriptAI();
            script.ID = NumberScripts.Text.ToInt32();
            script.NpcEntry = EntryNpc.Text.ToInt32();
            script.EventType = _cbEventType.GetIntValue();
            script.Phase = _clbPhase.GetFlagsValue();
            script.Chance = _tbShance.Text.ToInt32();
            script.Flags = _clbEventFlag.GetFlagsValue();

            script.EventParam[0] = _cbEventParametr1.GetIntValue();
            script.EventParam[1] = _cbEventParametr2.GetIntValue();
            script.EventParam[2] = _cbEventParametr3.GetIntValue();
            script.EventParam[3] = _cbEventParametr4.GetIntValue();
            
            script.ActionType[0] = _cbActionType1.GetIntValue(); 
            script.ActionParam[0, 0] = _cbActionParam1_1.GetIntValue();
            script.ActionParam[0, 1] = _cbActionParam1_2.GetIntValue();
            script.ActionParam[0, 2] = _cbActionParam1_3.GetIntValue();

            script.ActionType[1] = _cbActionType2.GetIntValue();
            script.ActionParam[1, 0] = _cbActionParam2_1.GetIntValue();
            script.ActionParam[1, 1] = _cbActionParam2_2.GetIntValue();
            script.ActionParam[1, 2] = _cbActionParam2_3.GetIntValue();

            script.ActionType[2] = _cbActionType3.GetIntValue();
            script.ActionParam[2, 0] = _cbActionParam3_1.GetIntValue();
            script.ActionParam[2, 1] = _cbActionParam3_2.GetIntValue();
            script.ActionParam[2, 2] = _cbActionParam3_3.GetIntValue();
                
            script.Comment = _tbComment.Text;

#region Проверки

            if (script.ID < 1)
                LogOut("Номен скрипта должен быть больше 0!");

            if (script.Chance == 0 || script.Chance > 100)
                LogOut("Шанс срабатывания должен быть 0 и не больше 100%!");
            
            switch ((EventType)script.EventType)
            {
                case   EventType.ПО_ТАЙМЕРУ_В_БОЮ :
                case   EventType.ПО_ТАЙМЕРУ_В_НЕ_БОЯ:
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальное время до срабатывания не может быть больше максимального!");
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case   EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                case   EventType.ПРИ_ЗНАЧЕНИИ_МАННЫ_У_ЦЕЛИ:
                    if (script.EventParam[0] > 100 || script.EventParam[1] > 100)
                        LogOut("Параметр 1 или 2 не могут быть болше 100%!");
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальное значение жизни(маны) не может быть больше максимального!");
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
			}

            if (err)
            {
                _bWriteFiles.Enabled = false;
                return;
            }

#endregion

            //Сформируем строку запроса
            var scriptTextUpdate = String.Format("UPDATE `creature_template` SET `AIName` = 'EventAI' WHERE `entry` = '{0}';", script.NpcEntry);
            var scriptTextDelete = String.Format("DELETE FROM `creature_ai_scripts` WHERE (`id`='{0}');", script.ID);
            var scriptTextInsert = String.Format("INSERT INTO `creature_ai_scripts` VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}');",
                script.ID, script.NpcEntry, script.EventType, script.Phase, script.Chance, script.Flags,
                script.EventParam[0], script.EventParam[1], script.EventParam[2], script.EventParam[3],
                script.ActionType[0], script.ActionParam[0, 0], script.ActionParam[0, 1], script.ActionParam[0, 2],
                script.ActionType[1], script.ActionParam[1, 0], script.ActionParam[1, 1], script.ActionParam[1, 2],
                script.ActionType[2], script.ActionParam[2, 0], script.ActionParam[2, 1], script.ActionParam[2, 2],
                script.Comment.RemExc());

            rtbScriptOut.AppendLine(scriptTextDelete + "\r\n" + scriptTextInsert + "\r\n" + scriptTextUpdate+"\r\n");
            _bWriteFiles.Enabled = true;
        }
        
        public void CreateQueryTetxs()
        {
            int AITexts  = tNumberAITexts.Text.ToInt32();
            string[] loc = new string[_cbLocale.Items.Count];
            loc[_cbLocale.SelectedIndex] = _tbTextContentLocales.Text.RemExc();
       
            if (_tbTextContentDefault.Text == "" && _tbTextContentLocales.Text == "") 
                return;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormatLine("DELETE FROM `creature_ai_texts` WHERE entry IN (-{0});", AITexts);
            sb.AppendFormatLine("INSERT INTO `creature_ai_texts` VALUES ('-{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');",
                AITexts, 
                _tbTextContentDefault.Text.RemExc(), 
                loc[0], loc[1], loc[2], loc[3], loc[4], loc[5], loc[6], loc[7],
                _cbSoundEntry.GetIntValue(),
                _cbMessageType.GetIntValue(), 
                _cbLenguage.GetIntValue(), 
                _cbTextEmote.GetIntValue(), 
                _tbCommentAITexts.Text.RemExc());

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
                ParseScriptsData(MySQLConnenct.AIScript[_lvScripts.SelectedIndices[0]]);
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
            _cbEventParametr1.SetValue(script.EventParam[0]);
            _cbEventParametr2.SetValue(script.EventParam[1]);
            _cbEventParametr3.SetValue(script.EventParam[2]);
            _cbEventParametr4.SetValue(script.EventParam[3]);

            _cbActionType1.SetValue(script.ActionType[0]);
            _cbActionParam1_1.SetValue(script.ActionParam[0, 0]);
            _cbActionParam1_2.SetValue(script.ActionParam[0, 1]);
            _cbActionParam1_3.SetValue(script.ActionParam[0, 2]);

            _cbActionType2.SetValue(script.ActionType[1]);
            _cbActionParam2_1.SetValue(script.ActionParam[1, 0]);
            _cbActionParam2_2.SetValue(script.ActionParam[1, 1]);
            _cbActionParam2_3.SetValue(script.ActionParam[1, 2]);

            _cbActionType3.SetValue(script.ActionType[2]);
            _cbActionParam3_1.SetValue(script.ActionParam[2, 0]);
            _cbActionParam3_2.SetValue(script.ActionParam[2, 1]);
            _cbActionParam3_3.SetValue(script.ActionParam[2, 2]);

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
            int id = _tbFilterNum.GetIntValue();
            int creature = _tbFilterCreat.GetIntValue();
            int etype = _cbFilteEventType.GetIntValue();
            int atype = _cbFilteActionType.GetIntValue();

            string fquery = "SELECT * FROM `creature_ai_scripts` WHERE ";
            string squery = "";
            squery += (id > 0) ? String.Format("id = {0} || ", id) : "";
            squery += (creature > 0) ? String.Format("creature_id = {0} || ", creature) : "";
            squery += (etype > -1) ? String.Format("event_type = {0} || ", etype) : "";
            squery += (atype > -1) ? String.Format("action1_type = {0} || action2_type = {0} || action3_type = {0} || ", atype) : "";

            string q = (squery.Length == 0) ? fquery.Remove(fquery.Length - 6) : fquery + squery.Remove(squery.Length - 3);

            MySQLConnenct.SelectAIScript(q);
            _lvScripts.VirtualListSize = MySQLConnenct.AIScript.Count;

        }

        private void _tbFilterNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateQuery();
            }
        }

        private void _cbFilteEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > 0)
            {
                CreateQuery();
            }
        }

        private void _bFind_Click(object sender, EventArgs e)
        {
            {
                CreateQuery();
            }
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
            e.Item = new ListViewItem(MySQLConnenct.AIScript[e.ItemIndex].ToString().Split('^'));
        }

        private void LogOut(string text, params object[] arg)
        {
            rtbScriptOut.AppendFormatLine(text, arg);
            err = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPropertis form = new FormPropertis();
            form.ShowDialog(this);
        }

        private void WriteFiles_Click(object sender, EventArgs e)
        {
            MySQLConnenct.Insert(rtbScriptOut.Text);

            using (StreamWriter sw = new StreamWriter("log.sql", true, Encoding.UTF8))
            {
                sw.WriteLine(rtbScriptOut.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbScriptOut.Clear();
        }
    }
}
