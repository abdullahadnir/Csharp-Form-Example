namespace Proje1
{
    partial class Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buton1 = new System.Windows.Forms.Button();
            this.buton2 = new System.Windows.Forms.Button();
            this.buton3 = new System.Windows.Forms.Button();
            this.buton4 = new System.Windows.Forms.Button();
            this.buton5 = new System.Windows.Forms.Button();
            this.buton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buton1
            // 
            this.buton1.Location = new System.Drawing.Point(25, 22);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(193, 71);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "Üçgen mi? ";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click_1);
            // 
            // buton2
            // 
            this.buton2.Location = new System.Drawing.Point(25, 123);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(193, 70);
            this.buton2.TabIndex = 1;
            this.buton2.Text = "Kare mi? ";
            this.buton2.UseVisualStyleBackColor = true;
            this.buton2.Click += new System.EventHandler(this.buton2_Click_1);
            // 
            // buton3
            // 
            this.buton3.Location = new System.Drawing.Point(25, 229);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(193, 76);
            this.buton3.TabIndex = 2;
            this.buton3.Text = "Kağıt-Taş-Makas oyunu";
            this.buton3.UseVisualStyleBackColor = true;
            this.buton3.Click += new System.EventHandler(this.buton3_Click);
            // 
            // buton4
            // 
            this.buton4.Location = new System.Drawing.Point(25, 349);
            this.buton4.Name = "buton4";
            this.buton4.Size = new System.Drawing.Size(193, 74);
            this.buton4.TabIndex = 3;
            this.buton4.Text = "Altdizgi mi?";
            this.buton4.UseVisualStyleBackColor = true;
            this.buton4.Click += new System.EventHandler(this.buton4_Click);
            // 
            // buton5
            // 
            this.buton5.Location = new System.Drawing.Point(25, 465);
            this.buton5.Name = "buton5";
            this.buton5.Size = new System.Drawing.Size(193, 75);
            this.buton5.TabIndex = 4;
            this.buton5.Text = " Ön ek veya art ek mi?";
            this.buton5.UseVisualStyleBackColor = true;
            this.buton5.Click += new System.EventHandler(this.buton5_Click);
            // 
            // buton6
            // 
            this.buton6.BackColor = System.Drawing.Color.Red;
            this.buton6.Location = new System.Drawing.Point(768, 492);
            this.buton6.Name = "buton6";
            this.buton6.Size = new System.Drawing.Size(193, 77);
            this.buton6.TabIndex = 5;
            this.buton6.Text = " Çıkış ve formu sonlandırma (forma ait pencere kapanacaktır)";
            this.buton6.UseVisualStyleBackColor = false;
            this.buton6.Click += new System.EventHandler(this.buton6_Click);
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.Controls.Add(this.buton6);
            this.Controls.Add(this.buton5);
            this.Controls.Add(this.buton4);
            this.Controls.Add(this.buton3);
            this.Controls.Add(this.buton2);
            this.Controls.Add(this.buton1);
            this.Name = "Form";
            this.Text = "GİRİŞ EKRANI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Button buton3;
        private System.Windows.Forms.Button buton4;
        private System.Windows.Forms.Button buton5;
        private System.Windows.Forms.Button buton6;
    }
}

