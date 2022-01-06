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
    public partial class Pay : UserControl
    {

        public static double SubTotal, TaxPercent, TaxTotal, OrderTotal, CustomerChange, CustomerPayment;
        public DataGridView ListOfOrders { get; set; }
        

        public Pay()
        {
            InitializeComponent();
        }
        

        private void Pay_Load(object sender, EventArgs e)
        {
            ListOfOrders = dgvPayOrderSummary;
        }

        


        private void rbCancelOrder_Click(object sender, EventArgs e)
        {
            ParentForm.Close();

            frmClickToStart cts = new frmClickToStart();
            cts.Show();
        }

        private void rbDone_Click(object sender, EventArgs e)
        {
            new MultiStepHelper().NextPage(ParentForm, "pbPay", "pbOrderConfirmed", "OrderConfirmed");
        }

        private void rbPay_Click(object sender, EventArgs e)
        {
            SubTotal = MyOrders.subtot;
            TaxPercent = MyOrders.vatTaxPercent;
            TaxTotal = MyOrders.vatTaxTotal;
            OrderTotal = MyOrders.tot;


            txtSubTotal.Text = String.Format("{0:c2}", (SubTotal.ToString()));
            txtTax.Text = String.Format("{0:c2}", (TaxTotal.ToString()));
            txtTotal.Text = String.Format("{0:c2}", (OrderTotal.ToString()));
            lblOrderCost.Text = String.Format("{0:c2}", (OrderTotal.ToString()));


            if (dgvPayOrderSummary.Rows.Count > 0)
            {

                CustomerPayment = double.Parse(lblPaymentAmount.Text);
                CustomerChange = CustomerPayment - OrderTotal;
                lblChange.Text = String.Format("{0:c2}", (CustomerChange));
            }

            rbPay.Visible = false;
            rbCancelOrder.Visible = false;
            rbDone.Visible = true;
            
        }

        

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (lblPaymentAmount.Text == "0.00")
            {
                lblPaymentAmount.Text = "";
                lblPaymentAmount.Text = num.Text;
            }

            else if(num.Text == ".")
            {
                if(!lblPaymentAmount.Text.Contains("."))
                {
                    lblPaymentAmount.Text = lblPaymentAmount.Text + num.Text;
                }
                
            }
            else
            {
                lblPaymentAmount.Text = lblPaymentAmount.Text + num.Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPaymentAmount.Text = "0.00";
        }
        
    }
}
