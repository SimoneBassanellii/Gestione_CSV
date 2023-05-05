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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Carica il file CSV
        public string FileName = @"bassanelli.csv";

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
    }
}
