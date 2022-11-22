namespace Database
{
    partial class Warehouse
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
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Kategooria_lbl = new System.Windows.Forms.Label();
            this.Kat_cbx = new System.Windows.Forms.ComboBox();
            this.Toode_pbx = new System.Windows.Forms.PictureBox();
            this.KogusPic_btn = new System.Windows.Forms.Button();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lisa_kat_lbl = new System.Windows.Forms.Label();
            this.Kustuta_Kat_lbl = new System.Windows.Forms.Label();
            this.Kogus_txt = new System.Windows.Forms.NumericUpDown();
            this.Hind_txt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hind_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(150, 48);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(152, 20);
            this.Toode_txt.TabIndex = 0;
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Toode_lbl.Location = new System.Drawing.Point(37, 47);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(107, 18);
            this.Toode_lbl.TabIndex = 3;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Hind_lbl.Location = new System.Drawing.Point(106, 119);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(38, 18);
            this.Hind_lbl.TabIndex = 4;
            this.Hind_lbl.Text = "Hind";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kogus_lbl.Location = new System.Drawing.Point(93, 84);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(51, 18);
            this.Kogus_lbl.TabIndex = 5;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Kategooria_lbl
            // 
            this.Kategooria_lbl.AutoSize = true;
            this.Kategooria_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kategooria_lbl.Location = new System.Drawing.Point(64, 153);
            this.Kategooria_lbl.Name = "Kategooria_lbl";
            this.Kategooria_lbl.Size = new System.Drawing.Size(80, 18);
            this.Kategooria_lbl.TabIndex = 6;
            this.Kategooria_lbl.Text = "Kategooria";
            // 
            // Kat_cbx
            // 
            this.Kat_cbx.FormattingEnabled = true;
            this.Kat_cbx.Location = new System.Drawing.Point(150, 152);
            this.Kat_cbx.Name = "Kat_cbx";
            this.Kat_cbx.Size = new System.Drawing.Size(152, 21);
            this.Kat_cbx.TabIndex = 7;
            // 
            // Toode_pbx
            // 
            this.Toode_pbx.Location = new System.Drawing.Point(334, 25);
            this.Toode_pbx.Name = "Toode_pbx";
            this.Toode_pbx.Size = new System.Drawing.Size(186, 186);
            this.Toode_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toode_pbx.TabIndex = 8;
            this.Toode_pbx.TabStop = false;
            // 
            // KogusPic_btn
            // 
            this.KogusPic_btn.Location = new System.Drawing.Point(526, 180);
            this.KogusPic_btn.Name = "KogusPic_btn";
            this.KogusPic_btn.Size = new System.Drawing.Size(90, 30);
            this.KogusPic_btn.TabIndex = 9;
            this.KogusPic_btn.Text = "Otsi fail";
            this.KogusPic_btn.UseVisualStyleBackColor = true;
            this.KogusPic_btn.Click += new System.EventHandler(this.KogusPic_btn_Click);
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.Location = new System.Drawing.Point(526, 216);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(90, 30);
            this.Kustuta_btn.TabIndex = 10;
            this.Kustuta_btn.Text = "Kustuta";
            this.Kustuta_btn.UseVisualStyleBackColor = true;
            this.Kustuta_btn.Click += new System.EventHandler(this.Kustuta_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Location = new System.Drawing.Point(430, 216);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(90, 30);
            this.Uuenda_btn.TabIndex = 11;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            this.Uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click);
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(334, 216);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(90, 30);
            this.Lisa_btn.TabIndex = 12;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_Andmed);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 217);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Lisa_kat_lbl
            // 
            this.Lisa_kat_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lisa_kat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lisa_kat_lbl.Location = new System.Drawing.Point(40, 152);
            this.Lisa_kat_lbl.Name = "Lisa_kat_lbl";
            this.Lisa_kat_lbl.Size = new System.Drawing.Size(21, 21);
            this.Lisa_kat_lbl.TabIndex = 15;
            this.Lisa_kat_lbl.Text = "+";
            this.Lisa_kat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lisa_kat_lbl.Click += new System.EventHandler(this.Lisa_kat_lbl_Click);
            this.Lisa_kat_lbl.MouseEnter += new System.EventHandler(this.Lisa_kat_lbl_MouseEnter);
            this.Lisa_kat_lbl.MouseLeave += new System.EventHandler(this.Lisa_kat_lbl_MouseLeave);
            // 
            // Kustuta_Kat_lbl
            // 
            this.Kustuta_Kat_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kustuta_Kat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kustuta_Kat_lbl.Location = new System.Drawing.Point(13, 152);
            this.Kustuta_Kat_lbl.Name = "Kustuta_Kat_lbl";
            this.Kustuta_Kat_lbl.Size = new System.Drawing.Size(21, 21);
            this.Kustuta_Kat_lbl.TabIndex = 16;
            this.Kustuta_Kat_lbl.Text = "-";
            this.Kustuta_Kat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kustuta_Kat_lbl.Click += new System.EventHandler(this.Kustuta_Kat_lbl_Click);
            this.Kustuta_Kat_lbl.MouseEnter += new System.EventHandler(this.Kustuta_Kat_lbl_MouseEnter);
            this.Kustuta_Kat_lbl.MouseLeave += new System.EventHandler(this.Kustuta_Kat_lbl_MouseLeave);
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(150, 86);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(152, 20);
            this.Kogus_txt.TabIndex = 17;
            // 
            // Hind_txt
            // 
            this.Hind_txt.DecimalPlaces = 2;
            this.Hind_txt.Location = new System.Drawing.Point(150, 121);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(152, 20);
            this.Hind_txt.TabIndex = 18;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 517);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Kustuta_Kat_lbl);
            this.Controls.Add(this.Lisa_kat_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.KogusPic_btn);
            this.Controls.Add(this.Toode_pbx);
            this.Controls.Add(this.Kat_cbx);
            this.Controls.Add(this.Kategooria_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.Toode_txt);
            this.Name = "Warehouse";
            this.Text = "Ladu";
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hind_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Kategooria_lbl;
        private System.Windows.Forms.ComboBox Kat_cbx;
        private System.Windows.Forms.PictureBox Toode_pbx;
        private System.Windows.Forms.Button KogusPic_btn;
        private System.Windows.Forms.Button Kustuta_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lisa_kat_lbl;
        private System.Windows.Forms.Label Kustuta_Kat_lbl;
        private System.Windows.Forms.NumericUpDown Kogus_txt;
        private System.Windows.Forms.NumericUpDown Hind_txt;
    }
}

