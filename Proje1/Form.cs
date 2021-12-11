using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 190106109013 - ABDULLAH ADANIR  (1. Öğretim)
namespace Proje1
{

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //Form içinde form açılabilir yapıyoruz
        }

        private void buton1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();//açılacak form
            this.Hide();
            form1.Show(this); //form 1 açılıyor.
        }

        private void buton2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();//açılacak form
            this.Hide();
            form2.Show(this); //form 2 açılıyor.          
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();//açılacak form
            this.Hide();
            form3.Show(this); //form 3 açılıyor.         
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();//açılacak form
            this.Hide();
            form4.Show(this); //form 4 açılıyor.        
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();//açılacak form
            this.Hide();
            form8.Show(this); //form 8 açılıyor.
           
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\kayıt.txt"))
                System.IO.File.Delete(Application.StartupPath + "\\kayıt.txt");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\kayıt.txt"))
                System.Diagnostics.Process.Start(Application.StartupPath + "\\kayıt.txt");
        }
    }
}
