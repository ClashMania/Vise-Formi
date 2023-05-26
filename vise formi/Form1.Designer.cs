namespace Vise_formi
{
    partial class Studenti
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
            this.fDodajSt = new System.Windows.Forms.Button();
            this.fObrisiSve = new System.Windows.Forms.Button();
            this.fObrisiSt = new System.Windows.Forms.Button();
            this.fPodatci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fDodajSt
            // 
            this.fDodajSt.Location = new System.Drawing.Point(12, 12);
            this.fDodajSt.Name = "fDodajSt";
            this.fDodajSt.Size = new System.Drawing.Size(149, 37);
            this.fDodajSt.TabIndex = 0;
            this.fDodajSt.Text = "Dodaj novog studenta";
            this.fDodajSt.UseVisualStyleBackColor = true;
            this.fDodajSt.Click += new System.EventHandler(this.fDodajSt_Click);
            // 
            // fObrisiSve
            // 
            this.fObrisiSve.Location = new System.Drawing.Point(12, 200);
            this.fObrisiSve.Name = "fObrisiSve";
            this.fObrisiSve.Size = new System.Drawing.Size(126, 37);
            this.fObrisiSve.TabIndex = 1;
            this.fObrisiSve.Text = "Obrisi sve studente";
            this.fObrisiSve.UseVisualStyleBackColor = true;
            this.fObrisiSve.Click += new System.EventHandler(this.fObrisiSve_Click);
            // 
            // fObrisiSt
            // 
            this.fObrisiSt.Location = new System.Drawing.Point(565, 200);
            this.fObrisiSt.Name = "fObrisiSt";
            this.fObrisiSt.Size = new System.Drawing.Size(108, 37);
            this.fObrisiSt.TabIndex = 2;
            this.fObrisiSt.Text = "Obrisi studenta";
            this.fObrisiSt.UseVisualStyleBackColor = true;
            this.fObrisiSt.Click += new System.EventHandler(this.fObrisiSt_Click);
            // 
            // fPodatci
            // 
            this.fPodatci.FormattingEnabled = true;
            this.fPodatci.Location = new System.Drawing.Point(14, 55);
            this.fPodatci.Name = "fPodatci";
            this.fPodatci.Size = new System.Drawing.Size(659, 134);
            this.fPodatci.TabIndex = 3;
            this.fPodatci.SelectedIndexChanged += new System.EventHandler(this.fPodatci_SelectedIndexChanged);
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 270);
            this.Controls.Add(this.fPodatci);
            this.Controls.Add(this.fObrisiSt);
            this.Controls.Add(this.fObrisiSve);
            this.Controls.Add(this.fDodajSt);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fDodajSt;
        private System.Windows.Forms.Button fObrisiSve;
        private System.Windows.Forms.Button fObrisiSt;
        private System.Windows.Forms.ListBox fPodatci;
    }
}

