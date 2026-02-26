using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.Models
{
    public class Programs
    {
        [Key] public int Id { get; set; }
        [Required] public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Specialization>? Specializations { get; set; }
        [ForeignKey("AppUser")]
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual AppUser? AppUser { get; set; }
    }
}
