namespace Entitity_Oto_Galeri_Programı
{
    partial class PersonelSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSilme));
            this.btn_PersonelSil = new System.Windows.Forms.Button();
            this.btn_MenüDön = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SilinecekPersonelId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_personelgöster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PersonelSil
            // 
            this.btn_PersonelSil.Location = new System.Drawing.Point(300, 114);
            this.btn_PersonelSil.Name = "btn_PersonelSil";
            this.btn_PersonelSil.Size = new System.Drawing.Size(129, 38);
            this.btn_PersonelSil.TabIndex = 0;
            this.btn_PersonelSil.Text = "Sil";
            this.btn_PersonelSil.UseVisualStyleBackColor = true;
            this.btn_PersonelSil.Click += new System.EventHandler(this.btn_PersonelSil_Click);
            // 
            // btn_MenüDön
            // 
            this.btn_MenüDön.Location = new System.Drawing.Point(300, 201);
            this.btn_MenüDön.Name = "btn_MenüDön";
            this.btn_MenüDön.Size = new System.Drawing.Size(129, 37);
            this.btn_MenüDön.TabIndex = 1;
            this.btn_MenüDön.Text = "Menü Dön";
            this.btn_MenüDön.UseVisualStyleBackColor = true;
            this.btn_MenüDön.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Personel ID:";
            // 
            // txt_SilinecekPersonelId
            // 
            this.txt_SilinecekPersonelId.Location = new System.Drawing.Point(234, 67);
            this.txt_SilinecekPersonelId.Name = "txt_SilinecekPersonelId";
            this.txt_SilinecekPersonelId.Size = new System.Drawing.Size(195, 22);
            this.txt_SilinecekPersonelId.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_personelgöster
            // 
            this.btn_personelgöster.Location = new System.Drawing.Point(300, 158);
            this.btn_personelgöster.Name = "btn_personelgöster";
            this.btn_personelgöster.Size = new System.Drawing.Size(129, 37);
            this.btn_personelgöster.TabIndex = 5;
            this.btn_personelgöster.Text = "Personel Göster";
            this.btn_personelgöster.UseVisualStyleBackColor = true;
            this.btn_personelgöster.Click += new System.EventHandler(this.btn_personelgöster_Click);
            // 
            // PersonelSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_personelgöster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SilinecekPersonelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MenüDön);
            this.Controls.Add(this.btn_PersonelSil);
            this.Name = "PersonelSilme";
            this.Text = "PersonelSilme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PersonelSil;
        private System.Windows.Forms.Button btn_MenüDön;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SilinecekPersonelId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_personelgöster;
    }
}