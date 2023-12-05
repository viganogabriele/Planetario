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
        bool start = false;
        int cont = 1;
        double speed = 1;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            /*
            this.BackgroundImage = Properties.Resources.sfondo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            */
            this.WindowState = FormWindowState.Maximized;
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
            return (float) Math.Sqrt(massa);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Pianeta p1 = new Pianeta(100, new Vettore(500, 400), new Vettore(1, 1));
            Pianeta p2 = new Pianeta(200, new Vettore(550, 350), new Vettore(-2, 1));
            Pianeta p3 = new Pianeta(50, new Vettore(600, 370), new Vettore(0, 1));
            Pianeta p4 = new Pianeta(20, new Vettore(630, 400), new Vettore(-4, 2));
            planetario.Pianeti.Add(p1);
            planetario.Pianeti.Add(p2);
            planetario.Pianeti.Add(p3);
            planetario.Pianeti.Add(p4);
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                for (int i = 0; i < speed*250; i++)
                {
                    planetario.Muovi();
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
                Avvia.Text = "Stop";
            }
            else
            {
                start = false;
                Avvia.Text = "Avvia";
            }
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            switch (cont)
            {
                case 0:
                    speed = 0.5;
                    btnSpeed.Text = "0.5 x";
                    break;
                case 1:
                    speed = 1;
                    btnSpeed.Text = "1 x";
                    break;
                case 2:
                    speed = 1.5;
                    btnSpeed.Text = "1.5 x";
                    break;
            }
            cont++;
            if(cont == 3)
            {
                cont = 0;
            }
        }
    }
}
