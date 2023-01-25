namespace _03_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbAmac = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSecenekler = new System.Windows.Forms.GroupBox();
            this.gbAmac.SuspendLayout();
            this.gbSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAmac
            // 
            this.gbAmac.Controls.Add(this.label2);
            this.gbAmac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAmac.Location = new System.Drawing.Point(8, 8);
            this.gbAmac.Margin = new System.Windows.Forms.Padding(2);
            this.gbAmac.Name = "gbAmac";
            this.gbAmac.Padding = new System.Windows.Forms.Padding(2);
            this.gbAmac.Size = new System.Drawing.Size(395, 295);
            this.gbAmac.TabIndex = 0;
            this.gbAmac.TabStop = false;
            this.gbAmac.Text = "Programın amacı";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 240);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(11, 37);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(375, 43);
            this.btnKayitOl.TabIndex = 1;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(11, 119);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(375, 43);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "veya";
            // 
            // gbSecenekler
            // 
            this.gbSecenekler.Controls.Add(this.btnGirisYap);
            this.gbSecenekler.Controls.Add(this.btnKayitOl);
            this.gbSecenekler.Controls.Add(this.label1);
            this.gbSecenekler.Location = new System.Drawing.Point(8, 307);
            this.gbSecenekler.Margin = new System.Windows.Forms.Padding(2);
            this.gbSecenekler.Name = "gbSecenekler";
            this.gbSecenekler.Padding = new System.Windows.Forms.Padding(2);
            this.gbSecenekler.Size = new System.Drawing.Size(395, 177);
            this.gbSecenekler.TabIndex = 4;
            this.gbSecenekler.TabStop = false;
            this.gbSecenekler.Text = "Oturum Açma Seçenekleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 494);
            this.Controls.Add(this.gbSecenekler);
            this.Controls.Add(this.gbAmac);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAmac.ResumeLayout(false);
            this.gbSecenekler.ResumeLayout(false);
            this.gbSecenekler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbAmac;
        private Label label2;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private Label label1;
        private GroupBox gbSecenekler;
    }
}