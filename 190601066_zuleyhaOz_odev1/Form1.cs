using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Configuration;

namespace _190601066_zuleyhaOz_odev1
{
    public partial class fSayilarlaIslemler : Form
    {
        static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "Error";
            }
        }
        public fSayilarlaIslemler()
        {
            InitializeComponent();
            string tabName = ReadSetting("islem_tipi");
            foreach (TabPage tab in tbMenu.TabPages)
            {
                if (tabName.Equals(tab.Name))
                {
                    tbMenu.SelectedTab = tab;
                    break;
                }
                else
                {
                    tbMenu.SelectedIndex = 0;
                }
            }
        }

        public void EkranHazirla()
        {
            msktxtBaslangic.Text = "1";
            msktxtBitis.Text = "10000";
            msktxtBaslangic.Focus();
        }

        Boolean Dogrula(int baslangic, int bitis)
        {
            return (bitis > baslangic) ? true : false;
        }

        void Clear()
        {
            lvTekSayilar.Items.Clear();
            lvCiftSayilar.Items.Clear();
            lvAsalSayilar.Items.Clear();
            lvArmstrongSayilar.Items.Clear();
        }

        void AsalSayiSonuc(int baslangic, int bitis)
        {
            int asalToplam = 0;
            BigInteger asalCarpim = 1;


            bool asalMi = true;

            for (int kntrlEdilenSayi = baslangic; kntrlEdilenSayi <= bitis; kntrlEdilenSayi++)
            {

                for (int i = 2; i < kntrlEdilenSayi; i++)
                {
                    if (kntrlEdilenSayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }

                }

                if ((asalMi == true) && (kntrlEdilenSayi != 1))
                {
                    asalToplam += kntrlEdilenSayi;
                    asalCarpim *= kntrlEdilenSayi;

                    lvAsalSayilar.Items.Add(kntrlEdilenSayi.ToString());

                }

                asalMi = true;
            }

            lvAsalSayilar.Items.Add("Asal Sayıların Toplamı: " + asalToplam.ToString());
            lvAsalSayilar.Items.Add("Asal Sayıların Çarpımı: " + asalCarpim.ToString());

        }

        void TekSayilar(int baslangic, int bitis)
        {
            int tekToplam = 0;
            BigInteger tekCarpim = 1;

            for (int sayi = baslangic; sayi <= bitis; sayi++)
            {
                if (sayi % 2 == 1)
                {
                    tekToplam += sayi;
                    tekCarpim *= sayi;
                    lvTekSayilar.Items.Add(sayi.ToString());
                }
            }

            lvTekSayilar.Items.Add("\n\nTek sayıların toplamı: " + tekToplam.ToString());
            lvTekSayilar.Items.Add("\n\nTek sayıların çarpımı: " + tekCarpim.ToString());
        }

        void CiftSayilar(int baslangic, int bitis)
        {
            int ciftToplam = 0;
            BigInteger ciftCarpim = 1;

            for (int sayi = baslangic; sayi <= bitis; sayi++)
            {
                if (sayi % 2 == 0)
                {
                    ciftToplam += sayi;
                    ciftCarpim *= sayi;
                    lvCiftSayilar.Items.Add(sayi.ToString());
                }
            }

            lvCiftSayilar.Items.Add("\n\nCift sayıların toplamı: " + ciftToplam.ToString());
            lvCiftSayilar.Items.Add("\n\nCift sayıların çarpımı: " + ciftCarpim.ToString());
        }

        void ArmstrongSayilar(int baslangic, int bitis)
        {
            int birinciBasamak, ikinciBasamak, ucuncuBasamak, dorduncuBasamak, geciciDeger;
            int basamak;

            int armstrongToplam = 0;
            BigInteger armstrongCarpim = 1;

            for (int i = baslangic; i <= bitis; i++)
            {
                geciciDeger = i;
                basamak = 0;

                while (geciciDeger > 0)
                {
                    geciciDeger /= 10;
                    basamak++;
                }

                if (basamak == 1)
                {
                    if (i == 1)
                    {
                        lvArmstrongSayilar.Items.Add(i.ToString());
                    }
                }
                else if (basamak == 3)
                {
                    birinciBasamak = i % 10;
                    ikinciBasamak = (i / 10) % 10;
                    ucuncuBasamak = (i / 100);

                    if (i == (birinciBasamak * birinciBasamak * birinciBasamak) + (ikinciBasamak * ikinciBasamak * ikinciBasamak) + (ucuncuBasamak * ucuncuBasamak * ucuncuBasamak))
                    {
                        armstrongToplam += i;
                        armstrongCarpim *= i;
                        lvArmstrongSayilar.Items.Add(i.ToString());
                    }
                }
                else if (basamak == 4)
                {
                    birinciBasamak = i % 10;
                    ikinciBasamak = (i / 10) % 10;
                    ucuncuBasamak = (i / 100) % 10;
                    dorduncuBasamak = (i / 1000);

                    if (i == (birinciBasamak * birinciBasamak * birinciBasamak * birinciBasamak) + (ikinciBasamak * ikinciBasamak * ikinciBasamak * ikinciBasamak) + (ucuncuBasamak * ucuncuBasamak * ucuncuBasamak * ucuncuBasamak) + (dorduncuBasamak * dorduncuBasamak * dorduncuBasamak * dorduncuBasamak))
                    {
                        armstrongToplam += i;
                        armstrongCarpim *= i;
                        lvArmstrongSayilar.Items.Add(i.ToString());
                    }
                }
            }

             lvArmstrongSayilar.Items.Add("Armstrong sayıların toplamı: " + armstrongToplam.ToString());
             lvArmstrongSayilar.Items.Add("Armstrong sayıların çarpımı: " + armstrongCarpim.ToString());

        }

            private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(msktxtBaslangic.Text);
            int bitis = Convert.ToInt32(msktxtBitis.Text);

            Clear();

            if (Dogrula(baslangic, bitis))
            {
                AsalSayiSonuc(baslangic, bitis);

                TekSayilar(baslangic, bitis);

                CiftSayilar(baslangic, bitis);

                ArmstrongSayilar(baslangic, bitis);
            }
            else
            {
                MessageBox.Show("Bitiş değeri başlangıç değerinden küçük olamaz !!!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = (tbMenu.SelectedIndex - 1 < tbMenu.TabCount) ? tbMenu.SelectedIndex - 1 : tbMenu.SelectedIndex;

            if (tbMenu.SelectedIndex < 0)
                tbMenu.SelectedIndex = 0;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = (tbMenu.SelectedIndex + 1 < tbMenu.TabCount) ? tbMenu.SelectedIndex + 1 : tbMenu.SelectedIndex;
        }

        private void fSayilarlaIslemler_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void fSayilarlaIslemler_Load(object sender, EventArgs e)
        {
            notifyUyari.BalloonTipIcon = ToolTipIcon.Info;
            notifyUyari.BalloonTipText = "Nesne Yönelimli Programlama Ödev 1";
            notifyUyari.BalloonTipTitle = "Programa hoş geldiniz!";
            notifyUyari.ShowBalloonTip(1000);
        }
    }
}
