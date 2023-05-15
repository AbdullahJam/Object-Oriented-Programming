using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    abstract class Hayvan
    {
        public int enerji;
        public bool yasamakDurumu ;
        public int urun;
        public int satmakFiyati;
        public int azalanEnerji;

        public Hayvan(int _azalanEnerji, int _satmakFiyati)
        {
            azalanEnerji = _azalanEnerji;
            satmakFiyati = _satmakFiyati;
            enerji = 100;
            urun = 0;
            yasamakDurumu = true ;
        }

        public void yemVer()
        {
            if (yasamakDurumu)
            {
                enerji = 100;
            }
        }

        public void enerjiAzalma()
        {
            enerji -= azalanEnerji;
            if (enerji <= 0)
            {
                yasamakDurumu = false;
                enerji = 0;
            }
        }
        public void resimEkle(PictureBox picture, string adres)
        {
            picture.ImageLocation = adres;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Load();
        }
        public int urunSat()
        {
            
                int kazananPara = urun * satmakFiyati;
                urun = 0;
                return kazananPara;
            
        }
        public abstract void urunEkle(int sure);

        
       

    }
}
