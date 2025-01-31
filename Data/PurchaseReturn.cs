using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class PurchaseReturn
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int PurchaseId { get; set; } // Foreign key to Purchase table

        [Required]
        public DateTime ReturnDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal RefundAmount { get; set; }

        [MaxLength(500)]
        public string Reason { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}