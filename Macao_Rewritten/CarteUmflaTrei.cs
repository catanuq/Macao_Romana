using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class CarteUmflaTrei:Carte
    {
        public CarteUmflaTrei(string numar, string simbol, Image imagine) : base(numar, simbol, imagine) { }

        public override int ActiuneCarte() {
            return 3;
        }
    }
}
