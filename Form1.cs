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
        Planetario planetario = new Planetario();
        int cont = 0;
        double t;
        public Form1()
        {
            InitializeComponent();
            planetario.G = 6.67;
            t = planetario.Timer;
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
        private void DrawPianeta(Graphics g, Pianeta pianeta, Color colore)
        {
            float x = (float)pianeta.Posizione.x;
            float y = (float)pianeta.Posizione.y;
            float raggio = 10.0f;
            g.FillEllipse(new SolidBrush(colore), x, y, raggio, raggio);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Pianeta p = new Pianeta();
            p.Posizione = new Vettore(0, 2);
            p.Massa = 200;
            p.Velocita = new Vettore(3, 4);
            Pianeta p1 = new Pianeta();
            p1.Posizione = new Vettore(5, 3);
            p1.Massa = 250;
            p1.Velocita = new Vettore(7, 6);
            planetario.Pianeti.Add(p1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Vettore> ForzeP = new List<Vettore>();
            // Calcola Forza totale dei Pianeti
            for (int i = 0; i < planetario.Pianeti.Count; i++)
            {
                for (int j = 0; j < planetario.Pianeti.Count; j++)
                {
                    if (planetario.Pianeti[i] != planetario.Pianeti[j])
                    {
                        ForzeP[i] += VForza(planetario, planetario.Pianeti[i], planetario.Pianeti[j]);
                    }
                }
            }
            // Calcola nuova posizione dei Pianeti
            for (int i = 0; i < planetario.Pianeti.Count; i++)
            {
                Pianeta p = planetario.Pianeti[i];
                Vettore a = ForzeP[i] / p.Massa;
                Vettore v = a * t;
                if(cont < planetario.Pianeti.Count)
                {
                    v = planetario.Pianeti[i].Velocita;
                }
                Vettore S = p.Posizione + v * t + (a * 0.5 * (t * t));
                planetario.Pianeti[i].Posizione = S;
            }
            // Disegna i Pianeti
            using (Graphics g = this.CreateGraphics())
            {
                for (int i = 0; i < planetario.Pianeti.Count; i++)
                {
                    Pianeta p = planetario.Pianeti[i];
                    DrawPianeta(g, p, Color.Blue);
                }
            }
        }
    }
}
