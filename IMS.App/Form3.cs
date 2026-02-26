using IMS.Domain.Models;
using IMS.Service.Repositories;
using IMS.Service.Repositories.IRepositories;
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
    public partial class Form3 : Form
    {
        private readonly ISpecializationService specializationService;
        private readonly IProgramService programService;
        public Form3()
        {
            specializationService = new SpecializationService();
            programService = new ProgramService();
            InitializeComponent();
            LoadPrograms();
            LoadSpecialization();

        }

        private async void LoadPrograms()
        {
            var programs = await programService.GetAllAsync();
            comboBoxPrograms.DataSource = programs;
            comboBoxPrograms.DisplayMember = "Name";
            comboBoxPrograms.ValueMember = "Id";
        }

        private async void LoadSpecialization()
        {
            try
            {
                var specialization = await specializationService.GetAllAsync("Program");
                dataGridView1.DataSource = specialization.Select(p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ProgramName = p.Program != null ? p.Program.Name : "N/A"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
                {
                    specializationService.AddAsync(new Specialization
                    {
                        Name = textBoxName.Text.Trim(),
                        Description = textBoxDescription.Text.Trim(),
                        ProgramId = (int)comboBoxPrograms.SelectedValue
                    });
                }
                else
                {
                    specializationService.UpdateAsync(new Specialization
                    {
                        Id = int.Parse(textBoxId.Text.Trim()),
                        Name = textBoxName.Text.Trim(),
                        Description = textBoxDescription.Text.Trim(),
                        ProgramId = (int)comboBoxPrograms.SelectedValue
                    });
                }
                MessageBox.Show("Specialization saved successfully!");
                LoadSpecialization();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
