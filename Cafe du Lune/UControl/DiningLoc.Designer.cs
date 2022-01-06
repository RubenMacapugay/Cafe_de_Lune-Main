namespace Cafe_du_Lune.UControl
{
    partial class DiningLoc
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
            this.ques1 = new System.Windows.Forms.Label();
            this.rbDineIn = new Cafe_du_Lune.RoundedButton();
            this.rbTakeOut = new Cafe_du_Lune.RoundedButton();
            this.rbNext = new Cafe_du_Lune.RoundedButton();
            this.rbCancelOrder = new Cafe_du_Lune.RoundedButton();
            this.SuspendLayout();
            // 
            // ques1
            // 
            this.ques1.AutoSize = true;
            this.ques1.Enabled = false;
            this.ques1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 25F, System.Drawing.FontStyle.Bold);
            this.ques1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.ques1.Location = new System.Drawing.Point(265, 88);
            this.ques1.Name = "ques1";
            this.ques1.Size = new System.Drawing.Size(381, 39);
            this.ques1.TabIndex = 3;
            this.ques1.Text = "How would you like to eat?";
            this.ques1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbDineIn
            // 
            this.rbDineIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbDineIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbDineIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbDineIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbDineIn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbDineIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbDineIn.Image = global::Cafe_du_Lune.Properties.Resources.dine_in;
            this.rbDineIn.Location = new System.Drawing.Point(171, 164);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(239, 164);
            this.rbDineIn.TabIndex = 5;
            this.rbDineIn.Text = "Dine-in";
            this.rbDineIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbDineIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbDineIn.UseVisualStyleBackColor = false;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbTakeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbTakeOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbTakeOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbTakeOut.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbTakeOut.Image = global::Cafe_du_Lune.Properties.Resources.take_out;
            this.rbTakeOut.Location = new System.Drawing.Point(496, 164);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(239, 164);
            this.rbTakeOut.TabIndex = 6;
            this.rbTakeOut.Text = "Take-out";
            this.rbTakeOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbTakeOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbTakeOut.UseVisualStyleBackColor = false;
            // 
            // rbNext
            // 
            this.rbNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbNext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbNext.Location = new System.Drawing.Point(761, 394);
            this.rbNext.Name = "rbNext";
            this.rbNext.Size = new System.Drawing.Size(146, 55);
            this.rbNext.TabIndex = 7;
            this.rbNext.Text = "Next";
            this.rbNext.UseVisualStyleBackColor = false;
            this.rbNext.Click += new System.EventHandler(this.rbNext_Click);
            // 
            // rbCancelOrder
            // 
            this.rbCancelOrder.BackColor = System.Drawing.Color.DarkGray;
            this.rbCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCancelOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.rbCancelOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.rbCancelOrder.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbCancelOrder.ForeColor = System.Drawing.Color.White;
            this.rbCancelOrder.Location = new System.Drawing.Point(3, 394);
            this.rbCancelOrder.Name = "rbCancelOrder";
            this.rbCancelOrder.Size = new System.Drawing.Size(146, 55);
            this.rbCancelOrder.TabIndex = 8;
            this.rbCancelOrder.Text = "Cancel Order";
            this.rbCancelOrder.UseVisualStyleBackColor = false;
            this.rbCancelOrder.Click += new System.EventHandler(this.rbCancelOrder_Click);
            // 
            // DiningLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.rbCancelOrder);
            this.Controls.Add(this.rbNext);
            this.Controls.Add(this.rbTakeOut);
            this.Controls.Add(this.rbDineIn);
            this.Controls.Add(this.ques1);
            this.Name = "DiningLoc";
            this.Size = new System.Drawing.Size(910, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ques1;
        private RoundedButton rbDineIn;
        private RoundedButton rbTakeOut;
        private RoundedButton rbNext;
        private RoundedButton rbCancelOrder;
    }
}
