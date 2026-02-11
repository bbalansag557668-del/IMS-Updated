namespace IMS.App
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonLogin = new Button();
            linkRegisterForm = new LinkLabel();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(421, 157);
            label1.Name = "label1";
            label1.Size = new Size(591, 86);
            label1.TabIndex = 0;
            label1.Text = "Login your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 325);
            label2.Name = "label2";
            label2.Size = new Size(180, 48);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(436, 400);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(576, 55);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(436, 567);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(576, 55);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 492);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(436, 691);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(576, 69);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkRegisterForm
            // 
            linkRegisterForm.AutoSize = true;
            linkRegisterForm.Location = new Point(769, 798);
            linkRegisterForm.Name = "linkRegisterForm";
            linkRegisterForm.Size = new Size(243, 48);
            linkRegisterForm.TabIndex = 6;
            linkRegisterForm.TabStop = true;
            linkRegisterForm.Text = "Register Now!";
            linkRegisterForm.LinkClicked += linkRegisterForm_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1365, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 48);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "v2";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 1002);
            Controls.Add(linkLabel1);
            Controls.Add(linkRegisterForm);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonLogin;
        private LinkLabel linkRegisterForm;
        private LinkLabel linkLabel1;
    }
}