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
        private Button   _button;
        private Type     _type;
        private BType    _bType;

        private Point ButtonLocation
        {
            get { return new Point(_combobox.Location.X + _combobox.Size.Width, _combobox.Location.Y - 1); }
        }

        private Size ButtonSize 
        { 
            get { return new Size(58, 23); } 
        }

        private Size ComboboxSize
        {
            get { return new Size(180, 21); }
        }

        /// <summary>
        /// Создает кнопку для поиска значения в какой-то коллекции
        /// </summary>
        /// <param name="combobox">Елемент возле которого необходимо создать кнопку</param>
        /// <param name="btype">Тип кнопки</param>
        public ButtonHandler(ComboBox combobox, BType btype)
        {
            _combobox = combobox;
            _combobox.Size = ComboboxSize;

            CreateButton("Поиск");
        }

        /// <summary>
        /// Создает кнопку для вызова формы подсчета флагов 
        /// </summary>
        /// <typeparam name="T">Тип флага</typeparam>
        /// <param name="combobox">Елемент возле которого необходимо создать кнопку</param>
        public ButtonHandler(ComboBox combobox, Type type)
        {
            _type = type;
            _combobox = combobox;
            _combobox.Size = ComboboxSize;
            _bType = BType.FLAG;

            CreateButton("Флаг");
        }

        private void CreateButton(string text)
        {
            _button = new Button();
            _button.ImeMode = ImeMode.NoControl;
            _button.Size = ButtonSize;
            _button.Location = ButtonLocation;
            _button.Text = text;
            _button.UseVisualStyleBackColor = true;
            _button.Click += new System.EventHandler(ShowForm);

            ((GroupBox)_combobox.Parent).Controls.Add(_button);
        }

        private void ShowForm(object sender, EventArgs e)
        {
            uint val = _combobox.Text.ToUInt32();

            switch (_bType)
            {
                case BType.SPELL:
                    {
                        FormSearchSpell _form = new FormSearchSpell(Who.Spell);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Spell.ID);
                        _form.Dispose();
                    }
                    break;
                case BType.CREATURE:
                    {
                        FormSearchSpell _form = new FormSearchSpell(Who.Spell);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Spell.ID);
                        _form.Dispose();
                    }
                    break;
                case BType.EVENT:
                    {
                        FormSearchSpell _form = new FormSearchSpell(Who.Spell);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Spell.ID);
                        _form.Dispose();
                    }
                    break;
                case BType.ITEM:
                    {
                        FormSearchSpell _form = new FormSearchSpell(Who.Spell);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Spell.ID);
                        _form.Dispose();
                    }
                    break;
                case BType.QUEST:
                    {
                        FormSearchSpell _form = new FormSearchSpell(Who.Spell);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Spell.ID);
                        _form.Dispose();
                    }
                    break;
                case BType.FLAG:
                    {
                        FormCalculateFlags _form = new FormCalculateFlags(_type, val, String.Empty);
                        _form.ShowDialog();
                        _combobox.SetVal(_form.Flags);
                        _form.Dispose();
                    }
                    break;
            }
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
        /// Форма поиска флага
        /// </summary>
        FLAG,
    };
}
