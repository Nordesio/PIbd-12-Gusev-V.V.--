using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips 
{
    /// <summary>
    /// Класс-ошибка "Если в доке уже заняты все места"
    /// </summary>
    public class DockOverflowException : Exception
    {
        public DockOverflowException() : base("В доке нет свободных мест")
        { }
    }
}
