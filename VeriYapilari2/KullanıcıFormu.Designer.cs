namespace VeriYapilari2
{
    partial class KullaniciFormu
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
            this.tabIlanlar = new System.Windows.Forms.TabPage();
            this.btnIlanGuncelle = new System.Windows.Forms.Button();
            this.listViewKullaniciIlanlarBolmesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIlanBasvur = new System.Windows.Forms.Button();
            this.tabBilgileriGuncelle = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.brnKisiBilgiSil = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtYabanciDil = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtIlgiAlan = new System.Windows.Forms.TextBox();
            this.cmbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.TextBox();
            this.tabIsBasvuruKayit = new System.Windows.Forms.TabControl();
            this.tabIsDeneyimi = new System.Windows.Forms.TabPage();
            this.btnIsDeneyimiKaydet = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtKisininBolumu = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtOkulAdi = new System.Windows.Forms.TextBox();
            this.txtBolumBitisYili = new System.Windows.Forms.TextBox();
            this.txtNotOrtalamasi = new System.Windows.Forms.TextBox();
            this.txtBolumBaslangicYili = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEgitimDurumu = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtIsyeriAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsyeriAd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtIsyeriPozisyon = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtIsyeriCalismaYili = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabIlanlar.SuspendLayout();
            this.tabBilgileriGuncelle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabIsBasvuruKayit.SuspendLayout();
            this.tabIsDeneyimi.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIlanlar
            // 
            this.tabIlanlar.Controls.Add(this.btnIlanGuncelle);
            this.tabIlanlar.Controls.Add(this.listViewKullaniciIlanlarBolmesi);
            this.tabIlanlar.Controls.Add(this.btnIlanBasvur);
            this.tabIlanlar.Location = new System.Drawing.Point(4, 25);
            this.tabIlanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIlanlar.Name = "tabIlanlar";
            this.tabIlanlar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIlanlar.Size = new System.Drawing.Size(795, 408);
            this.tabIlanlar.TabIndex = 2;
            this.tabIlanlar.Text = "İlanlar";
            this.tabIlanlar.UseVisualStyleBackColor = true;
            // 
            // btnIlanGuncelle
            // 
            this.btnIlanGuncelle.Location = new System.Drawing.Point(77, 207);
            this.btnIlanGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlanGuncelle.Name = "btnIlanGuncelle";
            this.btnIlanGuncelle.Size = new System.Drawing.Size(131, 49);
            this.btnIlanGuncelle.TabIndex = 21;
            this.btnIlanGuncelle.Text = "İlanları Güncelle";
            this.btnIlanGuncelle.UseVisualStyleBackColor = true;
            this.btnIlanGuncelle.Click += new System.EventHandler(this.btnIlanGuncelle_Click);
            // 
            // listViewKullaniciIlanlarBolmesi
            // 
            this.listViewKullaniciIlanlarBolmesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewKullaniciIlanlarBolmesi.HideSelection = false;
            this.listViewKullaniciIlanlarBolmesi.Location = new System.Drawing.Point(232, 30);
            this.listViewKullaniciIlanlarBolmesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewKullaniciIlanlarBolmesi.Name = "listViewKullaniciIlanlarBolmesi";
            this.listViewKullaniciIlanlarBolmesi.Size = new System.Drawing.Size(384, 226);
            this.listViewKullaniciIlanlarBolmesi.TabIndex = 20;
            this.listViewKullaniciIlanlarBolmesi.UseCompatibleStateImageBehavior = false;
            this.listViewKullaniciIlanlarBolmesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlan Tanımı";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aranan Eleman Özellikleri";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pozisyon";
            this.columnHeader4.Width = 75;
            // 
            // btnIlanBasvur
            // 
            this.btnIlanBasvur.Location = new System.Drawing.Point(317, 289);
            this.btnIlanBasvur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlanBasvur.Name = "btnIlanBasvur";
            this.btnIlanBasvur.Size = new System.Drawing.Size(233, 63);
            this.btnIlanBasvur.TabIndex = 1;
            this.btnIlanBasvur.Text = "Seçiilen İlana Başvur";
            this.btnIlanBasvur.UseVisualStyleBackColor = true;
            this.btnIlanBasvur.Click += new System.EventHandler(this.btnIlanBasvur_Click);
            // 
            // tabBilgileriGuncelle
            // 
            this.tabBilgileriGuncelle.Controls.Add(this.groupBox3);
            this.tabBilgileriGuncelle.Location = new System.Drawing.Point(4, 25);
            this.tabBilgileriGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBilgileriGuncelle.Name = "tabBilgileriGuncelle";
            this.tabBilgileriGuncelle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBilgileriGuncelle.Size = new System.Drawing.Size(795, 408);
            this.tabBilgileriGuncelle.TabIndex = 1;
            this.tabBilgileriGuncelle.Text = "Bilgileri Güncelle ve Sil";
            this.tabBilgileriGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.brnKisiBilgiSil);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.txtYabanciDil);
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbUyruk);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.txtIlgiAlan);
            this.groupBox3.Controls.Add(this.cmbMedeniDurum);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTCKimlik);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtAdres);
            this.groupBox3.Controls.Add(this.txtEMail);
            this.groupBox3.Controls.Add(this.txtDogumYeri);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtDogumTarih);
            this.groupBox3.Location = new System.Drawing.Point(5, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(783, 252);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // brnKisiBilgiSil
            // 
            this.brnKisiBilgiSil.Location = new System.Drawing.Point(643, 215);
            this.brnKisiBilgiSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brnKisiBilgiSil.Name = "brnKisiBilgiSil";
            this.brnKisiBilgiSil.Size = new System.Drawing.Size(135, 32);
            this.brnKisiBilgiSil.TabIndex = 51;
            this.brnKisiBilgiSil.Text = "Kişi Bilgilerini Sil";
            this.brnKisiBilgiSil.UseVisualStyleBackColor = true;
            this.brnKisiBilgiSil.Click += new System.EventHandler(this.brnKisiBilgiSil_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 186);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 16);
            this.lbl.TabIndex = 52;
            this.lbl.Text = "Yabancı Dil";
            // 
            // txtYabanciDil
            // 
            this.txtYabanciDil.Location = new System.Drawing.Point(101, 183);
            this.txtYabanciDil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYabanciDil.Name = "txtYabanciDil";
            this.txtYabanciDil.Size = new System.Drawing.Size(100, 22);
            this.txtYabanciDil.TabIndex = 51;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(643, 180);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 31);
            this.btnGuncelle.TabIndex = 50;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(101, 49);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "İlgi Alanları";
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Items.AddRange(new object[] {
            "TC",
            "KKTC",
            "Avrupa",
            "ABD",
            "İngiltere",
            "Diğer"});
            this.cmbUyruk.Location = new System.Drawing.Point(345, 129);
            this.cmbUyruk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(100, 24);
            this.cmbUyruk.TabIndex = 49;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 17);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 28;
            // 
            // txtIlgiAlan
            // 
            this.txtIlgiAlan.Location = new System.Drawing.Point(581, 17);
            this.txtIlgiAlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIlgiAlan.Multiline = true;
            this.txtIlgiAlan.Name = "txtIlgiAlan";
            this.txtIlgiAlan.Size = new System.Drawing.Size(196, 157);
            this.txtIlgiAlan.TabIndex = 36;
            // 
            // cmbMedeniDurum
            // 
            this.cmbMedeniDurum.FormattingEnabled = true;
            this.cmbMedeniDurum.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.cmbMedeniDurum.Location = new System.Drawing.Point(345, 177);
            this.cmbMedeniDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMedeniDurum.Name = "cmbMedeniDurum";
            this.cmbMedeniDurum.Size = new System.Drawing.Size(100, 24);
            this.cmbMedeniDurum.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Uyruk";
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(101, 82);
            this.txtTCKimlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.ReadOnly = true;
            this.txtTCKimlik.Size = new System.Drawing.Size(100, 22);
            this.txtTCKimlik.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Ad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "Medeni Durumu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Soyad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "TC Kimlik";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "Doğum Yeri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(345, 54);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Doğum Tarihi";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(345, 20);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 31;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(345, 89);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(100, 22);
            this.txtEMail.TabIndex = 33;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(101, 150);
            this.txtDogumYeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(100, 22);
            this.txtDogumYeri.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(292, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "E-Mail";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(292, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Adres";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(283, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "Telefon";
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Location = new System.Drawing.Point(101, 112);
            this.txtDogumTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(100, 22);
            this.txtDogumTarih.TabIndex = 34;
            // 
            // tabIsBasvuruKayit
            // 
            this.tabIsBasvuruKayit.AccessibleName = "";
            this.tabIsBasvuruKayit.Controls.Add(this.tabBilgileriGuncelle);
            this.tabIsBasvuruKayit.Controls.Add(this.tabIlanlar);
            this.tabIsBasvuruKayit.Controls.Add(this.tabIsDeneyimi);
            this.tabIsBasvuruKayit.Location = new System.Drawing.Point(41, 39);
            this.tabIsBasvuruKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIsBasvuruKayit.Name = "tabIsBasvuruKayit";
            this.tabIsBasvuruKayit.SelectedIndex = 0;
            this.tabIsBasvuruKayit.Size = new System.Drawing.Size(803, 437);
            this.tabIsBasvuruKayit.TabIndex = 0;
            // 
            // tabIsDeneyimi
            // 
            this.tabIsDeneyimi.Controls.Add(this.btnIsDeneyimiKaydet);
            this.tabIsDeneyimi.Controls.Add(this.groupBox7);
            this.tabIsDeneyimi.Controls.Add(this.groupBox6);
            this.tabIsDeneyimi.Location = new System.Drawing.Point(4, 25);
            this.tabIsDeneyimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIsDeneyimi.Name = "tabIsDeneyimi";
            this.tabIsDeneyimi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIsDeneyimi.Size = new System.Drawing.Size(795, 408);
            this.tabIsDeneyimi.TabIndex = 3;
            this.tabIsDeneyimi.Text = "İş Deneyimi Ekle";
            this.tabIsDeneyimi.UseVisualStyleBackColor = true;
            // 
            // btnIsDeneyimiKaydet
            // 
            this.btnIsDeneyimiKaydet.Location = new System.Drawing.Point(609, 313);
            this.btnIsDeneyimiKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsDeneyimiKaydet.Name = "btnIsDeneyimiKaydet";
            this.btnIsDeneyimiKaydet.Size = new System.Drawing.Size(180, 39);
            this.btnIsDeneyimiKaydet.TabIndex = 33;
            this.btnIsDeneyimiKaydet.Text = "Kaydet";
            this.btnIsDeneyimiKaydet.UseVisualStyleBackColor = true;
            this.btnIsDeneyimiKaydet.Click += new System.EventHandler(this.btnIsDeneyimiKaydet_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtKisininBolumu);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.txtOkulAdi);
            this.groupBox7.Controls.Add(this.txtBolumBitisYili);
            this.groupBox7.Controls.Add(this.txtNotOrtalamasi);
            this.groupBox7.Controls.Add(this.txtBolumBaslangicYili);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.txtEgitimDurumu);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Location = new System.Drawing.Point(293, 57);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(496, 220);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Eğitim Bilgileri";
            // 
            // txtKisininBolumu
            // 
            this.txtKisininBolumu.Location = new System.Drawing.Point(131, 118);
            this.txtKisininBolumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKisininBolumu.Name = "txtKisininBolumu";
            this.txtKisininBolumu.Size = new System.Drawing.Size(100, 22);
            this.txtKisininBolumu.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 16);
            this.label27.TabIndex = 10;
            this.label27.Text = "Kişinin Okul Adı";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(371, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(12, 16);
            this.label30.TabIndex = 20;
            this.label30.Text = "-";
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.Location = new System.Drawing.Point(131, 25);
            this.txtOkulAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Size = new System.Drawing.Size(100, 22);
            this.txtOkulAdi.TabIndex = 11;
            // 
            // txtBolumBitisYili
            // 
            this.txtBolumBitisYili.Location = new System.Drawing.Point(389, 118);
            this.txtBolumBitisYili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBolumBitisYili.Name = "txtBolumBitisYili";
            this.txtBolumBitisYili.Size = new System.Drawing.Size(100, 22);
            this.txtBolumBitisYili.TabIndex = 17;
            // 
            // txtNotOrtalamasi
            // 
            this.txtNotOrtalamasi.Location = new System.Drawing.Point(265, 48);
            this.txtNotOrtalamasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotOrtalamasi.Name = "txtNotOrtalamasi";
            this.txtNotOrtalamasi.Size = new System.Drawing.Size(100, 22);
            this.txtNotOrtalamasi.TabIndex = 19;
            // 
            // txtBolumBaslangicYili
            // 
            this.txtBolumBaslangicYili.Location = new System.Drawing.Point(265, 118);
            this.txtBolumBaslangicYili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBolumBaslangicYili.Name = "txtBolumBaslangicYili";
            this.txtBolumBaslangicYili.Size = new System.Drawing.Size(100, 22);
            this.txtBolumBaslangicYili.TabIndex = 15;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(261, 89);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(176, 16);
            this.label29.TabIndex = 14;
            this.label29.Text = "Bölüm Başlangıç ve Bitiş Yılı";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(261, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(127, 16);
            this.label31.TabIndex = 18;
            this.label31.Text = "Okul Not Ortalaması";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 121);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(94, 16);
            this.label28.TabIndex = 12;
            this.label28.Text = "Kişinin Bölümü";
            // 
            // txtEgitimDurumu
            // 
            this.txtEgitimDurumu.Location = new System.Drawing.Point(131, 73);
            this.txtEgitimDurumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEgitimDurumu.Name = "txtEgitimDurumu";
            this.txtEgitimDurumu.Size = new System.Drawing.Size(100, 22);
            this.txtEgitimDurumu.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 16);
            this.label26.TabIndex = 8;
            this.label26.Text = "Eğitim Durumu";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtIsyeriAdres);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtIsyeriAd);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.txtIsyeriPozisyon);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.txtIsyeriCalismaYili);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(5, 57);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(273, 220);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İş Yeri Bilgileri";
            // 
            // txtIsyeriAdres
            // 
            this.txtIsyeriAdres.Location = new System.Drawing.Point(155, 71);
            this.txtIsyeriAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsyeriAdres.Name = "txtIsyeriAdres";
            this.txtIsyeriAdres.Size = new System.Drawing.Size(100, 22);
            this.txtIsyeriAdres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Yeri Adı";
            // 
            // txtIsyeriAd
            // 
            this.txtIsyeriAd.Location = new System.Drawing.Point(155, 27);
            this.txtIsyeriAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsyeriAd.Name = "txtIsyeriAd";
            this.txtIsyeriAd.Size = new System.Drawing.Size(100, 22);
            this.txtIsyeriAd.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "İş Yeri Adresi";
            // 
            // txtIsyeriPozisyon
            // 
            this.txtIsyeriPozisyon.Location = new System.Drawing.Point(155, 121);
            this.txtIsyeriPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsyeriPozisyon.Name = "txtIsyeriPozisyon";
            this.txtIsyeriPozisyon.Size = new System.Drawing.Size(100, 22);
            this.txtIsyeriPozisyon.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 126);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "İş Yerindeki Pozisyon";
            // 
            // txtIsyeriCalismaYili
            // 
            this.txtIsyeriCalismaYili.Location = new System.Drawing.Point(155, 176);
            this.txtIsyeriCalismaYili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsyeriCalismaYili.Name = "txtIsyeriCalismaYili";
            this.txtIsyeriCalismaYili.Size = new System.Drawing.Size(100, 22);
            this.txtIsyeriCalismaYili.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 178);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 16);
            this.label25.TabIndex = 6;
            this.label25.Text = "İş Yeri Çalışma Yılı";
            // 
            // KullaniciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 507);
            this.Controls.Add(this.tabIsBasvuruKayit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullaniciFormu";
            this.Text = "Kullanici Formu";
            this.Load += new System.EventHandler(this.İş_Başvuru_Formu_Load);
            this.tabIlanlar.ResumeLayout(false);
            this.tabBilgileriGuncelle.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabIsBasvuruKayit.ResumeLayout(false);
            this.tabIsDeneyimi.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabIlanlar;
        private System.Windows.Forms.ListView listViewKullaniciIlanlarBolmesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnIlanBasvur;
        private System.Windows.Forms.TabPage tabBilgileriGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button brnKisiBilgiSil;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtYabanciDil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtIlgiAlan;
        private System.Windows.Forms.ComboBox cmbMedeniDurum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDogumTarih;
        private System.Windows.Forms.TabControl tabIsBasvuruKayit;
        private System.Windows.Forms.TabPage tabIsDeneyimi;
        private System.Windows.Forms.Button btnIsDeneyimiKaydet;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtKisininBolumu;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtOkulAdi;
        private System.Windows.Forms.TextBox txtBolumBitisYili;
        private System.Windows.Forms.TextBox txtNotOrtalamasi;
        private System.Windows.Forms.TextBox txtBolumBaslangicYili;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtEgitimDurumu;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtIsyeriAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsyeriAd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtIsyeriPozisyon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtIsyeriCalismaYili;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnIlanGuncelle;
    }
}