using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class Jucator
    {
        protected List<Carte> cartiJucator;
        
        public Jucator(List<Carte> carti)
        {
            cartiJucator = carti;
           
        }

        public List<Carte> GetcartiJucator()
        {
            return cartiJucator;
        }



        public void AdaugareCarte(Carte carte)
        {
            cartiJucator.Add(carte);
        }

        public void EliminareCarte(Carte carte)
        {
            cartiJucator.Remove(carte);
        }

        
    }
}
