using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class DrawingObjectAirBomber : IDrawingObject
    {
        private DrawingAirBomber _airBomber = null;

        public DrawingObjectAirBomber(DrawingAirBomber airBomber)
        {
            _airBomber = airBomber;
        }

        public float Step => _airBomber?.AirBomber?.Step ?? 0;

        public DrawingAirBomber GetAirBomber => _airBomber;

        public (float Left, float Top, float Right, float Bottom) GetCurrentPosition()
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

        public string GetInfo() => _airBomber?.GetDataForSave();

        public static IDrawingObject Create(string data) => new DrawingObjectAirBomber(data.CreateDrawningAirBomber());

        public bool Equals(IDrawingObject? other)
        {
            if (other == null)
            {
                return false;
            }
            var otherAirBomber = other as DrawingObjectAirBomber;
            if (otherAirBomber == null)
            {
                return false;
            }
            var airBomber = _airBomber.AirBomber;
            var otherAirBomberAirBomber = otherAirBomber._airBomber.AirBomber;
            if (airBomber.Speed != otherAirBomberAirBomber.Speed)
            {
                return false;
            }
            if (airBomber.Weight != otherAirBomberAirBomber.Weight)
            {
                return false;
            }
            if (airBomber.BodyColor != otherAirBomberAirBomber.BodyColor)
            {
                return false;
            }
            if (airBomber is EntityHeavyAirBomber heavyAirBomber && otherAirBomberAirBomber is EntityHeavyAirBomber otherHeavyAirBomber)
            {
                if (heavyAirBomber.DopColor != otherHeavyAirBomber.DopColor)
                {
                    return false;
                }
                if (heavyAirBomber.Bombs != otherHeavyAirBomber.Bombs)
                {
                    return false;
                }
                if (heavyAirBomber.FuelTank != otherHeavyAirBomber.FuelTank)
                {
                    return false;
                }
                if (heavyAirBomber.TailLine != otherHeavyAirBomber.TailLine)
                {
                    return false;
                }
            }
            else if (airBomber is EntityHeavyAirBomber || otherAirBomberAirBomber is EntityHeavyAirBomber) return false;
            return true;
        }
    }
}
