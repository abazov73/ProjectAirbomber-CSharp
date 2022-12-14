using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class AirBomberCompareByColor : IComparer<IDrawingObject>
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
            var rCompare = xAirBomber.GetAirBomber.AirBomber.BodyColor.R.CompareTo(yAirBomber.GetAirBomber.AirBomber.BodyColor.R);
            if (rCompare != 0)
            {
                return rCompare;
            }
            var gCompare = xAirBomber.GetAirBomber.AirBomber.BodyColor.G.CompareTo(yAirBomber.GetAirBomber.AirBomber.BodyColor.G);
            if (gCompare != 0)
            {
                return gCompare;
            }
            var bCompare = xAirBomber.GetAirBomber.AirBomber.BodyColor.B.CompareTo(yAirBomber.GetAirBomber.AirBomber.BodyColor.B);
            if (bCompare != 0)
            {
                return bCompare;
            }
            if (xAirBomber.GetAirBomber.AirBomber is EntityHeavyAirBomber xHeavyAirBomber && yAirBomber.GetAirBomber.AirBomber is EntityHeavyAirBomber yHeavyAirBomber)
            {
                var rDopCompare = xHeavyAirBomber.DopColor.R.CompareTo(yHeavyAirBomber.DopColor.R);
                if (rDopCompare != 0)
                {
                    return rDopCompare;
                }
                var gDopCompare = xHeavyAirBomber.DopColor.G.CompareTo(yHeavyAirBomber.DopColor.G);
                if (gDopCompare != 0)
                {
                    return gDopCompare;
                }
                var bDopCompare = xHeavyAirBomber.DopColor.B.CompareTo(yHeavyAirBomber.DopColor.B);
                if (bDopCompare != 0)
                {
                    return bDopCompare;
                }
                return 0;
            }
            return 0;
        }
    }
}
