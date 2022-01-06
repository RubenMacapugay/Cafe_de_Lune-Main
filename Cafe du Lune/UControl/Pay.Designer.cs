namespace Cafe_du_Lune.UControl
{
    partial class Pay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.hgltFood = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.dgvPayOrderSummary = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentSlider = new System.Windows.Forms.Panel();
            this.lblOrderCost = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbDone = new Cafe_du_Lune.RoundedButton();
            this.rbCancelOrder = new Cafe_du_Lune.RoundedButton();
            this.rbPay = new Cafe_du_Lune.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayOrderSummary)).BeginInit();
            this.paymentSlider.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 5);
            this.panel1.TabIndex = 20;
            // 
            // hgltFood
            // 
            this.hgltFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.hgltFood.Location = new System.Drawing.Point(189, 25);
            this.hgltFood.Name = "hgltFood";
            this.hgltFood.Size = new System.Drawing.Size(720, 5);
            this.hgltFood.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(46, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "Payment";
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn9.Location = new System.Drawing.Point(137, 51);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn8.Location = new System.Drawing.Point(71, 51);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn7.Location = new System.Drawing.Point(5, 51);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 23;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn6.Location = new System.Drawing.Point(137, 118);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn5.Location = new System.Drawing.Point(71, 118);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 25;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn4.Location = new System.Drawing.Point(5, 118);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 26;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn3.Location = new System.Drawing.Point(137, 184);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn2.Location = new System.Drawing.Point(71, 184);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 28;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn1.Location = new System.Drawing.Point(5, 184);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btnClear.Location = new System.Drawing.Point(137, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btn0.Location = new System.Drawing.Point(71, 250);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 31;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btnPeriod.FlatAppearance.BorderSize = 2;
            this.btnPeriod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriod.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.btnPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btnPeriod.Location = new System.Drawing.Point(5, 250);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(60, 60);
            this.btnPeriod.TabIndex = 32;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // dgvPayOrderSummary
            // 
            this.dgvPayOrderSummary.AllowUserToAddRows = false;
            this.dgvPayOrderSummary.AllowUserToDeleteRows = false;
            this.dgvPayOrderSummary.AllowUserToResizeColumns = false;
            this.dgvPayOrderSummary.AllowUserToResizeRows = false;
            this.dgvPayOrderSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayOrderSummary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.dgvPayOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayOrderSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemQty,
            this.ItemPrice});
            this.dgvPayOrderSummary.Location = new System.Drawing.Point(213, 51);
            this.dgvPayOrderSummary.Name = "dgvPayOrderSummary";
            this.dgvPayOrderSummary.ReadOnly = true;
            this.dgvPayOrderSummary.RowHeadersVisible = false;
            this.dgvPayOrderSummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvPayOrderSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayOrderSummary.Size = new System.Drawing.Size(408, 337);
            this.dgvPayOrderSummary.TabIndex = 36;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.FillWeight = 135.4089F;
            this.ItemName.HeaderText = "ITEM";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemQty
            // 
            this.ItemQty.FillWeight = 88.44892F;
            this.ItemQty.HeaderText = "QUANTITY";
            this.ItemQty.Name = "ItemQty";
            this.ItemQty.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemPrice.FillWeight = 76.14214F;
            this.ItemPrice.HeaderText = "PRICE";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(5, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 72);
            this.panel3.TabIndex = 48;
            // 
            // paymentSlider
            // 
            this.paymentSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.paymentSlider.Controls.Add(this.lblOrderCost);
            this.paymentSlider.Controls.Add(this.lblChange);
            this.paymentSlider.Controls.Add(this.lblPaymentAmount);
            this.paymentSlider.Controls.Add(this.label8);
            this.paymentSlider.Controls.Add(this.label6);
            this.paymentSlider.Controls.Add(this.label7);
            this.paymentSlider.Location = new System.Drawing.Point(636, 226);
            this.paymentSlider.Name = "paymentSlider";
            this.paymentSlider.Size = new System.Drawing.Size(271, 162);
            this.paymentSlider.TabIndex = 51;
            // 
            // lblOrderCost
            // 
            this.lblOrderCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.lblOrderCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderCost.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblOrderCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblOrderCost.Location = new System.Drawing.Point(155, 68);
            this.lblOrderCost.Name = "lblOrderCost";
            this.lblOrderCost.ReadOnly = true;
            this.lblOrderCost.Size = new System.Drawing.Size(100, 24);
            this.lblOrderCost.TabIndex = 57;
            this.lblOrderCost.Text = "0.00";
            this.lblOrderCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChange.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblChange.Location = new System.Drawing.Point(155, 106);
            this.lblChange.Name = "lblChange";
            this.lblChange.ReadOnly = true;
            this.lblChange.Size = new System.Drawing.Size(100, 24);
            this.lblChange.TabIndex = 54;
            this.lblChange.Text = "0.00";
            this.lblChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.lblPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblPaymentAmount.Location = new System.Drawing.Point(155, 30);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(100, 24);
            this.lblPaymentAmount.TabIndex = 58;
            this.lblPaymentAmount.Text = "0.00";
            this.lblPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Payment Amount";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(19, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Change";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(19, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Order Cost";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(636, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 162);
            this.panel2.TabIndex = 59;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTax.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.txtTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.txtTax.Location = new System.Drawing.Point(156, 67);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 24);
            this.txtTax.TabIndex = 57;
            this.txtTax.Text = "0.00";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.txtTotal.Location = new System.Drawing.Point(156, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 24);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSubTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.txtSubTotal.Location = new System.Drawing.Point(156, 29);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 24);
            this.txtSubTotal.TabIndex = 58;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Sub-Total";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(19, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label10.Location = new System.Drawing.Point(19, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tax (12% Vat)";
            // 
            // rbDone
            // 
            this.rbDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbDone.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbDone.Location = new System.Drawing.Point(709, 397);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(196, 55);
            this.rbDone.TabIndex = 60;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = false;
            this.rbDone.Click += new System.EventHandler(this.rbDone_Click);
            // 
            // rbCancelOrder
            // 
            this.rbCancelOrder.BackColor = System.Drawing.Color.DarkGray;
            this.rbCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbCancelOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.rbCancelOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.rbCancelOrder.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbCancelOrder.ForeColor = System.Drawing.Color.White;
            this.rbCancelOrder.Location = new System.Drawing.Point(3, 394);
            this.rbCancelOrder.Name = "rbCancelOrder";
            this.rbCancelOrder.Size = new System.Drawing.Size(146, 55);
            this.rbCancelOrder.TabIndex = 15;
            this.rbCancelOrder.Text = "Cancel Order";
            this.rbCancelOrder.UseVisualStyleBackColor = false;
            this.rbCancelOrder.Click += new System.EventHandler(this.rbCancelOrder_Click);
            // 
            // rbPay
            // 
            this.rbPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbPay.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbPay.Location = new System.Drawing.Point(711, 397);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(196, 55);
            this.rbPay.TabIndex = 14;
            this.rbPay.Text = "Pay";
            this.rbPay.UseVisualStyleBackColor = false;
            this.rbPay.Click += new System.EventHandler(this.rbPay_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paymentSlider);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPayOrderSummary);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hgltFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCancelOrder);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbDone);
            this.Name = "Pay";
            this.Size = new System.Drawing.Size(910, 452);
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayOrderSummary)).EndInit();
            this.paymentSlider.ResumeLayout(false);
            this.paymentSlider.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton rbCancelOrder;
        private RoundedButton rbPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hgltFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.DataGridView dgvPayOrderSummary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paymentSlider;
        private System.Windows.Forms.TextBox lblOrderCost;
        private System.Windows.Forms.TextBox lblChange;
        private System.Windows.Forms.TextBox lblPaymentAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private RoundedButton rbDone;
    }
}
