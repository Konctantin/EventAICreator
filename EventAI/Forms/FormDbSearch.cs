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
        public uint Value 
        { 
            get { return  _val; } 
            private set { value = _val; } 
        }

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
            foreach (object ctrl in groupBox1.Controls)
                if (ctrl is ComboBox) 
                    ((ComboBox)ctrl).ResetS();

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
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";

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

        private void _bOk_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();

            switch (_type)
            {
                case BType.CREATURE:
                    {

                    }
                    break;
                case BType.ITEM:
                    {

                    }
                    break;
                case BType.QUEST:
                    {

                    }
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void _bCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
