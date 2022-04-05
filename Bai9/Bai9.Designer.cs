
namespace Bai9
{
    partial class Bai9
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(102, 67);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(231, 26);
            this.txtMaLop.TabIndex = 1;
            // 
            // dgvLH
            // 
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Location = new System.Drawing.Point(356, 67);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.RowHeadersWidth = 62;
            this.dgvLH.RowTemplate.Height = 28;
            this.dgvLH.Size = new System.Drawing.Size(589, 384);
            this.dgvLH.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLH);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Name = "Bai9";
            this.Text = "Bai10";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.Button button1;
    }
}