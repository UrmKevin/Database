namespace Database
{
    partial class Registr
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
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nimi_txt = new System.Windows.Forms.TextBox();
            this.perenimi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kasutaja_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parool_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.muuja_rbt = new System.Windows.Forms.RadioButton();
            this.omanik_rbt = new System.Windows.Forms.RadioButton();
            this.parool2_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(450, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lõpusta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nimi_txt
            // 
            this.nimi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nimi_txt.Location = new System.Drawing.Point(249, 25);
            this.nimi_txt.Multiline = true;
            this.nimi_txt.Name = "nimi_txt";
            this.nimi_txt.Size = new System.Drawing.Size(183, 36);
            this.nimi_txt.TabIndex = 2;
            // 
            // perenimi_txt
            // 
            this.perenimi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.perenimi_txt.Location = new System.Drawing.Point(249, 80);
            this.perenimi_txt.Multiline = true;
            this.perenimi_txt.Name = "perenimi_txt";
            this.perenimi_txt.Size = new System.Drawing.Size(183, 36);
            this.perenimi_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(126, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perekonnanimi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kasutaja_txt
            // 
            this.kasutaja_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kasutaja_txt.Location = new System.Drawing.Point(249, 135);
            this.kasutaja_txt.Multiline = true;
            this.kasutaja_txt.Name = "kasutaja_txt";
            this.kasutaja_txt.Size = new System.Drawing.Size(183, 36);
            this.kasutaja_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(126, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kasutajanimi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parool_txt
            // 
            this.parool_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.parool_txt.Location = new System.Drawing.Point(249, 190);
            this.parool_txt.Multiline = true;
            this.parool_txt.Name = "parool_txt";
            this.parool_txt.PasswordChar = '*';
            this.parool_txt.Size = new System.Drawing.Size(183, 36);
            this.parool_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(126, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parool";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muuja_rbt
            // 
            this.muuja_rbt.AutoSize = true;
            this.muuja_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.muuja_rbt.Location = new System.Drawing.Point(239, 297);
            this.muuja_rbt.Name = "muuja_rbt";
            this.muuja_rbt.Size = new System.Drawing.Size(70, 24);
            this.muuja_rbt.TabIndex = 10;
            this.muuja_rbt.TabStop = true;
            this.muuja_rbt.Text = "Müüja";
            this.muuja_rbt.UseVisualStyleBackColor = true;
            // 
            // omanik_rbt
            // 
            this.omanik_rbt.AutoSize = true;
            this.omanik_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.omanik_rbt.Location = new System.Drawing.Point(341, 297);
            this.omanik_rbt.Name = "omanik_rbt";
            this.omanik_rbt.Size = new System.Drawing.Size(81, 24);
            this.omanik_rbt.TabIndex = 11;
            this.omanik_rbt.TabStop = true;
            this.omanik_rbt.Text = "Omanik";
            this.omanik_rbt.UseVisualStyleBackColor = true;
            // 
            // parool2_txt
            // 
            this.parool2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.parool2_txt.Location = new System.Drawing.Point(249, 246);
            this.parool2_txt.Multiline = true;
            this.parool2_txt.Name = "parool2_txt";
            this.parool2_txt.PasswordChar = '*';
            this.parool2_txt.Size = new System.Drawing.Size(183, 36);
            this.parool2_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(126, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kirjuta uuesti";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.parool2_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.omanik_rbt);
            this.Controls.Add(this.muuja_rbt);
            this.Controls.Add(this.parool_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kasutaja_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.perenimi_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nimi_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Registr";
            this.Text = "Registr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nimi_txt;
        private System.Windows.Forms.TextBox perenimi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kasutaja_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parool_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton muuja_rbt;
        private System.Windows.Forms.RadioButton omanik_rbt;
        private System.Windows.Forms.TextBox parool2_txt;
        private System.Windows.Forms.Label label4;
    }
}