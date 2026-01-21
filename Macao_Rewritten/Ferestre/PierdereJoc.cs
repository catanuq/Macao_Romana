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
    public partial class PierdereJoc : Form
    {
        private bool RestartJoc;
        private bool SunetPornit;
        private SoundPlayer sunetClick = new SoundPlayer(Properties.Resources.click_sound_effect);
        public PierdereJoc()
        {
            InitializeComponent();
            if (SunetPornit)
            {
                sunetClick.Load();
            }
        }
        public bool GetRestartJoc()
        {
            return RestartJoc;
        }

        public void SetSunet(bool sunet)
        {
            SunetPornit = sunet;
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
            {
                sunetClick.Play();
            }
            RestartJoc = true;
            this.Close();
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            if (SunetPornit)
            {
                sunetClick.Play();
            }
            RestartJoc = false;
            this.Close();
        }


    }
}
