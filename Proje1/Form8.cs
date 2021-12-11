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
    public partial class Form8 : System.Windows.Forms.Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dizgi1 = Convert.ToString(girdi1.Text);
            string dizgi2 = Convert.ToString(girdi2.Text);

            char[] dizi1 = dizgi1.ToCharArray();
            char[] dizi2 = dizgi2.ToCharArray();

            int dizi1Length = dizi1.GetLength(0);
            int dizi2Length = dizi2.GetLength(0);

            int kontrol = 0;

            int son_bas2 = dizi2Length - dizi1Length;
            int i = 0;



            for (; (i < dizi1Length) && kontrol == 0; i++)
            {
                if (((dizi1[i]) == (dizi2[i])) && (i == dizi1Length - 1))
                {
                    cikti1.Text = "ÖN EK";
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $" Ön ek veya art ek mi? :{girdi1.Text}  {girdi2.Text}  \n  ÖN EK \n");
                    kontrol = 1;
                    break;
                }
                else if ((dizi1[i]) != (dizi2[i]))
                    break;
            }

            for (i = 0; (i < dizi1Length) && kontrol == 0; i++, son_bas2++)
            {
                if (((dizi1[i]) == (dizi2[son_bas2])) && (i == dizi1Length - 1))
                {
                    cikti1.Text = "ART EK";
                    System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $" Ön ek veya art ek mi? :{girdi1.Text}  {girdi2.Text}  \n ARKA EK \n");
                    kontrol = 1;
                    break;
                }
                else if ((dizi1[i]) != (dizi2[son_bas2]))

                    break;
            }
            if (kontrol == 0) { cikti1.Text = "HİÇBİRİ DEĞİL";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"Ön ek veya art ek mi? : {girdi1.Text}  {girdi2.Text}  \n  HİÇBİRİ DEĞİL \n");
            }
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
