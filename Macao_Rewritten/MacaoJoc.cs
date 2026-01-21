using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class MacaoJoc
    {
        #region VARIABILE MEMBRU

        private string[] Numere = new string[13]
        {
            "2","3","4","5","6","7","8","9","10","as","j","q","k"
        };
        private string[] Simboluri = new string[4]
        {
            "inimaR","inimaN","romb","trifoi"
        };

        private PachetCarti Pachet;
        private List<Carte> ListaCarti, ListaCartiFolosite;
        private Carte CarteDePeMasa = null;
        private Random random = new Random();

        private int TuraCurenta;
        private int CartiTrase;

        private bool AInceputJoc = false;
        private bool SeSareTura;

        private string SimbolCurent;

        //private int indicator = 0;
        #endregion


        #region METODE MEMBRU

        #region constructor si metode initializare joc
        public MacaoJoc()
        {
            PachetCarti aux = new PachetCarti(new List<Carte>());
            ListaCarti = aux.IncarcareImagini(Numere, Simboluri);
            ListaCartiFolosite = new List<Carte>();
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
        #endregion

        #region functii joc

        //metode de umflare sau tragere carte normala
        public Carte TragereCarte() //folosita pentru cele doua tipuri de trageri (normala sau umflare)
        {
            if (ListaCarti.Count == 0) //in cazul in care s-a epuizat pachetul
            {
                if (ListaCartiFolosite.Count == 0)
                {
                    return null;
                }
                foreach (Carte c in ListaCartiFolosite)
                {
                    ListaCarti.Add(c);
                }
                ListaCartiFolosite.Clear();
                AmestecarePachet();
            }

            Carte carteTrasa = ListaCarti[0];
            //Console.WriteLine(indicator+1+"."+carteTrasa.GetNumar() + " " + carteTrasa.GetSimbol());
            //indicator++;
            ListaCarti.RemoveAt(0);
            return carteTrasa;
        }

        public void TragereCarteNormala(object j)
        {

            ((Jucator)j).AdaugareCarte(TragereCarte());
        }

        public void TragereCarteUmflare(object j)
        {
            for (int i = 0; i < CartiTrase; i++)
            {
                ((Jucator)j).AdaugareCarte(TragereCarte());
            }
            CartiTrase = 0;
        }

        //schimbare de tura si sfarsire tura
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
        #endregion

        #region implementare polimorfism
        //pentru verificarea tipului de carte si daca se poate juca
        public int CazCarte(Carte carte)
        {
            return carte.ActiuneCarte(); //metoda virtuala din clasa Carte ce se regaseste in toate celelalte clase derivate
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
                    if (carte.GetNumar() == "4" && carte.GetSimbol() == SimbolCurent) return true;
                }
                if (CarteDePeMasa.GetNumar() == "2")
                {
                    if (CazCarte(carte) == 2) return true;
                    if (carte.GetSimbol() == SimbolCurent && carte.GetNumar() == "3") return true;
                    if (carte.GetNumar() == "4" && carte.GetSimbol() == SimbolCurent) return true;
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
                case 4: CartiTrase = 0; break;
                case 11: SeSareTura = true; break;
                case 7: break; //simbolul se alege din UI
                default: break;
            }
        }
        #endregion

        #region get-eri si set-eri
        public int GetTuraCurenta()
        {
            return TuraCurenta;
        }

        public int GetCartiTrase()
        {
            return CartiTrase;
        }

        public void SetSimbolCurent(string simbol)
        {
            SimbolCurent = simbol;
        }

        public string GetSimbolCurent()
        {
            return SimbolCurent;
        }

        public string GetSimbolRandom(List<Carte> carti) //pt bot, sa aleaga simbol pe care il are
        {
            if (carti.Count == 0)
            {
                return random.Next(0, Simboluri.Length).ToString();
            }
            else
            {
                List<string> simboluriRobot = new List<string>();
                for (int i = 0; i < carti.Count; i++)
                {
                    simboluriRobot.Add(carti[i].GetSimbol());
                }
                int simbol = random.Next(0, simboluriRobot.Count);
                return simboluriRobot[simbol];
            }
        }

        public void SetListaCartiFolosite(Carte carte)
        {
            ListaCartiFolosite.Add(carte);
        }

        public List<Carte> GetListaCartiFolosite()
        {
            return ListaCartiFolosite;
        }
        #endregion
        #endregion
    }
}

