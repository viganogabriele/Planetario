using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario
{
    public class Vettore
    {
        public double x;
        public double y;
        public Vettore(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.x - v2.x, v1.y - v2.y);
        }
        public static Vettore operator *(Vettore v1, double scalare)
        {
            return new Vettore(v1.x * scalare, v1.y * scalare);
        }
        public static Vettore operator /(Vettore v1, double scalare)
        {
            return new Vettore(v1.x / scalare, v1.y / scalare);
        }
        public double Modulo ()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public Vettore Versore()
        {
            return new Vettore(x / Math.Abs(x), y / Math.Abs(y));
        }

    }
}
