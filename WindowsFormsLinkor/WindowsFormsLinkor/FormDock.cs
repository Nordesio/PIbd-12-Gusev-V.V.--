using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWarships
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
            dockCollection = new DockCollection(pictureBoxDock.Width,pictureBoxDock.Height);
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
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >=listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;

            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index <listBoxDocks.Items.Count)
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
        /// Обработка нажатия кнопки "Добавить боевой корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetWarship_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Warship(100, 1000, dialog.Color);
                    if (dockCollection[listBoxDocks.SelectedItem.ToString()] + ship)
                    {
                        Draw();
                    }
                    else
                    {

                        MessageBox.Show("Док переполнен");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить линкор"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetLinkor_Click(object sender, EventArgs e)

        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)

                    {

                        var ship = new Linkor(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (dockCollection[listBoxDocks.SelectedItem.ToString()] + ship)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Док переполнен");
                        }
                    }
                }
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
    }
}