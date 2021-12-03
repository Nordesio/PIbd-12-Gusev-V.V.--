using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsShips
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    public class Dock<T> where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест в доке
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер одного места дока (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер одного места дока (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;



/// <summary>
/// Конструктор
/// </summary>
/// <param name="picWidth">Рамзер дока - ширина</param>
/// <param name="picHeight">Рамзер парковки - высота</param>
public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }



        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в док добавляется корабль
        /// </summary>
        /// <param name="p">Док</param>
        /// <param name="warship">Добавляемый корабль</param>
        /// <returns></returns>
        /// 

        public static bool operator +(Dock<T> p, T warship)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
           for(int i = 0; i < p._maxCount; i++)
            {
                if (p._places.Contains(warship) == false)
                {
                    p._places.Add(warship);
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с дока забираем корабль
        /// </summary>
        /// <param name="p">Док</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>

        /// <returns></returns>
        public static T operator -(Dock<T> p, int index)
        {
            if (p._places.Count - 1< index)
            {
                return null;
            }
                if (index < p._maxCount)
            {
                T a = p._places[index];
               
                p._places.RemoveAt(index);
                return a;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Метод отрисовки дока
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                int y = i%3;
                int z = i/3;
                _places[i]?.SetPosition(33 + 210 * y, 25 + 80 * z, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки мест дока
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
