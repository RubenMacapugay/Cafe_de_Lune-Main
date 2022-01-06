namespace Cafe_du_Lune.UControl
{
    partial class MyOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctgHotBev = new System.Windows.Forms.Button();
            this.ctgColdBev = new System.Windows.Forms.Button();
            this.ctgSnacks = new System.Windows.Forms.Button();
            this.ctgFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbDesign = new System.Windows.Forms.PictureBox();
            this.hgltFood = new System.Windows.Forms.PictureBox();
            this.hgltSnacks = new System.Windows.Forms.PictureBox();
            this.hgltHotBev = new System.Windows.Forms.PictureBox();
            this.hgltColdBev = new System.Windows.Forms.PictureBox();
            this.nonHighlight = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListOrder = new System.Windows.Forms.DataGridView();
            this.clmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.TextBox();
            this.rbBack = new Cafe_du_Lune.RoundedButton();
            this.rbCancelOrder = new Cafe_du_Lune.RoundedButton();
            this.rbNext = new Cafe_du_Lune.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltHotBev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltColdBev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonHighlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ctgHotBev
            // 
            this.ctgHotBev.FlatAppearance.BorderSize = 0;
            this.ctgHotBev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctgHotBev.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F);
            this.ctgHotBev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.ctgHotBev.Location = new System.Drawing.Point(504, 1);
            this.ctgHotBev.Name = "ctgHotBev";
            this.ctgHotBev.Size = new System.Drawing.Size(138, 32);
            this.ctgHotBev.TabIndex = 22;
            this.ctgHotBev.Text = "Hot Beverages";
            this.ctgHotBev.UseVisualStyleBackColor = true;
            this.ctgHotBev.Click += new System.EventHandler(this.ctgHotBev_Click);
            // 
            // ctgColdBev
            // 
            this.ctgColdBev.FlatAppearance.BorderSize = 0;
            this.ctgColdBev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctgColdBev.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F);
            this.ctgColdBev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.ctgColdBev.Location = new System.Drawing.Point(346, 1);
            this.ctgColdBev.Name = "ctgColdBev";
            this.ctgColdBev.Size = new System.Drawing.Size(138, 32);
            this.ctgColdBev.TabIndex = 20;
            this.ctgColdBev.Text = "Cold Beverages";
            this.ctgColdBev.UseVisualStyleBackColor = true;
            this.ctgColdBev.Click += new System.EventHandler(this.ctgColdBev_Click);
            // 
            // ctgSnacks
            // 
            this.ctgSnacks.FlatAppearance.BorderSize = 0;
            this.ctgSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctgSnacks.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F);
            this.ctgSnacks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.ctgSnacks.Location = new System.Drawing.Point(188, 1);
            this.ctgSnacks.Name = "ctgSnacks";
            this.ctgSnacks.Size = new System.Drawing.Size(138, 32);
            this.ctgSnacks.TabIndex = 18;
            this.ctgSnacks.Text = "Snacks";
            this.ctgSnacks.UseVisualStyleBackColor = true;
            this.ctgSnacks.Click += new System.EventHandler(this.ctgSnacks_Click);
            // 
            // ctgFood
            // 
            this.ctgFood.FlatAppearance.BorderSize = 0;
            this.ctgFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctgFood.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F);
            this.ctgFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.ctgFood.Location = new System.Drawing.Point(30, 1);
            this.ctgFood.Name = "ctgFood";
            this.ctgFood.Size = new System.Drawing.Size(138, 32);
            this.ctgFood.TabIndex = 16;
            this.ctgFood.Text = "Food";
            this.ctgFood.UseVisualStyleBackColor = true;
            this.ctgFood.Click += new System.EventHandler(this.ctgFood_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(707, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "My Orders";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(704, 346);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // pbDesign
            // 
            this.pbDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.pbDesign.Location = new System.Drawing.Point(703, 0);
            this.pbDesign.Name = "pbDesign";
            this.pbDesign.Size = new System.Drawing.Size(207, 388);
            this.pbDesign.TabIndex = 25;
            this.pbDesign.TabStop = false;
            // 
            // hgltFood
            // 
            this.hgltFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.hgltFood.Location = new System.Drawing.Point(30, 31);
            this.hgltFood.Name = "hgltFood";
            this.hgltFood.Size = new System.Drawing.Size(138, 5);
            this.hgltFood.TabIndex = 26;
            this.hgltFood.TabStop = false;
            // 
            // hgltSnacks
            // 
            this.hgltSnacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.hgltSnacks.Location = new System.Drawing.Point(188, 31);
            this.hgltSnacks.Name = "hgltSnacks";
            this.hgltSnacks.Size = new System.Drawing.Size(138, 5);
            this.hgltSnacks.TabIndex = 27;
            this.hgltSnacks.TabStop = false;
            this.hgltSnacks.Visible = false;
            // 
            // hgltHotBev
            // 
            this.hgltHotBev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.hgltHotBev.Location = new System.Drawing.Point(504, 31);
            this.hgltHotBev.Name = "hgltHotBev";
            this.hgltHotBev.Size = new System.Drawing.Size(138, 5);
            this.hgltHotBev.TabIndex = 28;
            this.hgltHotBev.TabStop = false;
            this.hgltHotBev.Visible = false;
            // 
            // hgltColdBev
            // 
            this.hgltColdBev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.hgltColdBev.Location = new System.Drawing.Point(346, 31);
            this.hgltColdBev.Name = "hgltColdBev";
            this.hgltColdBev.Size = new System.Drawing.Size(138, 5);
            this.hgltColdBev.TabIndex = 29;
            this.hgltColdBev.TabStop = false;
            this.hgltColdBev.Visible = false;
            // 
            // nonHighlight
            // 
            this.nonHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.nonHighlight.Location = new System.Drawing.Point(29, 31);
            this.nonHighlight.Name = "nonHighlight";
            this.nonHighlight.Size = new System.Drawing.Size(614, 5);
            this.nonHighlight.TabIndex = 30;
            this.nonHighlight.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(714, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "TOTAL";
            // 
            // dgvListOrder
            // 
            this.dgvListOrder.AllowUserToAddRows = false;
            this.dgvListOrder.AllowUserToResizeColumns = false;
            this.dgvListOrder.AllowUserToResizeRows = false;
            this.dgvListOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.dgvListOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListOrder.ColumnHeadersHeight = 25;
            this.dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItem,
            this.clmQuantity,
            this.clmPrice});
            this.dgvListOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListOrder.GridColor = System.Drawing.Color.White;
            this.dgvListOrder.Location = new System.Drawing.Point(703, 42);
            this.dgvListOrder.Name = "dgvListOrder";
            this.dgvListOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListOrder.RowHeadersVisible = false;
            this.dgvListOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvListOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOrder.Size = new System.Drawing.Size(207, 258);
            this.dgvListOrder.TabIndex = 33;
            // 
            // clmItem
            // 
            this.clmItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmItem.FillWeight = 56.49351F;
            this.clmItem.HeaderText = "ITEM";
            this.clmItem.Name = "clmItem";
            this.clmItem.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.FillWeight = 92.99541F;
            this.clmQuantity.HeaderText = "QTY";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 54;
            // 
            // clmPrice
            // 
            this.clmPrice.FillWeight = 150.5111F;
            this.clmPrice.HeaderText = "PRICE";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 64;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btnRemoveItem.FlatAppearance.BorderSize = 2;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(797, 6);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(29, 28);
            this.btnRemoveItem.TabIndex = 34;
            this.btnRemoveItem.Text = "X";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.btnClearAll.FlatAppearance.BorderSize = 2;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.btnClearAll.Location = new System.Drawing.Point(833, 6);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(71, 28);
            this.btnClearAll.TabIndex = 35;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblTotal.Location = new System.Drawing.Point(804, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 17);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(714, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "SUB-TOTAL";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(714, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "TAX (12%)";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTax.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblTax.Location = new System.Drawing.Point(804, 338);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 17);
            this.lblTax.TabIndex = 39;
            this.lblTax.Text = "0.00";
            this.lblTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSubTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.lblSubTotal.Location = new System.Drawing.Point(804, 316);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 17);
            this.lblSubTotal.TabIndex = 40;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbBack
            // 
            this.rbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbBack.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbBack.Location = new System.Drawing.Point(609, 394);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(146, 55);
            this.rbBack.TabIndex = 11;
            this.rbBack.Text = "Back";
            this.rbBack.UseVisualStyleBackColor = false;
            this.rbBack.Click += new System.EventHandler(this.rbBack_Click);
            // 
            // rbCancelOrder
            // 
            this.rbCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCancelOrder.BackColor = System.Drawing.Color.DarkGray;
            this.rbCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbCancelOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.rbCancelOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.rbCancelOrder.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbCancelOrder.ForeColor = System.Drawing.Color.White;
            this.rbCancelOrder.Location = new System.Drawing.Point(3, 394);
            this.rbCancelOrder.Name = "rbCancelOrder";
            this.rbCancelOrder.Size = new System.Drawing.Size(146, 55);
            this.rbCancelOrder.TabIndex = 10;
            this.rbCancelOrder.Text = "Cancel Order";
            this.rbCancelOrder.UseVisualStyleBackColor = false;
            this.rbCancelOrder.Click += new System.EventHandler(this.rbCancelOrder_Click);
            // 
            // rbNext
            // 
            this.rbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbNext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbNext.Location = new System.Drawing.Point(761, 394);
            this.rbNext.Name = "rbNext";
            this.rbNext.Size = new System.Drawing.Size(146, 55);
            this.rbNext.TabIndex = 9;
            this.rbNext.Text = "Place Order";
            this.rbNext.UseVisualStyleBackColor = false;
            this.rbNext.Click += new System.EventHandler(this.rbNext_Click);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.dgvListOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hgltColdBev);
            this.Controls.Add(this.hgltHotBev);
            this.Controls.Add(this.hgltSnacks);
            this.Controls.Add(this.hgltFood);
            this.Controls.Add(this.nonHighlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDesign);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ctgHotBev);
            this.Controls.Add(this.ctgColdBev);
            this.Controls.Add(this.ctgSnacks);
            this.Controls.Add(this.ctgFood);
            this.Controls.Add(this.rbBack);
            this.Controls.Add(this.rbCancelOrder);
            this.Controls.Add(this.rbNext);
            this.Name = "MyOrders";
            this.Size = new System.Drawing.Size(910, 452);
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltHotBev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgltColdBev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonHighlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton rbCancelOrder;
        private RoundedButton rbNext;
        private RoundedButton rbBack;
        private System.Windows.Forms.Button ctgHotBev;
        private System.Windows.Forms.Button ctgColdBev;
        private System.Windows.Forms.Button ctgSnacks;
        private System.Windows.Forms.Button ctgFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbDesign;
        private System.Windows.Forms.PictureBox hgltFood;
        private System.Windows.Forms.PictureBox hgltSnacks;
        private System.Windows.Forms.PictureBox hgltHotBev;
        private System.Windows.Forms.PictureBox hgltColdBev;
        private System.Windows.Forms.PictureBox nonHighlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox lblTotal;
        public System.Windows.Forms.TextBox lblTax;
        public System.Windows.Forms.TextBox lblSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        public System.Windows.Forms.DataGridView dgvListOrder;
    }
}
