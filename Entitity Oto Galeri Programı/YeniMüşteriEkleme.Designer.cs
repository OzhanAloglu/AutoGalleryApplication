﻿namespace Entitity_Oto_Galeri_Programı
{
    partial class YeniMüşteriEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniMüşteriEkleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMüşteriAdEkle = new System.Windows.Forms.TextBox();
            this.txtMüşteriSoyadEkle = new System.Windows.Forms.TextBox();
            this.txtMüşteriMailEkle = new System.Windows.Forms.TextBox();
            this.mskdMüşteriTelEkle = new System.Windows.Forms.MaskedTextBox();
            this.txtMüşteriAdresEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnMenüyeDön = new System.Windows.Forms.Button();
            this.btnGöster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Müşteri Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Müşteri Adresi:";
            // 
            // txtMüşteriAdEkle
            // 
            this.txtMüşteriAdEkle.Location = new System.Drawing.Point(180, 23);
            this.txtMüşteriAdEkle.Name = "txtMüşteriAdEkle";
            this.txtMüşteriAdEkle.Size = new System.Drawing.Size(178, 22);
            this.txtMüşteriAdEkle.TabIndex = 7;
            // 
            // txtMüşteriSoyadEkle
            // 
            this.txtMüşteriSoyadEkle.Location = new System.Drawing.Point(180, 71);
            this.txtMüşteriSoyadEkle.Name = "txtMüşteriSoyadEkle";
            this.txtMüşteriSoyadEkle.Size = new System.Drawing.Size(178, 22);
            this.txtMüşteriSoyadEkle.TabIndex = 8;
            // 
            // txtMüşteriMailEkle
            // 
            this.txtMüşteriMailEkle.Location = new System.Drawing.Point(180, 116);
            this.txtMüşteriMailEkle.Name = "txtMüşteriMailEkle";
            this.txtMüşteriMailEkle.Size = new System.Drawing.Size(285, 22);
            this.txtMüşteriMailEkle.TabIndex = 9;
            // 
            // mskdMüşteriTelEkle
            // 
            this.mskdMüşteriTelEkle.Location = new System.Drawing.Point(180, 167);
            this.mskdMüşteriTelEkle.Mask = "(999) 000-0000";
            this.mskdMüşteriTelEkle.Name = "mskdMüşteriTelEkle";
            this.mskdMüşteriTelEkle.Size = new System.Drawing.Size(100, 22);
            this.mskdMüşteriTelEkle.TabIndex = 10;
            // 
            // txtMüşteriAdresEkle
            // 
            this.txtMüşteriAdresEkle.Location = new System.Drawing.Point(180, 215);
            this.txtMüşteriAdresEkle.Multiline = true;
            this.txtMüşteriAdresEkle.Name = "txtMüşteriAdresEkle";
            this.txtMüşteriAdresEkle.Size = new System.Drawing.Size(408, 38);
            this.txtMüşteriAdresEkle.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(594, 193);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 60);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnMenüyeDön
            // 
            this.btnMenüyeDön.Location = new System.Drawing.Point(691, 193);
            this.btnMenüyeDön.Name = "btnMenüyeDön";
            this.btnMenüyeDön.Size = new System.Drawing.Size(97, 60);
            this.btnMenüyeDön.TabIndex = 13;
            this.btnMenüyeDön.Text = "Menüye Dön";
            this.btnMenüyeDön.UseVisualStyleBackColor = true;
            this.btnMenüyeDön.Click += new System.EventHandler(this.btnMenüyeDön_Click);
            // 
            // btnGöster
            // 
            this.btnGöster.Location = new System.Drawing.Point(594, 259);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(184, 34);
            this.btnGöster.TabIndex = 14;
            this.btnGöster.Text = "Göster";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // YeniMüşteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.btnMenüyeDön);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMüşteriAdresEkle);
            this.Controls.Add(this.mskdMüşteriTelEkle);
            this.Controls.Add(this.txtMüşteriMailEkle);
            this.Controls.Add(this.txtMüşteriSoyadEkle);
            this.Controls.Add(this.txtMüşteriAdEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YeniMüşteriEkleme";
            this.Text = "YeniMüşteriEkleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMüşteriAdEkle;
        private System.Windows.Forms.TextBox txtMüşteriSoyadEkle;
        private System.Windows.Forms.TextBox txtMüşteriMailEkle;
        private System.Windows.Forms.MaskedTextBox mskdMüşteriTelEkle;
        private System.Windows.Forms.TextBox txtMüşteriAdresEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnMenüyeDön;
        private System.Windows.Forms.Button btnGöster;
    }
}