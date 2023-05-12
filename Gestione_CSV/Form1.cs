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

namespace Gestione_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public string FileName = @"bassanelli.csv";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Random rnd = new Random();

        private void Aggiunta_mio_valore_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(FileName);
            //string vs = sr.ReadLine();
            string[] lines = File.ReadAllLines(FileName);
           
            
            StreamWriter writer = new StreamWriter(FileName);
            for (int i = 0; i < lines.Length; i++)
            {
                writer.WriteLine(lines[i] + ";" + rnd.Next(10,21)+";0");
            }
            writer.Close();
        }



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

                listView1.Items.Add(n.ToString());
            }
        }
    }
}
