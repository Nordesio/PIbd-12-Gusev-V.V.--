using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsLinkor
{
    class Linkor
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX = 50;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY = 50;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки линкора
        /// </summary>

        private readonly int linkorWidth = 100;
        /// <summary>
        /// Высота отрисовки линкора
        /// </summary>
        private readonly int linkorHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес линкора
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет линкора
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего орудия
        /// </summary>
        public bool FrontWeapon { private set; get; }
        /// <summary>
        /// Признак наличия боковых орудий
        /// </summary>
        public bool SideWeapon { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool BackWeapon { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool Roundels { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес линкора</param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontWeapon">Признак наличия переднего орудия</param>
        /// <param name="sideWeapon">Признак наличия боковых орудий</param>
        /// <param name="backWeapon">Признак наличия заднего орудия</param>
        /// <param name="roundels">Признак наличия "круглешков" позади орудий</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontWeapon, bool sideWeapon, bool backWeapon, bool roundels)
        {
            MaxSpeed = maxSpeed;

            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontWeapon = frontWeapon;
            SideWeapon = sideWeapon;
            BackWeapon = backWeapon;
            Roundels = roundels;
        }
        /// <summary>
        /// Установка позиции ликнора
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {

            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Directions direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Directions.Right:
                    if (_startPosX + step < _pictureWidth - linkorWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Directions.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Directions.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Directions.Down:
                    if (_startPosY + step < _pictureHeight - linkorHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTransport(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(MainColor);
            Brush br_dop = new SolidBrush(DopColor);
            //границы ликнора
            if (FrontWeapon)
            {
                g.FillRectangle(br_dop, _startPosX + 60, _startPosY + 5, 20, 5);
                g.FillRectangle(br_dop, _startPosX + 60, _startPosY + 30, 20, 5);




            }
            g.FillRectangle(br, _startPosX - 10, _startPosY, 70, 40);
            g.DrawLine(pen, _startPosX - 10, _startPosY + 3, _startPosX, _startPosY + 3);
            g.DrawLine(pen, _startPosX, _startPosY + 3, _startPosX, _startPosY + 36);
            g.DrawLine(pen, _startPosX, _startPosY + 36, _startPosX - 10, _startPosY + 36);
            // перед линкора
            PointF point1 = new PointF(_startPosX + 60, _startPosY);
            PointF point2 = new PointF(_startPosX + 85, _startPosY + 20);
            PointF point3 = new PointF(_startPosX + 60, _startPosY + 40);

            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
             };


            g.FillPolygon(br, curvePoints);



            // и боковые
            if (SideWeapon)
            {

                // "блок" орудий
                g.FillRectangle(br_dop, _startPosX + 25, _startPosY + 5, 15, 32);
                //сами пушки
                g.FillRectangle(br_dop, _startPosX + 25, _startPosY + 8, 30, 5);
                g.FillRectangle(br_dop, _startPosX + 25, _startPosY + 28, 30, 5);
                //второй блок
                g.FillRectangle(br_dop, _startPosX + 45, _startPosY + 14, 15, 13);
                //его пушка
                g.FillRectangle(br_dop, _startPosX + 45, _startPosY + 18, 30, 5);
            }


            // рисуем заднее орудие ликнора
            if (BackWeapon)
            {
                g.FillRectangle(br_dop, _startPosX - 30, _startPosY + 15, 20, 10);
                g.FillRectangle(br, _startPosX - 18, _startPosY + 5, 10, 30);

            }
            if (Roundels)
            {
                // "кругляшки" сзади бокового орудия и спереди





                g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 5, 8, 8);
                g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 15, 8, 8);
                g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 25, 8, 8);


            }
        }
    }
}