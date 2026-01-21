using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class CarteStopareUmflare: Carte
    {
        public CarteStopareUmflare(string simbol, string valoare, Image imagine) : base(simbol, valoare, imagine){}

        public override int ActiuneCarte()
        {
            return 4;
        }
    }
}
