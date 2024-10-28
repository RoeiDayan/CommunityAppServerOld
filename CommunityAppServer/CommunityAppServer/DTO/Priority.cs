using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Priority
    {
        [Key]
        public int PriorityNum { get; set; }

        [Column("Priority")]
        [StringLength(10)]
        public string? Priority1 { get; set; }

        [InverseProperty("PriorityNavigation")]
        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}
