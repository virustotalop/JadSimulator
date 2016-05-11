using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadSimulator
{
    public partial class JadSimulatorMain : Form
    {
        public JadSimulatorMain()
        {
            InitializeComponent();
        }

        private void JadSimulatorMain_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = Image.FromFile(DownloadResources.prayerBookLocalLocation);
            this.load();
            PictureButton.setButtonStyle(this.rangeButton, DownloadResources.rangePrayerLocalLocation);
            PictureButton.setButtonStyle(this.mageButton, DownloadResources.magePrayerLocalLocation);
            this.mageButton.Update();
        }

        private void load()
        {
            DownloadResources.DownloadAll();
            while (true)
            {
                if (DownloadResources.AllDownloaded())
                {
                    break;
                }
            }
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test mage");
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test range");
        }
    }
}
