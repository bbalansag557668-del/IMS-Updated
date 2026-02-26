using IMS.Domain.Models;
using IMS.Domain.ViewModel;
using IMS.Infrastructure.Data;
using IMS.Service.Repositories;
using IMS.Service.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace IMS.App
{
    public partial class Form1 : Form
    {
        private readonly IProgramService programService;
        public Form1()
        {
            programService = new ProgramService();
            InitializeComponent();
            LoadPrograms();
        }

        //CRUD - Read Operation (Listing Programs)
        private async void LoadPrograms(string? searchTerm = null)
        {
            try
            {
                var programs = await programService.GetAllAsync();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    programs = programs.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
                }

                dataGridView1.DataSource = programs.Select(p => new ProgramViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    SpecializationName = p.Specializations != null ?
                            string.Join(",", p.Specializations.Select(c => c.Name).ToList())
                            : "N/A"
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
            }
        }

        //CRUD - Read Operation (Listing - Single Entity Program)
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPrograms(textBoxSearch.Text.ToLower());
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
                {
                    // Create new program
                    var newProgram = new Programs
                    {
                        Name = textBoxName.Text.Trim(),
                        Description = textBoxDescription.Text.Trim()
                    };
                    await programService.AddAsync(newProgram);
                }
                else
                {
                    var programId = int.Parse(textBoxId.Text.Trim());
                    var existingProgram = await programService.GetByIdAsync(programId);
                    await programService.UpdateAsync(existingProgram);
                }

                MessageBox.Show("Program saved/updated successfully!");
                LoadPrograms();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid Program ID to delete.");
                return;
            }
            var programId = int.Parse(textBoxId.Text.Trim());
            if (programId != 0)
            {
                programService.DeleteAsync(programId);
                MessageBox.Show("Program deleted successfully!");
                LoadPrograms();
            }
            else
            {
                MessageBox.Show("Program not found for deletion.");
            }
        }
    }
}
