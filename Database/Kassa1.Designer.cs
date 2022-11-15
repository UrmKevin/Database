namespace Database
{
    partial class Kassa1
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
            this.Arve_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Toode_pbx = new System.Windows.Forms.PictureBox();
            this.KõikHind_lbl = new System.Windows.Forms.Label();
            this.Kogus_txt = new System.Windows.Forms.NumericUpDown();
            this.Kat_cbx = new System.Windows.Forms.ComboBox();
            this.Kategooria_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Osta_btn = new System.Windows.Forms.Button();
            this.Korv_lbx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Arve_btn
            // 
            this.Arve_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Arve_btn.Location = new System.Drawing.Point(644, 258);
            this.Arve_btn.Name = "Arve_btn";
            this.Arve_btn.Size = new System.Drawing.Size(140, 53);
            this.Arve_btn.TabIndex = 4;
            this.Arve_btn.Text = "Väljastada arve";
            this.Arve_btn.UseVisualStyleBackColor = true;
            this.Arve_btn.Click += new System.EventHandler(this.Arve_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 224);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // Toode_pbx
            // 
            this.Toode_pbx.BackColor = System.Drawing.Color.White;
            this.Toode_pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Toode_pbx.Location = new System.Drawing.Point(351, 24);
            this.Toode_pbx.Name = "Toode_pbx";
            this.Toode_pbx.Size = new System.Drawing.Size(218, 218);
            this.Toode_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toode_pbx.TabIndex = 25;
            this.Toode_pbx.TabStop = false;
            // 
            // KõikHind_lbl
            // 
            this.KõikHind_lbl.BackColor = System.Drawing.Color.White;
            this.KõikHind_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KõikHind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.KõikHind_lbl.Location = new System.Drawing.Point(575, 214);
            this.KõikHind_lbl.Name = "KõikHind_lbl";
            this.KõikHind_lbl.Size = new System.Drawing.Size(209, 28);
            this.KõikHind_lbl.TabIndex = 33;
            this.KõikHind_lbl.Text = "Mitte midagi...";
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kogus_txt.Location = new System.Drawing.Point(155, 89);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(152, 20);
            this.Kogus_txt.TabIndex = 42;
            // 
            // Kat_cbx
            // 
            this.Kat_cbx.FormattingEnabled = true;
            this.Kat_cbx.Location = new System.Drawing.Point(155, 155);
            this.Kat_cbx.Name = "Kat_cbx";
            this.Kat_cbx.Size = new System.Drawing.Size(152, 21);
            this.Kat_cbx.TabIndex = 39;
            this.Kat_cbx.Visible = false;
            // 
            // Kategooria_lbl
            // 
            this.Kategooria_lbl.AutoSize = true;
            this.Kategooria_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kategooria_lbl.Location = new System.Drawing.Point(69, 156);
            this.Kategooria_lbl.Name = "Kategooria_lbl";
            this.Kategooria_lbl.Size = new System.Drawing.Size(80, 18);
            this.Kategooria_lbl.TabIndex = 38;
            this.Kategooria_lbl.Text = "Kategooria";
            this.Kategooria_lbl.Visible = false;
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Kogus_lbl.Location = new System.Drawing.Point(98, 87);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(51, 18);
            this.Kogus_lbl.TabIndex = 37;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Hind_lbl.Location = new System.Drawing.Point(111, 122);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(38, 18);
            this.Hind_lbl.TabIndex = 36;
            this.Hind_lbl.Text = "Hind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Toode nimetus";
            // 
            // Toode_txt
            // 
            this.Toode_txt.BackColor = System.Drawing.Color.White;
            this.Toode_txt.Location = new System.Drawing.Point(155, 51);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.ReadOnly = true;
            this.Toode_txt.Size = new System.Drawing.Size(152, 20);
            this.Toode_txt.TabIndex = 34;
            // 
            // Hind_txt
            // 
            this.Hind_txt.BackColor = System.Drawing.Color.White;
            this.Hind_txt.Location = new System.Drawing.Point(155, 122);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.ReadOnly = true;
            this.Hind_txt.Size = new System.Drawing.Size(152, 20);
            this.Hind_txt.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ostu korv";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lisa_btn.Location = new System.Drawing.Point(155, 202);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(152, 35);
            this.Lisa_btn.TabIndex = 45;
            this.Lisa_btn.Text = "Lisa korves";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Osta_btn
            // 
            this.Osta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Osta_btn.Location = new System.Drawing.Point(498, 258);
            this.Osta_btn.Name = "Osta_btn";
            this.Osta_btn.Size = new System.Drawing.Size(140, 53);
            this.Osta_btn.TabIndex = 46;
            this.Osta_btn.Text = "Osta";
            this.Osta_btn.UseVisualStyleBackColor = true;
            this.Osta_btn.Click += new System.EventHandler(this.Osta_btn_Click);
            // 
            // Korv_lbx
            // 
            this.Korv_lbx.FormattingEnabled = true;
            this.Korv_lbx.Location = new System.Drawing.Point(575, 56);
            this.Korv_lbx.Name = "Korv_lbx";
            this.Korv_lbx.Size = new System.Drawing.Size(209, 160);
            this.Korv_lbx.TabIndex = 47;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 567);
            this.Controls.Add(this.Korv_lbx);
            this.Controls.Add(this.Osta_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Kat_cbx);
            this.Controls.Add(this.Kategooria_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.KõikHind_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Toode_pbx);
            this.Controls.Add(this.Arve_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Arve_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Toode_pbx;
        private System.Windows.Forms.Label KõikHind_lbl;
        private System.Windows.Forms.NumericUpDown Kogus_txt;
        private System.Windows.Forms.ComboBox Kat_cbx;
        private System.Windows.Forms.Label Kategooria_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Osta_btn;
        private System.Windows.Forms.ListBox Korv_lbx;
    }
}