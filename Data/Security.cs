using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class Security
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; } // Foreign key to User table

        [Required]
        public int RoleId { get; set; } // Foreign key to UserRole table

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