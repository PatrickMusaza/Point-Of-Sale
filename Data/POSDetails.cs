using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class POSDetails
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string ServerName { get; set; }

        [Required, MaxLength(100)]
        public string IPAddress { get; set; }

        [Required]
        public int Port { get; set; }

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