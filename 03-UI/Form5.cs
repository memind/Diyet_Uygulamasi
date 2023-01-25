using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using System.Data;

namespace _03_UI
{
    public partial class Form5 : Form
    {
        Kullanici kullanici;
        DiyetUygulamasiContext context;
        Form4 baseForm;

        public Form5(Kullanici user, Form4 form4)
        {
            InitializeComponent();
            kullanici = user;
            baseForm = form4;

            form4.comboboxOgundoldur(cmbOgunTipi);
            form4.comboboxYemekdoldur(cmbYemek);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Enum.TryParse<OgunTipleri>(cmbOgunTipi.SelectedValue.ToString(), out OgunTipleri status);

            Ogun yeniOgun = new Ogun()
            {
                KullaniciId = kullanici.Id,
                Tarih = dtpTarih.Value,
                OgunNo = OgunNoHesapla(),
                OgunTipi = status,
            };

            context.Ogunler.Add(yeniOgun);
            context.SaveChanges();

            YemekOgun yemekOgun = new YemekOgun()
            {
                YemekId = cmbYemek.SelectedIndex + 1,
                OgunId = yeniOgun.OgunId,
                Porsiyon = decimal.Parse(txtPorsiyon.Text),
                
            };

            context.YemekOgun.Add(yemekOgun);
            context.SaveChanges();

            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseForm.OgunleriListele();
            baseForm.Show();
        }

        /// <summary>
        /// Yeni olusturulan Ogun nesnesi icin OgunNo hesaplayan metot.
        /// </summary>
        /// <returns>OgunNo</returns>
        private int OgunNoHesapla()
        {
            context = new DiyetUygulamasiContext();
            int numara;

            if (context.Ogunler.Where(x => x.Tarih == DateTime.Now.Date &&  x.KullaniciId == kullanici.Id).OrderBy(x => x.OgunNo).LastOrDefault() != null)
            {
                numara = (int)context.Ogunler.Where(x => x.Tarih == DateTime.Now.Date)
                                             .OrderBy(x => x.OgunNo)
                                             .LastOrDefault().OgunNo + 1;
                return numara;
            }

            else
                return numara = 1;
        }
    }
}

