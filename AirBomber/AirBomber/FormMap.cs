using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBomber
{
    public partial class FormMap : Form
    {
        private AbstractMap _abstractMap;

        public FormMap()
        {
            InitializeComponent();
            _abstractMap = new SimpleMap();
        }
        /// <summary>
        /// Заполнение информации по объекту
        /// </summary>
        /// <param name="car"></param>
        private void SetData(DrawingAirBomber airBomber)
        {
            toolStripStatusLabelSpeed.Text = $"Скорость: {airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {airBomber.AirBomber.BodyColor.Name}";
            pictureBoxAirBomber.Image = _abstractMap.CreateMap(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height,
                new DrawingObjectAirBomber(airBomber));
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var airBomber = new DrawingAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetData(airBomber);
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            Direction dir = Direction.None;
            switch (name)
            {
                case "buttonUp":
                    dir = Direction.Up;
                    break;
                case "buttonDown":
                    dir = Direction.Down;
                    break;
                case "buttonLeft":
                    dir = Direction.Left;
                    break;
                case "buttonRight":
                    dir = Direction.Right;
                    break;
            }
            pictureBoxAirBomber.Image = _abstractMap?.MoveObject(dir);
        }
        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var airBomber = new DrawingHeavyAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData(airBomber);
        }
        /// <summary>
        /// Смена карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    _abstractMap = new SimpleMap();
                    break;
                case "Городская карта":
                    _abstractMap = new CityMap();
                    break;
                case "Линейная карта":
                    _abstractMap = new LineMap();
                    break;
            }
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            comboBoxSelectorMap.SelectedIndex = 0;
        }
    }
}
