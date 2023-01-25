namespace _03_UI
{
    partial class Form4
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
            this.gbKaloriTakip = new System.Windows.Forms.GroupBox();
            this.lblKalori = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniOgun = new System.Windows.Forms.Button();
            this.gbOgunler = new System.Windows.Forms.GroupBox();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnOgundenYemekSil = new System.Windows.Forms.Button();
            this.dgvOgunler = new System.Windows.Forms.DataGridView();
            this.dgvOgundekiYemekler = new System.Windows.Forms.DataGridView();
            this.btnGunSonuRaporu = new System.Windows.Forms.Button();
            this.btnKiyasRaporu = new System.Windows.Forms.Button();
            this.btnYemekCesidiRaporu = new System.Windows.Forms.Button();
            this.btnOguneYemekEkle = new System.Windows.Forms.Button();
            this.gbYeniOgun = new System.Windows.Forms.GroupBox();
            this.btnYemekKaydet = new System.Windows.Forms.Button();
            this.txtPorsiyon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gbKaloriTakip.SuspendLayout();
            this.gbOgunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgundekiYemekler)).BeginInit();
            this.gbYeniOgun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKaloriTakip
            // 
            this.gbKaloriTakip.Controls.Add(this.lblKalori);
            this.gbKaloriTakip.Controls.Add(this.label1);
            this.gbKaloriTakip.Location = new System.Drawing.Point(8, 8);
            this.gbKaloriTakip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbKaloriTakip.Name = "gbKaloriTakip";
            this.gbKaloriTakip.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbKaloriTakip.Size = new System.Drawing.Size(997, 83);
            this.gbKaloriTakip.TabIndex = 0;
            this.gbKaloriTakip.TabStop = false;
            this.gbKaloriTakip.Text = "Kalori Takip";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Location = new System.Drawing.Point(106, 37);
            this.lblKalori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(50, 20);
            this.lblKalori.TabIndex = 1;
            this.lblKalori.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaloriniz :";
            // 
            // btnYeniOgun
            // 
            this.btnYeniOgun.Location = new System.Drawing.Point(384, 491);
            this.btnYeniOgun.Name = "btnYeniOgun";
            this.btnYeniOgun.Size = new System.Drawing.Size(195, 51);
            this.btnYeniOgun.TabIndex = 10;
            this.btnYeniOgun.Text = "ÖĞÜN EKLE";
            this.btnYeniOgun.UseVisualStyleBackColor = true;
            this.btnYeniOgun.Click += new System.EventHandler(this.btnYeniOgun_Click);
            // 
            // gbOgunler
            // 
            this.gbOgunler.Controls.Add(this.btnOgunSil);
            this.gbOgunler.Controls.Add(this.btnOgundenYemekSil);
            this.gbOgunler.Controls.Add(this.dgvOgunler);
            this.gbOgunler.Controls.Add(this.dgvOgundekiYemekler);
            this.gbOgunler.Location = new System.Drawing.Point(8, 95);
            this.gbOgunler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbOgunler.Name = "gbOgunler";
            this.gbOgunler.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbOgunler.Size = new System.Drawing.Size(959, 367);
            this.gbOgunler.TabIndex = 1;
            this.gbOgunler.TabStop = false;
            this.gbOgunler.Text = "Bugün Aldığın Öğünler Listesi";
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.Location = new System.Drawing.Point(259, 309);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(94, 51);
            this.btnOgunSil.TabIndex = 2;
            this.btnOgunSil.Text = "ÖĞÜN SİL";
            this.btnOgunSil.UseVisualStyleBackColor = true;
            this.btnOgunSil.Click += new System.EventHandler(this.btnOgunSil_Click);
            // 
            // btnOgundenYemekSil
            // 
            this.btnOgundenYemekSil.Location = new System.Drawing.Point(782, 311);
            this.btnOgundenYemekSil.Name = "btnOgundenYemekSil";
            this.btnOgundenYemekSil.Size = new System.Drawing.Size(165, 51);
            this.btnOgundenYemekSil.TabIndex = 4;
            this.btnOgundenYemekSil.Text = "ÖĞÜNDEN YEMEK SİL";
            this.btnOgundenYemekSil.UseVisualStyleBackColor = true;
            this.btnOgundenYemekSil.Click += new System.EventHandler(this.btnYemekSil_Click);
            // 
            // dgvOgunler
            // 
            this.dgvOgunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunler.Location = new System.Drawing.Point(9, 20);
            this.dgvOgunler.MultiSelect = false;
            this.dgvOgunler.Name = "dgvOgunler";
            this.dgvOgunler.ReadOnly = true;
            this.dgvOgunler.RowHeadersVisible = false;
            this.dgvOgunler.RowHeadersWidth = 51;
            this.dgvOgunler.RowTemplate.Height = 29;
            this.dgvOgunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunler.Size = new System.Drawing.Size(347, 284);
            this.dgvOgunler.TabIndex = 1;
            this.dgvOgunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgunler_CellClick);
            this.dgvOgunler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvOgunler_ColumnAdded);
            this.dgvOgunler.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvOgunler_ColumnRemoved);
            // 
            // dgvOgundekiYemekler
            // 
            this.dgvOgundekiYemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgundekiYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgundekiYemekler.Location = new System.Drawing.Point(376, 23);
            this.dgvOgundekiYemekler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvOgundekiYemekler.MultiSelect = false;
            this.dgvOgundekiYemekler.Name = "dgvOgundekiYemekler";
            this.dgvOgundekiYemekler.RowHeadersVisible = false;
            this.dgvOgundekiYemekler.RowHeadersWidth = 72;
            this.dgvOgundekiYemekler.RowTemplate.Height = 37;
            this.dgvOgundekiYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgundekiYemekler.Size = new System.Drawing.Size(570, 284);
            this.dgvOgundekiYemekler.TabIndex = 3;
            this.dgvOgundekiYemekler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvOgundekiYemekler_ColumnAdded);
            this.dgvOgundekiYemekler.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvOgundekiYemekler_ColumnRemoved);
            // 
            // btnGunSonuRaporu
            // 
            this.btnGunSonuRaporu.Location = new System.Drawing.Point(8, 549);
            this.btnGunSonuRaporu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            this.btnGunSonuRaporu.Size = new System.Drawing.Size(174, 51);
            this.btnGunSonuRaporu.TabIndex = 6;
            this.btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            this.btnGunSonuRaporu.UseVisualStyleBackColor = true;
            this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);
            // 
            // btnKiyasRaporu
            // 
            this.btnKiyasRaporu.Location = new System.Drawing.Point(8, 491);
            this.btnKiyasRaporu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKiyasRaporu.Name = "btnKiyasRaporu";
            this.btnKiyasRaporu.Size = new System.Drawing.Size(174, 51);
            this.btnKiyasRaporu.TabIndex = 5;
            this.btnKiyasRaporu.Text = "Kıyas Raporu";
            this.btnKiyasRaporu.UseVisualStyleBackColor = true;
            this.btnKiyasRaporu.Click += new System.EventHandler(this.btnKiyasRaporu_Click);
            // 
            // btnYemekCesidiRaporu
            // 
            this.btnYemekCesidiRaporu.Location = new System.Drawing.Point(8, 611);
            this.btnYemekCesidiRaporu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            this.btnYemekCesidiRaporu.Size = new System.Drawing.Size(174, 51);
            this.btnYemekCesidiRaporu.TabIndex = 7;
            this.btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            this.btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            this.btnYemekCesidiRaporu.Click += new System.EventHandler(this.btnYemekCesidiRaporu_Click);
            // 
            // btnOguneYemekEkle
            // 
            this.btnOguneYemekEkle.Location = new System.Drawing.Point(384, 549);
            this.btnOguneYemekEkle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOguneYemekEkle.Name = "btnOguneYemekEkle";
            this.btnOguneYemekEkle.Size = new System.Drawing.Size(195, 51);
            this.btnOguneYemekEkle.TabIndex = 11;
            this.btnOguneYemekEkle.Text = "ÖĞÜNE YEMEK EKLE";
            this.btnOguneYemekEkle.UseVisualStyleBackColor = true;
            this.btnOguneYemekEkle.Click += new System.EventHandler(this.btnOguneYemekEkle_Click);
            // 
            // gbYeniOgun
            // 
            this.gbYeniOgun.Controls.Add(this.btnYemekKaydet);
            this.gbYeniOgun.Controls.Add(this.txtPorsiyon);
            this.gbYeniOgun.Controls.Add(this.label6);
            this.gbYeniOgun.Controls.Add(this.label5);
            this.gbYeniOgun.Controls.Add(this.cmbYemek);
            this.gbYeniOgun.Location = new System.Drawing.Point(584, 483);
            this.gbYeniOgun.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbYeniOgun.Name = "gbYeniOgun";
            this.gbYeniOgun.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbYeniOgun.Size = new System.Drawing.Size(382, 201);
            this.gbYeniOgun.TabIndex = 7;
            this.gbYeniOgun.TabStop = false;
            this.gbYeniOgun.Text = "Öğün Bilgileri Gir";
            this.gbYeniOgun.Visible = false;
            // 
            // btnYemekKaydet
            // 
            this.btnYemekKaydet.Location = new System.Drawing.Point(234, 131);
            this.btnYemekKaydet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYemekKaydet.Name = "btnYemekKaydet";
            this.btnYemekKaydet.Size = new System.Drawing.Size(136, 51);
            this.btnYemekKaydet.TabIndex = 14;
            this.btnYemekKaydet.Text = "Yemek Kaydet";
            this.btnYemekKaydet.UseVisualStyleBackColor = true;
            this.btnYemekKaydet.Click += new System.EventHandler(this.btnYemekKaydet_Click);
            // 
            // txtPorsiyon
            // 
            this.txtPorsiyon.Location = new System.Drawing.Point(86, 85);
            this.txtPorsiyon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPorsiyon.Name = "txtPorsiyon";
            this.txtPorsiyon.Size = new System.Drawing.Size(284, 27);
            this.txtPorsiyon.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porsiyon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yemek:";
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(86, 37);
            this.cmbYemek.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(284, 28);
            this.cmbYemek.TabIndex = 12;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(114, 665);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(69, 51);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(8, 665);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(101, 51);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Uygulamayı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 739);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYeniOgun);
            this.Controls.Add(this.gbYeniOgun);
            this.Controls.Add(this.btnOguneYemekEkle);
            this.Controls.Add(this.btnYemekCesidiRaporu);
            this.Controls.Add(this.btnKiyasRaporu);
            this.Controls.Add(this.btnGunSonuRaporu);
            this.Controls.Add(this.gbOgunler);
            this.Controls.Add(this.gbKaloriTakip);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gbKaloriTakip.ResumeLayout(false);
            this.gbKaloriTakip.PerformLayout();
            this.gbOgunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgundekiYemekler)).EndInit();
            this.gbYeniOgun.ResumeLayout(false);
            this.gbYeniOgun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbKaloriTakip;
        private Label lblKalori;
        private Label label1;
        private GroupBox gbOgunler;
        private DataGridView dgvOgundekiYemekler;
        private Button btnGunSonuRaporu;
        private Button btnKiyasRaporu;
        private Button btnYemekCesidiRaporu;
        private Button btnOguneYemekEkle;
        private GroupBox gbYeniOgun;
        private Button btnYemekKaydet;
        private TextBox txtPorsiyon;
        private Label label6;
        private Label label5;
        private ComboBox cmbYemek;
        private Button btnYeniOgun;
        private DataGridView dgvOgunler;
        private Button btnCikis;
        private Button btnKapat;
        private Button btnOgunSil;
        private Button btnOgundenYemekSil;
    }
}