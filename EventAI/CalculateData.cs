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
    public partial class CalculateData : Form
    {
        public CalculateData(Point p, Form owner)
        {
            InitializeComponent();
            p.Offset(p);
            this.Location = p;
            this.Owner = owner;
        }

        private void bCensel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            //this.Location = new Point(45, 55);
        }
    }
}
