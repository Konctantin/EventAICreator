using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.IO;

namespace EventAI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
             // 1 page
            _cbEventType.SetEnumValues<EventType>();
            _cbActionType1.SetEnumValues<ActionType>();
            _cbActionType2.SetEnumValues<ActionType>();
            _cbActionType3.SetEnumValues<ActionType>();

            _cbFilteEventType.SetEnumValues<EventType>("Тип события", "", false);
            _cbFilteActionType.SetEnumValues<ActionType>("Тип действия", "", false);
             // 2 page
            _cbMessageType.SetEnumValues<MessageType>();
            _cbLenguage.SetEnumValues<Lenguage>();
            _cbLocale.DataSource = Enum.GetValues(typeof(Locales));
             // 3 page

             // def
            _cbEventType.SelectedValue = 1;
        }

        private bool err = false;

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

        private void EventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscription.ShowEventType(_cbEventType, _cbEventParametr1, _cbEventParametr2, _cbEventParametr3, _cbEventParametr4, lEventType1, lEventType2, lEventType3, lEventType4);
        }

        private void ActionType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Inscription.ShowActionParametr(_cbActionType1, _cbActionParam1_1, _cbActionParam1_2, _cbActionParam1_3, lActionParam1_1, lActionParam1_2, lActionParam1_3);
        }

        private void ActionType_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Inscription.ShowActionParametr(_cbActionType2, _cbActionParam2_1, _cbActionParam2_2, _cbActionParam2_3, lActionParam2_1, lActionParam2_2, lActionParam2_3);
        }

        private void ActionType_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            Inscription.ShowActionParametr(_cbActionType3, _cbActionParam3_1, _cbActionParam3_2, _cbActionParam3_3, lActionParam3_1, lActionParam3_2, lActionParam3_3);
        }

        private void ActionTyteCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscription.ShowActionTyteCondition(_cbEventType, _cbEventParametr2, _cbEventParametr3, _cbEventParametr4, lEventType3, lEventType4);
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

        private void _lvScripts_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(MySQLConnenct.AIScript[e.ItemIndex].ToArray());
        }

        private void LogOut(string text, params object[] arg)
        {
            rtbScriptOut.ForeColor = Color.Red;
            rtbScriptOut.AppendFormatLine(text, arg);
            rtbScriptOut.ForeColor = rtbScriptOut.ForeColor;
            err = true;
        }

        private void _clbPhase_SelectedValueChanged(object sender, EventArgs e)
        {
            _gbPhase.Text = "Фаза " + ((CheckedListBox)sender).GetFlagsValue();
        }

        private void _clbEventFlag_SelectedValueChanged(object sender, EventArgs e)
        {
            _gbEventFlag.Text = "Флаг события " + ((CheckedListBox)sender).GetFlagsValue();
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

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPropertis form = new FormPropertis();
            form.ShowDialog(this);
        }

        private void _lvScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvScripts.SelectedIndices.Count > 0)
                ParseScriptsData(MySQLConnenct.AIScript[_lvScripts.SelectedIndices[0]]);
        }

        private void CreateAIScript_Click(object sender, EventArgs e)
        {
            err = false;
            rtbScriptOut.Clear();
            rtbScriptOut.ForeColor = Color.Blue;

            ScriptAI script             = new ScriptAI();
            script.ID                   = _tbScriptID.Text.ToInt32();
            script.NpcEntry             = _tbEntryNpc.Text.ToInt32();
            script.EventType            = _cbEventType.GetIntValue();
            script.Phase                = _clbPhase.GetFlagsValue();
            script.Chance               = _tbShance.Text.ToInt32();
            script.Flags                = _clbEventFlag.GetFlagsValue();

            script.EventParam[0]        = _cbEventParametr1.GetIntValue();
            script.EventParam[1]        = _cbEventParametr2.GetIntValue();
            script.EventParam[2]        = _cbEventParametr3.GetIntValue();
            script.EventParam[3]        = _cbEventParametr4.GetIntValue();

            script.ActionType[0]        = _cbActionType1.GetIntValue();
            script.ActionParam[0, 0]    = _cbActionParam1_1.GetIntValue();
            script.ActionParam[0, 1]    = _cbActionParam1_2.GetIntValue();
            script.ActionParam[0, 2]    = _cbActionParam1_3.GetIntValue();

            script.ActionType[1]        = _cbActionType2.GetIntValue();
            script.ActionParam[1, 0]    = _cbActionParam2_1.GetIntValue();
            script.ActionParam[1, 1]    = _cbActionParam2_2.GetIntValue();
            script.ActionParam[1, 2]    = _cbActionParam2_3.GetIntValue();

            script.ActionType[2]        = _cbActionType3.GetIntValue();
            script.ActionParam[2, 0]    = _cbActionParam3_1.GetIntValue();
            script.ActionParam[2, 1]    = _cbActionParam3_2.GetIntValue();
            script.ActionParam[2, 2]    = _cbActionParam3_3.GetIntValue();

            script.Comment              = _tbComment.Text;

            #region Проверки

            if (script.ID < 1)
                LogOut("Номен скрипта должен быть больше 0!");

            if (script.Chance == 0 || script.Chance > 100)
                LogOut("Шанс срабатывания должен быть 0 и не больше 100%!");

            switch ((EventType)script.EventType)
            {
                case EventType.ПО_ТАЙМЕРУ_В_БОЮ:
                case EventType.ПО_ТАЙМЕРУ_ВНЕ_БОЯ:
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальное время до срабатывания не может быть больше максимального!");
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ_У_ЦЕЛИ:
                    if (script.EventParam[0] > 100 || script.EventParam[1] > 100)
                        LogOut("Параметр 1 или 2 не могут быть болше 100%!");
                    if (script.EventParam[1] > script.EventParam[0])
                        LogOut("Минимальное значение жизни(маны) не может быть больше максимального!");
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case EventType.ПРИ_УБИЙСТВЕ_ЦЕЛИ:
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case EventType.ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ:
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    if (script.EventParam[0] > 0 && script.EventParam[1] > -1)
                        LogOut("Если указано значение \"ID Заклинания\", тогда значение \"Школа\" должно быть (-1), иначе \"ИД заклинания\" должно быть (0)");
                    break;
                case EventType.ПРИ_ДИСТАНЦИИ:
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальная дистанция до цели не может быть больше максимальной!");
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case EventType.ПРИ_ПОЯВЛЕНИИ_В_ЗОНЕ_ВИДИМОСТИ:
                    if (script.EventParam[2] > script.EventParam[3])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
                case EventType.ЕСЛИ_ЦЕЛЬ_ЧИТАЕТ_ЗАКЛИНАНИЕ:
                    if (script.EventParam[0] > script.EventParam[1])
                        LogOut("Минимальное время до повтора не может быть больше максимального!");
                    break;
            }

            if (err)
            {
                _bWriteFiles.Enabled = false;
                return;
            }

            #endregion

            StringBuilder sb = new StringBuilder();
            sb.AppendFormatLine("UPDATE `creature_template` SET `AIName` = 'EventAI' WHERE `entry` = '{0}';", script.NpcEntry);
            sb.AppendFormatLine("DELETE FROM `creature_ai_scripts` WHERE (`id`='{0}');", script.ID);
            sb.AppendFormatLine("INSERT INTO `creature_ai_scripts` VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}');",
                script.ID, script.NpcEntry, script.EventType, script.Phase, script.Chance, script.Flags,
                script.EventParam[0], script.EventParam[1], script.EventParam[2], script.EventParam[3],
                script.ActionType[0], script.ActionParam[0, 0], script.ActionParam[0, 1], script.ActionParam[0, 2],
                script.ActionType[1], script.ActionParam[1, 0], script.ActionParam[1, 1], script.ActionParam[1, 2],
                script.ActionType[2], script.ActionParam[2, 0], script.ActionParam[2, 1], script.ActionParam[2, 2],
                script.Comment.RemExc());

            rtbScriptOut.Text = sb.ToString();
            _bWriteFiles.Enabled = true;
        }

        private void CreateTextQuery_Click(object sender, EventArgs e)
        {
            string[] loc = new string[_cbLocale.Items.Count];
            loc[_cbLocale.SelectedIndex] = _tbTextContentLocales.Text.RemExc();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormatLine("DELETE FROM `creature_ai_texts` WHERE entry IN (-{0});", _tbTextID.Text.ToInt32());
            sb.AppendFormatLine("INSERT INTO `creature_ai_texts` VALUES ('-{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');",
                _tbTextID.Text.ToInt32(),
                _tbTextContentDefault.Text.RemExc(),
                loc[1], loc[2], loc[3], loc[4], loc[5], loc[6], loc[7], loc[8],
                _cbSoundEntry.GetIntValue(),
                _cbMessageType.GetIntValue(),
                _cbLenguage.GetIntValue(),
                _cbTextEmote.GetIntValue(),
                _tbCommentAITexts.Text.RemExc());

            rtbTextOut.Text = sb.ToString();
        }

        private void ParseScriptsData(ScriptAI script)
        {
            _tbScriptID.Text = script.ID.ToString();
            _tbEntryNpc.Text = script.NpcEntry.ToString();
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

        private void UnselectALL_Click(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Name)
            {
                case "UnselectALL":
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, false);
                    break;
                case "SelectAll":
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, true);
                    break;
                case "Revert":
                    for (int i = 0; i < _clbPhase.Items.Count; i++)
                        _clbPhase.SetItemChecked(i, !_clbPhase.GetItemChecked(i));
                    break;
            }
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

        private void WriteFiles_Click(object sender, EventArgs e)
        {
            MySQLConnenct.Insert(rtbScriptOut.Text);
            using (StreamWriter sw = new StreamWriter("log.sql", true, Encoding.UTF8))
                sw.WriteLine(rtbScriptOut.Text);
        }

        private void _lvText_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(MySQLConnenct.AIText[e.ItemIndex].ToArray());
        }

        private void _bTextSearch_Click(object sender, EventArgs e)
        {
            MySQLConnenct.SelectAIText();
            _lvText.VirtualListSize = MySQLConnenct.AIText.Count;
        }

        private void _lvText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvText.SelectedIndices.Count > 0)
            {
                TextAI text = MySQLConnenct.AIText[_lvText.SelectedIndices[0]];
                int loc = _cbLocale.SelectedIndex;

                _tbTextID.Text = text.ID.ToString();
                _tbTextContentDefault.Text = text.ContentDefault;
                _tbTextContentLocales.Text = text.ContentLocale[loc];
                _cbSoundEntry.SetValue(text.Sound);
                _cbMessageType.SetValue(text.Type);
                _cbLenguage.SetValue(text.Lenguage);
                _cbTextEmote.SetValue(text.Emote);
                _tbCommentAITexts.Text = text.Comment;
            }
        }

        private void _lvSummon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvSummon.SelectedIndices.Count > 0)
            {
                SummonAI summon = MySQLConnenct.AISummon[_lvSummon.SelectedIndices[0]];

                _tbSummonID.Text        = summon.ID.ToString();
                _tbSummonX.Text         = summon.PositionX.ToString();
                _tbSummonY.Text         = summon.PositionY.ToString();
                _tbSummonZ.Text         = summon.PositionZ.ToString();
                _tbSummonO.Text         = summon.Orientation.ToString();
                _tbSummonSps.Text       = summon.SpawnTimeSecs.ToString();
                _tbSummonComment.Text   = summon.Comment;
            }
        }

        private void _lvSummon_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(MySQLConnenct.AISummon[e.ItemIndex].ToArray());
        }

        private void _bSummonSearch_Click(object sender, EventArgs e)
        {
            MySQLConnenct.SelectAISummon();
            _lvSummon.VirtualListSize = MySQLConnenct.AISummon.Count;
        }

        private void _tPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((TabControl)sender).SelectedIndex == 1)
                _cbTextEmote.SetDbcData<EmotesEntry>(DBC.Emotes);
        }
    }
}