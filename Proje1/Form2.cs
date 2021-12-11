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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(girdi1.Text);
            int b;
            b = Convert.ToInt32(girdi2.Text);
            int alan = (int)Math.Pow(a, 2);
            if (a <= 0 || b <= 0) { cikti1.Text = "GİRDİ HATASI";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"KARE Mİ ? : {girdi1.Text}  {girdi2.Text}  \n GİRDİ HATASI \n");
            }
            else
            {
                if (b == alan)
                { cikti1.Text = ("KARE");
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $" KARE Mİ ? :{girdi1.Text}  {girdi2.Text}  \n  KARE \n");
                }
                else { cikti1.Text = ("KARE DEĞİL");
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $" KARE Mİ ? :{girdi1.Text}  {girdi2.Text}  \n  KARE DEĞİL \n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
