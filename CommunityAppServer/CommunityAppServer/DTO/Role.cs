using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Role
    {
        [Key]
        public int RoleNum { get; set; }

        [StringLength(10)]
        public string? RoleName { get; set; }
    }
}
