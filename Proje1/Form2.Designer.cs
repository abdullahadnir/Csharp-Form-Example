namespace Proje1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.girdi1 = new System.Windows.Forms.TextBox();
            this.girdi2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cikti1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girdi1
            // 
            this.girdi1.Location = new System.Drawing.Point(147, 34);
            this.girdi1.Name = "girdi1";
            this.girdi1.Size = new System.Drawing.Size(103, 20);
            this.girdi1.TabIndex = 0;
            // 
            // girdi2
            // 
            this.girdi2.Location = new System.Drawing.Point(147, 78);
            this.girdi2.Name = "girdi2";
            this.girdi2.Size = new System.Drawing.Size(103, 20);
            this.girdi2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikti1
            // 
            this.cikti1.Location = new System.Drawing.Point(517, 57);
            this.cikti1.Name = "cikti1";
            this.cikti1.Size = new System.Drawing.Size(200, 20);
            this.cikti1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KENAR GİRİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ALAN GİRİNİZ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SONUÇ =";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cikti1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girdi2);
            this.Controls.Add(this.girdi1);
            this.Name = "Form2";
            this.Text = "Kare mi ?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox girdi1;
        private System.Windows.Forms.TextBox girdi2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cikti1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}