﻿
namespace Bai9
{
    partial class Bai18
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(251, 121);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 62;
            this.dgvSP.RowTemplate.Height = 28;
            this.dgvSP.Size = new System.Drawing.Size(697, 285);
            this.dgvSP.TabIndex = 2;
            this.dgvSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSP_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "SẢN PHẨM";
            // 
            // Bai18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSP);
            this.Name = "Bai18";
            this.Text = "Bai18";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}