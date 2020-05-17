namespace VeriYapilari2
{
    partial class IsBasvurusuIcinIlanaBasvurmaFormu
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
            this.dgvIlanListesi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIlanaBasvur = new System.Windows.Forms.Button();
            this.btnPozisyonaGoreListele = new System.Windows.Forms.Button();
            this.btnIsyeriAdinaGoreListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIlanListesi
            // 
            this.dgvIlanListesi.AllowUserToAddRows = false;
            this.dgvIlanListesi.AllowUserToDeleteRows = false;
            this.dgvIlanListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIlanListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlanListesi.Location = new System.Drawing.Point(183, 179);
            this.dgvIlanListesi.Name = "dgvIlanListesi";
            this.dgvIlanListesi.ReadOnly = true;
            this.dgvIlanListesi.RowHeadersWidth = 51;
            this.dgvIlanListesi.RowTemplate.Height = 24;
            this.dgvIlanListesi.Size = new System.Drawing.Size(1003, 454);
            this.dgvIlanListesi.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(178, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mevcut İlanlar";
            // 
            // btnIlanaBasvur
            // 
            this.btnIlanaBasvur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanaBasvur.Location = new System.Drawing.Point(617, 711);
            this.btnIlanaBasvur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlanaBasvur.Name = "btnIlanaBasvur";
            this.btnIlanaBasvur.Size = new System.Drawing.Size(181, 41);
            this.btnIlanaBasvur.TabIndex = 52;
            this.btnIlanaBasvur.Text = "Ilana basvur";
            this.btnIlanaBasvur.UseVisualStyleBackColor = true;
            this.btnIlanaBasvur.Click += new System.EventHandler(this.btnIlanaBasvur_Click);
            // 
            // btnPozisyonaGoreListele
            // 
            this.btnPozisyonaGoreListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonaGoreListele.Location = new System.Drawing.Point(183, 648);
            this.btnPozisyonaGoreListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPozisyonaGoreListele.Name = "btnPozisyonaGoreListele";
            this.btnPozisyonaGoreListele.Size = new System.Drawing.Size(294, 37);
            this.btnPozisyonaGoreListele.TabIndex = 54;
            this.btnPozisyonaGoreListele.Text = "Pozisyona gore listele";
            this.btnPozisyonaGoreListele.UseVisualStyleBackColor = true;
            // 
            // btnIsyeriAdinaGoreListele
            // 
            this.btnIsyeriAdinaGoreListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsyeriAdinaGoreListele.Location = new System.Drawing.Point(892, 648);
            this.btnIsyeriAdinaGoreListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsyeriAdinaGoreListele.Name = "btnIsyeriAdinaGoreListele";
            this.btnIsyeriAdinaGoreListele.Size = new System.Drawing.Size(294, 37);
            this.btnIsyeriAdinaGoreListele.TabIndex = 55;
            this.btnIsyeriAdinaGoreListele.Text = "İşyeri adına göre listele";
            this.btnIsyeriAdinaGoreListele.UseVisualStyleBackColor = true;
            // 
            // IsBasvurusuIcinIlanaBasvurmaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 821);
            this.Controls.Add(this.btnIsyeriAdinaGoreListele);
            this.Controls.Add(this.btnPozisyonaGoreListele);
            this.Controls.Add(this.btnIlanaBasvur);
            this.Controls.Add(this.dgvIlanListesi);
            this.Controls.Add(this.label2);
            this.Name = "IsBasvurusuIcinIlanaBasvurmaFormu";
            this.Text = "IsBasvurusuIcinIlanaBasvurmaFormu";
            this.Load += new System.EventHandler(this.IsBasvurusuIcinIlanaBasvurmaFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIlanListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIlanaBasvur;
        private System.Windows.Forms.Button btnPozisyonaGoreListele;
        private System.Windows.Forms.Button btnIsyeriAdinaGoreListele;
    }
}