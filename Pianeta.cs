using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario
{
    public class Pianeta
    {
        public Pianeta() { }
        public double Massa { get; set; }
        public Vettore Posizione { get; set; }
        public Vettore Velocita { get; set; }
        public Vettore Accelerazione { get; set; }
        public Pianeta(double massa, Vettore posizione, Vettore velocita)
        {
            Massa = massa;
            Posizione = posizione;
            Velocita = velocita;
        }
    }
}
