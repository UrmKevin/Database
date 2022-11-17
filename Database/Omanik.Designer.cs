namespace Database
{
    partial class Omanik
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
            this.kassa_pbx = new System.Windows.Forms.PictureBox();
            this.ladu_pbx = new System.Windows.Forms.PictureBox();
            this.admin_pbx = new System.Windows.Forms.PictureBox();
            this.logout_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kassa_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladu_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // kassa_pbx
            // 
            this.kassa_pbx.Location = new System.Drawing.Point(32, 80);
            this.kassa_pbx.Name = "kassa_pbx";
            this.kassa_pbx.Size = new System.Drawing.Size(200, 200);
            this.kassa_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kassa_pbx.TabIndex = 0;
            this.kassa_pbx.TabStop = false;
            this.kassa_pbx.Click += new System.EventHandler(this.kassa_pbx_Click);
            // 
            // ladu_pbx
            // 
            this.ladu_pbx.Location = new System.Drawing.Point(555, 80);
            this.ladu_pbx.Name = "ladu_pbx";
            this.ladu_pbx.Size = new System.Drawing.Size(200, 200);
            this.ladu_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ladu_pbx.TabIndex = 1;
            this.ladu_pbx.TabStop = false;
            this.ladu_pbx.Click += new System.EventHandler(this.ladu_pbx_Click);
            // 
            // admin_pbx
            // 
            this.admin_pbx.InitialImage = null;
            this.admin_pbx.Location = new System.Drawing.Point(296, 80);
            this.admin_pbx.Name = "admin_pbx";
            this.admin_pbx.Size = new System.Drawing.Size(200, 200);
            this.admin_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_pbx.TabIndex = 2;
            this.admin_pbx.TabStop = false;
            this.admin_pbx.Click += new System.EventHandler(this.admin_pbx_Click);
            // 
            // logout_pbx
            // 
            this.logout_pbx.Location = new System.Drawing.Point(742, 12);
            this.logout_pbx.Name = "logout_pbx";
            this.logout_pbx.Size = new System.Drawing.Size(40, 40);
            this.logout_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout_pbx.TabIndex = 3;
            this.logout_pbx.TabStop = false;
            this.logout_pbx.Click += new System.EventHandler(this.logout_pbx_Click);
            // 
            // Omanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 314);
            this.Controls.Add(this.logout_pbx);
            this.Controls.Add(this.admin_pbx);
            this.Controls.Add(this.ladu_pbx);
            this.Controls.Add(this.kassa_pbx);
            this.Name = "Omanik";
            this.Text = "Omanik";
            ((System.ComponentModel.ISupportInitialize)(this.kassa_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladu_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kassa_pbx;
        private System.Windows.Forms.PictureBox ladu_pbx;
        private System.Windows.Forms.PictureBox admin_pbx;
        private System.Windows.Forms.PictureBox logout_pbx;
    }
}