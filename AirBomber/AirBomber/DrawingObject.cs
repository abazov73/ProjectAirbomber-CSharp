using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class DrawingObject : IDrawingObject
    {
        private DrawingAirBomber _airBomber = null;

        public DrawingObject(DrawingAirBomber airBomber)
        {
            _airBomber = airBomber;
        }

        public float Step => _airBomber?.AirBomber?.Step ?? 0;

        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return _airBomber?.GetCurrentPosition() ?? default;
        }

        public void MoveObject(Direction direction)
        {
            _airBomber?.MoveTransport(direction);
        }

        public void SetObject(int x, int y, int width, int height)
        {
            _airBomber.SetPosition(x, y, width, height);
        }

        void IDrawingObject.DrawingObject(Graphics g)
        {
            if (_airBomber == null) return;
            if (_airBomber is DrawingHeavyAirBomber heavyAirBomber)
            {
                heavyAirBomber.DrawTransport(g);
            }
            else
            {
                _airBomber.DrawTransport(g);
            }
        }
    }
}
