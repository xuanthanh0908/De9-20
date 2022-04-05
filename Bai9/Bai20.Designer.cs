
namespace Bai9
{
    partial class Bai20
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
            this.dgvSIM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIM";
            // 
            // dgvSIM
            // 
            this.dgvSIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSIM.Location = new System.Drawing.Point(97, 151);
            this.dgvSIM.Name = "dgvSIM";
            this.dgvSIM.RowHeadersWidth = 62;
            this.dgvSIM.RowTemplate.Height = 28;
            this.dgvSIM.Size = new System.Drawing.Size(860, 344);
            this.dgvSIM.TabIndex = 1;
            // 
            // Bai20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.dgvSIM);
            this.Controls.Add(this.label1);
            this.Name = "Bai20";
            this.Text = "Bai20";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSIM;
    }
}