using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }

        [Required, MaxLength(100)]
        public string Role { get; set; } // e.g., "Admin", "Cashier"

        public bool Active { get; set; } = true;

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}