namespace Cafe_du_Lune.UControl
{
    partial class MenuChoice
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
            this.border = new System.Windows.Forms.Panel();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackgroundImage = global::Cafe_du_Lune.Properties.Resources.BorderStyle;
            this.border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.border.Controls.Add(this.pbProductImage);
            this.border.Controls.Add(this.lblPrice);
            this.border.Controls.Add(this.lblProdName);
            this.border.Location = new System.Drawing.Point(4, 4);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(214, 220);
            this.border.TabIndex = 1;
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Image = global::Cafe_du_Lune.Properties.Resources.CaféduLune_logo;
            this.pbProductImage.Location = new System.Drawing.Point(27, 19);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(154, 99);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 3;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.lblPrice.Location = new System.Drawing.Point(15, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "30.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProdName
            // 
            this.lblProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.lblProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.lblProdName.Location = new System.Drawing.Point(14, 164);
            this.lblProdName.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(181, 42);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Sprinkles Vanilla Ice Cream Sandwich Waffle";
            // 
            // MenuChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.border);
            this.Name = "MenuChoice";
            this.Size = new System.Drawing.Size(223, 229);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel border;
        public System.Windows.Forms.PictureBox pbProductImage;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblProdName;
    }
}
