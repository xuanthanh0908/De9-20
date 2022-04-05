
namespace Bai9
{
    partial class Bai12
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
            this.txtMABN = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBN = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã BN";
            // 
            // txtMABN
            // 
            this.txtMABN.Location = new System.Drawing.Point(172, 81);
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Size = new System.Drawing.Size(233, 26);
            this.txtMABN.TabIndex = 1;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(172, 152);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(233, 26);
            this.txtTenBN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên BN";
            // 
            // dgvBN
            // 
            this.dgvBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBN.Location = new System.Drawing.Point(466, 81);
            this.dgvBN.Name = "dgvBN";
            this.dgvBN.RowHeadersWidth = 62;
            this.dgvBN.RowTemplate.Height = 28;
            this.dgvBN.Size = new System.Drawing.Size(643, 379);
            this.dgvBN.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBN);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMABN);
            this.Controls.Add(this.label1);
            this.Name = "Bai12";
            this.Text = "Bai12";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMABN;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBN;
        private System.Windows.Forms.Button button1;
    }
}