namespace Vise_formi
{
    partial class NoviStudent
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
            this.fSnimi = new System.Windows.Forms.Button();
            this.fOtkazi = new System.Windows.Forms.Button();
            this.fIme = new System.Windows.Forms.TextBox();
            this.fPrezime = new System.Windows.Forms.TextBox();
            this.fBrojIndeksa = new System.Windows.Forms.TextBox();
            this.fSmjer = new System.Windows.Forms.ComboBox();
            this.fDatRodjenja = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fSnimi
            // 
            this.fSnimi.Location = new System.Drawing.Point(438, 137);
            this.fSnimi.Name = "fSnimi";
            this.fSnimi.Size = new System.Drawing.Size(87, 40);
            this.fSnimi.TabIndex = 0;
            this.fSnimi.Text = "Snimi";
            this.fSnimi.UseVisualStyleBackColor = true;
            this.fSnimi.Click += new System.EventHandler(this.fSnimi_Click);
            // 
            // fOtkazi
            // 
            this.fOtkazi.Location = new System.Drawing.Point(284, 137);
            this.fOtkazi.Name = "fOtkazi";
            this.fOtkazi.Size = new System.Drawing.Size(89, 40);
            this.fOtkazi.TabIndex = 1;
            this.fOtkazi.Text = "Otkaži";
            this.fOtkazi.UseVisualStyleBackColor = true;
            this.fOtkazi.Click += new System.EventHandler(this.fOtkazi_Click);
            // 
            // fIme
            // 
            this.fIme.Location = new System.Drawing.Point(40, 50);
            this.fIme.Name = "fIme";
            this.fIme.Size = new System.Drawing.Size(100, 20);
            this.fIme.TabIndex = 2;
            // 
            // fPrezime
            // 
            this.fPrezime.Location = new System.Drawing.Point(40, 102);
            this.fPrezime.Name = "fPrezime";
            this.fPrezime.Size = new System.Drawing.Size(100, 20);
            this.fPrezime.TabIndex = 3;
            // 
            // fBrojIndeksa
            // 
            this.fBrojIndeksa.Location = new System.Drawing.Point(40, 203);
            this.fBrojIndeksa.Name = "fBrojIndeksa";
            this.fBrojIndeksa.Size = new System.Drawing.Size(100, 20);
            this.fBrojIndeksa.TabIndex = 4;
            // 
            // fSmjer
            // 
            this.fSmjer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fSmjer.FormattingEnabled = true;
            this.fSmjer.Items.AddRange(new object[] {
            "Programer",
            "Sistem Administrator",
            "Mrežni administrator"});
            this.fSmjer.Location = new System.Drawing.Point(40, 148);
            this.fSmjer.Name = "fSmjer";
            this.fSmjer.Size = new System.Drawing.Size(121, 21);
            this.fSmjer.TabIndex = 5;
            // 
            // fDatRodjenja
            // 
            this.fDatRodjenja.Location = new System.Drawing.Point(40, 255);
            this.fDatRodjenja.Name = "fDatRodjenja";
            this.fDatRodjenja.Size = new System.Drawing.Size(200, 20);
            this.fDatRodjenja.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(40, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ime:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(40, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Prezime:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(40, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Smjer:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(40, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Broj indexa:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(40, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Datum Rođenja:";
            // 
            // NoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 345);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fDatRodjenja);
            this.Controls.Add(this.fSmjer);
            this.Controls.Add(this.fBrojIndeksa);
            this.Controls.Add(this.fPrezime);
            this.Controls.Add(this.fIme);
            this.Controls.Add(this.fOtkazi);
            this.Controls.Add(this.fSnimi);
            this.Name = "NoviStudent";
            this.Text = "Unos Novog studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fSnimi;
        private System.Windows.Forms.Button fOtkazi;
        private System.Windows.Forms.TextBox fIme;
        private System.Windows.Forms.TextBox fPrezime;
        private System.Windows.Forms.TextBox fBrojIndeksa;
        private System.Windows.Forms.ComboBox fSmjer;
        private System.Windows.Forms.DateTimePicker fDatRodjenja;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}