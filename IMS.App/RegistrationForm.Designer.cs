namespace IMS.App
{
    partial class RegistrationForm
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
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxConfirmPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(282, 751);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(576, 69);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(282, 485);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(576, 55);
            textBoxPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 401);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(282, 310);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(576, 55);
            textBoxUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 226);
            label2.Name = "label2";
            label2.Size = new Size(180, 48);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(267, 104);
            label1.Name = "label1";
            label1.Size = new Size(515, 86);
            label1.TabIndex = 6;
            label1.Text = "Register Account";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(282, 660);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(576, 55);
            textBoxConfirmPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 576);
            label4.Name = "label4";
            label4.Size = new Size(305, 48);
            label4.TabIndex = 12;
            label4.Text = "Confirm Password";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 924);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label1;
        private TextBox textBoxConfirmPassword;
        private Label label4;
    }
}