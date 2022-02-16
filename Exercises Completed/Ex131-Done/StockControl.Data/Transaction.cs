namespace StockControl.Data
{
    using System;
    using System.Collections.Generic;

    public sealed class Transaction
    {
        public Transaction()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public int TillId { get; set; }

        public int Status { get; set; }

        public DateTime StartedAt { get; set; }

        public DateTime? SavedAt { get; set; }

        public decimal TotalAmount { get; set; }

        public Till Till { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
