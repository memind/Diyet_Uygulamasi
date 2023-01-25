namespace _03_UI
{
    partial class Form8
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
            this.dgvYemekSiralama = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYemekKiyas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekSiralama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekKiyas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYemekSiralama
            // 
            this.dgvYemekSiralama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekSiralama.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYemekSiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekSiralama.Location = new System.Drawing.Point(14, 235);
            this.dgvYemekSiralama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvYemekSiralama.Name = "dgvYemekSiralama";
            this.dgvYemekSiralama.RowHeadersVisible = false;
            this.dgvYemekSiralama.RowHeadersWidth = 51;
            this.dgvYemekSiralama.RowTemplate.Height = 25;
            this.dgvYemekSiralama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvYemekSiralama.Size = new System.Drawing.Size(566, 245);
            this.dgvYemekSiralama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "En Çok Yenen Yemekler";
            // 
            // dgvYemekKiyas
            // 
            this.dgvYemekKiyas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekKiyas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekKiyas.Location = new System.Drawing.Point(14, 43);
            this.dgvYemekKiyas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvYemekKiyas.Name = "dgvYemekKiyas";
            this.dgvYemekKiyas.RowHeadersVisible = false;
            this.dgvYemekKiyas.RowHeadersWidth = 51;
            this.dgvYemekKiyas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvYemekKiyas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYemekKiyas.Size = new System.Drawing.Size(566, 143);
            this.dgvYemekKiyas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yemeklerin Kıyas Raporu";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(494, 507);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(86, 31);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Location = new System.Drawing.Point(321, 507);
            this.cmbYemekler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(138, 28);
            this.cmbYemekler.TabIndex = 3;
            this.cmbYemekler.SelectedIndexChanged += new System.EventHandler(this.cmbYemekler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kıyaslamak İstediğiniz Yemeği Seçiniz:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYemekler);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYemekKiyas);
            this.Controls.Add(this.dgvYemekSiralama);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form8";
            this.Text = "Form8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekSiralama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekKiyas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvYemekSiralama;
        private Label label1;
        private DataGridView dgvYemekKiyas;
        private Label label2;
        private Button btnGeriDon;
        private ComboBox cmbYemekler;
        private Label label3;
    }
}