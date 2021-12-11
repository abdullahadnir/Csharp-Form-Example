namespace Proje1
{
    partial class Form1
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
            this.girdi3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cikti1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girdi1
            // 
            this.girdi1.Location = new System.Drawing.Point(160, 38);
            this.girdi1.Name = "girdi1";
            this.girdi1.Size = new System.Drawing.Size(46, 20);
            this.girdi1.TabIndex = 0;
            // 
            // girdi2
            // 
            this.girdi2.Location = new System.Drawing.Point(161, 82);
            this.girdi2.Name = "girdi2";
            this.girdi2.Size = new System.Drawing.Size(45, 20);
            this.girdi2.TabIndex = 1;
            // 
            // girdi3
            // 
            this.girdi3.Location = new System.Drawing.Point(161, 129);
            this.girdi3.Name = "girdi3";
            this.girdi3.Size = new System.Drawing.Size(45, 20);
            this.girdi3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikti1
            // 
            this.cikti1.Location = new System.Drawing.Point(513, 84);
            this.cikti1.Name = "cikti1";
            this.cikti1.Size = new System.Drawing.Size(196, 20);
            this.cikti1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. kenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. kenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. kenar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SONUÇ =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cikti1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girdi3);
            this.Controls.Add(this.girdi2);
            this.Controls.Add(this.girdi1);
            this.Name = "Form1";
            this.Text = "Üçgen Mi ?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox girdi1;
        private System.Windows.Forms.TextBox girdi2;
        private System.Windows.Forms.TextBox girdi3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cikti1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}