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
    public partial class FormCalculateFlags : Form
    {
        public int Flags { get; private set; }

        public FormCalculateFlags(Type data, uint value, String remove)
        {
            InitializeComponent();

            this._clbCalcFlags.SetFlags(data, remove);
            this._clbCalcFlags.SetCheckedItemFromFlag(value);

            this.Text = "Calculate " + data.Name;
        }

        private void _bOk_Click(object sender, EventArgs e)
        {
            this.Flags = this._clbCalcFlags.GetFlagsValue();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _bNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _clbCalcFlags_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Flags = this._clbCalcFlags.GetFlagsValue();
            _lFlagValue.Text = "Value: " + this.Flags;
        }
    }
}
