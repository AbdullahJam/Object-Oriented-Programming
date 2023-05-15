using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    class Keci:Hayvan
    {
        public Keci(int _azalanEnerji, int _satmakFiyati) : base(_azalanEnerji, _satmakFiyati)
        {
        }

        public override void urunEkle(int sure)
        {
            if (yasamakDurumu == true && sure % 7 == 0)
            {
                urun++;
            }
        }
    }
}
