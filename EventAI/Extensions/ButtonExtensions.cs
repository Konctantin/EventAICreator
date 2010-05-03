using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventAI
{
    public enum BType
    {
        SPELL, 
        CREATURE, 
        ITEM, 
        QUEST,
        EVENT,
        FLAG,
    };
    
    public enum Pos
    {
        POST1,
        POST2,
        POST3,
        POST4,
        POSA1,
        POSA2,
        POSA3,
    }

    public static class ButtonExtensions
    {
        private static Size SIZE = new Size(56, 22);
        private const int X = 187;
        
        private static ComboBox _combobox;
        private static Button   _button;
        private static Type     _type;
        
        public static void CreateSearchButton(this ComboBox combobox, BType btype, Pos pos)
        {
            _combobox = combobox;
            _button = new Button();

            switch (pos)
            {
                case Pos.POSA1: _button.Location = new Point(X, 58);  break;
                case Pos.POSA2: _button.Location = new Point(X, 102); break;
                case Pos.POSA3: _button.Location = new Point(X, 148); break;

                case Pos.POST1: _button.Location = new Point(X, 67);  break;
                case Pos.POST2: _button.Location = new Point(X, 114); break;
                case Pos.POST3: _button.Location = new Point(X, 159); break;
                case Pos.POST4: _button.Location = new Point(X, 209); break;
            }
            switch (btype)
            {
                case BType.SPELL:    _button.Click += new System.EventHandler(ShowSpellForm);    break;
                case BType.CREATURE: _button.Click += new System.EventHandler(ShowCreatureForm); break;
                case BType.ITEM:     _button.Click += new System.EventHandler(ShowItemForm);     break;
                case BType.QUEST:    _button.Click += new System.EventHandler(ShowQuestForm);    break;
                case BType.EVENT:    _button.Click += new System.EventHandler(ShowEventForm);    break;
            }

            _button.ImeMode = ImeMode.NoControl;
            _button.Size = SIZE;
            _button.Text = "Поиск";
            _button.UseVisualStyleBackColor = true;
            ((GroupBox)combobox.Parent).Controls.Add(_button);
        }

        public static void CreateFlags<T>(this ComboBox combobox, Pos pos) where T : struct
        {
            _type = typeof(T);
            _combobox = combobox;
            _button = new Button();

            switch (pos)
            {
                case Pos.POSA1: _button.Location = new Point(X, 58);  break;
                case Pos.POSA2: _button.Location = new Point(X, 102); break;
                case Pos.POSA3: _button.Location = new Point(X, 148); break;

                case Pos.POST1: _button.Location = new Point(X, 67);  break;
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

        private static void ShowSpellForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private static void ShowCreatureForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }
        
        private static void ShowQuestForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private static void ShowItemForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private static void ShowEventForm(object sender, EventArgs e)
        {
            FormSearchSpell _form = new FormSearchSpell(Who.Spell);
            _form.ShowDialog();
            _combobox.SetVal(_form.Spell.ID);
            _form.Dispose();
        }

        private static void ShowFlagForm(object sender, EventArgs e)
        {
            uint val = _combobox.Text.ToUInt32();
            FormCalculateFlags _form = new FormCalculateFlags(_type, val, String.Empty);
            _form.ShowDialog();
            _combobox.SetVal(_form.Flags);
            _form.Dispose();
        }
    }
}
