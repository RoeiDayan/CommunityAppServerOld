using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Account
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Password { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Member> Members { get; set; } = new List<Member>();

        [InverseProperty("User")]
        public virtual ICollection<Notice> Notices { get; set; } = new List<Notice>();

        [InverseProperty("User")]
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

        [InverseProperty("User")]
        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

        [InverseProperty("User")]
        public virtual ICollection<RoomRequest> RoomRequests { get; set; } = new List<RoomRequest>();

        [InverseProperty("KeyHolder")]
        public virtual ICollection<TenantRoom> TenantRooms { get; set; } = new List<TenantRoom>();


        public Models.Account GetAccount()
        {
            Models.Account acc = new Models.Account();
            acc.Email = this.Email;
        }
        public Account(Models.Account acc)
        {
            this.Email = acc.Email;
        }
    }
}
