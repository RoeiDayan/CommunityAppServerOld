﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommunityAppServer.DTO
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int? ComId { get; set; }

        public int? UserId { get; set; }

        public int? Amount { get; set; }

        public bool? MarkedPayed { get; set; }

        public bool? WasPayed { get; set; }

        public DateOnly? PayFrom { get; set; }

        public DateOnly? PayUntil { get; set; }

        [ForeignKey("ComId")]
        [InverseProperty("Payments")]
        public virtual Community? Com { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Payments")]
        public virtual Account? User { get; set; }
    }
}
