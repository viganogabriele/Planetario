namespace Planetario
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtDeltaT = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.AggiungiPianeta = new System.Windows.Forms.Button();
            this.ListPlanetario = new System.Windows.Forms.ListBox();
            this.ModificaPianeta = new System.Windows.Forms.Button();
            this.EliminaPianeta = new System.Windows.Forms.Button();
            this.Avvia = new System.Windows.Forms.Button();
            this.Impostazioni = new System.Windows.Forms.Button();
            this.Pulisci = new System.Windows.Forms.Button();
            this.txtVelocita = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(1425, 290);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 1;
            // 
            // txtDeltaT
            // 
            this.txtDeltaT.Location = new System.Drawing.Point(970, 222);
            this.txtDeltaT.Name = "txtDeltaT";
            this.txtDeltaT.Size = new System.Drawing.Size(100, 20);
            this.txtDeltaT.TabIndex = 2;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(970, 264);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 3;
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(1425, 371);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(100, 20);
            this.txtMassa.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(1425, 447);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(38, 20);
            this.txtY.TabIndex = 5;
            // 
            // AggiungiPianeta
            // 
            this.AggiungiPianeta.Location = new System.Drawing.Point(970, 352);
            this.AggiungiPianeta.Name = "AggiungiPianeta";
            this.AggiungiPianeta.Size = new System.Drawing.Size(100, 23);
            this.AggiungiPianeta.TabIndex = 8;
            this.AggiungiPianeta.Text = "Aggiungi Pianeta";
            this.AggiungiPianeta.UseVisualStyleBackColor = true;
            // 
            // ListPlanetario
            // 
            this.ListPlanetario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPlanetario.FormattingEnabled = true;
            this.ListPlanetario.ItemHeight = 25;
            this.ListPlanetario.Location = new System.Drawing.Point(1583, 264);
            this.ListPlanetario.Name = "ListPlanetario";
            this.ListPlanetario.Size = new System.Drawing.Size(274, 479);
            this.ListPlanetario.TabIndex = 9;
            // 
            // ModificaPianeta
            // 
            this.ModificaPianeta.Location = new System.Drawing.Point(970, 391);
            this.ModificaPianeta.Name = "ModificaPianeta";
            this.ModificaPianeta.Size = new System.Drawing.Size(100, 23);
            this.ModificaPianeta.TabIndex = 10;
            this.ModificaPianeta.Text = "Modifica Pianeta";
            this.ModificaPianeta.UseVisualStyleBackColor = true;
            // 
            // EliminaPianeta
            // 
            this.EliminaPianeta.Location = new System.Drawing.Point(970, 434);
            this.EliminaPianeta.Name = "EliminaPianeta";
            this.EliminaPianeta.Size = new System.Drawing.Size(100, 23);
            this.EliminaPianeta.TabIndex = 11;
            this.EliminaPianeta.Text = "Elimina Pianeta";
            this.EliminaPianeta.UseVisualStyleBackColor = true;
            // 
            // Avvia
            // 
            this.Avvia.Location = new System.Drawing.Point(1382, 53);
            this.Avvia.Name = "Avvia";
            this.Avvia.Size = new System.Drawing.Size(216, 38);
            this.Avvia.TabIndex = 0;
            this.Avvia.Text = "Avvia";
            this.Avvia.UseVisualStyleBackColor = true;
            this.Avvia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Impostazioni
            // 
            this.Impostazioni.Location = new System.Drawing.Point(1425, 97);
            this.Impostazioni.Name = "Impostazioni";
            this.Impostazioni.Size = new System.Drawing.Size(216, 42);
            this.Impostazioni.TabIndex = 12;
            this.Impostazioni.Text = "Impostazioni";
            this.Impostazioni.UseVisualStyleBackColor = true;
            // 
            // Pulisci
            // 
            this.Pulisci.Location = new System.Drawing.Point(1247, 536);
            this.Pulisci.Name = "Pulisci";
            this.Pulisci.Size = new System.Drawing.Size(216, 36);
            this.Pulisci.TabIndex = 13;
            this.Pulisci.Text = "Pulisci";
            this.Pulisci.UseVisualStyleBackColor = true;
            // 
            // txtVelocita
            // 
            this.txtVelocita.Location = new System.Drawing.Point(1489, 447);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(36, 20);
            this.txtVelocita.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1027);
            this.Controls.Add(this.txtVelocita);
            this.Controls.Add(this.Pulisci);
            this.Controls.Add(this.Impostazioni);
            this.Controls.Add(this.EliminaPianeta);
            this.Controls.Add(this.ModificaPianeta);
            this.Controls.Add(this.ListPlanetario);
            this.Controls.Add(this.AggiungiPianeta);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtMassa);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtDeltaT);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.Avvia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtDeltaT;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button AggiungiPianeta;
        private System.Windows.Forms.ListBox ListPlanetario;
        private System.Windows.Forms.Button ModificaPianeta;
        private System.Windows.Forms.Button EliminaPianeta;
        private System.Windows.Forms.Button Avvia;
        private System.Windows.Forms.Button Impostazioni;
        private System.Windows.Forms.Button Pulisci;
        private System.Windows.Forms.TextBox txtVelocita;
    }
}

