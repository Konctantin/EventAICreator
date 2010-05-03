using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        FLAG
    };
    
    public enum Pos
    {
        POS1,
        POS2,
        POS3,
    }

    public static class ButtonExtensions
    {
        private static Size SIZE = new Size(56, 22);
        private static ComboBox _combobox;
        private static Button b;
        private static Type _type;

        public static void CreateSpellB(this ComboBox combobox, BType bt, Pos pos)
        {
            _combobox = combobox;
            b = new Button();
            b.ImeMode = ImeMode.NoControl;
            switch (pos)
            {
                case Pos.POS1: b.Location = new Point(187, 58);  break;
                case Pos.POS2: b.Location = new Point(187, 102); break;
                case Pos.POS3: b.Location = new Point(187, 148); break;
            }
            b.Size = SIZE;
            b.Text = "Поиск";
            b.UseVisualStyleBackColor = true;
            switch (bt)
            {
                case BType.SPELL:    b.Click += new System.EventHandler(ShowSpellForm);    break;
                case BType.CREATURE: b.Click += new System.EventHandler(ShowCreatureForm); break;
               // case BType.ITEM:     b.Click += new System.EventHandler(ShowItemForm); break;
                case BType.QUEST:    b.Click += new System.EventHandler(ShowQuestForm); break;
            }

            ((GroupBox)combobox.Parent).Controls.Add(b);
        }

        public static void CreateFlags<T>(this ComboBox combobox, Pos pos) where T : struct
        {
            _type = typeof(T);
            _combobox = combobox;

            b = new Button();
            b.ImeMode = ImeMode.NoControl;
            switch (pos)
            {
                case Pos.POS1: b.Location = new Point(187, 58);  break;
                case Pos.POS2: b.Location = new Point(187, 102); break;
                case Pos.POS3: b.Location = new Point(187, 148); break;
            }
            b.Size = SIZE;
            b.Text = "Флаг";
            b.UseVisualStyleBackColor = true;
            b.Click += new System.EventHandler(ShowFlagForm);

            ((GroupBox)combobox.Parent).Controls.Add(b);
        }

        private static void ShowSpellForm(object sender, EventArgs e)
        {
            FormSearchSpell form = new FormSearchSpell(Who.Spell);
            form.ShowDialog();
            _combobox.Text = form.Spell.ID.ToString();
            form.Dispose();
        }

        private static void ShowCreatureForm(object sender, EventArgs e)
        {
            FormSearchSpell form = new FormSearchSpell(Who.Spell);
            form.ShowDialog();
            _combobox.Text = form.Spell.ID.ToString();
            form.Dispose();
        }
        
        private static void ShowQuestForm(object sender, EventArgs e)
        {
            FormSearchSpell form = new FormSearchSpell(Who.Spell);
            form.ShowDialog();
            _combobox.Text = form.Spell.ID.ToString();
            form.Dispose();
        }

        private static void ShowFlagForm(object sender, EventArgs e)
        {
            uint val = _combobox.Text.ToUInt32();
            FormCalculateFlags form = new FormCalculateFlags(_type, val, String.Empty);
            form.ShowDialog();
            _combobox.Text = form.Flags.ToString();
            form.Dispose();
        }
    }
}
