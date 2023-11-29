﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
            Pianeta p1 = new Pianeta(100, new Vettore(100, 150), new Vettore(8, 4));
            Pianeta p2 = new Pianeta(70, new Vettore(200, 100), new Vettore(4, 2));
            planetario.Pianeti.Add(p1);
            planetario.Pianeti.Add(p2);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                for (int i = 0; i < 100; i++)
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
