using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using System.Data;

namespace _03_UI
{
    public partial class Form7 : Form
    {
        DiyetUygulamasiContext context;
        Form4 baseForm4;
        Kullanici user;

        public Form7(Form4 form4, Kullanici kullanici)
        {
            InitializeComponent();
            baseForm4 = form4;
            user = kullanici;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboboxOgundoldur(cmbOgunTipi);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm4.Show();
        }

        private void cmbOgunTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaporlariGetir();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseForm4.Show();
        }

        /// <summary>
        /// Icine verilen ComboBox'a ogunleri dolduran metot. 
        /// </summary>
        /// <param name="comboBox"></param>
        public void comboboxOgundoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = Enum.GetValues(typeof(OgunTipleri));
            comboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Kullanicinin yedigi ogunleri ve bu ogunlerde aldigi toplam kaloriyi aylik ve haftalik olarak gormesini ve diger kullanicilarin toplamlariyla kiyaslamasini saglayan metot.
        /// </summary>
        public void RaporlariGetir()
        {
            context = new DiyetUygulamasiContext();

            var raporKullaniciHaftalik = from yemekOgun in context.YemekOgun
                                         from ogun in context.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Day <= DateTime.Now.Day & x.Tarih.Day >= DateTime.Now.Day - 7 && x.KullaniciId == user.Id)
                                         from yemek in context.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                         from kullanici in context.Kullanicilar.Where(x => x.Id == user.Id)
                                         where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                         select new
                                         {
                                             Tarih = ogun.Tarih,
                                             OgunAdi = ogun.OgunTipi,
                                             Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                         };

            var sonucKullaniciHaftalik = from veri in raporKullaniciHaftalik
                                         group veri by veri.OgunAdi into Grup
                                         select new
                                         {
                                             OgunAdi = Grup.Key,
                                             Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Day <= DateTime.Now.Day && x.Tarih.Day >= DateTime.Now.Day - 7)
                                                          .Sum(x => x.Kalori)
                                         };

            dgvKullaniciHaftalik.DataSource = sonucKullaniciHaftalik.OrderByDescending(x => x.OgunAdi).ToList();


            var raporKullaniciAylik = from yemekOgun in context.YemekOgun
                                      from ogun in context.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Month == DateTime.Now.Month && x.KullaniciId == user.Id)
                                      from yemek in context.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                      from kullanici in context.Kullanicilar.Where(x => x.Id == user.Id)
                                      where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                      select new
                                      {
                                          Tarih = ogun.Tarih,
                                          OgunAdi = ogun.OgunTipi,
                                          Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                      };

            var sonucKullaniciAylik = from veri in raporKullaniciAylik
                                      group veri by veri.OgunAdi into Grup
                                      select new
                                      {
                                          OgunAdi = Grup.Key,
                                          Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Month == DateTime.Now.Month)
                                                       .Sum(x => x.Kalori)
                                      };

            dgvKullaniciAylik.DataSource = sonucKullaniciAylik.OrderByDescending(x => x.OgunAdi).ToList();


            var raporKullanicilarHaftalik = from yemekOgun in context.YemekOgun
                                            from ogun in context.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Day <= DateTime.Now.Day & x.Tarih.Day >= DateTime.Now.Day - 7)
                                            from yemek in context.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                            where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                            select new
                                            {
                                                Tarih = ogun.Tarih,
                                                OgunAdi = ogun.OgunTipi,
                                                Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                            };

            var sonucKullanicilarHaftalik = from veri in raporKullanicilarHaftalik
                                            group veri by veri.OgunAdi into Grup
                                            select new
                                            {
                                                OgunAdi = Grup.Key,
                                                Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Day <= DateTime.Now.Day && x.Tarih.Day >= DateTime.Now.Day - 7).Sum(x => x.Kalori)
                                            };

            dgvKullanicilarHaftalik.DataSource = sonucKullanicilarHaftalik.OrderByDescending(x => x.OgunAdi).ToList();


            var raporKullanicilarAylik = from yemekOgun in context.YemekOgun
                                         from ogun in context.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Month == DateTime.Now.Month)
                                         from yemek in context.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                         where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                         select new
                                         {
                                            Tarih = ogun.Tarih,
                                            OgunAdi = ogun.OgunTipi,
                                            Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                         };

            var sonucKullanicilarAylik = from veri in raporKullanicilarAylik
                                         group veri by veri.OgunAdi into Grup
                                         select new
                                         {
                                             OgunAdi = Grup.Key,
                                             Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Month == DateTime.Now.Month)
                                                          .Sum(x=>x.Kalori)
                                         };

            dgvKullanicilarAylik.DataSource = sonucKullanicilarAylik.OrderByDescending(x => x.OgunAdi).ToList();
        }

    }
}
