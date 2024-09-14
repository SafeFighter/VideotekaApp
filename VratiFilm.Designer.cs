namespace VideotekaApp
{
    partial class VratiFilm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tbIdFilma = new System.Windows.Forms.TextBox();
            this.tbIdPosudbe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Monoid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vrati film";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Teal;
            this.btnPovratak.Font = new System.Drawing.Font("Monoid", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(1, 1);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(74, 26);
            this.btnPovratak.TabIndex = 10;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // tbIdFilma
            // 
            this.tbIdFilma.Location = new System.Drawing.Point(403, 240);
            this.tbIdFilma.Name = "tbIdFilma";
            this.tbIdFilma.Size = new System.Drawing.Size(140, 22);
            this.tbIdFilma.TabIndex = 11;
            this.tbIdFilma.Text = "Unesi ID filma";
            // 
            // tbIdPosudbe
            // 
            this.tbIdPosudbe.Location = new System.Drawing.Point(241, 240);
            this.tbIdPosudbe.Name = "tbIdPosudbe";
            this.tbIdPosudbe.Size = new System.Drawing.Size(140, 22);
            this.tbIdPosudbe.TabIndex = 12;
            this.tbIdPosudbe.Text = "Unesi ID posudbe";
            // 
            // VratiFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIdPosudbe);
            this.Controls.Add(this.tbIdFilma);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VratiFilm";
            this.Text = "Vrati film";
            this.Load += new System.EventHandler(this.VratiFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox tbIdFilma;
        private System.Windows.Forms.TextBox tbIdPosudbe;
    }
}