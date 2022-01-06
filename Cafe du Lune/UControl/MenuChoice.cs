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
    public partial class MenuChoice : UserControl
    {
        public event EventHandler OnSelect = null;
        private categories _category;
        private string _prodname;
        private double _prodprice;

        public MenuChoice()
        {
            InitializeComponent();
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }


        public enum categories { Food, Snacks, ColdBev, HotBev }
        public categories Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string ProdName
        {
            get { return lblProdName.Text; }
            set { lblProdName.Text = value; }
        }

        public double ProdPrice
        {
            get { return _prodprice; }
            set { _prodprice = value; lblPrice.Text = _prodprice.ToString("C2"); }
        }

        public Image Icon
        {
            get { return pbProductImage.Image; }
            set { pbProductImage.Image = value; }
        }
    }
}
