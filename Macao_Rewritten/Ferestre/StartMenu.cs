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

    public partial class StartMenu : Form
    {
        private bool sunet = true;
        private SoundPlayer clickSunet = new SoundPlayer(Properties.Resources.click_sound_effect);
        private SoundPlayer muzicaFundal = new SoundPlayer(Properties.Resources.main_song);

        public StartMenu()
        {
            InitializeComponent();
            clickSunet.Load();
            muzicaFundal.Load();
            ManageMuzica();
        }
        private void ManageMuzica()
        {
            if (sunet)
            {
                muzicaFundal.PlayLooping();
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            }
            else
            {
                muzicaFundal.Stop();
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            using (TipJoc joc = new TipJoc(sunet))
            {
                Hide();
                joc.WindowState = this.WindowState;
                joc.ShowDialog();
                sunet = joc.GetSunet();
                ManageMuzica();
                this.WindowState = joc.WindowState;
                Show();
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            Application.Exit();
        }

        private void btnSunet_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            if (sunet)
            {
                sunet = false;

                ManageMuzica();
                return;
            }
            else
            {
                sunet = true;

                ManageMuzica();
                return;
            }

        }

        private void btnReguli_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            using (Reguli reguli = new Reguli(sunet))
            {
                Hide();
                reguli.WindowState = this.WindowState;
                reguli.ShowDialog();
                sunet = reguli.GetSunet();
                ManageMuzica();
                this.WindowState = reguli.WindowState;
                Show();
            }
        }

        private void btnOptiuni_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            using (PersonalizareJucator optiuni = new PersonalizareJucator(sunet))
            {
                Hide();
                optiuni.WindowState = this.WindowState;
                optiuni.ShowDialog();
                sunet = optiuni.GetSunet();
                ManageMuzica();
                this.WindowState = optiuni.WindowState;
                Show();
            }
        }
    }
}
