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
    public partial class OrderConfirmed : UserControl
    {
        public OrderConfirmed()
        {
            InitializeComponent();
        }

        MyOrders ord = new MyOrders();

        public DataGridView MyOrderList;
        

        public Bitmap mybitmap;

        private void rbNext_Click(object sender, EventArgs e)
        {
            try
            {
            //MyOrderList = ord.dgvListOrder;
            //int height = ord.dgvListOrder.Height;
            //ord.dgvListOrder.Height = ord.dgvListOrder.RowCount * ord.dgvListOrder.RowTemplate.Height * 2;
            //mybitmap = new Bitmap(ord.dgvListOrder.Width, ord.dgvListOrder.Height);
            //ord.dgvListOrder.DrawToBitmap(mybitmap, new Rectangle(0, 0, ord.dgvListOrder.Width, ord.dgvListOrder.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            //ord.dgvListOrder.Height = height;
            }
            catch (Exception ex)
            {
            //MessageBox.Show(ex.Message);
            }

            frmQueue que = new frmQueue();
            que.Show();
            ParentForm.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString("Café du Lune", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(300, 19));

                e.Graphics.DrawString("Lipa City, Batangas", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 60));

                e.Graphics.DrawString(" ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(19, 75));

                e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 95));
                e.Graphics.DrawString("Time: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 95));
                e.Graphics.DrawString("Transaction No. : ########", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 125));

                

                e.Graphics.DrawString("ITEM NAME", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(50, 175));
                e.Graphics.DrawString("QTY", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(400, 175));
                e.Graphics.DrawString("PRICE", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, 175));

                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 200));

                e.Graphics.DrawString("Transaction details dapat dito ehhh", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(250, 300));

                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 400));

                e.Graphics.DrawString("THANK YOU!", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(320, 600));

                e.Graphics.DrawString("===========================", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(270, 620));

                e.Graphics.DrawString("Order Number: ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 700));
                e.Graphics.DrawString("410", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(350, 800));
                e.Graphics.DrawString("BARCODE HERE if malalagyan TT TT", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(250, 900));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
