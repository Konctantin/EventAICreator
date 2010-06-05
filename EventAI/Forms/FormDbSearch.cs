using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAI
{
    public partial class FormDbSearch : Form
    {
        public uint Value { get; private set; }

        private BType _type;
        private uint  _val;

        #region Init

        public FormDbSearch(BType type, uint val)
        {
            _type = type;
            _val  = val;
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            _cbID.ResetS();
            _cbParam2.ResetS();
            _cbParam3.ResetS();
            _cbParam4.ResetS();
            _cbParam5.ResetS();
            _cbParam6.ResetS();
            _cbParam7.ResetS();
            _cbParam8.ResetS();

            switch (_type)
            {
                case BType.CREATURE:
                    {
                        this.Text = "Форма поиска существ";
                        _lvData.SetColumns<Creature>();
                        label1.Text = "Номер";
                        label2.Text = "Название";
                        label3.Text = "Тип";
                        label4.Text = "Семейство";
                        label5.Text = "Номер";
                        label6.Text = "Номер";
                        label7.Text = "Номер";
                        label8.Text = "Номер";
                        _cbParam3.SetDbcData(DBC.CreatureType, "Тип существа");
                        _cbParam4.SetDbcData(DBC.CreatureFamily, "Семейство существа");
                    }
                    break;
                case BType.ITEM:
                    {
                        _lvData.SetColumns<ItemTemplate>();
                    }
                    break;
                case BType.QUEST:
                    {
                        _lvData.SetColumns<Quest>();
                    }
                    break;
                default: 
                    this.Close();
                    break;
            }
        }

        #endregion
    }
}
