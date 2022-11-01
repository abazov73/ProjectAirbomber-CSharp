using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    /// <summary>
    /// Класс-сущность "Бомбардировщик"
    /// </summary>
    public class EntityAirBomber
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public float Weight { get; private set; }
        /// <summary>
        /// Цвет корпуса
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// Шаг перемещения бомбардировщика
        /// </summary>
        public float Step => Speed * 100 / Weight;
        /// <summary>
        /// Инициализация полей объекта-класса бомбардировщика
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        /// <returns></returns>
        public EntityAirBomber (int speed, float weight, Color bodyColor)
        {
            Random rnd = new();
            Speed = speed <= 0 ? rnd.Next(50, 150) : speed;
            Weight = weight <= 0 ? rnd.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }

        public void setColor(Color newColor)
        {
            BodyColor = newColor;
        }
    }
}
