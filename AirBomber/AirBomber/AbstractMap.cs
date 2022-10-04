using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal abstract class AbstractMap
    {
        private IDrawingObject _drawningObject = null;
        protected int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;

        public Bitmap CreateMap(int width, int height, IDrawingObject drawningObject)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }
        public Bitmap MoveObject(Direction direction)
        {
            if (_drawningObject == null) return DrawMapWithObject();
            bool canMove = true;
            switch (direction)
            {
                case Direction.Left:
                    if (!checkForBarriers(0, -1 * _drawningObject.Step, -1 * _drawningObject.Step, 0)) canMove = false;
                    break;
                case Direction.Right:
                    if (!checkForBarriers(0, _drawningObject.Step, _drawningObject.Step, 0)) canMove = false;
                    break;
                case Direction.Up:
                    if (!checkForBarriers(-1 * _drawningObject.Step, 0, 0, -1 * _drawningObject.Step)) canMove = false;
                    break;
                case Direction.Down:
                    if (!checkForBarriers(_drawningObject.Step, 0, 0, _drawningObject.Step)) canMove = false;
                    break;
            }
            if (canMove)
            {
                _drawningObject.MoveObject(direction);
            }
            return DrawMapWithObject();
        }
        private bool SetObjectOnMap()
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(0, 10);
            int y = _random.Next(0, 10);
            _drawningObject.SetObject(x, y, _width, _height);
            if (!checkForBarriers(0,0,0,0)) return false;
            return true;
        }
        private Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new(_width, _height);
            if (_drawningObject == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _freeRoad)
                    {
                        DrawRoadPart(gr, i, j);
                    }
                    else if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drawningObject.DrawingObject(gr);
            return bmp;
        }

        private bool checkForBarriers(float topOffset, float rightOffset, float leftOffset, float bottomOffset)
        {
            int top = Convert.ToInt32((_drawningObject.GetCurrentPosition().Top + topOffset) / _size_y);
            int right = Convert.ToInt32((_drawningObject.GetCurrentPosition().Right + rightOffset) / _size_x);
            int left = Convert.ToInt32((_drawningObject.GetCurrentPosition().Left + leftOffset) / _size_x);
            int bottom = Convert.ToInt32((_drawningObject.GetCurrentPosition().Bottom + bottomOffset) / _size_y);
            if (top < 0 || left < 0 || right >= _map.GetLength(1) || bottom >= _map.GetLength(0)) return false;
            for (int i = top; i <= bottom; i++)
            {
                for (int j = left; j <= right; j++)
                {
                    if (_map[j, i] == 1) return false;
                }
            }
            return true;
        }

        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);
    }
}
