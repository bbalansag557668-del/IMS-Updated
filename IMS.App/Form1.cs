using IMS.Domain.Models;
using IMS.Domain.ViewModel;
using IMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IMS.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPrograms();
        }

        //CRUD - Read Operation (Listing Programs)
        private void LoadPrograms(string? searchTerm = null)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    var programs = _context.Programs
                                                .Select(p => new ProgramViewModel
                                                {
                                                    Id = p.Id,
                                                    Name = p.Name,
                                                    Description = p.Description,
                                                    SpecializationName = string.Join(", ", p.Specializations.Select(s => s.Name))
                                                })
                                                .ToList();
                    if (string.IsNullOrEmpty(searchTerm))
                        dataGridView1.DataSource = programs;
                    else
                        dataGridView1.DataSource = programs
                            .Where(p => p.Id.ToString().Contains(searchTerm) ||
                                        p.Name.ToLower().Contains(searchTerm) ||
                                        p.Description.ToLower().Contains(searchTerm))
                            .ToList();


                    label5.Text = $"Total Programs: {_context.Programs.ToList().Count()}";
                }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
                    {
                        var program = new Programs
                        {
                            Name = textBoxName.Text.Trim(),
                            Description = textBoxDescription.Text.Trim()
                        };

                        _context.Programs.Add(program);
                    }
                    else
                    {
                        var programId = int.Parse(textBoxId.Text.Trim());
                        //var entity = _context.Programs.Where(c => c.Id == programId);
                        var entity = _context.Programs.Find(programId);
                        if (entity != null)
                        {
                            entity.Name = textBoxName.Text.Trim();
                            entity.Description = textBoxDescription.Text.Trim();
                        }
                        else
                        {
                            MessageBox.Show("Program not found for update.");
                            return;
                        }
                        _context.Programs.Update(entity);
                    }
                    _context.SaveChanges();

                    MessageBox.Show("Program saved/updated successfully!");
                    LoadPrograms();
                    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using(var _context = new AppDbContext())
            {
                if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid Program ID to delete.");
                    return;
                }
                var programId = int.Parse(textBoxId.Text.Trim());
                var entity = _context.Programs.Find(programId);
                if (entity != null)
                {
                    _context.Programs.Remove(entity);
                    _context.SaveChanges();
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
}
