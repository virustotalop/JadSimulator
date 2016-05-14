using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadSimulator
{
    class RangeButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
             base.OnPaint(e);
             if (JadSimulatorMain.prayer.Equals(PrayerEnum.Range))
             {
                 SolidBrush b = new SolidBrush(Color.FromArgb(70, 255, 255, 0));
                 Rectangle rect = new Rectangle(0, 0, 32, 32);
                 e.Graphics.FillEllipse(b, rect);
             }
         }
     }
}