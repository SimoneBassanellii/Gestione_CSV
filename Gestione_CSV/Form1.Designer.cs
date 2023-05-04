namespace Gestione_CSV
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
            this.Aggiunta_mio_valore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aggiunta_mio_valore
            // 
            this.Aggiunta_mio_valore.Location = new System.Drawing.Point(38, 34);
            this.Aggiunta_mio_valore.Name = "Aggiunta_mio_valore";
            this.Aggiunta_mio_valore.Size = new System.Drawing.Size(114, 32);
            this.Aggiunta_mio_valore.TabIndex = 0;
            this.Aggiunta_mio_valore.Text = "Aggiunta mio valore";
            this.Aggiunta_mio_valore.UseVisualStyleBackColor = true;
            this.Aggiunta_mio_valore.Click += new System.EventHandler(this.Aggiunta_mio_valore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aggiunta_mio_valore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aggiunta_mio_valore;
    }
}

