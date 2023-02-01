namespace Entitity_Oto_Galeri_Programı
{
    partial class MüşteriSilme
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
            this.btnMüşteriyiSil = new System.Windows.Forms.Button();
            this.txtMüşteriIdSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMenüDön = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMüşteriyiSil
            // 
            this.btnMüşteriyiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriyiSil.Location = new System.Drawing.Point(221, 78);
            this.btnMüşteriyiSil.Name = "btnMüşteriyiSil";
            this.btnMüşteriyiSil.Size = new System.Drawing.Size(129, 52);
            this.btnMüşteriyiSil.TabIndex = 0;
            this.btnMüşteriyiSil.Text = "Müşteri Sil";
            this.btnMüşteriyiSil.UseVisualStyleBackColor = true;
            this.btnMüşteriyiSil.Click += new System.EventHandler(this.btnMüşteriyiSil_Click);
            // 
            // txtMüşteriIdSil
            // 
            this.txtMüşteriIdSil.Location = new System.Drawing.Point(221, 31);
            this.txtMüşteriIdSil.Multiline = true;
            this.txtMüşteriIdSil.Name = "txtMüşteriIdSil";
            this.txtMüşteriIdSil.Size = new System.Drawing.Size(141, 22);
            this.txtMüşteriIdSil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Müşteri ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 198);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMenüDön
            // 
            this.btnMenüDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenüDön.Location = new System.Drawing.Point(221, 136);
            this.btnMenüDön.Name = "btnMenüDön";
            this.btnMenüDön.Size = new System.Drawing.Size(129, 54);
            this.btnMenüDön.TabIndex = 4;
            this.btnMenüDön.Text = "Menü Dön";
            this.btnMenüDön.UseVisualStyleBackColor = true;
            this.btnMenüDön.Click += new System.EventHandler(this.btnMenüDön_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(221, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MüşteriSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenüDön);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMüşteriIdSil);
            this.Controls.Add(this.btnMüşteriyiSil);
            this.Name = "MüşteriSilme";
            this.Text = "MüşteriSilme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMüşteriyiSil;
        private System.Windows.Forms.TextBox txtMüşteriIdSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMenüDön;
        private System.Windows.Forms.Button button1;
    }
}