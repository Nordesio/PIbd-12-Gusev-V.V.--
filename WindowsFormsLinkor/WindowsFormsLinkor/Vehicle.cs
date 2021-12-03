using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsShips
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес 
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной 
        /// </summary>
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void SetSpeed(int speed)
        {
            MaxSpeed = speed;
        }
        public void SetWeight(float new_weight)
        {
            Weight = new_weight;
        }
        public void SetMainColor(Color color) 
        {
            MainColor = color;
        }
        
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Directions direction);
    }
}