
namespace Bai9
{
    partial class Bai19
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
            this.txtSS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Số Sim";
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(254, 100);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(592, 26);
            this.txtSS.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = " Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSS
            // 
            this.dgvSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSS.Location = new System.Drawing.Point(254, 171);
            this.dgvSS.Name = "dgvSS";
            this.dgvSS.RowHeadersWidth = 62;
            this.dgvSS.RowTemplate.Height = 28;
            this.dgvSS.Size = new System.Drawing.Size(794, 348);
            this.dgvSS.TabIndex = 3;
            // 
            // Bai19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 626);
            this.Controls.Add(this.dgvSS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.label1);
            this.Name = "Bai19";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSS;
    }
}