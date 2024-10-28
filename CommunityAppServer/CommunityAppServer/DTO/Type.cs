using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Type
    {
        [Key]
        public int TypeNum { get; set; }

        [Column("Type")]
        [StringLength(10)]
        public string? Type1 { get; set; }

        [InverseProperty("TypeNavigation")]
        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}
