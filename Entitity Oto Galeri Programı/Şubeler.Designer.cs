namespace Entitity_Oto_Galeri_Programı
{
    partial class Şubeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Şubeler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubeler = new System.Windows.Forms.Button();
            this.btnMenüDön = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSubeler
            // 
            this.btnSubeler.Location = new System.Drawing.Point(23, 32);
            this.btnSubeler.Name = "btnSubeler";
            this.btnSubeler.Size = new System.Drawing.Size(114, 49);
            this.btnSubeler.TabIndex = 1;
            this.btnSubeler.Text = "Şubeler";
            this.btnSubeler.UseVisualStyleBackColor = true;
            this.btnSubeler.Click += new System.EventHandler(this.btnSubeler_Click);
            // 
            // btnMenüDön
            // 
            this.btnMenüDön.Location = new System.Drawing.Point(171, 32);
            this.btnMenüDön.Name = "btnMenüDön";
            this.btnMenüDön.Size = new System.Drawing.Size(103, 49);
            this.btnMenüDön.TabIndex = 2;
            this.btnMenüDön.Text = "Menüye Dön";
            this.btnMenüDön.UseVisualStyleBackColor = true;
            this.btnMenüDön.Click += new System.EventHandler(this.btnMenüDön_Click);
            // 
            // Şubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenüDön);
            this.Controls.Add(this.btnSubeler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Şubeler";
            this.Text = "Şubeler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubeler;
        private System.Windows.Forms.Button btnMenüDön;
    }
}