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
//using static System.Net.WebRequestMethods;

namespace Gestione_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VisualizzaCSV();
        }

        public string FileName = @"../../bassanelli.csv";
        public string Filename2 = @"../../bassanelli2.csv";

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

        #region Funzione 1 aggiunta mio valore
        private void Aggiunta_mio_valore_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(FileName);
            //string vs = sr.ReadLine();
            string[] lines = File.ReadAllLines(FileName);

            StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine(lines[0] + ";" + "Mio valore");
            for (int i = 0; i < lines.Length; i++)
            {
                writer.WriteLine(lines[i] + ";" + rnd.Next(10, 21)+";1");
            }
            writer.Close();
        }
        #endregion

        #region Funzione 2 conta campi

        private void BNCam_Click(object sender, EventArgs e)
        {
            ContaCampi();
        }

        public void ContaCampi()
        {
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

        #region Funzione 3 calcolare la lunghezza massima dei record presenti 
        public int Lunghezzamassimacampi()
        {
            int max = 0;
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

        #region Funzione 4 dimensione fissa 
        public void DimFissa()
        {
            string s;
            int i = 0;
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter("bassanelli2.csv");

          
            s = reader.ReadLine();
            while (s != null)
            {
                if (i != 0)
                {
                    writer.WriteLine(s.PadRight(300));
                }
                else
                {
                    writer.WriteLine(s);
                }

                s = reader.ReadLine();
                i++;
            }

            reader.Close();
            writer.Close();

            File.Replace("bassanelli2.csv", FileName, "prova.csv");
        }

        private void Dimfissa_Click(object sender, EventArgs e)
        {
            DimFissa();
        }
        #endregion

        #region Funzione 5 Aggiungere un record in coda
        public void Recordcoda(string comunetextBox1, string provinciatextBox2, string regionetextBox3, string nometextBox4, string annotextBox5, string datatextBox6, string identificatoretextBox7, string longitudinetextBox8, string latitudinetextBox9)
        {
            StreamReader reader = new StreamReader(Filename2);
            StreamWriter writer = new StreamWriter(FileName);

            string s = reader.ReadLine();
            while (s != null)
            {
                writer.WriteLine(s);
                s = reader.ReadLine();
            }

            writer.WriteLine(comunetextBox1 + ";" + provinciatextBox2 + ";" + regionetextBox3 + ";" + nometextBox4 + ";" + annotextBox5 + ";" + datatextBox6 + ";" + identificatoretextBox7 + ";" + longitudinetextBox8 + ";" + latitudinetextBox9);
            
            reader.Close();
            writer.Close();
        }

        private void recordcoda_Click(object sender, EventArgs e)
        {
            Recordcoda(comunetextBox1.Text, provinciatextBox2.Text, regionetextBox3.Text, nometextBox4.Text, annotextBox5.Text, datatextBox6.Text, identificatoretextBox7.Text, longitudinetextBox8.Text, latitutinetextBox9.Text);
        }
        #endregion

        #region Funzione 6 campi signifiacativi
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

        #region Funzione 7 Ricerca per campo a scelta 
        public void RicercaPerCampo()
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
                    if (campi2[0] == ricercatextBox10.Text)
                    {
                        ListViewItem item = new ListViewItem(campi2[0]);
                        item.SubItems.Add(campi2[1]);
                        item.SubItems.Add(campi2[2]);
                        item.SubItems.Add(campi2[3]);
                        item.SubItems.Add(campi2[4]);
                        item.SubItems.Add(campi2[5]);
                        item.SubItems.Add(campi2[6]);
                        item.SubItems.Add(campi2[7]);
                        item.SubItems.Add(campi2[8]);
                        listView1.Items.Add(item);
                    }
                }
            }

        }
        private void ricerca_Click(object sender, EventArgs e)
        {
            RicercaPerCampo();
        }
        #endregion

        #region Funzione 9 Cancellazione logica di un record a scelta 
        public void CancLogica()
        {
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter("bassanelli2.csv");
            string s = reader.ReadLine();
            string a = "";
            while (s != null)
            {
                string[] campi = s.Split(';');
                if (campi[6] == canclogicatextBox11.Text)
                {
                    if (campi[campi.Length - 1] == "1")
                    {
                        for (int i = 0; i < campi.Length; i++)
                        {
                            if (i == campi.Length - 1)
                            {
                                s = s + campi[i];
                            }
                            else
                            {
                                s = s + campi[i] + ";";
                            }
                        }
                    }
                }     
                writer.WriteLine(s);
                s = reader.ReadLine();
            }
            reader.Close();
            writer.Close();
            File.Replace("bassanelli2.csv", FileName, "prova.csv");
        }
        
       

        private void canclogica_Click(object sender, EventArgs e)
        {
            CancLogica();
        }
        #endregion

        #region Funzioni extra
        private void Reload_Click(object sender, EventArgs e)
        {
            VisualizzaCSV();
        }
        #endregion

        private void latidutinetextBox9_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
