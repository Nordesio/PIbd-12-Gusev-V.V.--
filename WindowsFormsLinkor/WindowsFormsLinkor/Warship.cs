using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsShips
{
    public class Warship : Vehicle
    {
        
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        protected readonly int warshipWidth = 100;
        /// <summary>
        /// Высота отрисовки корабля
        /// </summary>
        protected readonly int warshipHeight = 60;
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет </param>
        public Warship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор изменения размеров корабля
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="warshipWidth">Ширина отрисовки корабля</param>
        /// <param name="warshipHeight">Высота отрисовки корабля</param>
        protected Warship(int maxSpeed, float weight, Color mainColor, int warshipWidth, int
        warshipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.warshipWidth = warshipWidth;
            this.warshipHeight = warshipHeight;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Warship(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Directions direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Directions.Right:
                    if (_startPosX + step < _pictureWidth - warshipWidth)
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
                    if (_startPosY + step < _pictureHeight - warshipHeight)
                    {
                        _startPosY += step;
                    }
                    break;


            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(MainColor);

            //границы ликнора
          
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

            
            Brush br_dop = new SolidBrush(Color.Brown);
            g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 5, 8, 8);
            g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 15, 8, 8);
            g.FillEllipse(br_dop, _startPosX + 10, _startPosY + 25, 8, 8);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}