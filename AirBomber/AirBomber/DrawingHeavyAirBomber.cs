using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class DrawingHeavyAirBomber : DrawingAirBomber
    {
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="bodyKit">Признак наличия обвеса</param>
        /// <param name="wing">Признак наличия антикрыла</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public DrawingHeavyAirBomber(int speed, float weight, Color bodyColor, Color dopColor, bool bodyKit, bool wing, bool sportLine) :
            base(speed, weight, bodyColor, 110, 100)
        {
            AirBomber = new EntityHeavyAirBomber(speed, weight, bodyColor, dopColor, bodyKit, wing, sportLine);
        }
        public override void DrawTransport(Graphics g)
        {
            if (AirBomber is not EntityHeavyAirBomber heavyAirBomber)
            {
                return;
            }

            Pen pen = new(Color.Black);
            Brush dopBrush = new SolidBrush(heavyAirBomber.DopColor);

            if (heavyAirBomber.Bombs) 
            {
                g.FillEllipse(dopBrush, _startPosX + 45, _startPosY, 20, 10);
                g.FillEllipse(dopBrush, _startPosX + 45, _startPosY + 90, 20, 10);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY, 20, 10);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 90, 20, 10);
            }

            base.DrawTransport(g);

            if (heavyAirBomber.TailLine) //TODO отрисовка полоски на хвосте
            {
                g.FillRectangle(dopBrush, _startPosX + 95, _startPosY + 30, 15, 5);
                g.FillRectangle(dopBrush, _startPosX + 95, _startPosY + 65, 15, 5);
            }

            if (heavyAirBomber.FuelTank) //TODO отрисовка топливных баков
            {
                g.FillEllipse(dopBrush, _startPosX + 23, _startPosY + 42, 25, 15);
                g.FillEllipse(dopBrush, _startPosX + 53, _startPosY + 42, 25, 15);
                g.FillEllipse(dopBrush, _startPosX + 83, _startPosY + 42, 25, 15);
                g.DrawEllipse(pen, _startPosX + 23, _startPosY + 42, 25, 15);
                g.DrawEllipse(pen, _startPosX + 53, _startPosY + 42, 25, 15);
                g.DrawEllipse(pen, _startPosX + 83, _startPosY + 42, 25, 15);
            }
        }
    }
}
