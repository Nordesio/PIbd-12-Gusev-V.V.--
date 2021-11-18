using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    public interface ITransport
    {
        /// <summary>
/// Установка позиции
/// </summary>
/// <param name="x">Координата X</param>
/// <param name="y">Координата Y</param>
/// <param name="width">Ширина картинки</param>
/// <param name="height">Высота картинки</param>



void SetPosition(int x, int y, int width, int height);
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveTransport(Directions direction);
        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="g"></param>
        void DrawTransport(Graphics g);
    }
}
