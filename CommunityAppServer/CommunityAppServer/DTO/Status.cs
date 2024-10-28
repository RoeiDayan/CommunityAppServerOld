using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Status
    {
        [Key]
        public int StatNum { get; set; }

        [Column("Status")]
        [StringLength(10)]
        public string? Status1 { get; set; }

        [InverseProperty("StatusNavigation")]
        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}
