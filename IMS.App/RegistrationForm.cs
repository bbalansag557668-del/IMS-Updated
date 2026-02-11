using IMS.Domain.Dtos;
using IMS.Domain.Models;
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
    public partial class RegistrationForm : Form
    {
        private readonly PasswordHasher<AppUser> _passwordHasher = new();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registerDto = new RegisterDto
            {
                Username = textBoxUsername.Text.Trim(),
                Password = textBoxPassword.Text.Trim(),
                ConfirmPassword = textBoxConfirmPassword.Text.Trim()
            };

            using (var _context = new AppDbContext())
            {
                _context.AppUsers.Add(new Domain.Models.AppUser
                {
                    UserName = registerDto.Username,
                    PasswordHash = _passwordHasher.HashPassword(null, registerDto.Password) 
                });
                _context.SaveChanges();
            }

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
