using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    /// <summary>
/// Класс-ошибка "Если в доке уже есть корабль с такими же характеристиками"
/// </summary>
    public class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("В доке уже есть такой корабль")
        {

        }
    }
}
