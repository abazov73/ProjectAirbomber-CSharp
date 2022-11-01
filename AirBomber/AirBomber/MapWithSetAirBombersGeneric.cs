using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class MapWithSetAirBombersGeneric <T, U>
        where T : class, IDrawingObject
        where U : AbstractMap
    {
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер занимаемого объектом места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 110;
        /// <summary>
        /// Размер занимаемого объектом места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 100;
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly SetAirBombersGeneric<T> _setAirBombers;
        /// <summary>
        /// Карта
        /// </summary>
        private readonly U _map;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        /// <param name="map"></param>
        public MapWithSetAirBombersGeneric(int picWidth, int picHeight, U map)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _setAirBombers = new SetAirBombersGeneric<T>(width * height);
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _map = map;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="map"></param>
        /// <param name="airBomber"></param>
        /// <returns></returns>
        public static int operator +(MapWithSetAirBombersGeneric<T, U> map, T airBomber)
        {
            return map._setAirBombers.Insert(airBomber);
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <param name="map"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T operator -(MapWithSetAirBombersGeneric<T, U> map, int position)
        {
            return map._setAirBombers.Remove(position);
        }

        public void add(T airBomber)
        {
            _setAirBombers.Insert(airBomber);
        }
        /// <summary>
        /// Вывод всего набора объектов
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowSet()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawAirBombers(gr);
            return bmp;
        }
        /// <summary>
        /// Просмотр объекта на карте
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowOnMap()
        {
            Shaking();
            foreach (var airBomber in _setAirBombers.GetAirBombers())
            {
                return _map.CreateMap(_pictureWidth, _pictureHeight, airBomber);
            }
            return new(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// Перемещение объекта по крате
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Bitmap MoveObject(Direction direction)
        {
            if (_map != null)
            {
                return _map.MoveObject(direction);
            }
            return new(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// "Взбалтываем" набор, чтобы все элементы оказались в начале
        /// </summary>
        private void Shaking()
        {
            int j = _setAirBombers.Count - 1;
            for (int i = 0; i < _setAirBombers.Count; i++)
            {
                if (_setAirBombers[i] == null)
                {
                    for (; j > i; j--)
                    {
                        var car = _setAirBombers[j];
                        if (car != null)
                        {
                            _setAirBombers.Insert(car, i);
                            _setAirBombers.Remove(j);
                            break;
                        }
                    }
                    if (j <= i)
                    {
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Метод отрисовки фона
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.White, 3);
            g.FillRectangle(Brushes.Gray, 0, 0, _pictureWidth, _pictureHeight);
            g.FillRectangle(Brushes.Black, _pictureWidth - 40, 0, _pictureWidth, _pictureHeight);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        /// <summary>
        /// Метод прорисовки объектов
        /// </summary>
        /// <param name="g"></param>
        private void DrawAirBombers(Graphics g)
        {
            int numOfObjectsInRow = _pictureWidth / _placeSizeWidth;
            int i = 0;
            foreach (var airBomber in _setAirBombers.GetAirBombers())
            {
                airBomber.SetObject((numOfObjectsInRow - (i % numOfObjectsInRow) - 1) * _placeSizeWidth, (i / numOfObjectsInRow) * _placeSizeHeight, _pictureWidth, _pictureHeight);
                airBomber.DrawingObject(g);
                i++;
            }
        }
    }
}
