using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class CashRegister
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public DateTime OpenDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime CloseDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal OpeningBalance { get; set; }

        [Required]
        public decimal ClosingBalance { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}