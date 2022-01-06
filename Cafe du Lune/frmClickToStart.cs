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
    public partial class frmClickToStart : Form
    {
        public frmClickToStart()
        {
            InitializeComponent();
        }

        private void frmClickToStart_Load(object sender, EventArgs e)
        {
            loadBar.Visible = false;
            btnClickToStart.Visible = true;
        }

        private void tmrTrans_Tick(object sender, EventArgs e)
        {
            this.loadBar.Increment(4);

            if (loadBar.Value >= loadBar.Maximum)
            {
                tmrTrans.Stop();
                this.Hide();

                frmMainOrderPage fmop = new frmMainOrderPage();
                fmop.Show();

            }
        }

        private void btnClickToStart_Click(object sender, EventArgs e)
        {
            this.tmrTrans.Start();
            btnClickToStart.Visible = false;
            loadBar.Visible = true;
        }
    }
}
