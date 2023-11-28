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
        Color[] colori = { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.Cyan };
        double t;
        bool start = false;
        public Form1()
        {
            InitializeComponent();
            t = planetario.Timer;
            //timer1.Interval = (int)(t * 1000);
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
        private void DisegnaPianeta(Graphics g, Pianeta pianeta, Color colore)
        {
            float raggio = CalcolaRaggioPianeta(pianeta.Massa);
            float x = (float)(pianeta.Posizione.x);
            float y = (float)(pianeta.Posizione.y);
            g.FillEllipse(new SolidBrush(colore), x, y, raggio, raggio);
        }
        private float CalcolaRaggioPianeta(double massa)
        {
            //for (int i = 0; i < massa; i+=10000) Trovare una proprietà sensata per calcolare il raggio
            if(massa > Math.Pow(10, 20))
            {
                return 20;
            }
            return 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Pianeta p1 = new Pianeta(6 * Math.Pow(10, 24), new Vettore(100, 150), new Vettore(1, 4));
            Pianeta p2 = new Pianeta(7.3 * Math.Pow(10, 22), new Vettore(300, 200), new Vettore(2, 3));
            planetario.Pianeti.Add(p1);
            planetario.Pianeti.Add(p2);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == true) 
            { 
            List <Vettore> ForzeP = new List <Vettore>(planetario.Pianeti.Count);
            for (int i = 0; i < planetario.Pianeti.Count; i++)
            {
                ForzeP.Add(new Vettore(0, 0));
            }
            // Calcola Forza totale dei Pianeti
            for (int i = 0; i < planetario.Pianeti.Count; i++)
            {
                for (int j = 0; j < planetario.Pianeti.Count; j++)
                {
                    if (i != j) 
                    {
                        ForzeP[i] += VForza(planetario, planetario.Pianeti[i], planetario.Pianeti[j]);
                    }
                }
            }
            // Calcola nuova posizione dei Pianeti
            for (int i = 0; i < planetario.Pianeti.Count; i++)
            {
                planetario.Pianeti[i].Accelerazione = ForzeP[i] / planetario.Pianeti[i].Massa;
                Vettore S = planetario.Pianeti[i].Posizione + planetario.Pianeti[i].Velocita * t + (planetario.Pianeti[i].Accelerazione * 0.5 * (t * t));
                planetario.Pianeti[i].Posizione = S;
                Vettore v = planetario.Pianeti[i].Accelerazione * t;
                planetario.Pianeti[i].Velocita= v;
            }
            // Disegna i Pianeti

            using (Graphics g = this.CreateGraphics())
            {
                for (int i = 0; i < planetario.Pianeti.Count; i++)
                {
                    Pianeta p = planetario.Pianeti[i];
                    DisegnaPianeta(g, p, colori[i]);
                }
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                start = true;
                button1.Text = "Stop";
            }
            else
            {
                start = false;
                button1.Text = "Start";
            }
        }
    }
}
