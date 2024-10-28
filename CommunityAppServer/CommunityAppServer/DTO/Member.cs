using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Member
    {
        [Key]
        public int ComId { get; set; }

        [Key]
        public int UserId { get; set; }

        [StringLength(20)]
        public string? Role { get; set; }

        public int? Balance { get; set; }

        public int? UnitNum { get; set; }

        public bool? IsLiable { get; set; }

        public bool? IsResident { get; set; }

        public bool? IsManager { get; set; }

        public bool? IsProvider { get; set; }

        [ForeignKey("ComId")]
        [InverseProperty("Members")]
        public virtual Community Com { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("Members")]
        public virtual Account User { get; set; } = null!;
    }
}
