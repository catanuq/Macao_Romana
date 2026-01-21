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
    public partial class Reguli : Form
    {
        private bool sunet;
        private SoundPlayer clickSunet = new SoundPlayer(Properties.Resources.click_sound_effect);
        public Reguli(bool sunet)
        {
            InitializeComponent();
            label1.Text = "1. Umflii cu 2 si cu 3\n" +
                "2. Schimbi cu 7\n" +
                "3. Sari tura cu as\n" +
                "4. Stopezi cu 4\n" +
                "5. Cand mai ai doar o carte, spui Macao";
            label1.Location = new Point((this.ClientSize.Width - label1.Size.Width) / 2, label1.Location.Y);
            this.sunet = sunet;
            if(this.sunet)
                btnSunet.BackgroundImage = Properties.Resources.sound_button;
            else
                btnSunet.BackgroundImage = Properties.Resources.mute_button;
        }

        public bool GetSunet()
        {
            return sunet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIesire_Click(object sender, EventArgs e)
        {   
            if(sunet)
                clickSunet.Play();
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
