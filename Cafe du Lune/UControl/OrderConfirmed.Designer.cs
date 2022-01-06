namespace Cafe_du_Lune.UControl
{
    partial class OrderConfirmed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirmed));
            this.ques1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.rbNext = new Cafe_du_Lune.RoundedButton();
            this.SuspendLayout();
            // 
            // ques1
            // 
            this.ques1.AutoSize = true;
            this.ques1.Enabled = false;
            this.ques1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 40F, System.Drawing.FontStyle.Bold);
            this.ques1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.ques1.Location = new System.Drawing.Point(169, 129);
            this.ques1.Name = "ques1";
            this.ques1.Size = new System.Drawing.Size(572, 136);
            this.ques1.TabIndex = 18;
            this.ques1.Text = "Your order has been sent \r\nto our kitchen.";
            this.ques1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // rbNext
            // 
            this.rbNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(132)))), ((int)(((byte)(101)))));
            this.rbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbNext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbNext.Location = new System.Drawing.Point(352, 268);
            this.rbNext.Name = "rbNext";
            this.rbNext.Size = new System.Drawing.Size(206, 55);
            this.rbNext.TabIndex = 19;
            this.rbNext.Text = "OK";
            this.rbNext.UseVisualStyleBackColor = false;
            this.rbNext.Click += new System.EventHandler(this.rbNext_Click);
            // 
            // OrderConfirmed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.rbNext);
            this.Controls.Add(this.ques1);
            this.Name = "OrderConfirmed";
            this.Size = new System.Drawing.Size(910, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ques1;
        private RoundedButton rbNext;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
