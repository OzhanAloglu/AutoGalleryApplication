namespace Entitity_Oto_Galeri_Programı
{
    partial class PersonelListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnMenüDön = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(12, 12);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(164, 53);
            this.btnPersoneller.TabIndex = 1;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnMenüDön
            // 
            this.btnMenüDön.Location = new System.Drawing.Point(12, 84);
            this.btnMenüDön.Name = "btnMenüDön";
            this.btnMenüDön.Size = new System.Drawing.Size(164, 46);
            this.btnMenüDön.TabIndex = 2;
            this.btnMenüDön.Text = "Menüye Dön";
            this.btnMenüDön.UseVisualStyleBackColor = true;
            this.btnMenüDön.Click += new System.EventHandler(this.btnMenüDön_Click);
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 452);
            this.Controls.Add(this.btnMenüDön);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelListesi";
            this.Text = "PersonelListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnMenüDön;
    }
}