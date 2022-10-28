using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class CityMap : AbstractMap
    {
        /// <summary>
        /// Цвет участка закрытого
        /// </summary>
        private readonly Brush barrierColor = new SolidBrush(Color.Gray);
        /// <summary>
        /// Цвет участка открытого
        /// </summary>
        private readonly Brush roadColor = new SolidBrush(Color.LightBlue);

        protected override void DrawBarrierPart(Graphics g, int i, int j)
        {
            g.FillRectangle(barrierColor, i * _size_x, j * _size_y, _size_x, _size_y);
        }
        protected override void DrawRoadPart(Graphics g, int i, int j)
        {
            g.FillRectangle(roadColor, i * _size_x, j * _size_y, _size_x, _size_y);
        }
        protected override void GenerateMap()
        {
            _map = new int[100, 100];
            _size_x = (float)_width / _map.GetLength(0);
            _size_y = (float)_height / _map.GetLength(1);
            int buildingCounter = 0;
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    _map[i, j] = _freeRoad;
                }
            }
            while (buildingCounter < 10)
            {
                int x = _random.Next(0, 89);
                int y = _random.Next(0, 89);
                int buildingWidth = _random.Next(2, 10);
                int buildingHeight = _random.Next(2, 10);
                if (x + buildingWidth >= _map.GetLength(0)) x = _random.Next(_map.GetLength(0) - buildingWidth - 1, _map.GetLength(0));
                if (y + buildingHeight >= _map.GetLength(1)) y = _random.Next(_map.GetLength(1) - buildingHeight - 1, _map.GetLength(1));

                bool isFreeSpace = true;
                for (int i = x; i < x + buildingWidth; i++)
                {
                    for (int j = y; j < y + buildingHeight; j++)
                    {
                        if (_map[i, j] != _freeRoad)
                        {
                            isFreeSpace = false;
                            break;
                        }
                    }
                }
                if (isFreeSpace)
                {
                    for (int i = x; i < x + buildingWidth; i++)
                    {
                        for (int j = y; j < y + buildingHeight; j++)
                        {
                            _map[i, j] = _barrier;
                        }
                    }
                    buildingCounter++;
                }
            }
        }
    }
}
