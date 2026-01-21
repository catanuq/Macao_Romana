using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Macao_Rewritten
{
    public partial class MacaoForm : Form
    {
        #region VARIABILE MEMBRU
        private MacaoJoc Joc;

        private Jucator Om;
        private JucatorBot Robot;

        private PictureBox carteSelectata = null;

        //pentru selectarea simbolului din UI cand se joaca 7
        private Carte carteSchimbaSimbol;

        private int ScorJucator;
        private int ScorBot;
        private int NumarRunde;

        private bool SeSchimbaSimbolul = false;
        private bool sfarsitJoc = false;
        private bool btnStrigaMacaoEApasat = false;
        private bool SunetPornit;
        private bool ETurneu;


        SoundPlayer sunetPierdere = new SoundPlayer(Properties.Resources.lose_sound_effect);
        SoundPlayer sunetCastig = new SoundPlayer(Properties.Resources.win_sound_effect);
        SoundPlayer sunetClick = new SoundPlayer(Properties.Resources.click_sound_effect);
        #endregion

        #region METODE MEMBRU

        #region constructor si initializare joc
        public MacaoForm(bool turneu,bool sunet)
        {
            InitializeComponent();
            FormatOptiuniSimbol();
            ETurneu = turneu;
            ScorJucator = 0;
            ScorBot = 0;
            NumarRunde = 0;
            SunetPornit = sunet;
            if (SunetPornit)
            {
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            }
            else
                btnSunet.BackgroundImage = Properties.Resources.mute_button;

            string pozaJucator = Properties.Settings.Default.PozaJucator;
            Image imagineJucator = (Image)Properties.Resources.ResourceManager.GetObject(pozaJucator.ToLower());
            pbJucator.Image = imagineJucator;
            lblNumeJucator.Text = Properties.Settings.Default.NumeJucator.ToString();

            InitializareJoc();
        }

        private void InitializareJoc()
        {
            if (ETurneu)
            {
                ActualizareScor();
                lblScorJucator.Visible = true;
                lblScorRobot.Visible = true;
            }

            Joc = new MacaoJoc();
            Om = new Jucator(new List<Carte>());
            Robot = new JucatorBot(new List<Carte>());


            Joc.StartJoc(Om, Robot);

            AfisareCartiOm();
            AfisareCartiBot();
            AfiseazaTuraCurenta();
            Carte carteInitiala = Joc.TragereCarte();
            Joc.SetListaCartiFolosite(carteInitiala);
            AfiseazaCartePeTabla(carteInitiala);
            if (carteInitiala.GetNumar() != "7")
            {
                Joc.AflareCartePeMasa(carteInitiala);
                string text = ConvertireTextSimbol(Joc.GetSimbolCurent());
                lblSimbolCurent.Text = text;
            }
            else lblSimbolCurent.Text = "orice";
            if (Joc.GetTuraCurenta() == 1)
            {
                TuraBot();
            }

            sunetPierdere.Load();
            sunetCastig.Load();
            if (SunetPornit)
                sunetClick.Load();
        }
        #endregion

        #region metode de afisat carti
        private void AfisareCartiOm()
        {
            pnlJucator.Controls.Clear();

            for (int i = 0; i < Om.GetcartiJucator().Count; i++)
            {
                Carte carte = Om.GetcartiJucator()[i];

                PictureBox imagine = new PictureBox();
                imagine.Width = 80;
                imagine.Height = 120;
                imagine.SizeMode = PictureBoxSizeMode.StretchImage;
                imagine.Image = carte.GetImagine();
                imagine.Tag = carte; //legarea cartii de picturebox
                imagine.Click += Imagine_Click; //pt a afla ce carte a fost selectata
                imagine.BackColor = Color.Transparent;
                pnlJucator.Controls.Add(imagine);
            }
        }

        private void AfisareCartiBot()
        {
            pnlBot.Controls.Clear();
            for (int i = 0; i < Robot.GetcartiJucator().Count; i++)
            {
                PictureBox carte = new PictureBox();
                carte.Width = 80;
                carte.Height = 120;
                carte.SizeMode = PictureBoxSizeMode.StretchImage;
                carte.Image = Properties.Resources.carte_spate;

                pnlBot.Controls.Add(carte);
            }
        }

        private void AfiseazaCartePeTabla(Carte carte)
        {
            pbTabla.Image = carte.GetImagine();
            //lblCarteIndicator.Text = carte.GetSimbol() + " " + carte.GetNumar();
            pbTabla.SizeMode = PictureBoxSizeMode.StretchImage;
            string text = ConvertireTextSimbol(Joc.GetSimbolCurent());
            lblSimbolCurent.Text = text;
        }

        private void AfiseazaTuraCurenta()
        {
            if (Joc.GetTuraCurenta() == 0)
            {
                lblTuraCurenta.Text = "Tura: Jucator";
            }
            else lblTuraCurenta.Text = "Tura: Bot";
        }
        #endregion

        #region metode pentru delurarea jocului
        //async ca sa fie un mic delay, sa pot sa vad si cartea pe care a jucat-o playeru
        private async void TuraBot()
        {
            if (sfarsitJoc) return;
            if (Joc.GetTuraCurenta() != 1) return;

            string simbolRandom = "null";
            foreach (Carte carte in Robot.GetcartiJucator())
            {   //daca poate juca carte, o joaca si termina tura
                if (Joc.PoateJuca(carte))
                {
                    Robot.EliminareCarte(carte);
                    Joc.AflareCartePeMasa(carte);
                    Joc.SetListaCartiFolosite(carte);
                    if (carte.GetNumar() == "7")
                    {
                        simbolRandom = Joc.GetSimbolRandom(Robot.GetcartiJucator());
                        Joc.SetSimbolCurent(simbolRandom);
                    }
                    Joc.AplicareEfectCarte(carte);
                    await Task.Delay(1000);
                    AfiseazaCartePeTabla(carte);
                    AfisareCartiBot();
                    FinalizareTura();
                    if (carte.GetNumar() == "7")
                    {
                        string simbolDeAfisat = ConvertireTextSimbol(simbolRandom);

                        AfisareMesaj("Simbol selectat:\n" + simbolDeAfisat);
                    }
                    return;
                }

            }
            //altfel, trage carti, ori ca trebuie sa umfle ori ca nu are carte de pus jos
            if (Joc.GetCartiTrase() > 0)
                Joc.TragereCarteUmflare(Robot);
            else
                Joc.TragereCarteNormala(Robot);

            await Task.Delay(1000);
            AfisareCartiBot();
            FinalizareTura();

        }

        private void FinalizareTurneu()
        {
            if (ScorJucator < ScorBot)
            {
                if (SunetPornit)
                    sunetPierdere.Play();
                sfarsitJoc = true;
                using (PierdereJoc pierdere = new PierdereJoc())
                {
                    pierdere.SetSunet(SunetPornit);
                    pierdere.ShowDialog();
                    if (pierdere.GetRestartJoc())
                    {
                        sunetPierdere.Stop();
                        NumarRunde = 0;
                        ScorJucator = 0;
                        ScorBot = 0;
                        RestartareJoc();
                    }
                    else
                    {
                        sunetPierdere.Stop();
                        this.Close();
                        return;
                    }
                }
                return;
            }

            else if (ScorJucator > ScorBot)
            {
                if (SunetPornit)
                    sunetCastig.Play();
                sfarsitJoc = true;
                using (CastigareJoc castig = new CastigareJoc())
                {
                    castig.SetSunet(SunetPornit);
                    castig.ShowDialog();
                    if (castig.GetRestartJoc())
                    {
                        sunetCastig.Stop();
                        sunetPierdere.Stop();
                        NumarRunde = 0;
                        ScorJucator = 0;
                        ScorBot = 0;
                        RestartareJoc();
                    }
                    else
                    {
                        sunetCastig.Stop();
                        this.Close();
                        return;
                    }
                }
                return;
            }
        }

        private void FinalizareTura()
        {
            btnJoaca.Enabled = true;
            btnTrage.Enabled = true;
            Joc.SfarsitTura();
            AfiseazaTuraCurenta();
            if (Robot.GetcartiJucator().Count == 0)
            {
                if (ETurneu)
                {
                    Anunturi anunturi = new Anunturi();
                    anunturi.SetSunet(SunetPornit);
                    anunturi.AfisareAnunt("Ai pierdut runda aceasta");
                    anunturi.ShowDialog();
                    ScorBot += 100;
                    ActualizareScor();
                    NumarRunde++;
                    if (NumarRunde == 5)
                    {
                        FinalizareTurneu();
                        return;
                    }
                    RestartareJoc();
                    return;
                }
                else
                {
                    if (SunetPornit)
                        sunetPierdere.Play();
                    sfarsitJoc = true;
                    using (PierdereJoc pierdere = new PierdereJoc())
                    {
                        pierdere.SetSunet(SunetPornit);
                        pierdere.ShowDialog();
                        if (pierdere.GetRestartJoc())
                        {
                            sunetPierdere.Stop();
                            RestartareJoc();
                        }
                        else
                        {
                            sunetPierdere.Stop();
                            this.Close();
                            return;
                        }

                    }
                }
                return;

            }

            if (Om.GetcartiJucator().Count == 0)
            {
                if (ETurneu)
                {
                    Anunturi anunturi = new Anunturi();
                    anunturi.SetSunet(SunetPornit);
                    anunturi.AfisareAnunt("Ai castigat runda aceasta");
                    anunturi.ShowDialog();
                    ScorJucator += 100;
                    NumarRunde++;
                    if (NumarRunde == 5)
                    {
                        FinalizareTurneu();
                        return;
                    }
                    ActualizareScor();
                    RestartareJoc();
                    return;
                }
                else
                {
                    sfarsitJoc = true;
                    if (SunetPornit)
                        sunetCastig.Play();

                    sfarsitJoc = true;
                    using (CastigareJoc castig = new CastigareJoc())
                    {
                        castig.SetSunet(SunetPornit);
                        castig.ShowDialog();
                        if (castig.GetRestartJoc())
                        {
                            sunetCastig.Stop();
                            RestartareJoc();
                        }
                        else
                        {
                            sunetCastig.Stop();
                            this.Close();
                            return;
                        }
                    }
                }

                return;
            }

            if (Joc.GetTuraCurenta() == 1)
            {
                TuraBot();
                btnJoaca.Enabled = false;
                btnTrage.Enabled = false;
            }

        }

        private void ActualizareScor()
        {
            lblScorJucator.Text = ScorJucator.ToString();
            lblScorRobot.Text = ScorBot.ToString();
            int text = NumarRunde + 1;
            lblNumarRunde.Text = text.ToString()+" / 5";
        }

        private void RestartareJoc()
        {
            sfarsitJoc = false;
            carteSelectata = null;
            SeSchimbaSimbolul = false;
            btnStrigaMacaoEApasat = false;
            InitializareJoc();
        }
        #endregion

        #region metode pentru estetic
        private string ConvertireTextSimbol(string simbol) //convertire pentru estetic
        {
            string simbolDeAfisat = "";
            switch (simbol)
            {
                case "inimaR":
                    simbolDeAfisat = "Inima rosie";
                    break;
                case "inimaN":
                    simbolDeAfisat = "Inima neagra";
                    break;
                case "romb":
                    simbolDeAfisat = "Romb";
                    break;
                case "trifoi":
                    simbolDeAfisat = "Trifoi";
                    break;
            }
            return simbolDeAfisat;
        }

        private void FormatOptiuniSimbol()
        {

            RadioButton inimaR = new RadioButton();
            RadioButton inimaN = new RadioButton();
            RadioButton romb = new RadioButton();
            RadioButton trifoi = new RadioButton();
            inimaN.Text = "Inima neagra";
            inimaR.Text = "Inima rosie";
            romb.Text = "Romb";
            trifoi.Text = "Trifoi";


            inimaN.BackColor = Color.Transparent;
            inimaR.BackColor = Color.Transparent;
            romb.BackColor = Color.Transparent;
            trifoi.BackColor = Color.Transparent;

            inimaN.ForeColor = Color.White;
            inimaR.ForeColor = Color.White;
            romb.ForeColor = Color.White;
            trifoi.ForeColor = Color.White;

            inimaR.Location = new Point(30, 30);
            inimaN.Location = new Point(30, 50);
            romb.Location = new Point(30, 70);
            trifoi.Location = new Point(30, 90);

            inimaN.Tag = "inimaN";
            inimaR.Tag = "inimaR";
            romb.Tag = "romb";
            trifoi.Tag = "trifoi";

            pnlSelectareSimbol.Controls.Add(inimaR);
            pnlSelectareSimbol.Controls.Add(inimaN);
            pnlSelectareSimbol.Controls.Add(romb);
            pnlSelectareSimbol.Controls.Add(trifoi);
        }

        private void AfisareMesaj(string mesaj)
        {
            using (Anunturi anunt = new Anunturi())
            {
                anunt.SetSunet(SunetPornit);
                anunt.AfisareAnunt(mesaj);
                anunt.ShowDialog();
            }
        }

        #endregion

        #region metode pentru selectarea simbolului (cand joci 7)
        private string GetSimbolSelectat()
        {
            foreach (Control c in pnlSelectareSimbol.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    rb.Checked = false;
                    return rb.Tag.ToString();
                }
            }
            return null;
        }

        private void StrigaMacao()
        {
            if (btnStrigaMacaoEApasat == true)
            {
                btnStrigaMacao.Visible = false;
                btnStrigaMacaoEApasat = false;
                FinalizareTura();
                btnTrage.Enabled = true;
                btnJoaca.Enabled = true;
            }
            else
            {
                Joc.TragereCarteNormala(Om);
                AfisareCartiOm();
                btnStrigaMacao.Visible = false;
                btnStrigaMacaoEApasat = false;
                FinalizareTura();
                btnTrage.Enabled = true;
                btnJoaca.Enabled = true;
            }
        }
        #endregion

        #region Get-eri si Set-eri
    
        public bool GetSunet()
        {
            return SunetPornit;
        }

        #endregion

        #region event-handlers
        private void Imagine_Click(object sender, EventArgs e) //imagine reprezinta cartea selectata
        {
            if (SunetPornit)
                sunetClick.Play();
            if (sfarsitJoc) return;
            PictureBox pb = (PictureBox)sender;
            Carte carteNoua = (Carte)pb.Tag;
            if (SeSchimbaSimbolul)
            {
                if (carteNoua.GetNumar() != "7")
                {
                    SeSchimbaSimbolul = false;
                    carteSchimbaSimbol = null;

                    pnlSelectareSimbol.Visible = false;
                    lblSimbol.Visible = false;
                    btnConfirmaSimbol.Visible = false;
                }
            }
            if (carteSelectata != null)
                carteSelectata.BorderStyle = BorderStyle.None;
            carteSelectata = pb;
            carteSelectata.BorderStyle = BorderStyle.Fixed3D;
            //lblCarteIndicator.Text = ((Carte)carteSelectata.Tag).GetSimbol() + " " + ((Carte)carteSelectata.Tag).GetNumar();

        }

        private async void btnJoaca_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
                sunetClick.Play();
            if (sfarsitJoc) return;
            if (Joc.GetTuraCurenta() == 1)
            {
                AfisareMesaj("Nu este tura ta");
                return;
            }
            if (carteSelectata == null)
            {
                AfisareMesaj("Selecteaza carte");
                return;
            }
            if (SeSchimbaSimbolul)
            {
                AfisareMesaj("Selecteaza simbolul");
                return;
            }


            Carte carte = (Carte)carteSelectata.Tag;
            if (Joc.PoateJuca(carte) == false)
            {
                AfisareMesaj("Nu poti juca aceasta carte");
                return;
            }
            if (carte.GetNumar() == "7")
            {
                SeSchimbaSimbolul = true;
                carteSchimbaSimbol = carte;


                FormatOptiuniSimbol();
                pnlSelectareSimbol.Visible = true;
                lblSimbol.Visible = true;
                btnConfirmaSimbol.Visible = true;
                return;

            }

            Om.EliminareCarte(carte);
            Joc.AflareCartePeMasa(carte);
            Joc.AplicareEfectCarte(carte);
            Joc.SetListaCartiFolosite(carte);
            AfiseazaCartePeTabla(carte);
            pnlJucator.Controls.Remove(carteSelectata);
            carteSelectata = null;

            if (Om.GetcartiJucator().Count == 1)
            {
                btnStrigaMacao.Visible = true;
                btnTrage.Enabled = false;
                btnJoaca.Enabled = false;
                await Task.Delay(2500);
                StrigaMacao();
                return;
            }

            FinalizareTura();
        }

        private void btnTrage_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
                sunetClick.Play();
            if (sfarsitJoc) return;
            if (Joc.GetTuraCurenta() == 1)
            {
                AfisareMesaj("Nu este tura ta");
                return;
            }

            if (Joc.GetListaCartiFolosite().Count == 0)
            {
                AfisareMesaj("Nu mai poti trage carti");
                return;
            }
            carteSelectata = null;
            if (Joc.GetCartiTrase() > 0)
            {
                Joc.TragereCarteUmflare(Om);

            }
            else
            {
                Joc.TragereCarteNormala(Om);

            }

            AfisareCartiOm();
            FinalizareTura();
        }

        private async void btnConfirmaSimbol_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
                sunetClick.Play();
            string SimbolNou = GetSimbolSelectat();
            if (SimbolNou == null)
            {
                AfisareMesaj("Selecteaza simbolul");
                return;
            }

            Joc.SetSimbolCurent(SimbolNou);

            pnlSelectareSimbol.Visible = false;
            lblSimbol.Visible = false;
            btnConfirmaSimbol.Visible = false;

            SeSchimbaSimbolul = false;
            Om.EliminareCarte(carteSchimbaSimbol);
            Joc.AflareCartePeMasa(carteSchimbaSimbol);
            AfiseazaCartePeTabla(carteSchimbaSimbol);
            Joc.SetListaCartiFolosite(carteSchimbaSimbol);
            pnlJucator.Controls.Remove(carteSelectata);
            carteSelectata = null;

            if (Om.GetcartiJucator().Count == 1)
            {
                btnStrigaMacao.Visible = true;
                btnTrage.Enabled = false;
                btnJoaca.Enabled = false;
                await Task.Delay(2000);
                StrigaMacao();
                return;
            }

            FinalizareTura();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
                sunetClick.Play();
            this.Close();
        }

        private void btnStrigaMacao_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
                sunetClick.Play();
            btnStrigaMacaoEApasat = true;
        }

        private void btnSunet_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
            {
                SunetPornit = false;
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
            }
            else
            {
                SunetPornit = true;
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            }
        }
        #endregion

        #endregion
    }
}


