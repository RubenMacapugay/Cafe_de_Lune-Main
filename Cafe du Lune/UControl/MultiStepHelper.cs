using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_du_Lune.UControl
{
    public class MultiStepHelper
    {
        public void NextPage(Form ParentForm, string currentPictureBox, string nextPictureBox, string nextPageName)
        {
            PictureBox currentImageBox = (PictureBox)ParentForm.Controls.Find(currentPictureBox, true)[0];
            currentImageBox.Image = Properties.Resources.complete;

            PictureBox nextImageBox = (PictureBox)ParentForm.Controls.Find(nextPictureBox, true)[0];
            nextImageBox.Image = Properties.Resources.current;

            ParentForm.Controls.Find("PanelSlider", true)[0].Controls.Find(nextPageName, true)[0].BringToFront();
        }

        public void PreviousPage(Form ParentForm, string currentPictureBox, string previousPictureBox, string previousPageName)
        {
            PictureBox currentImageBox = (PictureBox)ParentForm.Controls.Find(currentPictureBox, true)[0];
            currentImageBox.Image = Properties.Resources.pendingg;

            PictureBox previousImageBox = (PictureBox)ParentForm.Controls.Find(previousPictureBox, true)[0];
            previousImageBox.Image = Properties.Resources.current;

            ParentForm.Controls.Find("PanelSlider", true)[0].Controls.Find(previousPageName, true)[0].BringToFront();
        }
    }
}
