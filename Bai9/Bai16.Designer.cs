
namespace Bai9
{
    partial class Bai16
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.txtTSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateNHH = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.DateNSX = new System.Windows.Forms.DateTimePicker();
            this.txtNCC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // txtMSP
            // 
            this.txtMSP.Location = new System.Drawing.Point(104, 53);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(251, 26);
            this.txtMSP.TabIndex = 1;
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(378, 53);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 62;
            this.dgvSP.RowTemplate.Height = 28;
            this.dgvSP.Size = new System.Drawing.Size(710, 436);
            this.dgvSP.TabIndex = 2;
            // 
            // txtTSP
            // 
            this.txtTSP.Location = new System.Drawing.Point(104, 131);
            this.txtTSP.Name = "txtTSP";
            this.txtTSP.Size = new System.Drawing.Size(251, 26);
            this.txtTSP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên SP";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(104, 222);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(251, 26);
            this.txtSL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày SX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "NCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày HH";
            // 
            // DateNHH
            // 
            this.DateNHH.CustomFormat = "dd-MM-yyyy";
            this.DateNHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNHH.Location = new System.Drawing.Point(104, 383);
            this.DateNHH.Name = "DateNHH";
            this.DateNHH.Size = new System.Drawing.Size(251, 26);
            this.DateNHH.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateNSX
            // 
            this.DateNSX.CustomFormat = "dd-MM-yyyy";
            this.DateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNSX.Location = new System.Drawing.Point(104, 315);
            this.DateNSX.Name = "DateNSX";
            this.DateNSX.Size = new System.Drawing.Size(251, 26);
            this.DateNSX.TabIndex = 15;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(104, 463);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(251, 26);
            this.txtNCC.TabIndex = 16;
            // 
            // Bai16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 628);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.DateNSX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateNHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.txtMSP);
            this.Controls.Add(this.label1);
            this.Name = "Bai16";
            this.Text = "Bai16";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TextBox txtTSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateNHH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateNSX;
        private System.Windows.Forms.TextBox txtNCC;
    }
}