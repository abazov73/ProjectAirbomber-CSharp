using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    /// <summary>
    /// Класс-сущность "Тяжелый бомбардировщик"
    /// </summary>
    internal class EntityHeavyAirBomber : EntityAirBomber
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { get; private set; }
        /// <summary>
        /// Признак наличия бомб
        /// </summary>
        public bool Bombs { get; private set; }
        /// <summary>
        /// Признак наличия топливных баков
        /// </summary>
        public bool FuelTank { get; private set; }
        /// <summary>
        /// Признак наличия полосы на хвосте
        /// </summary>
        public bool TailLine { get; private set; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="bombs">Признак наличия обвеса</param>
        /// <param name="fuelTank">Признак наличия антикрыла</param>
        /// <param name="tailLine">Признак наличия гоночной полосы</param>
        public EntityHeavyAirBomber(int speed, float weight, Color bodyColor, Color dopColor, bool bombs, bool fuelTank, bool tailLine) :
            base(speed, weight, bodyColor)
        {
            DopColor = dopColor;
            Bombs = bombs;
            FuelTank = fuelTank;
            TailLine = tailLine;
        }

        public void setDopColor(Color newDopColor)
        {
            DopColor = newDopColor;
        }
    }
}
