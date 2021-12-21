using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    class ShipComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType() != y.GetType())
            {
                if (x is Warship && y is Linkor) return -1;
                else return 1;
            }

            if (x.GetType().Name.Equals("Plane")) return ComparerWarship((Warship)x, (Warship)y);
            if (x.GetType().Name.Equals("Plane_bomber")) return ComparerLinkor((Linkor)x, (Linkor)y);

            return 0;
            
        }
        private int ComparerWarship(Warship x, Warship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerLinkor(Linkor x, Linkor y)
        {
            var res = ComparerWarship(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontWeapon != y.FrontWeapon)
            {
                return x.FrontWeapon.CompareTo(y.FrontWeapon);
            }
            if (x.SideWeapon != y.SideWeapon)
            {
                return x.SideWeapon.CompareTo(y.SideWeapon);
            }
            return 0;
        }
    }
}
