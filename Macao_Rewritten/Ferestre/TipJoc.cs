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
    public partial class TipJoc : Form
    {
        private bool sunet;
        private SoundPlayer clickSunet = new SoundPlayer(Properties.Resources.click_sound_effect);

        public TipJoc(bool sunet)
        {
            InitializeComponent();
            this.sunet = sunet;
            if(sunet)
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            else
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
        }

        public bool GetSunet()
        {
            return sunet;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {   if (sunet)
                clickSunet.Play();
            using(MacaoForm macao = new MacaoForm(false,sunet))
            {
                this.Hide();
                macao.WindowState = this.WindowState;
                macao.ShowDialog();
                sunet = macao.GetSunet();
                this.WindowState = macao.WindowState;
                this.Close();
            }
        }

        private void btnTurneu_Click(object sender, EventArgs e)
        {
            if (sunet)
                clickSunet.Play();
            using(MacaoForm macao = new MacaoForm(true,sunet))
            {
                this.Hide();
                macao.Size = this.Size;
                macao.ShowDialog();
                sunet = macao.GetSunet();   
                this.Close();
            }
        }

        private void btnSunet_Click(object sender, EventArgs e)
        {   
            if(sunet)
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
