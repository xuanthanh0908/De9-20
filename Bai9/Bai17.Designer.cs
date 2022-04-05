
namespace Bai9
{
    partial class Bai17
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // txtMSP
            // 
            this.txtMSP.Location = new System.Drawing.Point(148, 81);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(269, 26);
            this.txtMSP.TabIndex = 1;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(148, 167);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(269, 26);
            this.txtNCC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NCC";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(461, 81);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 62;
            this.dgvSP.RowTemplate.Height = 28;
            this.dgvSP.Size = new System.Drawing.Size(646, 355);
            this.dgvSP.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMSP);
            this.Controls.Add(this.label1);
            this.Name = "Bai17";
            this.Text = "Bai17";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button button1;
    }
}