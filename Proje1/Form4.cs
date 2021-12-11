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
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            string value = dizgi2.Text; //Değerimizi alalim.
            for (int length = 1; length < value.Length; length++)
            {
                // bitiş indexi biraz zor.
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    if(substring == dizgi1.Text ) { kontrol = 1; }
                }
            }
            if (kontrol == 1) { cikti1.Text = "ALTDİZGİ";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $"ALTDİZGİ Mİ ?  : {dizgi1.Text}  {dizgi2.Text}  \n  ALTDİZGİ \n");
            }
            else {  cikti1.Text = "ALTDİZGİ DEĞİLDİR";
                System.IO.File.AppendAllText(Application.StartupPath + "\\kayıt.txt", $" ALTDİZGİ Mİ ?  : {dizgi1.Text}  {dizgi2.Text}  \n  ALTDİZGİ DEĞİLDİR \n");
            }

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
