using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsWarships
{
    class Linkor : Warship
    {
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
        /// Признак наличия заднего оружия
        /// </summary>
        public bool BackWeapon { private set; get; }

       
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
     
        public Linkor(int maxSpeed, float weigth, Color mainColor, Color dopColor, bool frontWeapon,
            bool sideWeapon, bool backWeapon) :
            base(maxSpeed, weigth, mainColor, 100, 60)
        {
           
            DopColor = dopColor;
            FrontWeapon = frontWeapon;
            SideWeapon = sideWeapon;
            BackWeapon = backWeapon;
         
        }

        public override void DrawTransport(Graphics g)
        {
           Brush br_dop = new SolidBrush(DopColor);

            base.DrawTransport(g);
            //Переднее орудие
            if (FrontWeapon)
            {
                g.FillRectangle(br_dop, _startPosX + 60, _startPosY + 5, 20, 5);
                g.FillRectangle(br_dop, _startPosX + 60, _startPosY + 30, 20, 5);
            }
            
            //боковые
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
                g.FillRectangle(br_dop, _startPosX - 18, _startPosY + 5, 10, 30);

            }

            
        }
    }
}