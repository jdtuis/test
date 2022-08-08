namespace Trial2
{
    partial class AddDbAccountForm
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
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numRole = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRole)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(219, 42);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(471, 27);
            this.txtAccountID.TabIndex = 1;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(219, 127);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(471, 27);
            this.txtAccountPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtAccountFullName
            // 
            this.txtAccountFullName.Location = new System.Drawing.Point(219, 215);
            this.txtAccountFullName.Name = "txtAccountFullName";
            this.txtAccountFullName.Size = new System.Drawing.Size(471, 27);
            this.txtAccountFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FullName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // numRole
            // 
            this.numRole.Location = new System.Drawing.Point(219, 300);
            this.numRole.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRole.Name = "numRole";
            this.numRole.Size = new System.Drawing.Size(150, 27);
            this.numRole.TabIndex = 7;
            // 
            // AddDbAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 536);
            this.Controls.Add(this.numRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccountFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.label1);
            this.Name = "AddDbAccountForm";
            this.Text = "AddDbAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.numRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRole;
    }
}