using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double MForza(Planetario p, Pianeta p1, Pianeta p2)
        {
            return (p.G * p1.Massa * p2.Massa) / Math.Pow((p2.Posizione - p1.Posizione).Modulo(), 2);
        }
        public static Vettore VForza(Planetario p, Pianeta p1, Pianeta p2)
        {
            Vettore v = (p2.Posizione - p1.Posizione).Versore();
            double f = MForza(p, p1, p2);
            return new Vettore(v.x * f, v.y * f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Planetario planetario = new Planetario(); // non va qua
            List<Vettore> ForzeP = new List<Vettore>();
            for (int i = 0; i < planetario.pianeti.Count; i++)
            {
                for (int j = 0; j < planetario.pianeti.Count; j++)
                {
                    if (planetario.pianeti[i] != planetario.pianeti[j])
                    {
                        ForzeP[i] += VForza(planetario, planetario.pianeti[i], planetario.pianeti[j]);
                    }
                }
            }
            for(int i = 0; i < ForzeP.Count; i++)
            {
                planetario.pianeti[i].Posizione += ForzeP[i];
            }
            //disegna il pianeta
        }
    }
}
