﻿namespace VeriYapilari2
{
    partial class SirketAnaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnaSayfa = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSirketIsmi = new System.Windows.Forms.Label();
            this.tabSirketBilgileri = new System.Windows.Forms.TabPage();
            this.richTxtSirketAdres = new System.Windows.Forms.RichTextBox();
            this.txtSirketEPosta = new System.Windows.Forms.TextBox();
            this.txtSirketFax = new System.Windows.Forms.TextBox();
            this.txtSirketTelefon = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSirketAdi = new System.Windows.Forms.Label();
            this.btnSirketBilgiGuncelle = new System.Windows.Forms.Button();
            this.tabSirketSil = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSirketSil = new System.Windows.Forms.Button();
            this.tabYeniIlanVer = new System.Windows.Forms.TabPage();
            this.txtYeniIlanPozisyon = new System.Windows.Forms.TextBox();
            this.richTxtYeniArananEleman = new System.Windows.Forms.RichTextBox();
            this.richTxtYeniIsIlani = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYeniIlanVer = new System.Windows.Forms.Button();
            this.tabIlanlarim = new System.Windows.Forms.TabPage();
            this.btnYabanciDilOlanListele = new System.Windows.Forms.Button();
            this.btnEnAzIkıYılListele = new System.Windows.Forms.Button();
            this.ilanListesiListView = new System.Windows.Forms.ListView();
            this.btnTiklananIlanSil = new System.Windows.Forms.Button();
            this.btnIseAl = new System.Windows.Forms.Button();
            this.maskedTxtEnUygunKisi = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAnaSayfa.SuspendLayout();
            this.tabSirketBilgileri.SuspendLayout();
            this.tabSirketSil.SuspendLayout();
            this.tabYeniIlanVer.SuspendLayout();
            this.tabIlanlarim.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnaSayfa);
            this.tabControl1.Controls.Add(this.tabSirketBilgileri);
            this.tabControl1.Controls.Add(this.tabSirketSil);
            this.tabControl1.Controls.Add(this.tabYeniIlanVer);
            this.tabControl1.Controls.Add(this.tabIlanlarim);
            this.tabControl1.Location = new System.Drawing.Point(40, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnaSayfa
            // 
            this.tabAnaSayfa.Controls.Add(this.label3);
            this.tabAnaSayfa.Controls.Add(this.label2);
            this.tabAnaSayfa.Controls.Add(this.labelSirketIsmi);
            this.tabAnaSayfa.Location = new System.Drawing.Point(4, 25);
            this.tabAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnaSayfa.Name = "tabAnaSayfa";
            this.tabAnaSayfa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnaSayfa.Size = new System.Drawing.Size(717, 344);
            this.tabAnaSayfa.TabIndex = 0;
            this.tabAnaSayfa.Text = "Ana Sayfa";
            this.tabAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üstteki panelden tüm işlemlerinizi halledebilirsiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sisteme Hoş Geldiniz.";
            // 
            // labelSirketIsmi
            // 
            this.labelSirketIsmi.AutoSize = true;
            this.labelSirketIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSirketIsmi.Location = new System.Drawing.Point(177, 74);
            this.labelSirketIsmi.Name = "labelSirketIsmi";
            this.labelSirketIsmi.Size = new System.Drawing.Size(364, 31);
            this.labelSirketIsmi.TabIndex = 3;
            this.labelSirketIsmi.Text = "Şirket İsmi Gelecek Otomatik";
            // 
            // tabSirketBilgileri
            // 
            this.tabSirketBilgileri.Controls.Add(this.richTxtSirketAdres);
            this.tabSirketBilgileri.Controls.Add(this.txtSirketEPosta);
            this.tabSirketBilgileri.Controls.Add(this.txtSirketFax);
            this.tabSirketBilgileri.Controls.Add(this.txtSirketTelefon);
            this.tabSirketBilgileri.Controls.Add(this.txtSirketAdi);
            this.tabSirketBilgileri.Controls.Add(this.label6);
            this.tabSirketBilgileri.Controls.Add(this.label5);
            this.tabSirketBilgileri.Controls.Add(this.label4);
            this.tabSirketBilgileri.Controls.Add(this.label1);
            this.tabSirketBilgileri.Controls.Add(this.labelSirketAdi);
            this.tabSirketBilgileri.Controls.Add(this.btnSirketBilgiGuncelle);
            this.tabSirketBilgileri.Location = new System.Drawing.Point(4, 25);
            this.tabSirketBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSirketBilgileri.Name = "tabSirketBilgileri";
            this.tabSirketBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSirketBilgileri.Size = new System.Drawing.Size(717, 344);
            this.tabSirketBilgileri.TabIndex = 1;
            this.tabSirketBilgileri.Text = "Şirket Bilgileri";
            this.tabSirketBilgileri.UseVisualStyleBackColor = true;
            // 
            // richTxtSirketAdres
            // 
            this.richTxtSirketAdres.Location = new System.Drawing.Point(403, 79);
            this.richTxtSirketAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTxtSirketAdres.Name = "richTxtSirketAdres";
            this.richTxtSirketAdres.Size = new System.Drawing.Size(172, 134);
            this.richTxtSirketAdres.TabIndex = 10;
            this.richTxtSirketAdres.Text = "";
            // 
            // txtSirketEPosta
            // 
            this.txtSirketEPosta.Location = new System.Drawing.Point(141, 192);
            this.txtSirketEPosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSirketEPosta.Name = "txtSirketEPosta";
            this.txtSirketEPosta.Size = new System.Drawing.Size(100, 22);
            this.txtSirketEPosta.TabIndex = 9;
            // 
            // txtSirketFax
            // 
            this.txtSirketFax.Location = new System.Drawing.Point(141, 156);
            this.txtSirketFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSirketFax.Name = "txtSirketFax";
            this.txtSirketFax.Size = new System.Drawing.Size(100, 22);
            this.txtSirketFax.TabIndex = 8;
            // 
            // txtSirketTelefon
            // 
            this.txtSirketTelefon.Location = new System.Drawing.Point(141, 118);
            this.txtSirketTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSirketTelefon.Name = "txtSirketTelefon";
            this.txtSirketTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtSirketTelefon.TabIndex = 7;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(141, 79);
            this.txtSirketAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(100, 22);
            this.txtSirketAdi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "E Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şirket Adresi";
            // 
            // labelSirketAdi
            // 
            this.labelSirketAdi.AutoSize = true;
            this.labelSirketAdi.Location = new System.Drawing.Point(72, 82);
            this.labelSirketAdi.Name = "labelSirketAdi";
            this.labelSirketAdi.Size = new System.Drawing.Size(25, 17);
            this.labelSirketAdi.TabIndex = 1;
            this.labelSirketAdi.Text = "Ad";
            // 
            // btnSirketBilgiGuncelle
            // 
            this.btnSirketBilgiGuncelle.Location = new System.Drawing.Point(267, 277);
            this.btnSirketBilgiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSirketBilgiGuncelle.Name = "btnSirketBilgiGuncelle";
            this.btnSirketBilgiGuncelle.Size = new System.Drawing.Size(152, 42);
            this.btnSirketBilgiGuncelle.TabIndex = 0;
            this.btnSirketBilgiGuncelle.Text = "Bilgileri Güncelle!";
            this.btnSirketBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnSirketBilgiGuncelle.UseWaitCursor = true;
            this.btnSirketBilgiGuncelle.Click += new System.EventHandler(this.sirketBilgiGuncelleButon_Click);
            // 
            // tabSirketSil
            // 
            this.tabSirketSil.Controls.Add(this.label7);
            this.tabSirketSil.Controls.Add(this.btnSirketSil);
            this.tabSirketSil.Location = new System.Drawing.Point(4, 25);
            this.tabSirketSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSirketSil.Name = "tabSirketSil";
            this.tabSirketSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSirketSil.Size = new System.Drawing.Size(717, 344);
            this.tabSirketSil.TabIndex = 2;
            this.tabSirketSil.Text = "Şirketi Sil";
            this.tabSirketSil.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(628, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Eğer şirketi silerseniz sistemden çıkarılacaksınız!";
            // 
            // btnSirketSil
            // 
            this.btnSirketSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketSil.Location = new System.Drawing.Point(199, 182);
            this.btnSirketSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSirketSil.Name = "btnSirketSil";
            this.btnSirketSil.Size = new System.Drawing.Size(291, 78);
            this.btnSirketSil.TabIndex = 0;
            this.btnSirketSil.Text = "Şirketi Sil!";
            this.btnSirketSil.UseVisualStyleBackColor = true;
            this.btnSirketSil.Click += new System.EventHandler(this.sirketSilButon_Click);
            // 
            // tabYeniIlanVer
            // 
            this.tabYeniIlanVer.Controls.Add(this.txtYeniIlanPozisyon);
            this.tabYeniIlanVer.Controls.Add(this.richTxtYeniArananEleman);
            this.tabYeniIlanVer.Controls.Add(this.richTxtYeniIsIlani);
            this.tabYeniIlanVer.Controls.Add(this.label10);
            this.tabYeniIlanVer.Controls.Add(this.label9);
            this.tabYeniIlanVer.Controls.Add(this.label8);
            this.tabYeniIlanVer.Controls.Add(this.btnYeniIlanVer);
            this.tabYeniIlanVer.Location = new System.Drawing.Point(4, 25);
            this.tabYeniIlanVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabYeniIlanVer.Name = "tabYeniIlanVer";
            this.tabYeniIlanVer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabYeniIlanVer.Size = new System.Drawing.Size(717, 344);
            this.tabYeniIlanVer.TabIndex = 3;
            this.tabYeniIlanVer.Text = "Yeni İlan Ver!";
            this.tabYeniIlanVer.UseVisualStyleBackColor = true;
            // 
            // txtYeniIlanPozisyon
            // 
            this.txtYeniIlanPozisyon.Location = new System.Drawing.Point(531, 158);
            this.txtYeniIlanPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYeniIlanPozisyon.Name = "txtYeniIlanPozisyon";
            this.txtYeniIlanPozisyon.Size = new System.Drawing.Size(100, 22);
            this.txtYeniIlanPozisyon.TabIndex = 6;
            // 
            // richTxtYeniArananEleman
            // 
            this.richTxtYeniArananEleman.Location = new System.Drawing.Point(259, 80);
            this.richTxtYeniArananEleman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTxtYeniArananEleman.Name = "richTxtYeniArananEleman";
            this.richTxtYeniArananEleman.Size = new System.Drawing.Size(215, 152);
            this.richTxtYeniArananEleman.TabIndex = 5;
            this.richTxtYeniArananEleman.Text = "";
            // 
            // richTxtYeniIsIlani
            // 
            this.richTxtYeniIsIlani.Location = new System.Drawing.Point(16, 80);
            this.richTxtYeniIsIlani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTxtYeniIsIlani.Name = "richTxtYeniIsIlani";
            this.richTxtYeniIsIlani.Size = new System.Drawing.Size(215, 152);
            this.richTxtYeniIsIlani.TabIndex = 4;
            this.richTxtYeniIsIlani.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pozisyon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Aranan Eleman Özellikleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "İşin Tanımı";
            // 
            // btnYeniIlanVer
            // 
            this.btnYeniIlanVer.Location = new System.Drawing.Point(273, 277);
            this.btnYeniIlanVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniIlanVer.Name = "btnYeniIlanVer";
            this.btnYeniIlanVer.Size = new System.Drawing.Size(137, 34);
            this.btnYeniIlanVer.TabIndex = 0;
            this.btnYeniIlanVer.Text = "Yeni İlan Ver!";
            this.btnYeniIlanVer.UseVisualStyleBackColor = true;
            this.btnYeniIlanVer.Click += new System.EventHandler(this.sirketYeniIlanVerButon_Click);
            // 
            // tabIlanlarim
            // 
            this.tabIlanlarim.Controls.Add(this.btnYabanciDilOlanListele);
            this.tabIlanlarim.Controls.Add(this.btnEnAzIkıYılListele);
            this.tabIlanlarim.Controls.Add(this.ilanListesiListView);
            this.tabIlanlarim.Controls.Add(this.btnTiklananIlanSil);
            this.tabIlanlarim.Controls.Add(this.btnIseAl);
            this.tabIlanlarim.Controls.Add(this.maskedTxtEnUygunKisi);
            this.tabIlanlarim.Controls.Add(this.label14);
            this.tabIlanlarim.Controls.Add(this.label13);
            this.tabIlanlarim.Controls.Add(this.label12);
            this.tabIlanlarim.Controls.Add(this.label11);
            this.tabIlanlarim.Location = new System.Drawing.Point(4, 25);
            this.tabIlanlarim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIlanlarim.Name = "tabIlanlarim";
            this.tabIlanlarim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIlanlarim.Size = new System.Drawing.Size(717, 344);
            this.tabIlanlarim.TabIndex = 4;
            this.tabIlanlarim.Text = "İlanlarım";
            this.tabIlanlarim.UseVisualStyleBackColor = true;
            // 
            // btnYabanciDilOlanListele
            // 
            this.btnYabanciDilOlanListele.Location = new System.Drawing.Point(288, 191);
            this.btnYabanciDilOlanListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYabanciDilOlanListele.Name = "btnYabanciDilOlanListele";
            this.btnYabanciDilOlanListele.Size = new System.Drawing.Size(153, 62);
            this.btnYabanciDilOlanListele.TabIndex = 9;
            this.btnYabanciDilOlanListele.Text = "Yabancı Dili Olanları Listele!";
            this.btnYabanciDilOlanListele.UseVisualStyleBackColor = true;
            this.btnYabanciDilOlanListele.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEnAzIkıYılListele
            // 
            this.btnEnAzIkıYılListele.Location = new System.Drawing.Point(288, 113);
            this.btnEnAzIkıYılListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnAzIkıYılListele.Name = "btnEnAzIkıYılListele";
            this.btnEnAzIkıYılListele.Size = new System.Drawing.Size(153, 62);
            this.btnEnAzIkıYılListele.TabIndex = 8;
            this.btnEnAzIkıYılListele.Text = "En Az 2 Yıl İş Deneyimine Sahip Olanları Listele!";
            this.btnEnAzIkıYılListele.UseVisualStyleBackColor = true;
            this.btnEnAzIkıYılListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // ilanListesiListView
            // 
            this.ilanListesiListView.HideSelection = false;
            this.ilanListesiListView.Location = new System.Drawing.Point(5, 113);
            this.ilanListesiListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilanListesiListView.Name = "ilanListesiListView";
            this.ilanListesiListView.Size = new System.Drawing.Size(276, 194);
            this.ilanListesiListView.TabIndex = 7;
            this.ilanListesiListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnTiklananIlanSil
            // 
            this.btnTiklananIlanSil.Location = new System.Drawing.Point(533, 300);
            this.btnTiklananIlanSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTiklananIlanSil.Name = "btnTiklananIlanSil";
            this.btnTiklananIlanSil.Size = new System.Drawing.Size(173, 38);
            this.btnTiklananIlanSil.TabIndex = 6;
            this.btnTiklananIlanSil.Text = "Tıklanılan İlanı Sil!";
            this.btnTiklananIlanSil.UseVisualStyleBackColor = true;
            this.btnTiklananIlanSil.Click += new System.EventHandler(this.ilanSilButon_Click);
            // 
            // btnIseAl
            // 
            this.btnIseAl.Location = new System.Drawing.Point(493, 113);
            this.btnIseAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIseAl.Name = "btnIseAl";
            this.btnIseAl.Size = new System.Drawing.Size(173, 46);
            this.btnIseAl.TabIndex = 5;
            this.btnIseAl.Text = "İşe Al!";
            this.btnIseAl.UseVisualStyleBackColor = true;
            this.btnIseAl.Click += new System.EventHandler(this.ilanIseAlButon_Click);
            // 
            // maskedTxtEnUygunKisi
            // 
            this.maskedTxtEnUygunKisi.Location = new System.Drawing.Point(533, 74);
            this.maskedTxtEnUygunKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtEnUygunKisi.Name = "maskedTxtEnUygunKisi";
            this.maskedTxtEnUygunKisi.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtEnUygunKisi.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Seçtiğiniz İlan İçin En Uygun Kişi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "en uygun kişi çıkar.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "İlanlardan birine tıklandığında sağda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "İlanlar buraya eklenir";
            // 
            // SirketAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SirketAnaForm";
            this.Text = "SirketAnaForm";
            this.Load += new System.EventHandler(this.SirketAnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnaSayfa.ResumeLayout(false);
            this.tabAnaSayfa.PerformLayout();
            this.tabSirketBilgileri.ResumeLayout(false);
            this.tabSirketBilgileri.PerformLayout();
            this.tabSirketSil.ResumeLayout(false);
            this.tabSirketSil.PerformLayout();
            this.tabYeniIlanVer.ResumeLayout(false);
            this.tabYeniIlanVer.PerformLayout();
            this.tabIlanlarim.ResumeLayout(false);
            this.tabIlanlarim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnaSayfa;
        private System.Windows.Forms.TabPage tabSirketBilgileri;
        private System.Windows.Forms.TabPage tabSirketSil;
        private System.Windows.Forms.TabPage tabYeniIlanVer;
        private System.Windows.Forms.TabPage tabIlanlarim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSirketBilgiGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSirketAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSirketSil;
        private System.Windows.Forms.Button btnYeniIlanVer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYeniIlanPozisyon;
        private System.Windows.Forms.RichTextBox richTxtYeniArananEleman;
        private System.Windows.Forms.RichTextBox richTxtYeniIsIlani;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView ilanListesiListView;
        private System.Windows.Forms.Button btnTiklananIlanSil;
        private System.Windows.Forms.Button btnIseAl;
        private System.Windows.Forms.MaskedTextBox maskedTxtEnUygunKisi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnYabanciDilOlanListele;
        private System.Windows.Forms.Button btnEnAzIkıYılListele;
        public System.Windows.Forms.RichTextBox richTxtSirketAdres;
        public System.Windows.Forms.TextBox txtSirketEPosta;
        public System.Windows.Forms.TextBox txtSirketFax;
        public System.Windows.Forms.TextBox txtSirketTelefon;
        public System.Windows.Forms.TextBox txtSirketAdi;
        public System.Windows.Forms.Label labelSirketIsmi;
    }
}