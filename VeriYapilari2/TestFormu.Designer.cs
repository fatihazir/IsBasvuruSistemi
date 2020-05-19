namespace VeriYapilari2
{
    partial class TestFormu
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
            this.btnSirketIlanTest = new System.Windows.Forms.Button();
            this.btnSirketCekmeTesti = new System.Windows.Forms.Button();
            this.btnKisiCekmeTesti = new System.Windows.Forms.Button();
            this.BtnAraDugumEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSirketIlanTest
            // 
            this.btnSirketIlanTest.Location = new System.Drawing.Point(115, 54);
            this.btnSirketIlanTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSirketIlanTest.Name = "btnSirketIlanTest";
            this.btnSirketIlanTest.Size = new System.Drawing.Size(373, 41);
            this.btnSirketIlanTest.TabIndex = 0;
            this.btnSirketIlanTest.Text = "Sirketin birden fazla ilanı olabilir test";
            this.btnSirketIlanTest.UseVisualStyleBackColor = true;
            this.btnSirketIlanTest.Click += new System.EventHandler(this.btnSirketIlanTest_Click);
            // 
            // btnSirketCekmeTesti
            // 
            this.btnSirketCekmeTesti.Location = new System.Drawing.Point(115, 158);
            this.btnSirketCekmeTesti.Margin = new System.Windows.Forms.Padding(2);
            this.btnSirketCekmeTesti.Name = "btnSirketCekmeTesti";
            this.btnSirketCekmeTesti.Size = new System.Drawing.Size(373, 41);
            this.btnSirketCekmeTesti.TabIndex = 2;
            this.btnSirketCekmeTesti.Text = "Txt db sirket cekme tesi";
            this.btnSirketCekmeTesti.UseVisualStyleBackColor = true;
            this.btnSirketCekmeTesti.Click += new System.EventHandler(this.btnSirketCekmeTesti_Click);
            // 
            // btnKisiCekmeTesti
            // 
            this.btnKisiCekmeTesti.Location = new System.Drawing.Point(115, 212);
            this.btnKisiCekmeTesti.Margin = new System.Windows.Forms.Padding(2);
            this.btnKisiCekmeTesti.Name = "btnKisiCekmeTesti";
            this.btnKisiCekmeTesti.Size = new System.Drawing.Size(373, 41);
            this.btnKisiCekmeTesti.TabIndex = 3;
            this.btnKisiCekmeTesti.Text = "Txt db kisi cekme tesi";
            this.btnKisiCekmeTesti.UseVisualStyleBackColor = true;
            this.btnKisiCekmeTesti.Click += new System.EventHandler(this.btnKisiCekmeTesti_Click);
            // 
            // BtnAraDugumEkle
            // 
            this.BtnAraDugumEkle.Location = new System.Drawing.Point(115, 282);
            this.BtnAraDugumEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAraDugumEkle.Name = "BtnAraDugumEkle";
            this.BtnAraDugumEkle.Size = new System.Drawing.Size(373, 41);
            this.BtnAraDugumEkle.TabIndex = 4;
            this.BtnAraDugumEkle.Text = "Txt db kisi cekme tesi";
            this.BtnAraDugumEkle.UseVisualStyleBackColor = true;
            this.BtnAraDugumEkle.Click += new System.EventHandler(this.BtnAraDugumEkle_Click_);
            // 
            // TestFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnAraDugumEkle);
            this.Controls.Add(this.btnKisiCekmeTesti);
            this.Controls.Add(this.btnSirketCekmeTesti);
            this.Controls.Add(this.btnSirketIlanTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestFormu";
            this.Text = "TestFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSirketIlanTest;
        private System.Windows.Forms.Button btnSirketCekmeTesti;
        private System.Windows.Forms.Button btnKisiCekmeTesti;
        private System.Windows.Forms.Button BtnAraDugumEkle;
    }
}