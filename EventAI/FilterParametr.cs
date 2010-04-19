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
    public partial class FilterParametr : Form
    {
        public enum Delimiter
        {
             
            OR,
            AND
        }
        public FilterParametr()
        {
            InitializeComponent();

            _cbDelim1.DataSource = Enum.GetValues(typeof(Delimiter));
            _cbDelim2.DataSource = Enum.GetValues(typeof(Delimiter));
            _cbDelim3.DataSource = Enum.GetValues(typeof(Delimiter));
            _cbDelim4.DataSource = Enum.GetValues(typeof(Delimiter));
            _cbDelim5.DataSource = Enum.GetValues(typeof(Delimiter));
        }
    }
}
