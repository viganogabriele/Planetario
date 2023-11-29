using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario
{
    public class Planetario
    {
        public List <Pianeta> Pianeti = new List<Pianeta> ();
        public double G { get; set; } =  6.67 * Math.Pow(10, -11);
        public double DeltaT { get; set; } = 0.0001;

        /// <summary>
        /// Muove il sistema di pianeti di un tempo DeltaT.
        /// </summary>
        public void Muovi()
        {
            List<Vettore> forze = new List<Vettore>(Pianeti.Count);
            for (int i = 0; i < Pianeti.Count; i++)
            {
                forze.Add(new Vettore(0, 0));
            }
            // Calcola Forza totale dei Pianeti
            for (int i = 0; i < Pianeti.Count; i++)
            {
                for (int j = 0; j < Pianeti.Count; j++)
                {
                    if (i != j)
                    {
                        forze[i] += VettoreForza(G, Pianeti[i], Pianeti[j]);
                    }
                }
            }
            // Calcola nuova posizione dei Pianeti
            for (int i = 0; i < Pianeti.Count; i++)
            {
                Pianeta pianeta = Pianeti[i];
                pianeta.Accelerazione = forze[i] / Pianeti[i].Massa;
                pianeta.Posizione =
                    pianeta.Posizione +
                    pianeta.Velocita * DeltaT +
                    pianeta.Accelerazione * 0.5 * (DeltaT * DeltaT);
                pianeta.Velocita =
                    pianeta.Velocita +
                    Pianeti[i].Accelerazione * DeltaT;
            }

        }

        static Vettore VettoreForza(double g, Pianeta p1, Pianeta p2)
        {
            double moduloForza = (g * p1.Massa * p2.Massa) / Math.Pow((p2.Posizione - p1.Posizione).Modulo(), 2);
            return moduloForza * (p2.Posizione - p1.Posizione).Versore();
        }

    }
}
