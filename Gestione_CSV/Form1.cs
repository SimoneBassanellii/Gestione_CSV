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
        public int a;
        public Form1()
        {
            InitializeComponent();
            VisualizzaCSV();
            a = 0;

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
        public int Lunghezzamassimacampi()
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

                return max;
            }
        }

        private void Lunghezzacampi_Click(object sender, EventArgs e)
        {
           int a = Lunghezzamassimacampi();
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

        #region Funzione 4
        //inserire in ogni record un numero di spazi necessari a rendere fissa la dimensione di tutti i record, senza perdere informazioni, la dimensione viene presa dalla righa più lunga del csv. usando il comando padright
        public void Dimfissal(int lmax)
        {
            int dim = 0;
            string[] ele = new string[600];
            using (StreamReader sr = new StreamReader(FileName)) 
            {
                string b = sr.ReadLine();

                string y = "";

                while (b != null)
                {
                    int dif = lmax - b.Length;
                    for (int i = 0; i < dif; i++)
                    {
                        y = y + ".";
                    }
                    ele[dim] = b+y;

                     b = sr.ReadLine();
                    dim++;
                }

                sr.Close();
            }
          
    

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                dim = 0;

                while (ele[dim]!= null)
                {
                    sw.WriteLine(ele[dim]);
                    dim++;
                }
            }
        }
              
        private void Dimfissa_Click(object sender, EventArgs e)
        {
            Dimfissal(a);
        }
        #endregion

        #region Funzione 6
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
