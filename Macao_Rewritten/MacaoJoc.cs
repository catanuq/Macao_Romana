using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
//using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class MacaoJoc
    {
        private string[] Numere = new string[13]
        {
            "2","3","4","5","6","7","8","9","10","as","j","q","k"
        };
        private string[] Simboluri = new string[4]
        {
            "inimaR","inimaN","romb","trifoi"
        };

        private PachetCarti Pachet;
        private List<Carte> ListaCarti;

        private int indexCarti = 0;
     

        private int TuraCurenta;

        private bool SeSareTura;

        private Carte CarteDePeMasa;
        private int CartiTrase;
        private string SimbolCurent;

        private Random random = new Random();


        //initializare pachet
        public MacaoJoc()
        {
            PachetCarti aux = new PachetCarti(new List<Carte>());
            ListaCarti = aux.IncarcareImagini(Numere, Simboluri);
            Pachet = new PachetCarti(ListaCarti);
            AmestecarePachet();
        }


        public void AmestecarePachet()
        {
            for (int i = 0; i < ListaCarti.Count; i++)
            {
                int pozitie = random.Next(ListaCarti.Count);
                Carte carte = ListaCarti[i];
                ListaCarti[i] = ListaCarti[pozitie];
                ListaCarti[pozitie] = carte;
            }
        }

        //initializare mana jucatorilor si stabilim cine incepe

        public void StartJoc(Jucator Om, JucatorBot Robot)
        {

            for (int i = 0; i < 5; i++)
            {
                Om.AdaugareCarte(TragereCarte());
                Robot.AdaugareCarte(TragereCarte());
            }
            TuraCurenta = random.Next(0, 2);
        }

        public int GetTuraCurenta()
        {
            return TuraCurenta;
        }

        public string GetSimbolRandom()
        {
            int simbol = random.Next(0, Simboluri.Length);
            return Simboluri[simbol];
        }
        //functii joc - tragere/punere de carti, umfla cu 2/3, schimba semn, stai o tura

        //pe parcursul jocului trebuie eliminate cartile din pachet, altfel avem dubluri
        public int EliminareCarteDinPachet(Carte carte) //int pt a returna daca s-a terminat pachetul (1) sau nu (0)
        {
            if (indexCarti == ListaCarti.Count) return 1;
            else
            {
                ListaCarti.Remove(carte);
                indexCarti++;
                return 0;
            }

        }
      
        public Carte TragereCarte()
        {
            if (indexCarti >= ListaCarti.Count) //in cazul in care s-a epuizat pachetul
            {
                AmestecarePachet();
                indexCarti = 0;         
            }
            Carte carteTrasa = ListaCarti[indexCarti];
            indexCarti++;
            return carteTrasa;
        }

        public void TragereCarteNormala(object j)
        {
            for (int i = 0; i < 1; i++)
            {
                ((Jucator)j).AdaugareCarte(TragereCarte());

            }
        }

        public void TragereCarteUmflare(object j)
        {
            for (int i = 0; i < CartiTrase; i++)
            {
                ((Jucator)j).AdaugareCarte(TragereCarte());
            }
            CartiTrase = 0;

        }

        //implementare polimorfism
        public int CazCarte(Carte carte)
        {
            return carte.ActiuneCarte();
        }

        public void AflareCartePeMasa(Carte carte)
        {
            CarteDePeMasa = carte;
            if (carte.GetNumar() != "7")
                SimbolCurent = carte.GetSimbol();
        }

        public bool PoateJuca(Carte carte)
        {
            if (CarteDePeMasa == null) return true;
            if (CartiTrase > 0)
            {
                if (CarteDePeMasa.GetNumar() == "3")
                {
                    if (CazCarte(carte) == 3) return true;
                    if (carte.GetSimbol() == SimbolCurent && carte.GetNumar() == "2") return true;
                }
                if (CarteDePeMasa.GetNumar() == "2")
                {
                    if (CazCarte(carte) == 2) return true;
                    if (carte.GetSimbol() == SimbolCurent && carte.GetNumar() == "3") return true;
                }
                return false;
            }
            if (CazCarte(carte) == 7) return true;
            if (carte.GetSimbol() == SimbolCurent) return true;
            if (carte.GetNumar() == CarteDePeMasa.GetNumar()) return true;

            return false;
        }

        public void AplicareEfectCarte(Carte carte)
        {
            int efect = CazCarte(carte);
            switch (efect)
            {
                case 2: CartiTrase += 2; break;
                case 3: CartiTrase += 3; break;
                case 11: SeSareTura = true; break;
                case 7: break; //simbolul se alege din UI
                default: break;

            }
        }

        public int GetCartiTrase()
        {
            return CartiTrase;
        }

        public void TrecereUrmatorul()
        {
            if (TuraCurenta == 0)
            {
                TuraCurenta = 1;
            }
            else
            {
                TuraCurenta = 0;
            }
        }

        public void SfarsitTura()
        {
            TrecereUrmatorul();
            if (SeSareTura == true)
            {
                SeSareTura = false;
                TrecereUrmatorul();
            }
        }

        public void SetSimbolCurent(string simbol)
        {
            SimbolCurent = simbol;
        }
    }
}
