using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class Carte
    {
        private string Numar;
        private string Simbol;
        private Image Imagine;

        public Carte(string numar, string simbol, Image imagine)
        {
            Numar = numar;
            Simbol = simbol;
            Imagine = imagine;
        }

        public string GetNumar()
        {
            return Numar;
        }

        public string GetSimbol()
        {
            return Simbol;
        }

        public Image GetImagine()
        {
            return Imagine;
        }
        public virtual int ActiuneCarte() {
            return 0;
        }
    }
}
