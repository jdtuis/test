namespace Trial2
{
    partial class UpdateEmployeeForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtJobId = new System.Windows.Forms.ComboBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.NumberYoB = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberYoB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(295, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.FormattingEnabled = true;
            this.txtJobId.Location = new System.Drawing.Point(139, 292);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(402, 28);
            this.txtJobId.TabIndex = 20;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(139, 232);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(402, 27);
            this.txtDeptName.TabIndex = 19;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(139, 107);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(402, 27);
            this.txtEmpName.TabIndex = 18;
            // 
            // NumberYoB
            // 
            this.NumberYoB.Location = new System.Drawing.Point(139, 164);
            this.NumberYoB.Maximum = new decimal(new int[] {
            2002,
            0,
            0,
            0});
            this.NumberYoB.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.NumberYoB.Name = "NumberYoB";
            this.NumberYoB.Size = new System.Drawing.Size(206, 27);
            this.NumberYoB.TabIndex = 17;
            this.NumberYoB.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "JobTitle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dept";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "YoB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(139, 46);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(402, 27);
            this.txtEmpId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.NumberYoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label1);
            this.Name = "UpdateEmployeeForm";
            this.Text = "UpdateEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumberYoB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox txtJobId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.NumericUpDown NumberYoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label1;
    }
}