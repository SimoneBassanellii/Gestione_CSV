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
            this.listView1 = new System.Windows.Forms.ListView();
            this.BNCam = new System.Windows.Forms.Button();
            this.Lunghezzacampi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aggiunta_mio_valore
            // 
            this.Aggiunta_mio_valore.Location = new System.Drawing.Point(38, 34);
            this.Aggiunta_mio_valore.Name = "Aggiunta_mio_valore";
            this.Aggiunta_mio_valore.Size = new System.Drawing.Size(188, 32);
            this.Aggiunta_mio_valore.TabIndex = 0;
            this.Aggiunta_mio_valore.Text = "Aggiunta mio valore";
            this.Aggiunta_mio_valore.UseVisualStyleBackColor = true;
            this.Aggiunta_mio_valore.Click += new System.EventHandler(this.Aggiunta_mio_valore_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(867, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 576);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BNCam
            // 
            this.BNCam.Location = new System.Drawing.Point(38, 90);
            this.BNCam.Name = "BNCam";
            this.BNCam.Size = new System.Drawing.Size(188, 32);
            this.BNCam.TabIndex = 2;
            this.BNCam.Text = "Numero campi";
            this.BNCam.UseVisualStyleBackColor = true;
            this.BNCam.Click += new System.EventHandler(this.BNCam_Click);
            // 
            // Lunghezzacampi
            // 
            this.Lunghezzacampi.AutoSize = true;
            this.Lunghezzacampi.Location = new System.Drawing.Point(38, 146);
            this.Lunghezzacampi.Name = "Lunghezzacampi";
            this.Lunghezzacampi.Size = new System.Drawing.Size(188, 32);
            this.Lunghezzacampi.TabIndex = 3;
            this.Lunghezzacampi.Text = "Lunghezza campi";
            this.Lunghezzacampi.UseVisualStyleBackColor = true;
            this.Lunghezzacampi.Click += new System.EventHandler(this.Lunghezzacampi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 653);
            this.Controls.Add(this.Lunghezzacampi);
            this.Controls.Add(this.BNCam);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Aggiunta_mio_valore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aggiunta_mio_valore;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BNCam;
        private System.Windows.Forms.Button Lunghezzacampi;
    }
}

