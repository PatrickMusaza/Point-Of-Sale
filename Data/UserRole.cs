using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class UserRole
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string RoleName { get; set; } // e.g., "Admin", "Cashier", "Manager"

        [MaxLength(500)]
        public string Permissions { get; set; } // JSON or comma-separated list of permissions

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}