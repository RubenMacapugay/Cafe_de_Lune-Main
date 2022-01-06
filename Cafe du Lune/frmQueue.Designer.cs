namespace Cafe_du_Lune
{
    partial class frmQueue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ques1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNo = new Cafe_du_Lune.RoundedButton();
            this.rbYes = new Cafe_du_Lune.RoundedButton();
            this.SuspendLayout();
            // 
            // ques1
            // 
            this.ques1.AutoSize = true;
            this.ques1.Enabled = false;
            this.ques1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 40F, System.Drawing.FontStyle.Bold);
            this.ques1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.ques1.Location = new System.Drawing.Point(133, 130);
            this.ques1.Name = "ques1";
            this.ques1.Size = new System.Drawing.Size(662, 136);
            this.ques1.TabIndex = 4;
            this.ques1.Text = "Please take your receipt with \r\nyour order number.\r\n";
            this.ques1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(192, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Would you like to place another order?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbNo
            // 
            this.rbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(152)))), ((int)(((byte)(128)))));
            this.rbNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.rbNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.rbNo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbNo.ForeColor = System.Drawing.Color.White;
            this.rbNo.Location = new System.Drawing.Point(479, 333);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(207, 64);
            this.rbNo.TabIndex = 10;
            this.rbNo.Text = "No, thank you.";
            this.rbNo.UseVisualStyleBackColor = false;
            this.rbNo.Click += new System.EventHandler(this.rbCancelOrder_Click);
            // 
            // rbYes
            // 
            this.rbYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.rbYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(106)))), ((int)(((byte)(83)))));
            this.rbYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.rbYes.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.rbYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.rbYes.Location = new System.Drawing.Point(243, 333);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(207, 64);
            this.rbYes.TabIndex = 9;
            this.rbYes.Text = "Yes, please.";
            this.rbYes.UseVisualStyleBackColor = false;
            this.rbYes.Click += new System.EventHandler(this.rbNext_Click);
            // 
            // frmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ques1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQueue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ques1;
        private System.Windows.Forms.Label label1;
        private RoundedButton rbNo;
        private RoundedButton rbYes;
    }
}