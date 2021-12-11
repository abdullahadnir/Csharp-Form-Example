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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(girdi1.Text);
            int b;
            b =  Convert.ToInt32(girdi2.Text);
            int c;
            c = Convert.ToInt32(girdi3.Text);
            if (a <= 0 || b <= 0 || c <= 0) { cikti1.Text = "GİRDİ HATASI";
              System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"ÜÇGEN Mİ ? : {girdi1.Text}  {girdi2.Text}  {girdi3.Text} \n GİRDİ HATASI \n");

            }
            else
            {
                if (a < (b + c) && b < (c + a) && c < (b + a))
                {
                    cikti1.Text = ("ÜÇGENDİR");
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"ÜÇGEN Mİ ? : {girdi1.Text} {girdi2.Text}  {girdi3.Text} \n  ÜÇGENDİR \n");
                }

                else
                {
                    cikti1.Text = ("ÜÇGEN DEĞİLDİR");
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"ÜÇGEN Mİ ? : {girdi1.Text}  {girdi2.Text}  {girdi3.Text} \n ÜÇGENDİR \n");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}


