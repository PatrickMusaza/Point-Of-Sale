using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class Payment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int SaleId { get; set; } // Foreign key to Sale table

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal Amount { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; } // e.g., "Cash", "Card", "Mobile Money"

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}