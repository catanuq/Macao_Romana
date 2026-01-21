using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macao_Rewritten
{
    public partial class PersonalizareJucator : Form
    {
        private bool sunet;
        private SoundPlayer clickSunet = new SoundPlayer(Properties.Resources.click_sound_effect);
        public PersonalizareJucator(bool sunet)
        {
            InitializeComponent();

            lstPozeProfil.LargeImageList = imgLstListaImagini;
            imgLstListaImagini.ImageSize = new Size(120, 140);

            imgLstListaImagini.Images.Add("Toriel", Properties.Resources.toriel);
            imgLstListaImagini.Images.Add("Sans", Properties.Resources.sans);
            imgLstListaImagini.Images.Add("Papyrus", Properties.Resources.papyrus);
            imgLstListaImagini.Images.Add("Undyne", Properties.Resources.undyne);
            imgLstListaImagini.Images.Add("Alphys", Properties.Resources.alphys);
            imgLstListaImagini.Images.Add("Mettaton", Properties.Resources.mettaton);
            imgLstListaImagini.Images.Add("Asgore", Properties.Resources.asgore);
            imgLstListaImagini.Images.Add("Flowey", Properties.Resources.flowey);
            imgLstListaImagini.Images.Add("Asriel", Properties.Resources.asriel);
            imgLstListaImagini.Images.Add("Susie", Properties.Resources.susie);
            imgLstListaImagini.Images.Add("Noelle1", Properties.Resources.noelle1);
            imgLstListaImagini.Images.Add("Noelle2", Properties.Resources.noelle2);
           
            lstPozeProfil.Items.Add(new ListViewItem("","Toriel"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Sans"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Papyrus"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Undyne"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Alphys"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Mettaton"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Asgore"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Flowey"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Asriel"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Susie"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Noelle1"));
            lstPozeProfil.Items.Add(new ListViewItem("", "Noelle2"));

            clickSunet.Load();
            this.sunet = sunet;
            if (this.sunet)
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            else
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
        }

        private void lstPozeProfil_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection pozaAleasa = lstPozeProfil.SelectedItems; //seteaza imaginea aleasa
            Properties.Settings.Default.PozaJucator = pozaAleasa[0].ImageKey; //seteaza imaginea aleasa drept poza jucatorului   
        }

        public bool GetSunet()
        {
            return sunet;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            if(txtNumeJucator.Text == "")
            {
                Properties.Settings.Default.NumeJucator = "Jucator";
            }
            else Properties.Settings.Default.NumeJucator = txtNumeJucator.Text; //seteaza numele jucatorului
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            Properties.Settings.Default.Reload();
            this.Close();
        }

        private void btnSunet_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            if (sunet)
            {
                sunet = false;
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
            }
            else
            {
                sunet = true;
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            }
        }
    }
}
