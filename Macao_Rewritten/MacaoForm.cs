using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
//using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Threading;

namespace Macao_Rewritten
{
    public partial class MacaoForm : Form
    {
        private MacaoJoc Joc;

        private Jucator Om;
        private JucatorBot Robot;

        private PictureBox carteSelectata = null;

        private bool UmflaDoarBotul = false;

        //pentru selectarea simbolului din UI cand se joaca 7
        private Carte carteSchimbaSimbol;
        private bool SeSchimbaSimbolul = false;
        private bool sfarsitJoc = false;
        //private bool btnStrigaMacaoEApasat = false;
        //private Carte carteInitiala;

        public MacaoForm()
        {
            InitializeComponent();
            FormatOptiuniSimbol();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializareJoc();
        }

        public void InitializareJoc()
        {
            Joc = new MacaoJoc();
            Om = new Jucator(new List<Carte>());
            Robot = new JucatorBot(new List<Carte>());

            Joc.StartJoc(Om, Robot);

            AfisareCartiOm();
            AfisareCartiBot();
            AfiseazaTuraCurenta();
            Carte carteInitiala = Joc.TragereCarte();
            AfiseazaCartePeTabla(carteInitiala);
            Joc.AflareCartePeMasa(carteInitiala);
            if (Joc.GetTuraCurenta() == 1)
            {
                TuraBot();
            }
        }

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

