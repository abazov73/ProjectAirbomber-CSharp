using Serilog.Sinks.File;
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
		/// Список объектов, которые храним
		/// </summary>
		private readonly List<T> _places;
        /// <summary>
        /// Количество объектов в списке
        /// </summary>
        public int Count => _places.Count;

        private readonly int _maxCount;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        /// 
        public SetAirBombersGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T>();
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="airBomber">Добавляемый автомобиль</param>
        /// <returns></returns>
        public int Insert(T airBomber)
        {
            if (airBomber == null)
            {
                throw new ArgumentNullException();
            }
            if (_places.Count + 1 > _maxCount)
            {
                throw new StorageOverflowException(_maxCount);
            }
            Insert(airBomber, 0);
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
            foreach(var placedAirBomber in _places)
            {
                if ((placedAirBomber as DrawingObjectAirBomber).Equals(airBomber as DrawingObjectAirBomber)) throw new ArgumentException("Такой бомбардировщик уже существует!");
            }
            if (position < 0 || position >= _maxCount)
            {
                throw new AirBomberNotFoundException(position);
            }
            if (_places.Count + 1 >= _maxCount)
            {
                throw new StorageOverflowException(_maxCount);
            }
            _places.Insert(position, airBomber);
            return position;
        }
        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Remove(int position)
        {
            if (position < 0 || position >= _maxCount)
            {
                throw new AirBomberNotFoundException(position);
            }
            T removedObject = _places[position];
            _places.RemoveAt(position);
            return removedObject;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T this[int position]
        {
            get
            {
                if (position < 0 || position >= _maxCount) return null;
                return _places[position];
            }
            set
            {
                if (position < 0 || position >= _maxCount) Insert(value, position);
            }
        }

        /// <summary>
        /// Проход по набору до первого пустого
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAirBombers()
        {
            foreach (var airBomber in _places)
            {
                if (airBomber != null)
                {
                    yield return airBomber;
                }
                else
                {
                    yield break;
                }
            }
        }
        public void SortSet(IComparer<T> comparer)
        {
            if (comparer == null)
            {
                return;
            }
            _places.Sort(comparer);
        }
    }
}
