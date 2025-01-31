using SQLite;
using System;

namespace Point_Of_Sale.Data
{
    public class PromotionDiscount
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal DiscountRate { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public bool Active { get; set; } = true;

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}