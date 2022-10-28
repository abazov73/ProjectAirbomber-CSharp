using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    public class DrawingAirBomber
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityAirBomber AirBomber { protected set; get; }
        /// <summary>
        /// Левая координата отрисовки бомбардировщика
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки бомбардировщика
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки бомбардировщика
        /// </summary>
        private readonly int _airBomberWidth = 110;
        /// <summary>
        /// Высота отрисовки бомбардировщика
        /// </summary>
        private readonly int _airBomberHeight = 100;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса</param>
        public DrawingAirBomber(int speed, float weight, Color bodyColor)
        {
            AirBomber = new EntityAirBomber(speed, weight, bodyColor);
        }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса</param>
        /// <param name="carWidth">Ширина отрисовки бомбардировщика</param>
        /// <param name="carHeight">Высота отрисовки бомбардировщика</param>
        protected DrawingAirBomber(int speed, float weight, Color bodyColor, int carWidth, int carHeight) :
            this(speed, weight, bodyColor)
        {
            _airBomberWidth = carWidth;
            _airBomberHeight = carHeight;
        }

        /// <summary>
        /// Установка позиции омбардировщика
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            Random rd = new Random();
            _startPosX = x + _airBomberWidth >= _pictureWidth  ? rd.Next(0, _pictureWidth.Value - 1 - _airBomberWidth) : x;
            _startPosY = y + _airBomberHeight >= _pictureHeight ? rd.Next(0, _pictureHeight.Value - 1 - _airBomberHeight) : y;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _airBomberWidth + AirBomber.Step < _pictureWidth)
                    {
                        _startPosX += AirBomber.Step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - AirBomber.Step > 0)
                    {
                        _startPosX -= AirBomber.Step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - AirBomber.Step > 0)
                    {
                        _startPosY -= AirBomber.Step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _airBomberHeight + AirBomber.Step < _pictureHeight)
                    {
                        _startPosY += AirBomber.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка бомбардировщика
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawTransport(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0
            || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(AirBomber?.BodyColor ?? Color.Black);

            int _startPosXInt = Convert.ToInt32(_startPosX);
            int _startPosYInt = Convert.ToInt32(_startPosY);

            //отрисовка кабины
            g.DrawLine(pen, _startPosXInt, _startPosYInt + 50, _startPosXInt + 5, _startPosYInt + 50);
            Point[] cabin = 
            {
                new Point(_startPosXInt + 5, _startPosYInt + 50),
                new Point(_startPosXInt + 20, _startPosYInt + 40),
                new Point(_startPosXInt + 20, _startPosYInt + 60)
            };
            g.FillPolygon(Brushes.Black, cabin);

            //отрисовка корпуса
            g.FillRectangle(br, _startPosXInt + 20, _startPosYInt + 40, 90, 20);
            g.DrawRectangle(pen, _startPosXInt + 20, _startPosYInt + 40, 90, 20);

            //отрисовка правого крыла
            Point[] rightWing =
            {
                new Point(_startPosXInt + 50, _startPosYInt + 40),
                new Point(_startPosXInt + 50, _startPosYInt),
                new Point(_startPosXInt + 60, _startPosYInt),
                new Point(_startPosXInt + 70, _startPosYInt + 40)
            };
            g.FillPolygon(br, rightWing);
            g.DrawPolygon(pen, rightWing);

            //отрисовка левого крыла
            Point[] leftWing =
            {
                new Point(_startPosXInt + 50, _startPosYInt + 60),
                new Point(_startPosXInt + 50, _startPosYInt + 100),
                new Point(_startPosXInt + 60, _startPosYInt + 100),
                new Point(_startPosXInt + 70, _startPosYInt + 60)
            };
            g.FillPolygon(br, leftWing);
            g.DrawPolygon(pen, leftWing);

            //отрисовка хвоста (справа)
            Point[] rightTail =
            {
                new Point(_startPosXInt + 95, _startPosYInt + 40),
                new Point(_startPosXInt + 95, _startPosYInt + 30),
                new Point(_startPosXInt + 110, _startPosYInt + 15),
                new Point(_startPosXInt + 110, _startPosYInt + 40)
            };
            g.FillPolygon(br, rightTail);
            g.DrawPolygon(pen, rightTail);

            //отрисовка хвоста (слева)
            Point[] leftTail =
            {
                new Point(_startPosXInt + 95, _startPosYInt + 60),
                new Point(_startPosXInt + 95, _startPosYInt + 70),
                new Point(_startPosXInt + 110, _startPosYInt + 85),
                new Point(_startPosXInt + 110, _startPosYInt + 60)
            };
            g.FillPolygon(br, leftTail);
            g.DrawPolygon(pen, leftTail);
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _airBomberWidth || _pictureHeight <= _airBomberHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _airBomberWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _airBomberWidth;
            }
            if (_startPosY + _airBomberHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _airBomberHeight;
            }
        }

        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        public (float Left, float Top, float Right, float Bottom) GetCurrentPosition()
        {
            return (_startPosX, _startPosY, _startPosX + _airBomberWidth, _startPosY + _airBomberHeight);
        }
    }
}
