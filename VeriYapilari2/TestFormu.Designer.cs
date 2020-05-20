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
            this.btnAraDugumEkle = new System.Windows.Forms.Button();
            this.btnDugumAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnFatihTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSirketIlanTest
            // 
            this.btnSirketIlanTest.Location = new System.Drawing.Point(115, 54);
            this.btnSirketIlanTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSirketCekmeTesti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnKisiCekmeTesti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKisiCekmeTesti.Name = "btnKisiCekmeTesti";
            this.btnKisiCekmeTesti.Size = new System.Drawing.Size(373, 41);
            this.btnKisiCekmeTesti.TabIndex = 3;
            this.btnKisiCekmeTesti.Text = "Txt db kisi cekme tesi";
            this.btnKisiCekmeTesti.UseVisualStyleBackColor = true;
            this.btnKisiCekmeTesti.Click += new System.EventHandler(this.btnKisiCekmeTesti_Click);
            // 
            // btnAraDugumEkle
            // 
            this.btnAraDugumEkle.Location = new System.Drawing.Point(231, 263);
            this.btnAraDugumEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAraDugumEkle.Name = "btnAraDugumEkle";
            this.btnAraDugumEkle.Size = new System.Drawing.Size(113, 28);
            this.btnAraDugumEkle.TabIndex = 4;
            this.btnAraDugumEkle.Text = "Ağacı Ekle";
            this.btnAraDugumEkle.UseVisualStyleBackColor = true;
            this.btnAraDugumEkle.Click += new System.EventHandler(this.BtnAraDugumEkle_Click);
            // 
            // btnDugumAra
            // 
            this.btnDugumAra.Location = new System.Drawing.Point(349, 296);
            this.btnDugumAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDugumAra.Name = "btnDugumAra";
            this.btnDugumAra.Size = new System.Drawing.Size(56, 19);
            this.btnDugumAra.TabIndex = 5;
            this.btnDugumAra.Text = "Ara";
            this.btnDugumAra.UseVisualStyleBackColor = true;
            this.btnDugumAra.Click += new System.EventHandler(this.BtnDugumAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(231, 296);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(114, 20);
            this.txtAra.TabIndex = 6;
            // 
            // btnFatihTest
            // 
            this.btnFatihTest.Location = new System.Drawing.Point(582, 107);
            this.btnFatihTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFatihTest.Name = "btnFatihTest";
            this.btnFatihTest.Size = new System.Drawing.Size(196, 41);
            this.btnFatihTest.TabIndex = 7;
            this.btnFatihTest.Text = "Fatih Test";
            this.btnFatihTest.UseVisualStyleBackColor = true;
            this.btnFatihTest.Click += new System.EventHandler(this.btnFatihTest_Click);
            // 
            // TestFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 742);
            this.Controls.Add(this.btnFatihTest);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnDugumAra);
            this.Controls.Add(this.btnAraDugumEkle);
            this.Controls.Add(this.btnKisiCekmeTesti);
            this.Controls.Add(this.btnSirketCekmeTesti);
            this.Controls.Add(this.btnSirketIlanTest);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestFormu";
            this.Text = "TestFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSirketIlanTest;
        private System.Windows.Forms.Button btnSirketCekmeTesti;
        private System.Windows.Forms.Button btnKisiCekmeTesti;
        private System.Windows.Forms.Button btnAraDugumEkle;
        private System.Windows.Forms.Button btnDugumAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnFatihTest;
    }
}