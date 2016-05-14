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
        public static string prayer = "";

        public JadSimulatorMain()
        {
            InitializeComponent();
        }

        private Graphics rangeButtonGraphics;

        private void JadSimulatorMain_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = Image.FromFile(DownloadResources.prayerBookLocalLocation);
            this.load();
            PictureButtonStyle.setButtonStyle(this.rangeButton, DownloadResources.rangePrayerLocalLocation);
            PictureButtonStyle.setButtonStyle(this.mageButton, DownloadResources.magePrayerLocalLocation);
            this.mageButton.Update();
            this.rangeButtonGraphics = this.rangeButton.CreateGraphics();
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
            if(JadSimulatorMain.prayer.Equals(PrayerEnum.Magic))
            {
                JadSimulatorMain.prayer = PrayerEnum.None.ToString();
            }
            else
            {
                JadSimulatorMain.prayer = PrayerEnum.Magic.ToString();
            }

            this.mageButton.Invalidate();
            this.rangeButton.Invalidate();
            prayerLabel.Text = "Prayer: " + JadSimulatorMain.prayer;
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            if (JadSimulatorMain.prayer.Equals(PrayerEnum.Range))
            {
                JadSimulatorMain.prayer = PrayerEnum.None.ToString(); 
            }
            else
            {
                JadSimulatorMain.prayer = PrayerEnum.Range.ToString();
            }

            this.rangeButton.Invalidate();
            this.mageButton.Invalidate();
            prayerLabel.Text = "Prayer: " + JadSimulatorMain.prayer;
        }
    }
}