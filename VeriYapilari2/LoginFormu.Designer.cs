namespace VeriYapilari2
{
    partial class LoginFormu
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
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSirketGirisi = new System.Windows.Forms.Button();
            this.txtSirketSifre = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(180, 181);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(132, 22);
            this.txtTcNo.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(180, 230);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(132, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(180, 306);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(133, 55);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Kullaniciya Giris Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sirket adi";
            // 
            // btnSirketGirisi
            // 
            this.btnSirketGirisi.Location = new System.Drawing.Point(687, 306);
            this.btnSirketGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirketGirisi.Name = "btnSirketGirisi";
            this.btnSirketGirisi.Size = new System.Drawing.Size(133, 55);
            this.btnSirketGirisi.TabIndex = 12;
            this.btnSirketGirisi.Text = "Sirkete Giris Yap";
            this.btnSirketGirisi.UseVisualStyleBackColor = true;
            this.btnSirketGirisi.Click += new System.EventHandler(this.btnSirketGirisi_Click);
            // 
            // txtSirketSifre
            // 
            this.txtSirketSifre.Location = new System.Drawing.Point(687, 230);
            this.txtSirketSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketSifre.Name = "txtSirketSifre";
            this.txtSirketSifre.Size = new System.Drawing.Size(132, 22);
            this.txtSirketSifre.TabIndex = 11;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(687, 181);
            this.txtSirketAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(132, 22);
            this.txtSirketAdi.TabIndex = 10;
            // 
            // LoginFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSirketGirisi);
            this.Controls.Add(this.txtSirketSifre);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTcNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginFormu";
            this.Text = "LoginFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSirketGirisi;
        private System.Windows.Forms.TextBox txtSirketSifre;
        private System.Windows.Forms.TextBox txtSirketAdi;
    }
}