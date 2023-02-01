namespace Entitity_Oto_Galeri_Programı
{
    partial class MüşteriListesi
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
            this.btnMüşteriListele = new System.Windows.Forms.Button();
            this.btnMenüDön = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMüşteriListele
            // 
            this.btnMüşteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriListele.Location = new System.Drawing.Point(12, 12);
            this.btnMüşteriListele.Name = "btnMüşteriListele";
            this.btnMüşteriListele.Size = new System.Drawing.Size(182, 55);
            this.btnMüşteriListele.TabIndex = 1;
            this.btnMüşteriListele.Text = "Müşterileri Listele";
            this.btnMüşteriListele.UseVisualStyleBackColor = true;
            this.btnMüşteriListele.Click += new System.EventHandler(this.btnMüşteriListele_Click);
            // 
            // btnMenüDön
            // 
            this.btnMenüDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenüDön.Location = new System.Drawing.Point(12, 73);
            this.btnMenüDön.Name = "btnMenüDön";
            this.btnMenüDön.Size = new System.Drawing.Size(182, 52);
            this.btnMenüDön.TabIndex = 2;
            this.btnMenüDön.Text = "Menüye Dön";
            this.btnMenüDön.UseVisualStyleBackColor = true;
            this.btnMenüDön.Click += new System.EventHandler(this.btnMenüDön_Click);
            // 
            // MüşteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenüDön);
            this.Controls.Add(this.btnMüşteriListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MüşteriListesi";
            this.Text = "MüşteriListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMüşteriListele;
        private System.Windows.Forms.Button btnMenüDön;
    }
}