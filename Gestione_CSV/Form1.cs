using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace Gestione_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string FileName = @"../../bassanelli.csv";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();



        #region visulizzare il file CSV in una listview
        public void VisualizzaCSV()
        {
            listView1.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string a = sr.ReadLine();
                string[] campi = a.Split(';');
                for (int i = 0; i < campi.Length; i++)
                {
                    listView1.Columns.Add(campi[i]);
                }
                while (sr.Peek() != -1)
                {
                    string b = sr.ReadLine();
                    string[] campi2 = b.Split(';');
                    ListViewItem item = new ListViewItem(campi2);
                    listView1.Items.Add(item);
                }
            }
        }

        private void Visualizza_Click(object sender, EventArgs e)
        {
            VisualizzaCSV();
        }
        #endregion

        #region Funzione 1 
        private void Aggiunta_mio_valore_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(FileName);
            //string vs = sr.ReadLine();
            string[] lines = File.ReadAllLines(FileName);


            StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine(lines[0] + ";" + "Mio valore");
            for (int i = 0; i < lines.Length; i++)
            {
                writer.WriteLine(lines[i] + ";" + rnd.Next(10, 21)+";0");
            }
            writer.Close();
        }
        #endregion

        #region Funzione 2

        private void BNCam_Click(object sender, EventArgs e)
        {
            ContaCampi();
        }

        public void ContaCampi()
        {
            listView1.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                int n = 0;
                string a = sr.ReadLine();
                string[] campi = a.Split(';');
                for (int i = 0; i < campi.Length; i++)
                {
                    n++;
                }

                MessageBox.Show("Il numero di campi è " + (n.ToString()));
            }
        }

        #endregion

        #region Funzione 3
        public void Lunghezzamassimacampi()
        {
            int max = 0;
            listView1.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string a = sr.ReadLine();
                string[] campi = a.Split(';');
                for (int i = 0; i < campi.Length; i++)
                {
                    if (campi[i].Length > max)
                    {
                        max = campi[i].Length;
                    }
                }
                MessageBox.Show("La lunghezza massima dei campi è " + (max.ToString()));
            }
        }

        private void Lunghezzacampi_Click(object sender, EventArgs e)
        {
            Lunghezzamassimacampi();
        }
        #endregion
        /*
        public void RicercaElemento()
        {
            string elemento = textBox1.Text;
            using (StreamReader sr = new StreamReader(FileName))
            {
                string a = sr.ReadLine();
                string[] campi = a.Split(';');
                for (int i = 0; i < campi.Length; i++)
                {
                    if (campi[i] == elemento)
                    {
                        MessageBox.Show("L'elemento è stato trovato");
                    }
                }
            }
        }
        */


        //funzione per rendere la dimensione delle righe fissa andando a modificare il file originale inserendo dei punti per pareggiare la lunghezza, la lunghezza delle righe è data dalla riga più lnga nel file csv
        #region Funzione 4
        public int LunghezzaMassimaRiga()
        {
            int max = 0;
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (sr.Peek() != -1)
                {
                    string a = sr.ReadLine();
                    string[] campi = a.Split(';');
                    for (int i = 0; i < campi.Length; i++)
                    {
                        if (campi[i].Length > max)
                        {
                            max = campi[i].Length;
                        }
                    }
                }
            }
            return max;
        }
        







        private void Dimfissa_Click(object sender, EventArgs e)
        {
            LunghezzaMassimaRiga();       
        }
        #endregion

        #region Funzione 6
        //Visualizzare dei dati mostrando tre campi significativi a scelta comune provincia e identificatore nella view list;ù
        public void VisualizzaDatiSignificativi()
        {
            listView1.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string a = sr.ReadLine();
                string[] campi = a.Split(';');
                for (int i = 0; i < campi.Length; i++)
                {
                    listView1.Columns.Add(campi[i]);
                }
                while (sr.Peek() != -1)
                {
                    string b = sr.ReadLine();
                    string[] campi2 = b.Split(';');
                    ListViewItem item = new ListViewItem(campi2[0]);
                    item.SubItems.Add(campi2[2]);
                    item.SubItems.Add(campi2[6]);
                    listView1.Items.Add(item);
                }
            }
        }

        private void Significativi_Click(object sender, EventArgs e)
        {
            VisualizzaDatiSignificativi();
        }
        #endregion
    }
}
