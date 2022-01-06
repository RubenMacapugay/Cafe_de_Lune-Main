using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_du_Lune.UControl
{
    public partial class DiningLoc : UserControl
    {
        public DiningLoc()
        {
            InitializeComponent();
        }

        private void rbCancelOrder_Click(object sender, EventArgs e)
        {
            ParentForm.Close();

            frmClickToStart cts = new frmClickToStart();
            cts.Show();
        }

        private void rbNext_Click(object sender, EventArgs e)
        {
            new MultiStepHelper().NextPage(ParentForm, "pbDineLoc", "pbMyOrders", "MyOrders");
        }
    }
}
