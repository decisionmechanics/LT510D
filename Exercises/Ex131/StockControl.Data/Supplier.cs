namespace StockControl.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public sealed class Supplier
    {
        public Supplier()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
            Products1 = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string StateProvinceCounty { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(12)]
        public string PostalCode { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Product> Products1 { get; set; }
    }
}
