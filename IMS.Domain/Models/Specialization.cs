using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.Models
{
    public class Specialization
    {
        [Key] public int Id { get; set; }
        [Required] public string? Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(ProgramId))] public int ProgramId { get; set; }
        public virtual Programs? Program { get; set; }
    }
}
