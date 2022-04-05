
namespace Bai9
{
    partial class Bai15
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
            this.NCC = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // NCC
            // 
            this.NCC.AutoSize = true;
            this.NCC.Location = new System.Drawing.Point(166, 67);
            this.NCC.Name = "NCC";
            this.NCC.Size = new System.Drawing.Size(42, 20);
            this.NCC.TabIndex = 0;
            this.NCC.Text = "NCC";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(327, 64);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(353, 26);
            this.txtNCC.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(170, 138);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 62;
            this.dgvSP.RowTemplate.Height = 28;
            this.dgvSP.Size = new System.Drawing.Size(774, 393);
            this.dgvSP.TabIndex = 3;
            // 
            // Bai15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 572);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.NCC);
            this.Name = "Bai15";
            this.Text = "Bai15";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NCC;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSP;
    }
}