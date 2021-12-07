using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    /// <summary>
    /// Класс-коллекция доков
    /// </summary>
    public class DockCollection
    {
        /// <summary>
        /// Словарь (хранилище) с доками
        /// </summary>
        readonly Dictionary<string, Dock<Vehicle>> dockStages;
        /// <summary>
        /// Возвращение списка названий доков
        /// </summary>
        public List<string> Keys => dockStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DockCollection(int pictureWidth, int pictureHeight)
        {
            dockStages = new Dictionary<string, Dock<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            
        }

/// <summary>
/// Добавление дока
/// </summary>
/// <param name="name">Название парковки</param>
public void AddDock(string name)
        {
            if (dockStages.ContainsKey(name)) return;
            dockStages.Add(name, new Dock<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление дока
        /// </summary>
        /// <param name="name">Название дока</param>
        public void DelDock(string name)
        {
            if (dockStages.ContainsKey(name)) dockStages.Remove(name) ;
        }
        /// <summary>
        /// Доступ к доку
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Dock<Vehicle> this[string ind]
        {
            get
            {
                if (dockStages.ContainsKey(ind)) return dockStages[ind];
                else return null;
            }
        }
       
        /// <summary>
        /// Сохранение информации по кораблям в доке в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"DockCollection{Environment.NewLine}");
                foreach (var level in dockStages)
                {
                    //Начинаем парковку

                    sw.Write($"Dock{separator}{level.Key}{Environment.NewLine}");
                    ITransport ship = null;

                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип корабля
                            if (ship.GetType().Name == "Warship")

                            {
                                sw.Write($"Warship{separator}");
                            }

                            if (ship.GetType().Name == "Linkor")

                            {
                                sw.Write($"Linkor{separator}");
                            }

                            //Записываемые параметры
                            sw.Write(ship + Environment.NewLine);

                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Загрузка нформации по кораблям в доках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("DockCollection"))
                {
                    dockStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;

                }
                Vehicle ship = null;
                string key = string.Empty;
                for (int i = 1; (line = sr.ReadLine()) != null; ++i)
                {
                    //идем по считанным записям
                    if (line.Contains("Dock"))
                    {
                        //начинаем новую парковку
                        key = line.Split(separator)[1];
                        dockStages.Add(key, new Dock<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Warship")
                    {
                        ship = new Warship(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Linkor")
                    {
                        ship = new Linkor(line.Split(separator)[1]);
                    }
                    if (!dockStages.ContainsKey(key))
                    {
                        return false;
                    }
                    var result = dockStages[key] + ship;
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
