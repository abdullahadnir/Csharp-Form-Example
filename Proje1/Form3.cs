using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void tas1_Click(object sender, EventArgs e)
        {
            girdi1.Text = "Taş";
        }

        private void kagit1_Click(object sender, EventArgs e)
        {
            girdi1.Text = "Kağıt";
        }

        private void makas1_Click(object sender, EventArgs e)
        {
            girdi1.Text = "Makas";
        }

        private void tas2_Click(object sender, EventArgs e)
        {
            girdi2.Text = "Taş";
        }

        private void kagit2_Click(object sender, EventArgs e)
        {
            girdi2.Text = "Kağıt";
        }

        private void makas2_Click(object sender, EventArgs e)
        {
            girdi2.Text = "Makas";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((girdi1.Text == "Taş" && girdi2.Text == "Makas") || (girdi1.Text == "Kağıt" && girdi2.Text == "Taş") || (girdi1.Text == "Makas" && girdi2.Text == "Kağıt"))
            {
                cikti1.Text = " YENDİ ";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"TAŞ KAĞIT MAKAS OYUNU : {girdi1.Text}  {girdi2.Text}  \n  YENDİ \n");
            }
            else { cikti1.Text = " YENEMEDİ";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"TAŞ KAĞIT MAKAS OYUNU : {girdi1.Text}  {girdi2.Text}  \n YENEMEDİ \n");
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
