namespace VideotekaApp
{
    partial class DodajClana
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(82, 35);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 25);
            this.tbId.TabIndex = 0;
            this.tbId.Text = "ID";
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.Location = new System.Drawing.Point(82, 63);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 25);
            this.tbIme.TabIndex = 1;
            this.tbIme.Text = "Ime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.Location = new System.Drawing.Point(82, 91);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 25);
            this.tbPrezime.TabIndex = 2;
            this.tbPrezime.Text = "Prezime";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(82, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 25);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "Email";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresa.Location = new System.Drawing.Point(82, 147);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 25);
            this.tbAdresa.TabIndex = 4;
            this.tbAdresa.Text = "Adresa";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefon.Location = new System.Drawing.Point(82, 175);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 25);
            this.tbTelefon.TabIndex = 5;
            this.tbTelefon.Text = "Telefon";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.IndianRed;
            this.btnDodaj.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(82, 206);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 47);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj clana";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.IndianRed;
            this.btnPovratak.Font = new System.Drawing.Font("Monoid", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(2, 1);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(74, 26);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // DodajClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(272, 284);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbId);
            this.Name = "DodajClana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DodajClana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPovratak;
    }
}