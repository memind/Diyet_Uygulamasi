using Data_Access_Layer.Context;

namespace _03_UI
{
    public partial class Form8 : Form
    {
        DiyetUygulamasiContext context;
        Form4 baseForm4;
        public Form8(Form4 form4)
        {
            InitializeComponent();
            baseForm4 = form4;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SiralamaDoldur();
            baseForm4.comboboxYemekdoldur(cmbYemekler);
            cmbYemekler.SelectedIndex = -1;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            baseForm4.Show();
            this.Close();
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiyasDoldur();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseForm4.Show();
        }

        /// <summary>
        /// Secilen yemegin hangi ogunde kac kere yendigini gosteren metot.
        /// </summary>
        private void KiyasDoldur()
        {
            context = new DiyetUygulamasiContext();
            var yemekKiyasSorgu = from yemekOgun in context.YemekOgun
                                  join ogun in context.Ogunler on yemekOgun.OgunId equals ogun.OgunId
                                  join yemek in context.Yemekler on yemekOgun.YemekId equals yemek.YemekId
                                  select new { YemekAdi = yemek.YemekAdi, Ogun = ogun.OgunTipi };

            var yemekKiyasGrup = (from veri in yemekKiyasSorgu
                                  group veri by veri.Ogun into grup
                                  select new { Ogun = grup.Key, Sayisi = grup.Where(x => x.Ogun == grup.Key && x.YemekAdi == cmbYemekler.Text).Count() }).ToList();

            dgvYemekKiyas.DataSource = yemekKiyasGrup;
            dgvYemekKiyas.Columns["Ogun"].Width = 150;
        }

        /// <summary>
        /// Yemekleri en cok yenenden en az yenene dogru siralayan ve kac kere yendiklerini gosteren metot
        /// </summary>
        private void SiralamaDoldur()
        {
            context = new DiyetUygulamasiContext();
            var yemekKiyasSorguTum = from yemekOgun in context.YemekOgun
                                     join ogun in context.Ogunler on yemekOgun.OgunId equals ogun.OgunId
                                     join yemek in context.Yemekler on yemekOgun.YemekId equals yemek.YemekId
                                     select new { YemekAdi = yemek.YemekAdi, Ogun = ogun.OgunTipi };

            var yemekKiyasSonucTum = (from veri in yemekKiyasSorguTum
                                      group veri by veri.YemekAdi into grup
                                      select new { YemekAdi = grup.Key, Sayisi = grup.Where(x => x.YemekAdi == grup.Key).Count() })
                                      .OrderByDescending(x => x.Sayisi);



            var sonTum = yemekKiyasSonucTum.ToList();
            dgvYemekSiralama.DataSource = sonTum;
            dgvYemekSiralama.Columns["YemekAdi"].Width = 150;
        }
    }
}
