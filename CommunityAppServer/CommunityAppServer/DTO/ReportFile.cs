using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class ReportFile
    {
        [Key]
        public int ReportId { get; set; }

        [Key]
        [StringLength(255)]
        public string FileName { get; set; } = null!;

        [StringLength(5)]
        public string? RepFileExt { get; set; }

        [ForeignKey("ReportId")]
        [InverseProperty("ReportFiles")]
        public virtual Report Report { get; set; } = null!;
    }
}
