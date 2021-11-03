using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLinkor
{
    public partial class FormLinkor : Form
    {
        private Linkor linkor;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormLinkor()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLinkor.Width, pictureBoxLinkor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            linkor.DrawTransport(gr);
            pictureBoxLinkor.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            linkor = new Linkor();
            linkor.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Cyan,
           Color.Brown, true, true, true, true); linkor.SetPosition(50,
           50, pictureBoxLinkor.Width, pictureBoxLinkor.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    linkor.MoveTransport(Directions.Up);
                    break;
                case "buttonDown":
                    linkor.MoveTransport(Directions.Down);
                    break;
                case "buttonLeft":
                    linkor.MoveTransport(Directions.Left);
                    break;
                case "buttonRight":
                    linkor.MoveTransport(Directions.Right);
                    break;
            }
            Draw();
        }
    }
}