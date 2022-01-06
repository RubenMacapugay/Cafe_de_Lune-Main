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
    public partial class frmQueue : Form
    {
        public frmQueue()
        {
            InitializeComponent();
        }

        private void rbNext_Click(object sender, EventArgs e)
        {
            this.Close();

            frmClickToStart cts = new frmClickToStart();
            cts.Show();
        }

        private void rbCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();

            frmClickToStart cts = new frmClickToStart();
            cts.Show();
        }
    }
}
