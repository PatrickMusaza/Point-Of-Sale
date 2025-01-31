using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class Sale
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; } // Foreign key to Order table

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string Status { get; set; } // e.g., "Completed", "Refunded"

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}