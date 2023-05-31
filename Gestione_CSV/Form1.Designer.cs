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
            this.components = new System.ComponentModel.Container();
            this.Aggiunta_mio_valore = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BNCam = new System.Windows.Forms.Button();
            this.Lunghezzacampi = new System.Windows.Forms.Button();
            this.Dimfissa = new System.Windows.Forms.Button();
            this.Significativi = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.comunetextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.provinciatextBox2 = new System.Windows.Forms.TextBox();
            this.latitutinetextBox9 = new System.Windows.Forms.TextBox();
            this.longitudinetextBox8 = new System.Windows.Forms.TextBox();
            this.identificatoretextBox7 = new System.Windows.Forms.TextBox();
            this.annotextBox5 = new System.Windows.Forms.TextBox();
            this.nometextBox4 = new System.Windows.Forms.TextBox();
            this.regionetextBox3 = new System.Windows.Forms.TextBox();
            this.comune = new System.Windows.Forms.Label();
            this.provincia = new System.Windows.Forms.Label();
            this.regione = new System.Windows.Forms.Label();
            this.anno = new System.Windows.Forms.Label();
            this.identificatore = new System.Windows.Forms.Label();
            this.longitudine = new System.Windows.Forms.Label();
            this.Latitudine = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.recordcoda = new System.Windows.Forms.Button();
            this.datatextBox6 = new System.Windows.Forms.TextBox();
            this.dataora = new System.Windows.Forms.Label();
            this.ricerca = new System.Windows.Forms.Button();
            this.ricercatextBox10 = new System.Windows.Forms.TextBox();
            this.canclogicatextBox11 = new System.Windows.Forms.TextBox();
            this.canclogica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modificatextBox12 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aggiunta_mio_valore
            // 
            this.Aggiunta_mio_valore.Location = new System.Drawing.Point(45, 111);
            this.Aggiunta_mio_valore.Margin = new System.Windows.Forms.Padding(4);
            this.Aggiunta_mio_valore.Name = "Aggiunta_mio_valore";
            this.Aggiunta_mio_valore.Size = new System.Drawing.Size(251, 39);
            this.Aggiunta_mio_valore.TabIndex = 0;
            this.Aggiunta_mio_valore.Text = "Aggiunta mio valore";
            this.Aggiunta_mio_valore.UseVisualStyleBackColor = true;
            this.Aggiunta_mio_valore.Click += new System.EventHandler(this.Aggiunta_mio_valore_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(998, 42);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(978, 1086);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BNCam
            // 
            this.BNCam.Location = new System.Drawing.Point(45, 180);
            this.BNCam.Margin = new System.Windows.Forms.Padding(4);
            this.BNCam.Name = "BNCam";
            this.BNCam.Size = new System.Drawing.Size(251, 39);
            this.BNCam.TabIndex = 2;
            this.BNCam.Text = "Numero campi";
            this.BNCam.UseVisualStyleBackColor = true;
            this.BNCam.Click += new System.EventHandler(this.BNCam_Click);
            // 
            // Lunghezzacampi
            // 
            this.Lunghezzacampi.AutoSize = true;
            this.Lunghezzacampi.Location = new System.Drawing.Point(45, 249);
            this.Lunghezzacampi.Margin = new System.Windows.Forms.Padding(4);
            this.Lunghezzacampi.Name = "Lunghezzacampi";
            this.Lunghezzacampi.Size = new System.Drawing.Size(251, 39);
            this.Lunghezzacampi.TabIndex = 3;
            this.Lunghezzacampi.Text = "Lunghezza campi";
            this.Lunghezzacampi.UseVisualStyleBackColor = true;
            this.Lunghezzacampi.Click += new System.EventHandler(this.Lunghezzacampi_Click);
            // 
            // Dimfissa
            // 
            this.Dimfissa.Location = new System.Drawing.Point(45, 318);
            this.Dimfissa.Margin = new System.Windows.Forms.Padding(4);
            this.Dimfissa.Name = "Dimfissa";
            this.Dimfissa.Size = new System.Drawing.Size(251, 39);
            this.Dimfissa.TabIndex = 4;
            this.Dimfissa.Text = "Dimensione fissa";
            this.Dimfissa.UseVisualStyleBackColor = true;
            this.Dimfissa.Click += new System.EventHandler(this.Dimfissa_Click);
            // 
            // Significativi
            // 
            this.Significativi.Location = new System.Drawing.Point(326, 42);
            this.Significativi.Margin = new System.Windows.Forms.Padding(4);
            this.Significativi.Name = "Significativi";
            this.Significativi.Size = new System.Drawing.Size(251, 39);
            this.Significativi.TabIndex = 5;
            this.Significativi.Text = "Campi significativi";
            this.Significativi.UseVisualStyleBackColor = true;
            this.Significativi.Click += new System.EventHandler(this.Significativi_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(45, 42);
            this.reload.Margin = new System.Windows.Forms.Padding(4);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(251, 39);
            this.reload.TabIndex = 7;
            this.reload.Text = "Refresh LIstView";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // comunetextBox1
            // 
            this.comunetextBox1.Location = new System.Drawing.Point(45, 439);
            this.comunetextBox1.Multiline = true;
            this.comunetextBox1.Name = "comunetextBox1";
            this.comunetextBox1.Size = new System.Drawing.Size(251, 22);
            this.comunetextBox1.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // provinciatextBox2
            // 
            this.provinciatextBox2.Location = new System.Drawing.Point(45, 477);
            this.provinciatextBox2.Multiline = true;
            this.provinciatextBox2.Name = "provinciatextBox2";
            this.provinciatextBox2.Size = new System.Drawing.Size(251, 22);
            this.provinciatextBox2.TabIndex = 10;
            // 
            // latitutinetextBox9
            // 
            this.latitutinetextBox9.Location = new System.Drawing.Point(45, 742);
            this.latitutinetextBox9.Name = "latitutinetextBox9";
            this.latitutinetextBox9.Size = new System.Drawing.Size(251, 22);
            this.latitutinetextBox9.TabIndex = 11;
            this.latitutinetextBox9.TextChanged += new System.EventHandler(this.latidutinetextBox9_TextChanged);
            // 
            // longitudinetextBox8
            // 
            this.longitudinetextBox8.Location = new System.Drawing.Point(45, 705);
            this.longitudinetextBox8.Name = "longitudinetextBox8";
            this.longitudinetextBox8.Size = new System.Drawing.Size(251, 22);
            this.longitudinetextBox8.TabIndex = 12;
            // 
            // identificatoretextBox7
            // 
            this.identificatoretextBox7.Location = new System.Drawing.Point(45, 667);
            this.identificatoretextBox7.Name = "identificatoretextBox7";
            this.identificatoretextBox7.Size = new System.Drawing.Size(251, 22);
            this.identificatoretextBox7.TabIndex = 13;
            // 
            // annotextBox5
            // 
            this.annotextBox5.Location = new System.Drawing.Point(45, 591);
            this.annotextBox5.Multiline = true;
            this.annotextBox5.Name = "annotextBox5";
            this.annotextBox5.Size = new System.Drawing.Size(251, 22);
            this.annotextBox5.TabIndex = 14;
            // 
            // nometextBox4
            // 
            this.nometextBox4.Location = new System.Drawing.Point(45, 553);
            this.nometextBox4.Multiline = true;
            this.nometextBox4.Name = "nometextBox4";
            this.nometextBox4.Size = new System.Drawing.Size(251, 22);
            this.nometextBox4.TabIndex = 15;
            // 
            // regionetextBox3
            // 
            this.regionetextBox3.Location = new System.Drawing.Point(45, 515);
            this.regionetextBox3.Multiline = true;
            this.regionetextBox3.Name = "regionetextBox3";
            this.regionetextBox3.Size = new System.Drawing.Size(251, 22);
            this.regionetextBox3.TabIndex = 16;
            // 
            // comune
            // 
            this.comune.AutoSize = true;
            this.comune.Location = new System.Drawing.Point(323, 445);
            this.comune.Name = "comune";
            this.comune.Size = new System.Drawing.Size(57, 16);
            this.comune.TabIndex = 17;
            this.comune.Text = "Comune";
            // 
            // provincia
            // 
            this.provincia.AutoSize = true;
            this.provincia.Location = new System.Drawing.Point(323, 483);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(63, 16);
            this.provincia.TabIndex = 18;
            this.provincia.Text = "Provincia";
            // 
            // regione
            // 
            this.regione.AutoSize = true;
            this.regione.Location = new System.Drawing.Point(323, 521);
            this.regione.Name = "regione";
            this.regione.Size = new System.Drawing.Size(59, 16);
            this.regione.TabIndex = 19;
            this.regione.Text = "Regione";
            // 
            // anno
            // 
            this.anno.AutoSize = true;
            this.anno.Location = new System.Drawing.Point(323, 597);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(121, 16);
            this.anno.TabIndex = 21;
            this.anno.Text = "Anno d\'inserimento";
            // 
            // identificatore
            // 
            this.identificatore.AutoSize = true;
            this.identificatore.Location = new System.Drawing.Point(323, 673);
            this.identificatore.Name = "identificatore";
            this.identificatore.Size = new System.Drawing.Size(181, 16);
            this.identificatore.TabIndex = 22;
            this.identificatore.Text = "Identificatore OpenStreatMap";
            // 
            // longitudine
            // 
            this.longitudine.AutoSize = true;
            this.longitudine.Location = new System.Drawing.Point(323, 711);
            this.longitudine.Name = "longitudine";
            this.longitudine.Size = new System.Drawing.Size(76, 16);
            this.longitudine.TabIndex = 23;
            this.longitudine.Text = "Longitudine";
            // 
            // Latitudine
            // 
            this.Latitudine.AutoSize = true;
            this.Latitudine.Location = new System.Drawing.Point(323, 748);
            this.Latitudine.Name = "Latitudine";
            this.Latitudine.Size = new System.Drawing.Size(69, 16);
            this.Latitudine.TabIndex = 24;
            this.Latitudine.Text = "Latidudine";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(323, 559);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(44, 16);
            this.nome.TabIndex = 25;
            this.nome.Text = "Nome";
            // 
            // recordcoda
            // 
            this.recordcoda.Location = new System.Drawing.Point(45, 378);
            this.recordcoda.Margin = new System.Windows.Forms.Padding(4);
            this.recordcoda.Name = "recordcoda";
            this.recordcoda.Size = new System.Drawing.Size(251, 39);
            this.recordcoda.TabIndex = 26;
            this.recordcoda.Text = "Aggiungi record in coda ";
            this.recordcoda.UseVisualStyleBackColor = true;
            this.recordcoda.Click += new System.EventHandler(this.recordcoda_Click);
            // 
            // datatextBox6
            // 
            this.datatextBox6.Location = new System.Drawing.Point(45, 629);
            this.datatextBox6.Name = "datatextBox6";
            this.datatextBox6.Size = new System.Drawing.Size(251, 22);
            this.datatextBox6.TabIndex = 27;
            // 
            // dataora
            // 
            this.dataora.AutoSize = true;
            this.dataora.Location = new System.Drawing.Point(323, 635);
            this.dataora.Name = "dataora";
            this.dataora.Size = new System.Drawing.Size(73, 16);
            this.dataora.TabIndex = 28;
            this.dataora.Text = "Data e ora ";
            // 
            // ricerca
            // 
            this.ricerca.Location = new System.Drawing.Point(326, 111);
            this.ricerca.Margin = new System.Windows.Forms.Padding(4);
            this.ricerca.Name = "ricerca";
            this.ricerca.Size = new System.Drawing.Size(251, 39);
            this.ricerca.TabIndex = 29;
            this.ricerca.Text = "Ricerca ";
            this.ricerca.UseVisualStyleBackColor = true;
            this.ricerca.Click += new System.EventHandler(this.ricerca_Click);
            // 
            // ricercatextBox10
            // 
            this.ricercatextBox10.Location = new System.Drawing.Point(326, 157);
            this.ricercatextBox10.Multiline = true;
            this.ricercatextBox10.Name = "ricercatextBox10";
            this.ricercatextBox10.Size = new System.Drawing.Size(251, 22);
            this.ricercatextBox10.TabIndex = 30;
            // 
            // canclogicatextBox11
            // 
            this.canclogicatextBox11.Location = new System.Drawing.Point(326, 251);
            this.canclogicatextBox11.Multiline = true;
            this.canclogicatextBox11.Name = "canclogicatextBox11";
            this.canclogicatextBox11.Size = new System.Drawing.Size(251, 22);
            this.canclogicatextBox11.TabIndex = 32;
            // 
            // canclogica
            // 
            this.canclogica.Location = new System.Drawing.Point(326, 205);
            this.canclogica.Margin = new System.Windows.Forms.Padding(4);
            this.canclogica.Name = "canclogica";
            this.canclogica.Size = new System.Drawing.Size(251, 39);
            this.canclogica.TabIndex = 31;
            this.canclogica.Text = "Cancellazione logica";
            this.canclogica.UseVisualStyleBackColor = true;
            this.canclogica.Click += new System.EventHandler(this.canclogica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Inserire l\'identificatoren di OpenStreamMAp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Inserire il primo campo";
            // 
            // modificatextBox12
            // 
            this.modificatextBox12.Location = new System.Drawing.Point(326, 346);
            this.modificatextBox12.Multiline = true;
            this.modificatextBox12.Name = "modificatextBox12";
            this.modificatextBox12.Size = new System.Drawing.Size(251, 22);
            this.modificatextBox12.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Modifica ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.modificatextBox12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canclogicatextBox11);
            this.Controls.Add(this.canclogica);
            this.Controls.Add(this.ricercatextBox10);
            this.Controls.Add(this.ricerca);
            this.Controls.Add(this.dataora);
            this.Controls.Add(this.datatextBox6);
            this.Controls.Add(this.recordcoda);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Latitudine);
            this.Controls.Add(this.longitudine);
            this.Controls.Add(this.identificatore);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.regione);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.comune);
            this.Controls.Add(this.regionetextBox3);
            this.Controls.Add(this.nometextBox4);
            this.Controls.Add(this.annotextBox5);
            this.Controls.Add(this.identificatoretextBox7);
            this.Controls.Add(this.longitudinetextBox8);
            this.Controls.Add(this.latitutinetextBox9);
            this.Controls.Add(this.provinciatextBox2);
            this.Controls.Add(this.comunetextBox1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.Significativi);
            this.Controls.Add(this.Dimfissa);
            this.Controls.Add(this.Lunghezzacampi);
            this.Controls.Add(this.BNCam);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Aggiunta_mio_valore);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button Dimfissa;
        private System.Windows.Forms.Button Significativi;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.TextBox comunetextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox provinciatextBox2;
        private System.Windows.Forms.TextBox latitutinetextBox9;
        private System.Windows.Forms.TextBox longitudinetextBox8;
        private System.Windows.Forms.TextBox identificatoretextBox7;
        private System.Windows.Forms.TextBox annotextBox5;
        private System.Windows.Forms.TextBox nometextBox4;
        private System.Windows.Forms.TextBox regionetextBox3;
        private System.Windows.Forms.Label comune;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.Label regione;
        private System.Windows.Forms.Label anno;
        private System.Windows.Forms.Label identificatore;
        private System.Windows.Forms.Label longitudine;
        private System.Windows.Forms.Label Latitudine;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Button recordcoda;
        private System.Windows.Forms.TextBox datatextBox6;
        private System.Windows.Forms.Label dataora;
        private System.Windows.Forms.Button ricerca;
        private System.Windows.Forms.TextBox ricercatextBox10;
        private System.Windows.Forms.TextBox canclogicatextBox11;
        private System.Windows.Forms.Button canclogica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modificatextBox12;
        private System.Windows.Forms.Button button1;
    }
}

