/****************************************************************************
**                             SAKARYA ÜNİVERSİTESİ
**                    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                        NESNEYE DAYALI PROGRAMLAMA DERSİ
**                             2018-2019 BAHAR DÖNEMİ
**    
**                     ÖDEV NUMARASI..........: proje 
**                     ÖĞRENCİ ADI............: Abdullah Jamous 
**                     ÖĞRENCİ NUMARASI.......: G181210558 
**                     DERSİN ALINDIĞI GRUP...: 2\A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            ilkYazdirmak();
        }
        int sayac = 0;
        int kasa = 0;

        // nesne yaparkan azalan enerji ve satmak fiyati gondermeliyiz 
        Tavuk tavuk = new Tavuk(2,1);
        Ordek ordek = new Ordek(3,3);
        Inek inek = new Inek(8,5);
        Keci keci = new Keci(6,8);

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            enerjiVeUrunDegistirme();
            olmek();
            yazdir();
            progressBarYazdir();
        }

        private void btnTavukYemVer_Click(object sender, EventArgs e)
        {
            tavuk.yemVer();
            progressBarYazdir();
        }

        private void btnOrdekYemVer_Click(object sender, EventArgs e)
        {
            ordek.yemVer();
            progressBarYazdir();
        }

        private void btnInekYemVer_Click(object sender, EventArgs e)
        {
            inek.yemVer();
            progressBarYazdir();
        }

        private void btnKeciYemVer_Click(object sender, EventArgs e)
        {
            keci.yemVer();
            progressBarYazdir();
        }

        private void btnTavukYumurtasiSat_Click(object sender, EventArgs e)
        {
            kasa += tavuk.urunSat();
            yazdir();
        }

        private void btnOrdekYumurtasiSat_Click(object sender, EventArgs e)
        {
            kasa += ordek.urunSat();
            yazdir();
        }

        private void btnInekSutuSat_Click(object sender, EventArgs e)
        {
            kasa += inek.urunSat();
            yazdir();
        }

        private void btnKeciSutuSat_Click(object sender, EventArgs e)
        {
            kasa += keci.urunSat();
            yazdir();
        }

        public void yazdir()
        {
            lblKasa.Text = Convert.ToString(kasa) + " TL";
            lblTavukYumurtasiAdet.Text = Convert.ToString(tavuk.urun) + " ADET";
            lblOrdekYumurtasiAdet.Text = Convert.ToString(ordek.urun) + " ADET";
            lblInekSutuKg.Text = Convert.ToString(inek.urun) + " KG";
            lblkeciSutuKg.Text = Convert.ToString(keci.urun) + " KG";
            lblGecenSure.Text = Convert.ToString(sayac) + " SN ";
        }

        public void progressBarYazdir()
        {
            progressBarTavuk.Value = tavuk.enerji;
            progressBarOrdek.Value = ordek.enerji;
            progressBarInek.Value = inek.enerji;
            progressBarKeci.Value = keci.enerji;
        }

        public void enerjiVeUrunDegistirme()
        {
            tavuk.enerjiAzalma();
            tavuk.urunEkle(sayac);
            ordek.enerjiAzalma();
            ordek.urunEkle(sayac);
            inek.enerjiAzalma();
            inek.urunEkle(sayac);
            keci.enerjiAzalma();
            keci.urunEkle(sayac);
           
        }

        // burda fotograflari koyacam
         
        public void ilkYazdirmak()
        {
            tavuk.resimEkle(pictureBoxTavuk , "tavuk.png");
            inek.resimEkle(pictureBoxInek, "inek.png");
            keci.resimEkle(pictureBoxKeci, "keci.png");
            ordek.resimEkle(pictureBoxOrdek, "ordek.png");
            lblGecenSure.Text = "0 SN";
            lblKasa.Text = "0 TL";
            lblInekSutuKg.Text = "0 KG";
            lblTavukYumurtasiAdet.Text = "0 ADET";
            lblOrdekYumurtasiAdet.Text = "0 ADET";
            lblkeciSutuKg.Text = "0 KG";
            lblTavukYasamakDurumu.Text = "CANLI";
            lblOrdekYasamakDurumu.Text = "CANLI";
            lblKeciYasamakDurumu.Text = "CANLI";
            lblInekYasamakDurumu.Text = "CANLI";
            progressBarTavuk.Value = 100;
            progressBarOrdek.Value = 100;
            progressBarInek.Value = 100;
            progressBarKeci.Value = 100;

        }
        public void olmek()
        {
            if (!tavuk.yasamakDurumu && lblTavukYasamakDurumu.Text == "CANLI")
            {
                SoundPlayer sound = new SoundPlayer("tavuk.wav");
                sound.Play();
                lblTavukYasamakDurumu.Text = "ÖLDÜ";
            }
            if (!ordek.yasamakDurumu && lblOrdekYasamakDurumu.Text == "CANLI")
            {
                SoundPlayer sound = new SoundPlayer("ordek.wav");
                sound.Play();
                lblOrdekYasamakDurumu.Text = "ÖLDÜ";
            }
            if (!inek.yasamakDurumu && lblInekYasamakDurumu.Text == "CANLI")
            {
                SoundPlayer sound = new SoundPlayer("inek.wav");
                sound.Play();

                lblInekYasamakDurumu.Text = "ÖLDÜ";
            }
            if (!keci.yasamakDurumu && lblKeciYasamakDurumu.Text == "CANLI")
            {
                SoundPlayer sound = new SoundPlayer("keci.wav");
                sound.Play();
                lblKeciYasamakDurumu.Text = "ÖLDÜ";
            }
        }
        
    }
}
