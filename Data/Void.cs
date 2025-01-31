using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class Void
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; } // Foreign key to Order table

        [Required]
        public DateTime VoidDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string Reason { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}