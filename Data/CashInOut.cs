using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class CashInOut
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string TransactionType { get; set; } // e.g., "Cash In", "Cash Out"

        [Required]
        public decimal Amount { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}