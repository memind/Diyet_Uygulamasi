using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using System.Data;


namespace _03_UI
{
    public partial class Form4 : Form
    {
        DiyetUygulamasiContext context;
        Kullanici user;

        public Form4(Kullanici kullanici)
        {
            InitializeComponent();
            user = kullanici;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboboxYemekdoldur(cmbYemek);
            OgunleriListele();
            KullaniciKaloriHesapla(lblKalori);
            btnOguneYemekEkle.Enabled = false;
            btnOgunSil.Enabled = false;
        }

        private void btnOguneYemekEkle_Click(object sender, EventArgs e)
        {
            gbYeniOgun.Visible = true;
        }

        private void btnYemekKaydet_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            YemekOgun yemekOgun = new YemekOgun()
            {
                YemekId = cmbYemek.SelectedIndex + 1,
                OgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value,
                Porsiyon = decimal.Parse(txtPorsiyon.Text)
            };

            context.YemekOgun.Add(yemekOgun);
            context.SaveChanges();

            OgunleriListele();
            OgundekiYemekleriListele();
            gbYeniOgun.Visible = false;
        }

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgundekiYemekleriListele();
            btnOguneYemekEkle.Enabled = true;
            btnOgunSil.Enabled = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            user = null;
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            var silinecekOgunler = context.YemekOgun.Where(x => x.OgunId == (int)dgvOgunler.SelectedCells[0].Value)
                                                    .ToList();

            silinecekOgunler.ForEach(x => context.YemekOgun.Remove(x));

            context.Ogunler.Remove(context.Ogunler.Find((int)dgvOgunler.SelectedCells[0].Value));
            context.SaveChanges();

            OgunleriListele();
            OgundekiYemekleriListele();
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            var silinecekYemekOgun = context.YemekOgun.Where(x => x.YemekOgunId == (int)dgvOgundekiYemekler.SelectedRows[0].Cells[0].Value).ToList();

            silinecekYemekOgun.ForEach(x => context.YemekOgun.Remove(x));
            context.SaveChanges();

            OgundekiYemekleriListele();
        }

        private void btnYeniOgun_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(user, this);
            this.Hide();
            form5.Show();
        }

        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this, user); 
            this.Hide();
            form6.Show();
        }

        private void btnKiyasRaporu_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this, user);
            this.Hide();
            form7.Show();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            this.Hide();
            form8.Show();
        }

        private void dgvOgunler_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            KullaniciKaloriHesapla(lblKalori);
        }

        private void dgvOgunler_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            KullaniciKaloriHesapla(lblKalori);
        }

        private void dgvOgundekiYemekler_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            KullaniciKaloriHesapla(lblKalori);
        }

        private void dgvOgundekiYemekler_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            KullaniciKaloriHesapla(lblKalori);
        }

        /// <summary>
        /// Secilen ogunde tuketilen yemekleri listeleyen metot.
        /// </summary>
        private void OgundekiYemekleriListele()
        {
            dgvOgundekiYemekler.DataSource = null;
            dgvOgundekiYemekler.Rows.Clear();

            context = new DiyetUygulamasiContext();

            var sanalTablo = context.YemekOgun.Join(context.Yemekler,
                                                   yo => yo.YemekId,
                                                   y => y.YemekId,
                                                   (yo, y) => new { y.YemekAdi, y.Kalori, yo.OgunId, yo.Porsiyon, yo.YemekOgunId })
                                              .Join(context.Ogunler,
                                                   yoy => yoy.OgunId,
                                                   og => og.OgunId,
                                                   (yoy, og) =>
                                              new
                                              {
                                                  yoy.YemekOgunId,
                                                  og.OgunId,
                                                  og.KullaniciId,
                                                  Tipi = og.OgunTipi.ToString(),
                                                  og.Tarih,
                                                  og.OgunNo,
                                                  yoy.YemekAdi,
                                                  Kalori = yoy.Kalori * yoy.Porsiyon
                                              })
              .Where(x => x.KullaniciId == user.Id &&
              x.OgunId == (int)dgvOgunler.SelectedRows[0].Cells[0].Value)
                                              .ToList();

            dgvOgundekiYemekler.DataSource = sanalTablo;


            dgvOgundekiYemekler.Columns["Tarih"].Width = 80;
            dgvOgundekiYemekler.Columns["OgunNo"].Width = 70;
            dgvOgundekiYemekler.Columns["Tipi"].Width = 70;
            dgvOgundekiYemekler.Columns["Kalori"].Width = 75;

            dgvOgundekiYemekler.Columns["OgunId"].Visible = false;
            dgvOgundekiYemekler.Columns["YemekOgunId"].Visible = false;
            dgvOgundekiYemekler.Columns["KullaniciId"].Visible = false;
        }

        /// <summary>
        /// Ogunleri listeleyen metot.
        /// </summary>
        public void OgunleriListele()
        {
            dgvOgunler.DataSource = null;
            dgvOgunler.Rows.Clear();

            context = new DiyetUygulamasiContext();

            var sanalTablo = context.Ogunler.Where(x => x.KullaniciId == user.Id && x.Tarih.Date.Day == DateTime.Now.Day).ToList();

            dgvOgunler.DataSource = sanalTablo;
            dgvOgunler.Columns["OgunId"].Visible = false;
            dgvOgunler.Columns["KullaniciId"].Visible = false;
            dgvOgunler.Columns["Kullanici"].Visible = false;
            dgvOgunler.Columns["Yemek"].Visible = false;
            dgvOgunler.Columns["Tarih"].Width = 80;
            dgvOgunler.Columns["OgunNo"].Width = 70;
            dgvOgunler.Columns["OgunTipi"].Width = 120;
        }

        /// <summary>
        /// Icine verilen ComboBox'i ogun tipleriyle dolduran metot.
        /// </summary>
        /// <param name="comboBox"></param>
        public void comboboxOgundoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = Enum.GetValues(typeof(OgunTipleri));
            comboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Icine verilen ComboBox'i yemek isimleriyle dolduran metot.
        /// </summary>
        /// <param name="comboBox"></param>
        public void comboboxYemekdoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = context.Yemekler.ToList();
            comboBox.DisplayMember = "YemekAdi";
            comboBox.ValueMember = "YemekId";
            comboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Kullanicinin o gunku toplam kalorisini hesaplayip icine aldigi parametrenin "Text" ozelligine yazdiran metot.
        /// </summary>
        private void KullaniciKaloriHesapla(Label lbl)
        {
            context = new DiyetUygulamasiContext();

            var kalori = context.YemekOgun.Join(context.Yemekler,
                                                 yo => yo.YemekId,
                                                 y => y.YemekId,
                                                 (yo, y) => new { y.YemekAdi, y.Kalori, yo.OgunId, yo.Porsiyon, yo.YemekOgunId })
                                           .Join(context.Ogunler,
                                                 yoy => yoy.OgunId,
                                                 og => og.OgunId,
                                                 (yoy, og) => new
                                                 {
                                                     og.KullaniciId,
                                                     og.Tarih,
                                                     yoy.Kalori,
                                                     yoy.Porsiyon
                                                 })
                                           .Where(x => x.KullaniciId == user.Id && x.Tarih.Date == DateTime.Now.Date)
                                           .Sum(x => x.Kalori * x.Porsiyon);

            lbl.Text = kalori.ToString();
        }
    }
}
