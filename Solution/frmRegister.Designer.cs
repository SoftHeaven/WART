﻿namespace WART
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnCodeRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.btnRegisterCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(121, 19);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 21);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.txtPhoneNumber.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // btnCodeRequest
            // 
            this.btnCodeRequest.Enabled = false;
            this.btnCodeRequest.Location = new System.Drawing.Point(45, 72);
            this.btnCodeRequest.Name = "btnCodeRequest";
            this.btnCodeRequest.Size = new System.Drawing.Size(94, 23);
            this.btnCodeRequest.TabIndex = 6;
            this.btnCodeRequest.Text = "Request code";
            this.btnCodeRequest.UseVisualStyleBackColor = true;
            this.btnCodeRequest.Click += new System.EventHandler(this.btnCodeRequest_Click);
            this.btnCodeRequest.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.btnCodeRequest.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.btnSkip);
            this.grpStep1.Controls.Add(this.chkDebug);
            this.grpStep1.Controls.Add(this.btnExist);
            this.grpStep1.Controls.Add(this.btnID);
            this.grpStep1.Controls.Add(this.label3);
            this.grpStep1.Controls.Add(this.txtPassword);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.btnCodeRequest);
            this.grpStep1.Controls.Add(this.txtPhoneNumber);
            this.grpStep1.Location = new System.Drawing.Point(13, 13);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(259, 130);
            this.grpStep1.TabIndex = 4;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1: Request code";
            // 
            // btnSkip
            // 
            this.btnSkip.Enabled = false;
            this.btnSkip.Location = new System.Drawing.Point(73, 101);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(180, 23);
            this.btnSkip.TabIndex = 11;
            this.btnSkip.Text = "I already have a code";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(9, 103);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(57, 17);
            this.chkDebug.TabIndex = 10;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // btnExist
            // 
            this.btnExist.Enabled = false;
            this.btnExist.Location = new System.Drawing.Point(145, 72);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(108, 23);
            this.btnExist.TabIndex = 9;
            this.btnExist.Text = "Check existing";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            this.btnExist.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.btnExist.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // btnID
            // 
            this.btnID.Enabled = false;
            this.btnID.Location = new System.Drawing.Point(9, 72);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(30, 23);
            this.btnID.TabIndex = 8;
            this.btnID.Text = "ID";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            this.btnID.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.btnID.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password (optional)";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // grpStep2
            // 
            this.grpStep2.Controls.Add(this.btnRegisterCode);
            this.grpStep2.Controls.Add(this.txtCode);
            this.grpStep2.Controls.Add(this.label1);
            this.grpStep2.Enabled = false;
            this.grpStep2.Location = new System.Drawing.Point(13, 149);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(259, 50);
            this.grpStep2.TabIndex = 5;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "Step 2: Confirm code";
            // 
            // btnRegisterCode
            // 
            this.btnRegisterCode.Enabled = false;
            this.btnRegisterCode.Location = new System.Drawing.Point(159, 17);
            this.btnRegisterCode.Name = "btnRegisterCode";
            this.btnRegisterCode.Size = new System.Drawing.Size(94, 23);
            this.btnRegisterCode.TabIndex = 2;
            this.btnRegisterCode.Text = "Confirm code";
            this.btnRegisterCode.UseVisualStyleBackColor = true;
            this.btnRegisterCode.Click += new System.EventHandler(this.btnRegisterCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 19);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(65, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.txtCode.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(243, 108);
            this.txtOutput.TabIndex = 3;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtOutput);
            this.grpResult.Enabled = false;
            this.grpResult.Location = new System.Drawing.Point(13, 205);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(259, 133);
            this.grpResult.TabIndex = 7;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Step 3: Retrieve password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(89)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "WART Ver 1.9";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 409);
            this.MinimumSize = new System.Drawing.Size(300, 409);
            this.Name = "frmRegister";
            this.Text = "WhatsApp Registration Tool";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnCodeRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRegisterCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label4;
    }
}