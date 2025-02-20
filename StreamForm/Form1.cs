using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader Arq = new StreamReader(openFileDialog1.FileName);
                this.Text = openFileDialog1.FileName;
                string[] str = { Arq.ReadToEnd() };
                textBox1.Lines = str;
                Arq.Close();
            }
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Arq = new StreamWriter(saveFileDialog1.FileName);
                foreach(string s in textBox1.Lines)
                {
                    Arq.WriteLine(s);
                }
                Arq.Close();
                
            }
        }
    }
}