                pnlJucator.Controls.Add(imagine);
            }

        }

        private void AfisareCartiBot()
        {
            pnlBot.SuspendLayout();
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
            pnlBot.ResumeLayout();
        }

        private void AfiseazaCartePeTabla(Carte carte)
        {
            pbTabla.Image = carte.GetImagine();
            lblCarteIndicator.Text = carte.GetSimbol() + " " + carte.GetNumar();
            pbTabla.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AfiseazaTuraCurenta()
        {
            if (Joc.GetTuraCurenta() == 0)
            {
                lblTuraCurenta.Text = "Tura: Jucator";
            }
            else lblTuraCurenta.Text = "Tura: Bot";
        }

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

                    if (carte.GetNumar() == "7")
                    {
                        simbolRandom = Joc.GetSimbolRandom();
                        Joc.SetSimbolCurent(simbolRandom);
                    }

                    Joc.AplicareEfectCarte(carte);

                    await Task.Delay(1000);

                    AfiseazaCartePeTabla(carte);
                    AfisareCartiBot();
                    FinalizareTura();

                    if (carte.GetNumar() == "7")
                        MessageBox.Show("A fost selectat simbolul: " + simbolRandom);
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

            inimaR.Location = new Point(10, 0);
            inimaN.Location = new Point(10, 20);
            romb.Location = new Point(10, 40);
            trifoi.Location = new Point(10, 60);

            inimaN.Tag = "inimaN";
            inimaR.Tag = "inimaR";
            romb.Tag = "romb";
            trifoi.Tag = "trifoi";

            pnlSelectareSimbol.Controls.Add(inimaR);
            pnlSelectareSimbol.Controls.Add(inimaN);
            pnlSelectareSimbol.Controls.Add(romb);
            pnlSelectareSimbol.Controls.Add(trifoi);
        }

        private string GetSimbolSelectat()
        {
            foreach (Control c in pnlSelectareSimbol.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                    return rb.Tag.ToString();
            }
            return null;
        }

        private void FinalizareTura()
        {
            Joc.SfarsitTura();
            AfiseazaTuraCurenta();
            if (Robot.GetcartiJucator().Count == 0)
            {
                sfarsitJoc = true;
                var raspuns = MessageBox.Show("Ai perdut fraiere :( \n Joc nou?",
                    "Sfarsit joc",
                    MessageBoxButtons.YesNo);
                if (raspuns == DialogResult.Yes)
                    RestartareJoc();
                else
                    Application.Exit();
                
                return;
            }
            if (Om.GetcartiJucator().Count == 0)
            {
                sfarsitJoc = true;
                var raspuns = MessageBox.Show("Ai castigat :) \n Joc nou?",
                    "Sfarsit joc",
                    MessageBoxButtons.YesNo);
                if (DialogResult.Yes == raspuns)
                    RestartareJoc();
                else
                    Application.Exit();
                
                return;
            }

            //if (Om.GetcartiJucator().Count == 1)
            //{
            //    btnStrigaMacao.Visible = true;
            //    timerStrigaMacao.Start();
            //}
            //else
            //{
            //    btnStrigaMacao.Visible = false;
            //    timerStrigaMacao.Stop();
            //}

            if (Joc.GetTuraCurenta() == 1)
            {
                TuraBot();
            }
            //btnStrigaMacaoEApasat = false;
        }

        private void RestartareJoc()
        {
            sfarsitJoc = false;
            carteSelectata = null;
            SeSchimbaSimbolul = false;
            UmflaDoarBotul = false;

            //btnStrigaMacaoEApasat = false;
            //carteInitiala = null;
            //btnStrigaMacaoEApasat = false;


            InitializareJoc();
        }

        private void StrigaMacao()
        {
            if (timerStrigaMacao != null)
            {
                timerStrigaMacao.Stop();
                btnStrigaMacao.Visible = false;
                FinalizareTura();
            }
            else
            {
                Joc.TragereCarteNormala(Om);
                btnStrigaMacao.Visible = false;
                FinalizareTura();
            }
        }
        private void Imagine_Click(object sender, EventArgs e)
        {
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
            lblCarteIndicator.Text = ((Carte)carteSelectata.Tag).GetSimbol() + " " + ((Carte)carteSelectata.Tag).GetNumar();

        }

        private void btnJoaca_Click(object sender, EventArgs e)
        {
            if (sfarsitJoc) return;
            if (carteSelectata == null)
            {
                MessageBox.Show("Selecteaza carte");
                return;
            }

            if (SeSchimbaSimbolul)
            {
                MessageBox.Show("Selecteaza simbolul mai intai");
                return;
            }

            if (Joc.GetTuraCurenta() == 1)
            {
                MessageBox.Show("Nu este tura ta");
                return;
            }

            Carte carte = (Carte)carteSelectata.Tag;


            if (Joc.PoateJuca(carte) == false)
            {
                MessageBox.Show("Nu poti juca aceasta carte");
                return;
            }


            if ((carte.GetNumar() == "2" || carte.GetNumar() == "3") && Joc.GetCartiTrase() > 0)
            {
                UmflaDoarBotul = true;
            }
            if (carte.GetNumar() == "7")
            {
                SeSchimbaSimbolul = true;
                carteSchimbaSimbol = carte;

                pnlSelectareSimbol.Visible = true;
                lblSimbol.Visible = true;
                btnConfirmaSimbol.Visible = true;
                return;

            }

            Om.EliminareCarte(carte);
            Joc.AflareCartePeMasa(carte);
            Joc.AplicareEfectCarte(carte);
            AfiseazaCartePeTabla(carte);
            pnlJucator.Controls.Remove(carteSelectata);
            carteSelectata = null;
            FinalizareTura();
        }

        private void btnTrage_Click(object sender, EventArgs e)
        {
            if (sfarsitJoc) return;
            if (Joc.GetTuraCurenta() == 1)
            {
                MessageBox.Show("Nu este tura ta");
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

        private void btnConfirmaSimbol_Click(object sender, EventArgs e)
        {
            string SimbolNou = GetSimbolSelectat();
            if (SimbolNou == null)
            {
                MessageBox.Show("Selecteaza un simbol");
                return;
            }

            Joc.SetSimbolCurent(SimbolNou);

            MessageBox.Show("A fost selectat simbolul: " + SimbolNou);

            pnlSelectareSimbol.Visible = false;
            lblSimbol.Visible = false;
            btnConfirmaSimbol.Visible = false;

            SeSchimbaSimbolul = false;
            Om.EliminareCarte(carteSchimbaSimbol);
            Joc.AflareCartePeMasa(carteSchimbaSimbol);
            Joc.AplicareEfectCarte(carteSchimbaSimbol);
            AfiseazaCartePeTabla(carteSchimbaSimbol);
            pnlJucator.Controls.Remove(carteSelectata);
            carteSelectata = null;
            FinalizareTura();
        }


        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStrigaMacao_Click(object sender, EventArgs e)
        {
            //btnStrigaMacaoEApasat = true;
            timerStrigaMacao.Stop();
            btnStrigaMacao.Visible = false;

        }

        private void timerStrigaMacao_Tick(object sender, EventArgs e)
        {
            //timerStrigaMacao.Stop();

            //if (!btnStrigaMacaoEApasat && Om.GetcartiJucator().Count == 1)
            //{
            //    MessageBox.Show("Nu ai strigat MACAO! Penalizare +1 carte");

            //    Joc.TragereCarteNormala(Om);
            //    AfisareCartiOm();
            //}

            //btnStrigaMacao.Visible = false;
            //btnStrigaMacaoEApasat = false;
        }
    }
}


