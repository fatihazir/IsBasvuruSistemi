namespace VeriYapilari2
{
    partial class Form1
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
            this.LinkedListTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkedListTest
            // 
            this.LinkedListTest.Location = new System.Drawing.Point(76, 27);
            this.LinkedListTest.Name = "LinkedListTest";
            this.LinkedListTest.Size = new System.Drawing.Size(143, 23);
            this.LinkedListTest.TabIndex = 0;
            this.LinkedListTest.Text = "BagliListeTest";
            this.LinkedListTest.UseVisualStyleBackColor = true;
            this.LinkedListTest.Click += new System.EventHandler(this.LinkedListTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkedListTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LinkedListTest;
    }
}

