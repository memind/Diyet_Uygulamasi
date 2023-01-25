using Data_Access_Layer.Context;
using Entity;
using System.Data;

namespace _03_UI
{
    public partial class Form6 : Form
    {
        Form4 baseForm4;
        Kullanici user;
        DiyetUygulamasiContext ctx;

        public Form6(Form4 form4, Kullanici kullanici)
        {
            InitializeComponent();
            baseForm4 = form4;
            user = kullanici;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GunSonuRaporuYazdir();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm4.Show();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseForm4.Show();
        }

        /// <summary>
        /// Kullaniciya o gun hangi tipteki ogunlerde toplam kac kalori aldigini getiren metot.
        /// </summary>
        private void GunSonuRaporuYazdir()
        {
            ctx = new DiyetUygulamasiContext();

            var gunSonuRaporu = ctx.Yemekler
                                .Join(ctx.YemekOgun,
                                        y => y.YemekId,
                                        yo => yo.YemekId,
                                        (y, yo) => new { y.Kalori, yo.Porsiyon, yo.OgunId })
                                .Join(ctx.Ogunler,
                                        yyo => yyo.OgunId,
                                        o => o.OgunId,
                                        (yyo, o) => new
                                        {
                                            yyo.OgunId,
                                            o.KullaniciId,
                                            o.OgunTipi,
                                            o.Tarih,
                                            Kalori = (yyo.Kalori * yyo.Porsiyon)
                                        })
                                .Where(x => x.KullaniciId == user.Id && x.Tarih == DateTime.Now.Date)
                                .ToList();

            var gunSonuRaporuGrup = (from veri in gunSonuRaporu
                                     group veri by veri.OgunTipi into grup
                                     select new
                                     {
                                         Ogun = grup.Key,
                                         Kalori = grup.Where(x => x.OgunTipi == grup.Key)
                                                      .Sum(x => x.Kalori)
                                     }).ToList();

            dgvGunSonuRaporu.DataSource = gunSonuRaporuGrup;
        }

    }
}
