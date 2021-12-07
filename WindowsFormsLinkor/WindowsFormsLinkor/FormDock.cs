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
    public partial class FormDock : Form
    {
        /// <summary>
        /// Объект от класса-дока
        /// </summary>

        private readonly DockCollection dockCollection;

        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(pictureBoxDock.Width, pictureBoxDock.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxDocks.SelectedIndex;
            listBoxDocks.Items.Clear();

            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxDocks.Items.Add(dockCollection.Keys[i]);

            }
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >= listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;

            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index < listBoxDocks.Items.Count)
            {
                listBoxDocks.SelectedIndex = index;

            }
            Draw();
        }
        private void Draw()
        {
            if (listBoxDocks.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
            else if (listBoxDocks.Items.Count == 0)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxDock.Image = bmp;
            }
        }


        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeWarship_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var ship = dockCollection[listBoxDocks.SelectedItem.ToString()] -
                Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    FormLinkor form = new FormLinkor();
                    form.SetWarship(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonAddDock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDockName.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockCollection.AddDock(textBoxDockName.Text);

            ReloadLevels();
        }

        private void buttonDelDock_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockCollection.DelDock(listBoxDocks.SelectedItem.ToString());

                    ReloadLevels();

                }
            }
        }

        private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }


        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                var formShipConfig = new FormShipConfig();
                formShipConfig.AddEvent(AddShip);
                formShipConfig.Show();
            }
            
        }
       
        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxDocks.SelectedIndex > -1)
            {
                if ((dockCollection[listBoxDocks.SelectedItem.ToString()]) + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dockCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dockCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();

                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}