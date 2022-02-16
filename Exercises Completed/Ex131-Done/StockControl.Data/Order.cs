namespace StockControl.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        [Key]
        [StringLength(50)]
        public string UniversalCode { get; set; }

        public int SupplierId { get; set; }

        public DateTime OrderedOn { get; set; }

        public int QuantityOrdered { get; set; }

        public decimal TotalCost { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
