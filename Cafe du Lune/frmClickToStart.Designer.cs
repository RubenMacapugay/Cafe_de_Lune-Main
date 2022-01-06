namespace Cafe_du_Lune
{
    partial class frmClickToStart
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
            this.components = new System.ComponentModel.Container();
            this.pbCafeDeLune = new System.Windows.Forms.PictureBox();
            this.btnClickToStart = new System.Windows.Forms.Button();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.tmrTrans = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCafeDeLune)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCafeDeLune
            // 
            this.pbCafeDeLune.BackgroundImage = global::Cafe_du_Lune.Properties.Resources.WelcomeToCafeDuLune;
            this.pbCafeDeLune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCafeDeLune.Location = new System.Drawing.Point(162, 10);
            this.pbCafeDeLune.Name = "pbCafeDeLune";
            this.pbCafeDeLune.Size = new System.Drawing.Size(605, 419);
            this.pbCafeDeLune.TabIndex = 0;
            this.pbCafeDeLune.TabStop = false;
            // 
            // btnClickToStart
            // 
            this.btnClickToStart.AutoSize = true;
            this.btnClickToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnClickToStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClickToStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClickToStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClickToStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.btnClickToStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(54)))));
            this.btnClickToStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(88)))), ((int)(((byte)(60)))));
            this.btnClickToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickToStart.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickToStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.btnClickToStart.Location = new System.Drawing.Point(0, 425);
            this.btnClickToStart.Name = "btnClickToStart";
            this.btnClickToStart.Size = new System.Drawing.Size(928, 102);
            this.btnClickToStart.TabIndex = 3;
            this.btnClickToStart.Text = "CLICK HERE TO START";
            this.btnClickToStart.UseVisualStyleBackColor = false;
            this.btnClickToStart.Click += new System.EventHandler(this.btnClickToStart_Click);
            // 
            // loadBar
            // 
            this.loadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.loadBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.loadBar.Location = new System.Drawing.Point(102, 464);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(724, 19);
            this.loadBar.TabIndex = 4;
            // 
            // tmrTrans
            // 
            this.tmrTrans.Interval = 50;
            this.tmrTrans.Tick += new System.EventHandler(this.tmrTrans_Tick);
            // 
            // frmClickToStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.loadBar);
            this.Controls.Add(this.btnClickToStart);
            this.Controls.Add(this.pbCafeDeLune);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClickToStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Café du Lune";
            this.Load += new System.EventHandler(this.frmClickToStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCafeDeLune)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCafeDeLune;
        private System.Windows.Forms.Button btnClickToStart;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.Timer tmrTrans;
    }
}

