using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Macao_Rewritten
{
    public class PachetCarti
    {
        private List<Carte> listaCarti;

        public PachetCarti(List<Carte> carti)
        {
            listaCarti = new List<Carte>();

            for (int i = 0; i < carti.Count; i++)
            {
                Carte carte = carti[i];
                listaCarti.Add(carte);
            }
        }

        public List<Carte> IncarcareImagini(string[] numere, string[] simboluri)
        {
            List<Carte> toateCartile = new List<Carte>(); //lista unde punem toate cartile

            //pentru cautare in resursele proiectului
            ResourceManager rm = Properties.Resources.ResourceManager;

            var setResurse = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in setResurse)
            {
                string numeResursa = entry.Key.ToString();

                //luam numa resursele tip imagine
                if (entry.Value is Bitmap bmp)
                {
                    string[] parti = numeResursa.Split('_');
                    if (parti.Length != 2) continue; //in cazul in care am denumit gresit cartea

                    string numar = parti[0];
                    string simbol = parti[1];

                    bool numarCorect = false;
                    bool simbolCorect = false;

                    if (numar == "carte" && simbol == "spate") continue;
                    //asociere numar si simbol corect al cartii
                    for (int i = 0; i < numere.Length; i++)
                    {
                        if (numere[i] == numar)
                        {
                            numarCorect = true;
                            break;
                        }
                    }

                    for (int i = 0; i < simboluri.Length; i++)
                    {
                        if (simboluri[i] == simbol)
                        {
                            simbolCorect = true;
                            break;
                        }
                    }

                    //daca s-a format asocierea, adauga in lista de carti
                    if (simbolCorect && numarCorect)
                    {
                        if (numar == "2")
                        {
                            CarteUmflaDoi carte = new CarteUmflaDoi(numar, simbol, bmp);
                            toateCartile.Add(carte);
                        }
                        else if (numar == "3")
                        {
                            CarteUmflaTrei carte = new CarteUmflaTrei(numar, simbol, bmp);
                            toateCartile.Add(carte);
                        }
                        else if (numar == "4")
                        {
                            CarteStopareUmflare carte = new CarteStopareUmflare(numar, simbol, bmp);
                            toateCartile.Add(carte);
                        }
                        else if (numar == "7")
                        {
                            CarteSchimbaSimbol carte = new CarteSchimbaSimbol(numar, simbol, bmp);
                            toateCartile.Add(carte);
                        }
                        else if (numar == "as")
                        {
                            CarteStaiTura carte = new CarteStaiTura(numar, simbol, bmp);
                            toateCartile.Add(carte);
                        }                      
                        else
                        {
                            Carte c = new Carte(numar, simbol, bmp);
                            toateCartile.Add(c);
                        }
                    }
                }


            }
            return toateCartile;
        }
    }
}
