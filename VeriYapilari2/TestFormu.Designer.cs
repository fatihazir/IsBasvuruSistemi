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
            this.SuspendLayout();
            // 
            // btnSirketIlanTest
            // 
            this.btnSirketIlanTest.Location = new System.Drawing.Point(153, 66);
            this.btnSirketIlanTest.Name = "btnSirketIlanTest";
            this.btnSirketIlanTest.Size = new System.Drawing.Size(497, 50);
            this.btnSirketIlanTest.TabIndex = 0;
            this.btnSirketIlanTest.Text = "Sirketin birden fazla ilanı olabilir test";
            this.btnSirketIlanTest.UseVisualStyleBackColor = true;
            this.btnSirketIlanTest.Click += new System.EventHandler(this.btnSirketIlanTest_Click);
            // 
            // TestFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSirketIlanTest);
            this.Name = "TestFormu";
            this.Text = "TestFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSirketIlanTest;
    }
}