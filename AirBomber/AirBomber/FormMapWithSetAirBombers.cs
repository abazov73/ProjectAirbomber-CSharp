using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AirBomber
{
    public partial class FormMapWithSetAirBombers : Form
    {
        /// <summary>
        /// Объект от класса карты с набором объектов
        /// </summary>
        private MapWithSetAirBombersGeneric<DrawingObjectAirBomber, AbstractMap> _mapAirBombersCollectionGeneric;

        public FormMapWithSetAirBombers()
        {
            InitializeComponent();
        }

        private void comboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractMap map = null;
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    map = new SimpleMap();
                    break;
                case "Городская карта":
                    map = new CityMap();
                    break;
                case "Линейная карта":
                    map = new LineMap();
                    break;
            }
            if (map != null)
            {
                _mapAirBombersCollectionGeneric = new MapWithSetAirBombersGeneric<DrawingObjectAirBomber, AbstractMap>(
                    pictureBox.Width, pictureBox.Height, map);
            }
            else
            {
                _mapAirBombersCollectionGeneric = null;
            }
        }

        private void buttonAddAirBomber_Click(object sender, EventArgs e)
        {
            if (_mapAirBombersCollectionGeneric == null)
            {
                return;
            }
            FormAirBomber form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DrawingObjectAirBomber car = new(form.SelectedAirBomber);
                if (_mapAirBombersCollectionGeneric + car != -1)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBox.Image = _mapAirBombersCollectionGeneric.ShowSet();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }

        private void buttonRemoveAirBomber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            if (_mapAirBombersCollectionGeneric - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBox.Image = _mapAirBombersCollectionGeneric.ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void buttonShowStorage_Click(object sender, EventArgs e)
        {
            if (_mapAirBombersCollectionGeneric == null)
            {
                return;
            }
            pictureBox.Image = _mapAirBombersCollectionGeneric.ShowSet();
        }

        private void buttonShowOnMap_Click(object sender, EventArgs e)
        {
            if (_mapAirBombersCollectionGeneric == null)
            {
                return;
            }
            pictureBox.Image = _mapAirBombersCollectionGeneric.ShowOnMap();
        }

        /// <summary>
        /// Обработка нажатия кнопок движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
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
            pictureBox.Image = _mapAirBombersCollectionGeneric?.MoveObject(dir);
        }
    }
}
