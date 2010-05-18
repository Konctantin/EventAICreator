using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EventAI
{
    /// <summary>
    /// Создание кнопки для вызова предопределенной формы
    /// </summary>
    public class ButtonHandler
    {
        private ComboBox _combobox;
        private Button _button;
        private Type _type;

        private Point Location
        {
            get { return new Point(_combobox.Location.X + _combobox.Size.Width, _combobox.Location.Y - 1); }
        }

        private Size SIZE 
        { 
            get { return new Size(56, 23); } 
        }

        /// <summary>
        /// Создает кнопку для поиска значения в какой-то коллекции
        /// </summary>
        /// <param name="combobox">Елемент возле которого необходимо создать кнопку</param>
        /// <param name="btype">Тип кнопки</param>
        public ButtonHandler(ComboBox combobox, BType btype)
        {
            _combobox = combobox;
            _button = new Button();
            _button.ImeMode = ImeMode.NoControl;
            _button.Size = SIZE;
            _button.Location = Location;
            _button.Text = "Поиск";
            _button.UseVisualStyleBackColor = true;
            ((GroupBox)combobox.Parent).Controls.Add(_button);

            switch (btype)
            {
                case BType.SPELL: _button.Click    += new EventHandler(ShowSpellForm);    break;
                case BType.CREATURE: _button.Click += new EventHandler(ShowCreatureForm); break;
                case BType.ITEM: _button.Click     += new EventHandler(ShowItemForm);     break;
                case BType.QUEST: _button.Click    += new EventHandler(ShowQuestForm);    break;
                case BType.EVENT: _button.Click    += new EventHandler(ShowEventForm);    break;
            }
        }

        /// <summary>
        /// Создает кнопку для вызова формы подсчета флагов 
        /// </summary>
        /// <typeparam name="T">Тип флага</typeparam>
        /// <param name="combobox">Елемент возле которого необходимо создать кнопку</param>
        public ButtonHandler(ComboBox combobox, Type t)
        {
            _type = t;
            _combobox = combobox;
            _button = new Button();
            _button.ImeMode = ImeMode.NoControl;
            _button.Size = SIZE;
            _button.Location = Location;
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

    /// <summary>
    /// Указывает тип вызываемой формы
    /// </summary>
    public enum BType
    {
        /// <summary>
        /// Форма поиска заклинаний
        /// </summary>
        SPELL,
        /// <summary>
        /// Форма поиска существ
        /// </summary>
        CREATURE,
        /// <summary>
        /// Форма поиска предметов
        /// </summary>
        ITEM,
        /// <summary>
        /// Форма поиска заданий
        /// </summary>
        QUEST,
        /// <summary>
        /// Форма поиска событий
        /// </summary>
        EVENT,
        /// <summary>
        /// Форма поиска ...
        /// </summary>
        //TODO,
    };
}
