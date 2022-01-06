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
    public partial class MyOrders : UserControl
    {

        public static double subtot, vatTaxPercent, vatTaxTotal, tot;
        public DataGridView OrderList { get; set; }

        

        public MyOrders()
        {
            InitializeComponent();
        }

        private void AddItem(string name, double cost, MenuChoice.categories category, string icon)
        {
            var w = new MenuChoice()
            {
                ProdName = name,
                ProdPrice = cost,
                Category = category,
                Icon = Image.FromFile("Icons/" + icon),
                Tag = category
            };
            flowLayoutPanel1.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var mch = (MenuChoice)ss;
                foreach (DataGridViewRow item in dgvListOrder.Rows)
                {
                    if (item.Cells[0].Value.ToString() == mch.lblProdName.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(mch.lblPrice.Text.Replace("$", ""))).ToString("C2");
                        PlusTaxCost();
                        return;
                    }
                }
                dgvListOrder.Rows.Add(new object[] { mch.lblProdName.Text, 1, mch.lblPrice.Text });
                PlusTaxCost();
            };

        }

        

        public double Order_SubTotal()
        {
            subtot = 0;
            int i = 0;

            foreach (DataGridViewRow item in dgvListOrder.Rows)
            {
                subtot = subtot + double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
            }
            return subtot;
        }

        public void PlusTaxCost()
        {
            
            vatTaxPercent = 0.12;
            if(dgvListOrder.Rows.Count > 0)
            {
                lblTax.Text = String.Format("{0:c2}", (Order_SubTotal() * vatTaxPercent));
                lblSubTotal.Text = String.Format("{0:c2}", (Order_SubTotal()));
                vatTaxTotal = Order_SubTotal() * vatTaxPercent;
                tot = Order_SubTotal() + vatTaxTotal;
                lblTotal.Text = String.Format("{0:c2}", (tot));
            }

        }


        private void ctgFood_Click(object sender, EventArgs e)
        {
            hgltFood.Visible = true;
            ctgFood.ForeColor = Color.FromArgb(156, 97, 65);

            hgltSnacks.Visible = false;
            hgltColdBev.Visible = false;
            hgltHotBev.Visible = false;
            ctgSnacks.ForeColor = Color.FromArgb(177, 157, 125);
            ctgColdBev.ForeColor = Color.FromArgb(177, 157, 125);
            ctgHotBev.ForeColor = Color.FromArgb(177, 157, 125);

            flowLayoutPanel1.Controls.Clear();
            AddItem("Classic Cheese Burger", 50.00, MenuChoice.categories.Food, "Classic Cheese Burger.png");
            AddItem("No-Bun Bruschetta Burger", 50.00, MenuChoice.categories.Food, "No-Bun Bruschetta Burger.png");
            AddItem("Classic Veggie Burger", 50.00, MenuChoice.categories.Food, "Classic Veggie Burger.png");
            AddItem("Chicken Burger", 50.00, MenuChoice.categories.Food, "Chicken Burger.png");
            AddItem("Steak Frites Burger", 50.00, MenuChoice.categories.Food, "Steak Frites Burger.png");
            AddItem("Double Patty Veggie Burger", 50.00, MenuChoice.categories.Food, "Double Patty Veggie Burger.png");
            AddItem("Hawaiian Pizza", 50.00, MenuChoice.categories.Food, "hawaiian-pizza.png");
            AddItem("Cheese Pizza", 50.00, MenuChoice.categories.Food, "cheese-pizza.png");
            AddItem("Peperoni Pizza", 50.00, MenuChoice.categories.Food, "peperoni-pizza.png");
            AddItem("Veggie Pizza", 50.00, MenuChoice.categories.Food, "veggie-pizza.png");
            AddItem("Meat Pizza", 50.00, MenuChoice.categories.Food, "meat-pizza.png");
            AddItem("Margherita Pizza", 50.00, MenuChoice.categories.Food, "margherita-pizza.png");
            AddItem("BBQ Chicken Pizza", 50.00, MenuChoice.categories.Food, "bbq-chicken-pizza.png");
            AddItem("Buffalo Chicken Pizza", 50.00, MenuChoice.categories.Food, "buffalo-chicken-pizza.png");
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            AddItem("Classic Cheese Burger", 50.00, MenuChoice.categories.Food, "Classic Cheese Burger.png");
            AddItem("No-Bun Bruschetta Burger", 50.00, MenuChoice.categories.Food, "No-Bun Bruschetta Burger.png");
            AddItem("Classic Veggie Burger", 50.00, MenuChoice.categories.Food, "Classic Veggie Burger.png");
            AddItem("Chicken Burger", 50.00, MenuChoice.categories.Food, "Chicken Burger.png");
            AddItem("Steak Frites Burger", 50.00, MenuChoice.categories.Food, "Steak Frites Burger.png");
            AddItem("Double Patty Veggie Burger", 50.00, MenuChoice.categories.Food, "Double Patty Veggie Burger.png");
            AddItem("Hawaiian Pizza", 50.00, MenuChoice.categories.Food, "hawaiian-pizza.png");
            AddItem("Cheese Pizza", 50.00, MenuChoice.categories.Food, "cheese-pizza.png");
            AddItem("Peperoni Pizza", 50.00, MenuChoice.categories.Food, "peperoni-pizza.png");
            AddItem("Veggie Pizza", 50.00, MenuChoice.categories.Food, "veggie-pizza.png");
            AddItem("Meat Pizza", 50.00, MenuChoice.categories.Food, "meat-pizza.png");
            AddItem("Margherita Pizza", 50.00, MenuChoice.categories.Food, "margherita-pizza.png");
            AddItem("BBQ Chicken Pizza", 50.00, MenuChoice.categories.Food, "bbq-chicken-pizza.png");
            AddItem("Buffalo Chicken Pizza", 50.00, MenuChoice.categories.Food, "buffalo-chicken-pizza.png");

            OrderList = dgvListOrder;

        }

        private void ctgSnacks_Click(object sender, EventArgs e)
        {
            hgltSnacks.Visible = true;
            ctgSnacks.ForeColor = Color.FromArgb(156, 97, 65);

            hgltFood.Visible = false;
            hgltColdBev.Visible = false;
            hgltHotBev.Visible = false;
            ctgFood.ForeColor = Color.FromArgb(177, 157, 125);
            ctgColdBev.ForeColor = Color.FromArgb(177, 157, 125);
            ctgHotBev.ForeColor = Color.FromArgb(177, 157, 125);

            flowLayoutPanel1.Controls.Clear();
            AddItem("Chocolate Ice Cream Sandwich Waffle", 50.00, MenuChoice.categories.Snacks, "Chocolate Ice Cream Sandwich Waffle.png");
            AddItem("Sprinkles Vanilla Ice Cream Sandwich Waffle", 50.00, MenuChoice.categories.Snacks, "Sprinkles Vanilla Ice Cream Sandwich Waffle.png");
            AddItem("Matcha Ice Cream Sandwich Waffle", 50.00, MenuChoice.categories.Snacks, "Matcha Ice Cream Sandwich Waffle.png");
            AddItem("Strawberry Ice Cream Sandwich Waffle", 50.00, MenuChoice.categories.Snacks, "Strawberry Ice Cream Sandwich Waffle.png");
            AddItem("Caramelized Apple Sandwich Waffle", 50.00, MenuChoice.categories.Snacks, "Caramelized Apple Sandwich Waffle.png");
            AddItem("Vanilla Ice Cream Chocolate Glazed Waffle", 50.00, MenuChoice.categories.Snacks, "Vanilla Ice Cream Chocolate Glazed Waffle.png");
            AddItem("Ultimate Waffle Toppings Combo", 50.00, MenuChoice.categories.Snacks, "Ultimate Waffle Toppings Combo.png");
            AddItem("Regular Baked Fries", 50.00, MenuChoice.categories.Snacks, "Regular Baked Fries.png");
            AddItem("Bacon Cheese Baked Fries", 50.00, MenuChoice.categories.Snacks, "Bacon Cheese Baked Fries.png");
            AddItem("BBQ Baked Fries", 50.00, MenuChoice.categories.Snacks, "BBQ Baked Fries.png");
            AddItem("Vanilla Ice Cream", 50.00, MenuChoice.categories.Snacks, "Vanilla Ice Cream.png");
            AddItem("Chocolate Ice Cream", 50.00, MenuChoice.categories.Snacks, "Chocolate Ice Cream.png");
            AddItem("Matcha Ice Cream", 50.00, MenuChoice.categories.Snacks, "Matcha Ice Cream.png");
            AddItem("Strawberry Ice Cream", 50.00, MenuChoice.categories.Snacks, "Strawberry Ice Cream.png");
            AddItem("Rainbow Ice Cream", 50.00, MenuChoice.categories.Snacks, "Rainbow Ice Cream.png");
        }

        private void ctgColdBev_Click(object sender, EventArgs e)
        {
            hgltColdBev.Visible = true;
            ctgColdBev.ForeColor = Color.FromArgb(156, 97, 65);

            hgltFood.Visible = false;
            hgltSnacks.Visible = false;
            hgltHotBev.Visible = false;
            ctgFood.ForeColor = Color.FromArgb(177, 157, 125);
            ctgSnacks.ForeColor = Color.FromArgb(177, 157, 125);
            ctgHotBev.ForeColor = Color.FromArgb(177, 157, 125);

            flowLayoutPanel1.Controls.Clear();
            AddItem("Cherry Cola Ice Cream Float", 50.00, MenuChoice.categories.ColdBev, "Cherry Cola Ice Cream Float.png");
            AddItem("Chocolate Ice Cream Float", 50.00, MenuChoice.categories.ColdBev, "Chocolate Ice Cream Float.png");
            AddItem("Vanilla Caramel Iced Latte", 50.00, MenuChoice.categories.ColdBev, "Vanilla Caramel Iced Latte.png");
            AddItem("Coca Cola", 50.00, MenuChoice.categories.ColdBev, "Coca Cola.png");
            AddItem("Diet Coke", 50.00, MenuChoice.categories.ColdBev, "Diet Coke.png");
            AddItem("Iced Tea With Plums and Thyme", 50.00, MenuChoice.categories.ColdBev, "Iced Tea With Plums and Thyme.png");
            AddItem("Hibiscus Mocktini", 50.00, MenuChoice.categories.ColdBev, "Hibiscus Mocktini.png");
            AddItem("Strawberry Lemon Crush", 50.00, MenuChoice.categories.ColdBev, "Strawberry Lemon Crush.png");
            AddItem("Sparkling Pineapple Gingerale", 50.00, MenuChoice.categories.ColdBev, "Sparkling Pineapple Gingerale.png");
            AddItem("Coconut Water Lemonade", 50.00, MenuChoice.categories.ColdBev, "Coconut Water Lemonade.png");
            AddItem("Frozen Blueberry Lemonade", 50.00, MenuChoice.categories.ColdBev, "Frozen Blueberry Lemonade.png");
            AddItem("Cranberry Spritzer", 50.00, MenuChoice.categories.ColdBev, "Cranberry Spritzer.png");
            AddItem("Iced Tahini Mocha", 50.00, MenuChoice.categories.ColdBev, "Iced Tahini Mocha.png");
            AddItem("Iced Matcha Green Tea Latte", 50.00, MenuChoice.categories.ColdBev, "Iced Matcha Green Tea Latte.png");
            AddItem("Bubble Tea", 50.00, MenuChoice.categories.ColdBev, "Bubble Tea.png");
            AddItem("Bottled Water", 50.00, MenuChoice.categories.ColdBev, "Bottled Water.png");
        }

        private void ctgHotBev_Click(object sender, EventArgs e)
        {
            hgltHotBev.Visible = true;
            ctgHotBev.ForeColor = Color.FromArgb(156, 97, 65);

            hgltFood.Visible = false;
            hgltSnacks.Visible = false;
            hgltColdBev.Visible = false;
            ctgFood.ForeColor = Color.FromArgb(177, 157, 125);
            ctgSnacks.ForeColor = Color.FromArgb(177, 157, 125);
            ctgColdBev.ForeColor = Color.FromArgb(177, 157, 125);

            flowLayoutPanel1.Controls.Clear();
            AddItem("Hot Chocolate", 50.00, MenuChoice.categories.HotBev, "Hot Chocolate.png");
            AddItem("Chai Tea Latte", 50.00, MenuChoice.categories.HotBev, "Chai Tea Latte.png");
            AddItem("Spiced Ginger Cardamom Coffee", 50.00, MenuChoice.categories.HotBev, "Spiced Ginger Cardamom Coffee.png");
            AddItem("Irish Coffee", 50.00, MenuChoice.categories.HotBev, "Irish Coffee.png");
            AddItem("Creamy Caramel Latte", 50.00, MenuChoice.categories.HotBev, "Creamy Caramel Latte.png");
            AddItem("Warm Hazelnut Toddy", 50.00, MenuChoice.categories.HotBev, "Warm Hazelnut Toddy.png");
            AddItem("Caramel Hazelnut Mocha", 50.00, MenuChoice.categories.HotBev, "Caramel Hazelnut Mocha.png");
            AddItem("Hot Penicillin", 50.00, MenuChoice.categories.HotBev, "Hot Penicillin.png");
            AddItem("Pumpkin Spice Latte", 50.00, MenuChoice.categories.HotBev, "Pumpkin Spice Latte.png");
            AddItem("Hot Tumeric Latte", 50.00, MenuChoice.categories.HotBev, "Hot Tumeric Latte.png");
            AddItem("Hot Matcha Latte", 50.00, MenuChoice.categories.HotBev, "Hot Matcha Latte.png");
            AddItem("Asiático", 50.00, MenuChoice.categories.HotBev, "Asiático.png");
            AddItem("Double Chocolaty Chip Crème Frappuccino", 50.00, MenuChoice.categories.HotBev, "Double Chocolaty Chip Crème Frappuccino.png");
            AddItem("Caramel Frappuccino", 50.00, MenuChoice.categories.HotBev, "Caramel Frappuccino.png");
            AddItem("Espresso", 50.00, MenuChoice.categories.HotBev, "Espresso.png");
            AddItem("Cappuccino", 50.00, MenuChoice.categories.HotBev, "Cappuccino.png");
            AddItem("Dark Roast", 50.00, MenuChoice.categories.HotBev, "Dark Roast.png");
            AddItem("Caffè Misto", 50.00, MenuChoice.categories.HotBev, "Caffè Misto.png");
            AddItem("Americano", 50.00, MenuChoice.categories.HotBev, "Americano.png");
        }


        private void rbNext_Click(object sender, EventArgs e)
        {
            
            new MultiStepHelper().NextPage(ParentForm, "pbMyOrders", "pbPay", "Pay");
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dgvListOrder.SelectedRows)
            {
                dgvListOrder.Rows.Remove(row);
            }
            PlusTaxCost();
            
            
        }

        private void rbBack_Click(object sender, EventArgs e)
        {
            new MultiStepHelper().PreviousPage(ParentForm, "pbMyOrders", "pbDineLoc", "DiningLoc");
        }

        private void rbCancelOrder_Click(object sender, EventArgs e)
        {
            ParentForm.Close();

            frmClickToStart cts = new frmClickToStart();
            cts.Show();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                dgvListOrder.Rows.Clear();
                dgvListOrder.Refresh();
                lblSubTotal.Text = "0.00";
                lblTax.Text = "0.00";
                lblTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
