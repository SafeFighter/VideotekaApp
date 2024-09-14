namespace VideotekaApp
{
    partial class DodajFilm
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbRedatelj = new System.Windows.Forms.TextBox();
            this.tbZanr = new System.Windows.Forms.TextBox();
            this.tbTrajanje = new System.Windows.Forms.TextBox();
            this.tbGodina = new System.Windows.Forms.TextBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbOcjena = new System.Windows.Forms.TextBox();
            this.tbBrojKopija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.IndianRed;
            this.btnPovratak.Font = new System.Drawing.Font("Monoid", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(12, 3);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(74, 26);
            this.btnPovratak.TabIndex = 15;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.IndianRed;
            this.btnDodaj.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(92, 270);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 47);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj film";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbRedatelj
            // 
            this.tbRedatelj.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRedatelj.Location = new System.Drawing.Point(92, 177);
            this.tbRedatelj.Name = "tbRedatelj";
            this.tbRedatelj.Size = new System.Drawing.Size(100, 25);
            this.tbRedatelj.TabIndex = 13;
            this.tbRedatelj.Text = "Redatelj";
            // 
            // tbZanr
            // 
            this.tbZanr.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZanr.Location = new System.Drawing.Point(92, 149);
            this.tbZanr.Name = "tbZanr";
            this.tbZanr.Size = new System.Drawing.Size(100, 25);
            this.tbZanr.TabIndex = 12;
            this.tbZanr.Text = "Zanr";
            // 
            // tbTrajanje
            // 
            this.tbTrajanje.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrajanje.Location = new System.Drawing.Point(92, 121);
            this.tbTrajanje.Name = "tbTrajanje";
            this.tbTrajanje.Size = new System.Drawing.Size(100, 25);
            this.tbTrajanje.TabIndex = 11;
            this.tbTrajanje.Text = "Trajanje";
            // 
            // tbGodina
            // 
            this.tbGodina.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGodina.Location = new System.Drawing.Point(92, 93);
            this.tbGodina.Name = "tbGodina";
            this.tbGodina.Size = new System.Drawing.Size(100, 25);
            this.tbGodina.TabIndex = 10;
            this.tbGodina.Text = "Godina";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaslov.Location = new System.Drawing.Point(92, 65);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(100, 25);
            this.tbNaslov.TabIndex = 9;
            this.tbNaslov.Text = "Naslov";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(92, 37);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 25);
            this.tbId.TabIndex = 8;
            this.tbId.Text = "ID";
            // 
            // tbOcjena
            // 
            this.tbOcjena.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOcjena.Location = new System.Drawing.Point(92, 208);
            this.tbOcjena.Name = "tbOcjena";
            this.tbOcjena.Size = new System.Drawing.Size(100, 25);
            this.tbOcjena.TabIndex = 16;
            this.tbOcjena.Text = "Ocjena";
            // 
            // tbBrojKopija
            // 
            this.tbBrojKopija.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojKopija.Location = new System.Drawing.Point(92, 239);
            this.tbBrojKopija.Name = "tbBrojKopija";
            this.tbBrojKopija.Size = new System.Drawing.Size(100, 25);
            this.tbBrojKopija.TabIndex = 17;
            this.tbBrojKopija.Text = "BrojKopija";
            // 
            // DodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 387);
            this.Controls.Add(this.tbBrojKopija);
            this.Controls.Add(this.tbOcjena);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbRedatelj);
            this.Controls.Add(this.tbZanr);
            this.Controls.Add(this.tbTrajanje);
            this.Controls.Add(this.tbGodina);
            this.Controls.Add(this.tbNaslov);
            this.Controls.Add(this.tbId);
            this.Name = "DodajFilm";
            this.Text = "DodajFilm";
            this.Load += new System.EventHandler(this.DodajFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbRedatelj;
        private System.Windows.Forms.TextBox tbZanr;
        private System.Windows.Forms.TextBox tbTrajanje;
        private System.Windows.Forms.TextBox tbGodina;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbOcjena;
        private System.Windows.Forms.TextBox tbBrojKopija;
    }
}