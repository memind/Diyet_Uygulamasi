namespace _03_UI
{
    partial class Form7
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
            this.dgvKullaniciHaftalik = new System.Windows.Forms.DataGridView();
            this.gbRapor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOgunTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKullanicilarAylik = new System.Windows.Forms.DataGridView();
            this.dgvKullaniciAylik = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.dgvKullanicilarHaftalik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciHaftalik)).BeginInit();
            this.gbRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilarAylik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciAylik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilarHaftalik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullaniciHaftalik
            // 
            this.dgvKullaniciHaftalik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullaniciHaftalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciHaftalik.Location = new System.Drawing.Point(7, 103);
            this.dgvKullaniciHaftalik.Margin = new System.Windows.Forms.Padding(0);
            this.dgvKullaniciHaftalik.Name = "dgvKullaniciHaftalik";
            this.dgvKullaniciHaftalik.RowHeadersVisible = false;
            this.dgvKullaniciHaftalik.RowHeadersWidth = 51;
            this.dgvKullaniciHaftalik.RowTemplate.Height = 25;
            this.dgvKullaniciHaftalik.Size = new System.Drawing.Size(565, 149);
            this.dgvKullaniciHaftalik.TabIndex = 0;
            // 
            // gbRapor
            // 
            this.gbRapor.Controls.Add(this.label3);
            this.gbRapor.Controls.Add(this.label5);
            this.gbRapor.Controls.Add(this.label2);
            this.gbRapor.Controls.Add(this.cmbOgunTipi);
            this.gbRapor.Controls.Add(this.label4);
            this.gbRapor.Controls.Add(this.label1);
            this.gbRapor.Controls.Add(this.dgvKullanicilarAylik);
            this.gbRapor.Controls.Add(this.dgvKullaniciAylik);
            this.gbRapor.Controls.Add(this.btnGeriDon);
            this.gbRapor.Controls.Add(this.dgvKullanicilarHaftalik);
            this.gbRapor.Controls.Add(this.dgvKullaniciHaftalik);
            this.gbRapor.Location = new System.Drawing.Point(14, 16);
            this.gbRapor.Margin = new System.Windows.Forms.Padding(0);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRapor.Size = new System.Drawing.Size(1175, 528);
            this.gbRapor.TabIndex = 1;
            this.gbRapor.TabStop = false;
            this.gbRapor.Text = "Rapor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tüm Kullanıcıların Haftalık Raporu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Karşılaştırılacak Öğün Seçiniz: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcının Haftalık Raporu";
            // 
            // cmbOgunTipi
            // 
            this.cmbOgunTipi.FormattingEnabled = true;
            this.cmbOgunTipi.Location = new System.Drawing.Point(221, 37);
            this.cmbOgunTipi.Name = "cmbOgunTipi";
            this.cmbOgunTipi.Size = new System.Drawing.Size(151, 28);
            this.cmbOgunTipi.TabIndex = 4;
            this.cmbOgunTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOgunTipi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tüm Kullanıcıların Aylık Raporu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcının Aylık Raporu";
            // 
            // dgvKullanicilarAylik
            // 
            this.dgvKullanicilarAylik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilarAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilarAylik.Location = new System.Drawing.Point(603, 288);
            this.dgvKullanicilarAylik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKullanicilarAylik.Name = "dgvKullanicilarAylik";
            this.dgvKullanicilarAylik.RowHeadersVisible = false;
            this.dgvKullanicilarAylik.RowHeadersWidth = 51;
            this.dgvKullanicilarAylik.RowTemplate.Height = 25;
            this.dgvKullanicilarAylik.Size = new System.Drawing.Size(565, 149);
            this.dgvKullanicilarAylik.TabIndex = 2;
            // 
            // dgvKullaniciAylik
            // 
            this.dgvKullaniciAylik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullaniciAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciAylik.Location = new System.Drawing.Point(7, 288);
            this.dgvKullaniciAylik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKullaniciAylik.Name = "dgvKullaniciAylik";
            this.dgvKullaniciAylik.RowHeadersVisible = false;
            this.dgvKullaniciAylik.RowHeadersWidth = 51;
            this.dgvKullaniciAylik.RowTemplate.Height = 25;
            this.dgvKullaniciAylik.Size = new System.Drawing.Size(565, 149);
            this.dgvKullaniciAylik.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(859, 469);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(306, 39);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "G E R İ   D Ö N";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // dgvKullanicilarHaftalik
            // 
            this.dgvKullanicilarHaftalik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilarHaftalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilarHaftalik.Location = new System.Drawing.Point(603, 103);
            this.dgvKullanicilarHaftalik.Margin = new System.Windows.Forms.Padding(0);
            this.dgvKullanicilarHaftalik.Name = "dgvKullanicilarHaftalik";
            this.dgvKullanicilarHaftalik.RowHeadersVisible = false;
            this.dgvKullanicilarHaftalik.RowHeadersWidth = 51;
            this.dgvKullanicilarHaftalik.RowTemplate.Height = 25;
            this.dgvKullanicilarHaftalik.Size = new System.Drawing.Size(565, 149);
            this.dgvKullanicilarHaftalik.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 560);
            this.Controls.Add(this.gbRapor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciHaftalik)).EndInit();
            this.gbRapor.ResumeLayout(false);
            this.gbRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilarAylik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciAylik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilarHaftalik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvKullaniciHaftalik;
        private GroupBox gbRapor;
        private Button btnGeriDon;
        private DataGridView dgvKullaniciAylik;
        private Label label1;
        private ComboBox cmbOgunTipi;
        private DataGridView dgvKullanicilarAylik;
        private DataGridView dgvKullanicilarHaftalik;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}