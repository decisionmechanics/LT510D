namespace StockControl.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public Product()
        {
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        [StringLength(50)]
        public string UniversalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int QuantityOnHand { get; set; }

        public int ReorderThreshold { get; set; }

        public int ReorderQuantity { get; set; }

        public int? SupplierId { get; set; }

        public int? SupplierAltId { get; set; }

        public Order Order { get; set; }

        public Supplier Supplier { get; set; }

        public Supplier Supplier1 { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public override string ToString() => $"{UniversalCode,-6} ${Price,6:N2} {Name}";
    }
}
