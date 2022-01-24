namespace StockControl.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public sealed class Till
    {
        public Till()
        {
            Transactions = new HashSet<Transaction>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Operator { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
