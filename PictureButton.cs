using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadSimulator
{
    class PictureButton
    {
        public static void setButtonStyle(Button button, string fileLocation)
        {
           button.FlatStyle = FlatStyle.Flat;
           button.FlatAppearance.MouseDownBackColor = Color.Transparent;
           button.FlatAppearance.MouseOverBackColor = Color.Transparent;
           button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
           button.FlatAppearance.BorderSize = 0;
           button.TabStop = false;
           button.Text = "";
           button.Size = new System.Drawing.Size(32, 32);
           if(Image.FromFile(fileLocation) == null)
           {
                button.Image = global::JadSimulator.Properties.Resources.blank;
           }
           else
           {
                button.Image = Image.FromFile(fileLocation);
           }
   
           
           button.BackColor = Color.Transparent;
           button.ForeColor = Color.Transparent;
        }
    }
}
