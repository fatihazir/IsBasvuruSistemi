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
            this.btnTxtDb = new System.Windows.Forms.Button();
            this.btnSirketCekmeTesti = new System.Windows.Forms.Button();
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
            // btnTxtDb
            // 
            this.btnTxtDb.Location = new System.Drawing.Point(115, 181);
            this.btnTxtDb.Margin = new System.Windows.Forms.Padding(2);
            this.btnTxtDb.Name = "btnTxtDb";
            this.btnTxtDb.Size = new System.Drawing.Size(373, 41);
            this.btnTxtDb.TabIndex = 1;
            this.btnTxtDb.Text = "Txt db sirket ekleme tesi";
            this.btnTxtDb.UseVisualStyleBackColor = true;
            this.btnTxtDb.Click += new System.EventHandler(this.btnTxtDb_Click);
            // 
            // btnSirketCekmeTesti
            // 
            this.btnSirketCekmeTesti.Location = new System.Drawing.Point(115, 247);
            this.btnSirketCekmeTesti.Margin = new System.Windows.Forms.Padding(2);
            this.btnSirketCekmeTesti.Name = "btnSirketCekmeTesti";
            this.btnSirketCekmeTesti.Size = new System.Drawing.Size(373, 41);
            this.btnSirketCekmeTesti.TabIndex = 2;
            this.btnSirketCekmeTesti.Text = "Txt db sirket cekme tesi";
            this.btnSirketCekmeTesti.UseVisualStyleBackColor = true;
            this.btnSirketCekmeTesti.Click += new System.EventHandler(this.btnSirketCekmeTesti_Click);
            // 
            // TestFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSirketCekmeTesti);
            this.Controls.Add(this.btnTxtDb);
            this.Controls.Add(this.btnSirketIlanTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestFormu";
            this.Text = "TestFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSirketIlanTest;
        private System.Windows.Forms.Button btnTxtDb;
        private System.Windows.Forms.Button btnSirketCekmeTesti;
    }
}