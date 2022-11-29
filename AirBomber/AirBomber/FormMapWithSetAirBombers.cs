using Microsoft.Extensions.Logging;
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
        /// Словарь для выпадающего списка
        /// </summary>
        private readonly Dictionary<string, AbstractMap> _mapsDict = new()
        {
            { "Простая карта", new SimpleMap() },
            {"Городская карта", new CityMap() },
            {"Линейная карта", new LineMap() }
        };
        /// <summary>
        /// Объект от коллекции карт
        /// </summary>
        private readonly MapsCollection _mapsCollection;

        private Action<DrawingAirBomber> AddAction;

        private readonly ILogger _logger;

        public FormMapWithSetAirBombers(ILogger<FormMapWithSetAirBombers> logger)
        {
            InitializeComponent();
            _logger = logger;
            _mapsCollection = new MapsCollection(pictureBox.Width, pictureBox.Height);
            comboBoxSelectorMap.Items.Clear();
            foreach (var elem in _mapsDict)
            {
                comboBoxSelectorMap.Items.Add(elem.Key);
            }
            AddAction = addAirBomber;
        }

        private void addAirBomber(DrawingAirBomber airBomber)
        {
            try
            {
                int res = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] + new DrawingObjectAirBomber(airBomber);
                pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                _logger.LogInformation($"Добавлен объект {airBomber.ToString()}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                _logger.LogWarning($"Ошибка: {ex.Message}");
            }
            catch (StorageOverflowException ex)
            {
                MessageBox.Show(ex.Message);
                _logger.LogWarning($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning($"Ошибка: {ex.Message}");
            }
        }

        private void buttonAddAirBomber_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            var formAirBomberConfig = new FormAirBomberConfig();
            formAirBomberConfig.AddEvent(AddAction);
            formAirBomberConfig.Show();
        }

        private void buttonRemoveAirBomber_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            try
            {
                IDrawingObject drawingObject = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] - pos;
                MessageBox.Show("Объект удален");
                pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                _logger.LogInformation($"Удалён объект {drawingObject.ToString()}");
            }
            catch (AirBomberNotFoundException ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning($"Ошибка: {ex.Message}");
            }
        }

        private void buttonShowStorage_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void buttonShowOnMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowOnMap();
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
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].MoveObject(dir);
        }

        private void ReloadMaps()
        {
            int index = listBoxMaps.SelectedIndex;

            listBoxMaps.Items.Clear();
            for (int i = 0; i < _mapsCollection.Keys.Count; i++)
            {
                listBoxMaps.Items.Add(_mapsCollection.Keys[i]);
            }

            if (listBoxMaps.Items.Count > 0 && (index == -1 || index >= listBoxMaps.Items.Count))
            {
                listBoxMaps.SelectedIndex = 0;
            }
            else if (listBoxMaps.Items.Count > 0 && index > -1 && index < listBoxMaps.Items.Count)
            {
                listBoxMaps.SelectedIndex = index;
            }
        }

        private void buttonAddMap_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectorMap.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxNewMapName.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_mapsDict.ContainsKey(comboBoxSelectorMap.Text))
            {
                MessageBox.Show("Нет такой карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _mapsCollection.AddMap(textBoxNewMapName.Text, _mapsDict[comboBoxSelectorMap.Text]);
            ReloadMaps();
            _logger.LogInformation($"Добавлена карта: {textBoxNewMapName.Text}, тип карты: {comboBoxSelectorMap.Text}");
        }

        private void listBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
            _logger.LogInformation($"Переход на карту {listBoxMaps.SelectedItem?.ToString() ?? string.Empty}"); 
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            string mapName = listBoxMaps.SelectedItem?.ToString();
            if (MessageBox.Show($"Удалить карту {listBoxMaps.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mapsCollection.DelMap(listBoxMaps.SelectedItem?.ToString() ?? string.Empty);
                ReloadMaps();
            }
            _logger.LogInformation($"Удалена карта {mapName}");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Данные сохранены в файл {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Ошибка: {ex.Message}");
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadMaps();
                    _logger.LogInformation($"Данные загружены из файла {openFileDialog.FileName}");
                }
                catch(FileFormatException ex)
                {
                    MessageBox.Show($"Не загрузилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Ошибка: {ex.Message}");
                }
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show($"Не загрузилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
