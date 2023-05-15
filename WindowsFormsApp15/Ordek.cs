using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    class Ordek:Hayvan
    {
        public Ordek(int _azalanEnerji, int _satmakFiyati) : base(_azalanEnerji, _satmakFiyati)
        {
        }

        public override void urunEkle(int sure)
        {
            if (yasamakDurumu == true && sure % 5 == 0)
            {
                urun++;
            }
        }
    }
}
