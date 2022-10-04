using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class SetAirBombersGeneric<T>
        where T : class
    {
        /// <summary>
		/// Массив объектов, которые храним
		/// </summary>
		private readonly T[] _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Length;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetAirBombersGeneric(int count)
        {
            _places = new T[count];
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="airBomber">Добавляемый автомобиль</param>
        /// <returns></returns>
        public int Insert(T airBomber)
        {
            if (_places[0] != null) {
                int indexNull = -1;
                for (int i = 0; i < _places.Length; i++)
                {
                    if (_places[i] == null)
                    {
                        indexNull = i;
                        break;
                    }
                }
                if (indexNull == -1) return -1;
                for (int i = indexNull; i > 0; i--)
                {
                    T tmp = _places[i];
                    _places[i] = _places[i - 1];
                    _places[i - 1] = tmp;
                }
            }
            _places[0] = airBomber;
            return 0;
        }
        /// <summary>
        /// Добавление объекта в набор на конкретную позицию
        /// </summary>
        /// <param name="airBomber">Добавляемый автомобиль</param>
        /// <param name="position">Позиция</param>
        /// <returns></returns>
        public int Insert(T airBomber, int position)
        {
            if (position >= _places.Length)
            {
                return -1;
            }
            if (_places[position] != null)
            {
                int indexNull = -1;
                for (int i = position; i < _places.Length; i++)
                {
                    if (_places[i] == null)
                    {
                        indexNull = i;
                        break;
                    }
                }
                if (indexNull == -1) return -1;
                for (int i = indexNull; i > position; i++)
                {
                    T tmp = _places[i];
                    _places[i] = _places[i - 1];
                    _places[i - 1] = tmp;
                }
            }
            _places[position] = airBomber;
            return position;
        }
        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Remove(int position)
        {
            if (position >= _places.Length)
            {
                return null;
            }
            T removedObject = _places[position];
            _places[position] = null;
            return removedObject;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Get(int position)
        {
            if (position >= _places.Length)
            {
                return null;
            }
            return _places[position];
        }
    }
}
