using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class LineMap : AbstractMap
    {
        /// <summary>
        /// Цвет участка закрытого
        /// </summary>
        private readonly Brush barrierColor = new SolidBrush(Color.Black);
        /// <summary>
        /// Цвет участка открытого
        /// </summary>
        private readonly Brush roadColor = new SolidBrush(Color.Aquamarine);

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
            int lineCounter = 0;
            int numOfLines = _random.Next(1, 4);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    _map[i, j] = _freeRoad;
                }
            }
            while (lineCounter < numOfLines)
            {
                int randomInt = _random.Next(0, 1000);
                bool vertical = false;
                if (randomInt % 2 == 0) vertical = true;
                if (vertical)
                {
                    int x = _random.Next(0, 89);
                    int lineWidth = _random.Next(2, 5);
                    if (x + lineWidth >= _map.GetLength(0)) x = _random.Next(_map.GetLength(0) - lineWidth - 1, _map.GetLength(0));

                    bool isFreeSpace = true;
                    for (int i = x; i < x + lineWidth; i++)
                    {
                        if (_map[i, 0] != _freeRoad) isFreeSpace = false;
                    }
                    if (isFreeSpace)
                    {
                        for (int i = x; i < x + lineWidth; i++)
                        {
                            for (int j = 0; j < _map.GetLength(0); j++)
                            {
                                _map[i, j] = _barrier;
                            }
                        }
                        lineCounter++;
                    }
                }
                else
                {
                    int y = _random.Next(0, 89);
                    int lineHeigth = _random.Next(2, 5);
                    if (y + lineHeigth >= _map.GetLength(1)) y = _random.Next(_map.GetLength(1) - lineHeigth - 1, _map.GetLength(1));

                    bool isFreeSpace = true;
                    for (int j = y; j < y + lineHeigth; j++)
                    {
                        if (_map[0, j] != _freeRoad) isFreeSpace = false;
                    }
                    if (isFreeSpace)
                    {
                        for (int j = y; j < y + lineHeigth; j++)
                        {
                            for (int i = 0; i < _map.GetLength(1); i++)
                            {
                                _map[i, j] = _barrier;
                            }
                        }
                        lineCounter++;
                    }
                }
            }
        }
    }
}
