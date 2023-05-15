using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    class Tavuk : Hayvan
    {
        public Tavuk(int _azalanEnerji, int _satmakFiyati) : base(_azalanEnerji, _satmakFiyati)
        {
        }

        public override void urunEkle(int sure)
        {
            if (yasamakDurumu==true && sure%3==0)
            {
                urun++;
            }
        }

    }
}
