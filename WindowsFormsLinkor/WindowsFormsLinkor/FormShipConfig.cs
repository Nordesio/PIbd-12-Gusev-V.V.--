using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsShips
{
    public partial class FormShipConfig : Form
    {/// <summary>
     /// Переменная-выбранный корабль
     /// </summary>
        Vehicle ship = null;
        private event Action<Vehicle> eventAddShip;
        
        public FormShipConfig()
        {
            InitializeComponent();
            panelBlue.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelNavy.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
           
        }


        /// <summary>
        /// Отрисовать корабль
        /// </summary>
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShip.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelLinkor_MouseDown(object sender, MouseEventArgs e)
        {
            labelLinkor.DoDragDrop(labelLinkor.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный корабль":
                    ship = new Warship((int)numericSpeed.Value, (int)numericWeight.Value, Color.White);
                    break;
                case "Линкор":
                    ship = new Linkor((int)numericSpeed.Value, (int)numericWeight.Value, Color.White, Color.Black, checkBoxFrontWeapon.Checked, checkBoxSideWeapons.Checked, false);
                    break;
            }
            DrawShip();
        }



        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (ship != null)
            {
                (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color) e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null && (ship is Linkor))
            {
                (ship as Linkor).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ship == null) return;
            if (ship is Linkor)
            {
                if (checkBoxFrontWeapon.Checked)
                {
                    (ship as Linkor).SetFrontWeapon(true);
                }
                else
                {
                    (ship as Linkor).SetFrontWeapon(false);
                }
               
                if (checkBoxSideWeapons.Checked)
                {
                    (ship as Linkor).SetSideWeapons(true);
                }
                else
                {
                    (ship as Linkor).SetSideWeapons(false);
                }
                DrawShip();
            }
        }
        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (ship == null) return;
            if (numericSpeed.Value > 0)
            {
                ship.SetSpeed((int)numericSpeed.Value);
            }
            if (numericWeight.Value > 0)
            {
                ship.SetWeight((int)numericWeight.Value);
            }
            DrawShip();
        }


    }
}
