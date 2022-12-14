using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class AirBomberCompareByType : IComparer<IDrawingObject>
    {
        public int Compare(IDrawingObject? x, IDrawingObject? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null && y != null)
            {
                return 1;
            }
            if (x != null && y == null)
            {
                return -1;
            }
            var xAirBomber = x as DrawingObjectAirBomber;
            var yAirBomber = y as DrawingObjectAirBomber;
            if (xAirBomber == null && yAirBomber == null)
            {
                return 0;
            }
            if (xAirBomber == null && yAirBomber != null)
            {
                return 1;
            }
            if (xAirBomber != null && yAirBomber == null)
            {
                return -1;
            }
            if (xAirBomber.GetAirBomber.GetType().Name != yAirBomber.GetAirBomber.GetType().Name)
            {
                if (xAirBomber.GetAirBomber.GetType().Name == "DrawingAirBomber")
                {
                    return -1;
                }
                return 1;
            }
            var speedCompare = xAirBomber.GetAirBomber.AirBomber.Speed.CompareTo(yAirBomber.GetAirBomber.AirBomber.Speed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return xAirBomber.GetAirBomber.AirBomber.Weight.CompareTo(yAirBomber.GetAirBomber.AirBomber.Weight);
        }
    }
}
