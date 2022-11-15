namespace Database
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.Kategooria_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.nimi_txt = new System.Windows.Forms.TextBox();
            this.pere_txt = new System.Windows.Forms.TextBox();
            this.tele_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bronze_rbn = new System.Windows.Forms.RadioButton();
            this.silver_rbn = new System.Windows.Forms.RadioButton();
            this.gold_rbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 217);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(446, 45);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(90, 30);
            this.Lisa_btn.TabIndex = 29;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Location = new System.Drawing.Point(446, 99);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(90, 30);
            this.Uuenda_btn.TabIndex = 28;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            this.Uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click_1);
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.Location = new System.Drawing.Point(446, 153);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(90, 30);
            this.Kustuta_btn.TabIndex = 27;
            this.Kustuta_btn.Text = "Kustuta";
            this.Kustuta_btn.UseVisualStyleBackColor = true;
            this.Kustuta_btn.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // Kategooria_lbl
            // 
            this.Kategooria_lbl.AutoSize = true;
            this.Kategooria_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kategooria_lbl.Location = new System.Drawing.Point(32, 115);
            this.Kategooria_lbl.Name = "Kategooria_lbl";
            this.Kategooria_lbl.Size = new System.Drawing.Size(112, 18);
            this.Kategooria_lbl.TabIndex = 23;
            this.Kategooria_lbl.Text = "E-posti aadress";
            this.Kategooria_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kogus_lbl.Location = new System.Drawing.Point(37, 81);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(107, 18);
            this.Kogus_lbl.TabIndex = 22;
            this.Kogus_lbl.Text = "Perekonnanimi";
            this.Kogus_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Hind_lbl.Location = new System.Drawing.Point(34, 149);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(110, 18);
            this.Hind_lbl.TabIndex = 21;
            this.Hind_lbl.Text = "Telefoninumber";
            this.Hind_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Toode_lbl.Location = new System.Drawing.Point(106, 45);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(38, 18);
            this.Toode_lbl.TabIndex = 20;
            this.Toode_lbl.Text = "Nimi";
            this.Toode_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nimi_txt
            // 
            this.nimi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nimi_txt.Location = new System.Drawing.Point(150, 43);
            this.nimi_txt.Name = "nimi_txt";
            this.nimi_txt.Size = new System.Drawing.Size(152, 21);
            this.nimi_txt.TabIndex = 19;
            // 
            // pere_txt
            // 
            this.pere_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pere_txt.Location = new System.Drawing.Point(150, 79);
            this.pere_txt.Name = "pere_txt";
            this.pere_txt.Size = new System.Drawing.Size(152, 21);
            this.pere_txt.TabIndex = 31;
            // 
            // tele_txt
            // 
            this.tele_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tele_txt.Location = new System.Drawing.Point(150, 147);
            this.tele_txt.Name = "tele_txt";
            this.tele_txt.Size = new System.Drawing.Size(152, 21);
            this.tele_txt.TabIndex = 32;
            // 
            // mail_txt
            // 
            this.mail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mail_txt.Location = new System.Drawing.Point(150, 113);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(152, 21);
            this.mail_txt.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(60, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kliendikaart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bronze_rbn
            // 
            this.bronze_rbn.AutoSize = true;
            this.bronze_rbn.Location = new System.Drawing.Point(151, 184);
            this.bronze_rbn.Name = "bronze_rbn";
            this.bronze_rbn.Size = new System.Drawing.Size(58, 17);
            this.bronze_rbn.TabIndex = 35;
            this.bronze_rbn.TabStop = true;
            this.bronze_rbn.Text = "Bronze";
            this.bronze_rbn.UseVisualStyleBackColor = true;
            // 
            // silver_rbn
            // 
            this.silver_rbn.AutoSize = true;
            this.silver_rbn.Location = new System.Drawing.Point(153, 207);
            this.silver_rbn.Name = "silver_rbn";
            this.silver_rbn.Size = new System.Drawing.Size(51, 17);
            this.silver_rbn.TabIndex = 36;
            this.silver_rbn.TabStop = true;
            this.silver_rbn.Text = "Silver";
            this.silver_rbn.UseVisualStyleBackColor = true;
            // 
            // gold_rbn
            // 
            this.gold_rbn.AutoSize = true;
            this.gold_rbn.Location = new System.Drawing.Point(153, 230);
            this.gold_rbn.Name = "gold_rbn";
            this.gold_rbn.Size = new System.Drawing.Size(47, 17);
            this.gold_rbn.TabIndex = 37;
            this.gold_rbn.TabStop = true;
            this.gold_rbn.Text = "Gold";
            this.gold_rbn.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 517);
            this.Controls.Add(this.gold_rbn);
            this.Controls.Add(this.silver_rbn);
            this.Controls.Add(this.bronze_rbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.tele_txt);
            this.Controls.Add(this.pere_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.Kategooria_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.nimi_txt);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.Button Kustuta_btn;
        private System.Windows.Forms.Label Kategooria_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.TextBox nimi_txt;
        private System.Windows.Forms.TextBox pere_txt;
        private System.Windows.Forms.TextBox tele_txt;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bronze_rbn;
        private System.Windows.Forms.RadioButton silver_rbn;
        private System.Windows.Forms.RadioButton gold_rbn;
    }
}