using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class CarteSchimbaSimbol :Carte
    {
        public CarteSchimbaSimbol(string numar, string simbol, Image imagine) : base(numar, simbol, imagine) { }

        public override int ActiuneCarte() {
            return 7;
        }
    }
}
