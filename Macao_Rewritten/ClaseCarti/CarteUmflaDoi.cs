using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class CarteUmflaDoi:Carte
    {
        public CarteUmflaDoi(string numar, string simbol, Image imagine) : base(numar, simbol, imagine) { }

        public override int ActiuneCarte() {
            return 2;
        }
    }
}
