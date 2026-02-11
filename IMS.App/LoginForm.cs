using IMS.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkRegisterForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginDto = new Domain.Dtos.LoginDto
            {
                Username = textBoxUsername.Text.Trim(),
                Password = textBoxPassword.Text.Trim()
            };

            using (var _context = new AppDbContext())
            {
                var user = _context.AppUsers.FirstOrDefault(u => u.UserName == loginDto.Username);
                if (user != null)
                {
                    var passwordHasher = new PasswordHasher<Domain.Models.AppUser>();
                    var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, loginDto.Password);
                    if (result == PasswordVerificationResult.Success)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var form2 = new Form2();
                        form2.Show();
                        Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
