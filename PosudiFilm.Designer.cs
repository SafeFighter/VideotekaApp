namespace VideotekaApp
{
    partial class PosudiFilm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtDanPosudbe = new System.Windows.Forms.DateTimePicker();
            this.dtRokPovratka = new System.Windows.Forms.DateTimePicker();
            this.tbClanId = new System.Windows.Forms.TextBox();
            this.tbFilmId = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tbIdPosudbe = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Posudi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(250, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(385, 121);
            this.dataGridView2.TabIndex = 4;
            // 
            // dtDanPosudbe
            // 
            this.dtDanPosudbe.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDanPosudbe.Location = new System.Drawing.Point(15, 170);
            this.dtDanPosudbe.Name = "dtDanPosudbe";
            this.dtDanPosudbe.Size = new System.Drawing.Size(200, 25);
            this.dtDanPosudbe.TabIndex = 5;
            // 
            // dtRokPovratka
            // 
            this.dtRokPovratka.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRokPovratka.Location = new System.Drawing.Point(15, 198);
            this.dtRokPovratka.Name = "dtRokPovratka";
            this.dtRokPovratka.Size = new System.Drawing.Size(200, 25);
            this.dtRokPovratka.TabIndex = 6;
            // 
            // tbClanId
            // 
            this.tbClanId.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClanId.Location = new System.Drawing.Point(15, 114);
            this.tbClanId.Name = "tbClanId";
            this.tbClanId.Size = new System.Drawing.Size(100, 25);
            this.tbClanId.TabIndex = 7;
            this.tbClanId.Text = "ID clana";
            // 
            // tbFilmId
            // 
            this.tbFilmId.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilmId.Location = new System.Drawing.Point(15, 142);
            this.tbFilmId.Name = "tbFilmId";
            this.tbFilmId.Size = new System.Drawing.Size(100, 25);
            this.tbFilmId.TabIndex = 8;
            this.tbFilmId.Text = "ID filma";
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Teal;
            this.btnPovratak.Font = new System.Drawing.Font("Monoid", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(1, 3);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(74, 26);
            this.btnPovratak.TabIndex = 9;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // tbIdPosudbe
            // 
            this.tbIdPosudbe.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPosudbe.Location = new System.Drawing.Point(15, 226);
            this.tbIdPosudbe.Name = "tbIdPosudbe";
            this.tbIdPosudbe.Size = new System.Drawing.Size(100, 25);
            this.tbIdPosudbe.TabIndex = 10;
            this.tbIdPosudbe.Text = "ID posudbe";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(250, 293);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(385, 121);
            this.dataGridView3.TabIndex = 11;
            // 
            // PosudiFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 508);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tbIdPosudbe);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.tbFilmId);
            this.Controls.Add(this.tbClanId);
            this.Controls.Add(this.dtRokPovratka);
            this.Controls.Add(this.dtDanPosudbe);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "PosudiFilm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PosudiFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtDanPosudbe;
        private System.Windows.Forms.DateTimePicker dtRokPovratka;
        private System.Windows.Forms.TextBox tbClanId;
        private System.Windows.Forms.TextBox tbFilmId;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox tbIdPosudbe;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}