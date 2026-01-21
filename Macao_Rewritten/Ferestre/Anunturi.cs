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
    public partial class Anunturi : Form
    {
        private bool SunetPornit;
        private SoundPlayer sunetClick = new SoundPlayer(Properties.Resources.click_sound_effect);
        public Anunturi()
        {
            InitializeComponent();
            if (SunetPornit)
                sunetClick.Load();
        }

        public void SetSunet(bool sunet)
        {
            SunetPornit = sunet;
        }

        public void AfisareAnunt(string anunt)
        {
            lblAnunt.Text = anunt;
            lblAnunt.Location = new Point((this.ClientSize.Width - lblAnunt.Size.Width) / 2, lblAnunt.Location.Y);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(SunetPornit)
                sunetClick.Play();
            this.Close();
        }
    }
}
