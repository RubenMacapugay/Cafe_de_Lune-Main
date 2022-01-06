using Cafe_du_Lune.UControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_du_Lune
{
    public partial class frmMainOrderPage : Form
    {
        public frmMainOrderPage()
        {
            InitializeComponent();

            PanelSlider.Controls.Add(new DiningLoc());
            PanelSlider.Controls.Add(new MyOrders());
            PanelSlider.Controls.Add(new OrderConfirmed());
            PanelSlider.Controls.Add(new Pay());
        }
    }
}
