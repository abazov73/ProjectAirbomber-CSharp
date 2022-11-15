using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal static class ExtentionAirBomber
    {
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly char _separatorForObject = ':';
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static DrawingAirBomber CreateDrawningAirBomber(this string info)
        {
            string[] strs = info.Split(_separatorForObject);
            if (strs.Length == 3)
            {
                return new DrawingAirBomber(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]));
            }
            if (strs.Length == 7)
            {
                return new DrawingHeavyAirBomber(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]),
                    Color.FromName(strs[3]), Convert.ToBoolean(strs[4]),
                    Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]));
            }
            return null;
        }
        /// <summary>
        /// Получение данных для сохранения в файл
        /// </summary>
        /// <param name="drawningCar"></param>
        /// <returns></returns>
        public static string GetDataForSave(this DrawingAirBomber drawningAirBomber)
        {
            var airBomber = drawningAirBomber.AirBomber;
            var str = $"{airBomber.Speed}{_separatorForObject}{airBomber.Weight}{_separatorForObject}{airBomber.BodyColor.Name}";
            if (airBomber is not EntityHeavyAirBomber heavyAirBomber)
            {
                return str;
            }
            return $"{str}{_separatorForObject}{heavyAirBomber.DopColor.Name}{_separatorForObject}{heavyAirBomber.Bombs}{_separatorForObject}{heavyAirBomber.FuelTank}{_separatorForObject}{heavyAirBomber.TailLine}";
        }
    }
}
