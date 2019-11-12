namespace HospitalRecordingSystem.WinUI.Forms
{
    partial class FormSignInAndSignUp
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
            this.btnSelectSignUp = new System.Windows.Forms.Button();
            this.btnSelectSıgnIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.lblSignUpEmail = new System.Windows.Forms.Label();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.lblSignUpSurname = new System.Windows.Forms.Label();
            this.txtSignUpSurname = new System.Windows.Forms.TextBox();
            this.lblSignUpName = new System.Windows.Forms.Label();
            this.txtSignUpName = new System.Windows.Forms.TextBox();
            this.pnlSingIn = new System.Windows.Forms.Panel();
            this.lblSıgnIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSignInEmail = new System.Windows.Forms.TextBox();
            this.pnlSignUp.SuspendLayout();
            this.pnlSingIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSignUp
            // 
            this.btnSelectSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSelectSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSelectSignUp.FlatAppearance.BorderSize = 0;
            this.btnSelectSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSelectSignUp.Location = new System.Drawing.Point(245, 38);
            this.btnSelectSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectSignUp.Name = "btnSelectSignUp";
            this.btnSelectSignUp.Size = new System.Drawing.Size(148, 52);
            this.btnSelectSignUp.TabIndex = 0;
            this.btnSelectSignUp.Text = "Kayıt Ol";
            this.btnSelectSignUp.UseVisualStyleBackColor = false;
            this.btnSelectSignUp.Click += new System.EventHandler(this.btnSelectSignUp_Click);
            // 
            // btnSelectSıgnIn
            // 
            this.btnSelectSıgnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSelectSıgnIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSelectSıgnIn.FlatAppearance.BorderSize = 0;
            this.btnSelectSıgnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSıgnIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectSıgnIn.ForeColor = System.Drawing.Color.White;
            this.btnSelectSıgnIn.Location = new System.Drawing.Point(90, 38);
            this.btnSelectSıgnIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectSıgnIn.Name = "btnSelectSıgnIn";
            this.btnSelectSıgnIn.Size = new System.Drawing.Size(148, 52);
            this.btnSelectSıgnIn.TabIndex = 1;
            this.btnSelectSıgnIn.Text = "Giriş Yap";
            this.btnSelectSıgnIn.UseVisualStyleBackColor = false;
            this.btnSelectSıgnIn.Click += new System.EventHandler(this.btnSelectSıgnIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(52, 348);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(306, 52);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.label9);
            this.pnlSignUp.Controls.Add(this.lblSignUpPassword);
            this.pnlSignUp.Controls.Add(this.btnSignUp);
            this.pnlSignUp.Controls.Add(this.txtSignUpPassword);
            this.pnlSignUp.Controls.Add(this.lblSignUpEmail);
            this.pnlSignUp.Controls.Add(this.txtSignUpEmail);
            this.pnlSignUp.Controls.Add(this.lblSignUpSurname);
            this.pnlSignUp.Controls.Add(this.txtSignUpSurname);
            this.pnlSignUp.Controls.Add(this.lblSignUpName);
            this.pnlSignUp.Controls.Add(this.txtSignUpName);
            this.pnlSignUp.Location = new System.Drawing.Point(35, 108);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(425, 456);
            this.pnlSignUp.TabIndex = 3;
            this.pnlSignUp.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(141, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kayıt Ol";
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblSignUpPassword.Location = new System.Drawing.Point(25, 247);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(33, 17);
            this.lblSignUpPassword.TabIndex = 7;
            this.lblSignUpPassword.Text = "Şifre";
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignUpPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignUpPassword.Location = new System.Drawing.Point(28, 267);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.PasswordChar = '*';
            this.txtSignUpPassword.Size = new System.Drawing.Size(360, 41);
            this.txtSignUpPassword.TabIndex = 6;
            // 
            // lblSignUpEmail
            // 
            this.lblSignUpEmail.AutoSize = true;
            this.lblSignUpEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpEmail.ForeColor = System.Drawing.Color.LightGray;
            this.lblSignUpEmail.Location = new System.Drawing.Point(25, 169);
            this.lblSignUpEmail.Name = "lblSignUpEmail";
            this.lblSignUpEmail.Size = new System.Drawing.Size(45, 17);
            this.lblSignUpEmail.TabIndex = 5;
            this.lblSignUpEmail.Text = "E-Mail";
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignUpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignUpEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignUpEmail.Location = new System.Drawing.Point(28, 189);
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(360, 41);
            this.txtSignUpEmail.TabIndex = 4;
            // 
            // lblSignUpSurname
            // 
            this.lblSignUpSurname.AutoSize = true;
            this.lblSignUpSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpSurname.ForeColor = System.Drawing.Color.LightGray;
            this.lblSignUpSurname.Location = new System.Drawing.Point(210, 88);
            this.lblSignUpSurname.Name = "lblSignUpSurname";
            this.lblSignUpSurname.Size = new System.Drawing.Size(47, 17);
            this.lblSignUpSurname.TabIndex = 3;
            this.lblSignUpSurname.Text = "Soyad";
            // 
            // txtSignUpSurname
            // 
            this.txtSignUpSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignUpSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpSurname.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignUpSurname.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignUpSurname.Location = new System.Drawing.Point(213, 108);
            this.txtSignUpSurname.Name = "txtSignUpSurname";
            this.txtSignUpSurname.Size = new System.Drawing.Size(175, 41);
            this.txtSignUpSurname.TabIndex = 2;
            // 
            // lblSignUpName
            // 
            this.lblSignUpName.AutoSize = true;
            this.lblSignUpName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpName.ForeColor = System.Drawing.Color.LightGray;
            this.lblSignUpName.Location = new System.Drawing.Point(25, 88);
            this.lblSignUpName.Name = "lblSignUpName";
            this.lblSignUpName.Size = new System.Drawing.Size(26, 17);
            this.lblSignUpName.TabIndex = 1;
            this.lblSignUpName.Text = "Ad";
            // 
            // txtSignUpName
            // 
            this.txtSignUpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignUpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignUpName.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignUpName.Location = new System.Drawing.Point(28, 108);
            this.txtSignUpName.Name = "txtSignUpName";
            this.txtSignUpName.Size = new System.Drawing.Size(175, 41);
            this.txtSignUpName.TabIndex = 0;
            // 
            // pnlSingIn
            // 
            this.pnlSingIn.Controls.Add(this.lblSıgnIn);
            this.pnlSingIn.Controls.Add(this.lblPassword);
            this.pnlSingIn.Controls.Add(this.btnSignIn);
            this.pnlSingIn.Controls.Add(this.txtSignInPassword);
            this.pnlSingIn.Controls.Add(this.lblEmail);
            this.pnlSingIn.Controls.Add(this.txtSignInEmail);
            this.pnlSingIn.Location = new System.Drawing.Point(35, 108);
            this.pnlSingIn.Name = "pnlSingIn";
            this.pnlSingIn.Size = new System.Drawing.Size(425, 456);
            this.pnlSingIn.TabIndex = 4;
            // 
            // lblSıgnIn
            // 
            this.lblSıgnIn.AutoSize = true;
            this.lblSıgnIn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSıgnIn.ForeColor = System.Drawing.Color.LightGray;
            this.lblSıgnIn.Location = new System.Drawing.Point(141, 27);
            this.lblSıgnIn.Name = "lblSıgnIn";
            this.lblSıgnIn.Size = new System.Drawing.Size(128, 33);
            this.lblSıgnIn.TabIndex = 8;
            this.lblSıgnIn.Text = "Giriş Yap";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassword.Location = new System.Drawing.Point(23, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(33, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Şifre";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(52, 348);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(306, 52);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignInPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignInPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignInPassword.Location = new System.Drawing.Point(26, 223);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.Size = new System.Drawing.Size(360, 41);
            this.txtSignInPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.LightGray;
            this.lblEmail.Location = new System.Drawing.Point(23, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtSignInEmail
            // 
            this.txtSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignInEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignInEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignInEmail.Location = new System.Drawing.Point(26, 128);
            this.txtSignInEmail.Name = "txtSignInEmail";
            this.txtSignInEmail.Size = new System.Drawing.Size(360, 41);
            this.txtSignInEmail.TabIndex = 4;
            // 
            // FormSignInAndSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(490, 589);
            this.Controls.Add(this.pnlSingIn);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.btnSelectSıgnIn);
            this.Controls.Add(this.btnSelectSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSignInAndSignUp";
            this.Load += new System.EventHandler(this.FormSignInAndSignUp_Load);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.pnlSingIn.ResumeLayout(false);
            this.pnlSingIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSignUp;
        private System.Windows.Forms.Button btnSelectSıgnIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.TextBox txtSignUpName;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.Label lblSignUpEmail;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.Label lblSignUpSurname;
        private System.Windows.Forms.TextBox txtSignUpSurname;
        private System.Windows.Forms.Label lblSignUpName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlSingIn;
        private System.Windows.Forms.Label lblSıgnIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSignInEmail;
    }
}

