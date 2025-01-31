using SQLite;
using System.ComponentModel.DataAnnotations;
using SQLiteNetExtensions.Attributes;

namespace Point_Of_Sale.Data
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Color { get; set; }

        [MaxLength(255)]
        public string Icon { get; set; }

        [Required, MaxLength(50), Indexed]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Level { get; set; }

        public TaxType TaxType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(50), Indexed]
        public string Barcode { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Measurement { get; set; }

        public int AgeRestriction { get; set; }

        public bool Active { get; set; } = true;

        public bool DefQuantity { get; set; } = false;

        public bool Service { get; set; } = false;

        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal TaxRate { get; set; }

        public decimal DiscountRate { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal Markup { get; set; }

        public bool ChangeAllowed { get; set; } = false;

        public bool IsTaxInclusive { get; set; } = false;

        [MaxLength(100)]
        public int SupplierId { get; set; }

        public decimal ReorderPoint { get; set; }

        public decimal PreferredQuantity { get; set; }

        public decimal LowStockWarningQuantity { get; set; }

        public bool LowStockWarning { get; set; } = false;

        public int CategoryId { get; set; }

        [MaxLength(100)]
        public string CommentTitle { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }

        public int PrintStationId { get; set; }

        [MaxLength(50)]
        public string UserCreate { get; set; }

        [MaxLength(50)]
        public string UserUpdate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }

    public enum TaxType
    {
        A,
        B,
        C
    }
}