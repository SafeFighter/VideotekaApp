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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Posudi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(316, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(321, 121);
            this.dataGridView2.TabIndex = 4;
            // 
            // dtDanPosudbe
            // 
            this.dtDanPosudbe.Location = new System.Drawing.Point(23, 100);
            this.dtDanPosudbe.Name = "dtDanPosudbe";
            this.dtDanPosudbe.Size = new System.Drawing.Size(200, 22);
            this.dtDanPosudbe.TabIndex = 5;
            // 
            // dtRokPovratka
            // 
            this.dtRokPovratka.Location = new System.Drawing.Point(23, 128);
            this.dtRokPovratka.Name = "dtRokPovratka";
            this.dtRokPovratka.Size = new System.Drawing.Size(200, 22);
            this.dtRokPovratka.TabIndex = 6;
            // 
            // tbClanId
            // 
            this.tbClanId.Location = new System.Drawing.Point(23, 44);
            this.tbClanId.Name = "tbClanId";
            this.tbClanId.Size = new System.Drawing.Size(100, 22);
            this.tbClanId.TabIndex = 7;
            this.tbClanId.Text = "ID clana";
            // 
            // tbFilmId
            // 
            this.tbFilmId.Location = new System.Drawing.Point(23, 72);
            this.tbFilmId.Name = "tbFilmId";
            this.tbFilmId.Size = new System.Drawing.Size(100, 22);
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
            this.tbIdPosudbe.Location = new System.Drawing.Point(23, 156);
            this.tbIdPosudbe.Name = "tbIdPosudbe";
            this.tbIdPosudbe.Size = new System.Drawing.Size(100, 22);
            this.tbIdPosudbe.TabIndex = 10;
            this.tbIdPosudbe.Text = "ID posudbe";
            // 
            // PosudiFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 356);
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
    }
}