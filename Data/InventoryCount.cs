using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class InventoryCount
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; } // Foreign key to Product table

        [Required]
        public DateTime CountDate { get; set; } = DateTime.UtcNow;

        [Required]
        public int Quantity { get; set; }

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