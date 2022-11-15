using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class MapsCollection
    {
        /// <summary>
        /// Словарь (хранилище) с картами
        /// </summary>
        readonly Dictionary<string, MapWithSetAirBombersGeneric<IDrawingObject, AbstractMap>> _mapStorages;
        /// <summary>
        /// Возвращение списка названий карт
        /// </summary>
        public List<string> Keys => _mapStorages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Разделитель для записи информации по элементу словаря в файл
        /// </summary>
        private readonly char separatorDict = '|';
        /// <summary>
        /// Разделитель для записей коллекции данных в файл
        /// </summary>
        private readonly char separatorData = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            _mapStorages = new Dictionary<string, MapWithSetAirBombersGeneric<IDrawingObject, AbstractMap>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        /// <param name="map">Карта</param>
        public void AddMap(string name, AbstractMap map)
        {
            if (_mapStorages.ContainsKey(name))
            {
                MessageBox.Show("Карта с таким названием уже существует!");
                return;
            }
            _mapStorages.Add(name, new MapWithSetAirBombersGeneric<IDrawingObject, AbstractMap>(_pictureWidth, _pictureHeight, map));
        }
        /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        public void DelMap(string name)
        {
            if (_mapStorages.ContainsKey(name))
            {
                _mapStorages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public MapWithSetAirBombersGeneric<IDrawingObject, AbstractMap> this[string ind]
        {
            get
            {
                if (_mapStorages.ContainsKey(ind)) return _mapStorages[ind];
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по автомобилям в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new(filename, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write($"MapsCollection{Environment.NewLine}", sw);
                foreach (var storage in _mapStorages)
                {
                    sw.Write($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}{Environment.NewLine}", sw);
                }
            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new(filename, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                line = sr.ReadLine();
                line.Trim();
                if (line != "MapsCollection") return false;
                _mapStorages.Clear();
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    var elem = line.Split(separatorDict);
                    AbstractMap map = null;
                    switch (elem[1])
                    {
                        case "SimpleMap":
                            map = new SimpleMap();
                            break;
                        case "CityMap":
                            map = new CityMap();
                            break;
                        case "LineMap":
                            map = new LineMap();
                            break;
                    }
                    _mapStorages.Add(elem[0], new MapWithSetAirBombersGeneric<IDrawingObject, AbstractMap>(_pictureWidth, _pictureHeight, map));
                    _mapStorages[elem[0]].LoadData(elem[2].Split(separatorData, StringSplitOptions.RemoveEmptyEntries));
                }
            }
            return true;
        }
    }
}
