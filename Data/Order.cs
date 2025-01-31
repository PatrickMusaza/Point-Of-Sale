using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; } // Foreign key to Customer table

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string Status { get; set; } // e.g., "Pending", "Completed", "Cancelled"

        [MaxLength(500)]
        public string Notes { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}