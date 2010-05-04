using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EventAI
{
    public class BH
    {
        private static Size SIZE = new Size(56, 23);
        private const int X = 187;

        private static ComboBox _combobox;
        private static Button _button;
        private static Type _type;

        public BH(ComboBox combobox, BType btype, Pos pos)
        {
            _combobox = combobox;
            _button = new Button();

            switch (pos)
            {
                case Pos.POSA1: _button.Location = new Point(X, 58); break;
                case Pos.POSA2: _button.Location = new Point(X, 102); break;
                case Pos.POSA3: _button.Location = new Point(X, 148); break;

                case Pos.POST1: _button.Location = new Point(X, 67); break;
                case Pos.POST2: _button.Location = new Point(X, 114); break;
                case Pos.POST3: _button.Location = new Point(X, 159); break;
                case Pos.POST4: _button.Location = new Point(X, 209); break;
            }
            switch (btype)
            {
                case BType.SPELL: _button.Click    += new EventHandler(ShowSpellForm); break;
                case BType.CREATURE: _button.Click += new EventHandler(ShowCreatureForm); break;
                case BType.ITEM: _button.Click     += new EventHandler(ShowItemForm); break;
                case BType.QUEST: _button.Click    += new EventHandler(ShowQuestForm); break;
                case BType.EVENT: _button.Click    += new EventHandler(ShowEventForm); break;
            }

            _button.ImeMode = ImeMode.NoControl;
            _button.Size = SIZE;
            _button.Text = "Поиск";
            _button.UseVisualStyleBackColor = true;
            ((GroupBox)combobox.Parent).Controls.Add(_button);
        }

        public void CreateFlags<T>(ComboBox combobox, Pos pos) where T : struct
        {
            _type = typeof(T);
            _combobox = combobox;
            _button = new Button();

            switch (pos)
            {
                case Pos.POSA1: _button.Location = new Point(X, 58); break;
                case Pos.POSA2: _button.Location = new Point(X, 102); break;
                case Pos.POSA3: _button.Location = new Point(X, 148); break;

                case Pos.POST1: _button.Location = new Point(X, 67); break;
                case Pos.POST2: _button.Location = new Point(X, 114); break;
                case Pos.POST3: _button.Location = new Point(X, 159); break;
                case Pos.POST4: _button.Location = new Point(X, 209); break;
            }

            _button.ImeMode = ImeMode.NoControl;
            _button.Size = SIZE;
            _button.Text = "Флаг";
            _button.UseVisualStyleBackColor = true;
            _button.Click += new System.EventHandler(ShowFlagForm);

            ((GroupBox)combobox.Parent).Controls.Add(_button);
        }

        private void ShowSpellForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private void ShowCreatureForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private void ShowQuestForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private void ShowItemForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private void ShowEventForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private void ShowFlagForm(object sender, EventArgs e)
        {
            uint val = _combobox.Text.ToUInt32();
            FormCalculateFlags _form = new FormCalculateFlags(_type, val, String.Empty);
            _form.ShowDialog();
            _combobox.SetVal(_form.Flags);
            _form.Dispose();
        }
    }
}
