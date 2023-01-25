using Data_Access_Layer.Context;
using Entity;

namespace _03_UI
{
    public partial class Form1 : Form
    {
        DiyetUygulamasiContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();
            if (context.Yemekler.Count() == 0)
            {
                KategoriDoldur();
                YemekDoldur();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form2 frm2= new Form2(this);
            frm2.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Yemekleri veritabanina kaydeden metot
        /// </summary>
        private void YemekDoldur()
        {
            YemekEkle("Kayýsý", 1, 25);
            YemekEkle("Yoðurt", 5, 33);
            YemekEkle("Ekmek", 4, 66);
            YemekEkle("Cips", 6, 14.28m);
            YemekEkle("Tavuk Göðsü", 3, 100);
            YemekEkle("Muz", 1, 100);
            YemekEkle("Domates", 2, 33);
            YemekEkle("Yumurta", 3, 66);
            YemekEkle("Kýzarmýþ Patates", 2, 12.5m);
            YemekEkle("Badem", 7, 10);
            YemekEkle("Simit", 8, 300);
            YemekEkle("Taze Fasülye", 2, 50);
        }

        /// <summary>
        /// Kategorileri veritabanina kaydeden metot
        /// </summary>
        private void KategoriDoldur()
        {
            KategoriEkle("Meyveler", "");
            KategoriEkle("Sebzeler", "");
            KategoriEkle("Hayvansal Gýda", "");
            KategoriEkle("Ekmek", "");
            KategoriEkle("Süt Ürünleri", "");
            KategoriEkle("Cips", "");
            KategoriEkle("Kuruyemiþ", "");
            KategoriEkle("Kahvaltýlýk", "");
        }

        /// <summary>
        /// Yeni Kategori nesnesi olusturan metot.
        /// </summary>
        /// <param name="kategoriAdi"></param>
        /// <param name="kategoriAciklama"></param>
        private void KategoriEkle(string kategoriAdi, string kategoriAciklama)
        {
            Kategori yeniKategori = new Kategori()
            {
                KategoriAdi = kategoriAdi,
                Aciklama = kategoriAciklama
            };

            context.Kategoriler.Add(yeniKategori);
            context.SaveChanges();
        }

        /// <summary>
        /// Yeni Yemek nesnesi olusturan metot.
        /// </summary>
        /// <param name="adi"></param>
        /// <param name="kategori"></param>
        /// <param name="kalori"></param>
        private void YemekEkle(string adi, int kategori, decimal kalori)
        {
            Yemek yeniYemek = new Yemek()
            {
                YemekAdi = adi,
                KategoriId = kategori,
                Kalori = kalori
            };

            context.Yemekler.Add(yeniYemek);
            context.SaveChanges();
        }
    }
}