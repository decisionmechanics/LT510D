namespace StockControl.Data
{
    using System.Data.Entity;

    public class StockControlEntities : DbContext
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Course\510D\Data\StockControl.mdf;Integrated Security=True;";

		public StockControlEntities()
			: base(ConnectionString)
		{
		}

		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Supplier> Suppliers { get; set; }
		public virtual DbSet<Till> Tills { get; set; }
		public virtual DbSet<Transaction> Transactions { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>()
				.Property(e => e.UniversalCode)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.TotalCost)
				.HasPrecision(12, 2);

			modelBuilder.Entity<Product>()
				.Property(e => e.UniversalCode)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.Price)
				.HasPrecision(12, 2);

			modelBuilder.Entity<Product>()
				.HasOptional(e => e.Order)
				.WithRequired(e => e.Product);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.Transactions)
				.WithMany(e => e.Products)
				.Map(m => m.ToTable("ProductTransactions").MapLeftKey("ProductUniversalCode").MapRightKey("TransactionId"));

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Address1)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.StateProvinceCounty)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Country)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.PostalCode)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Supplier)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Products)
				.WithOptional(e => e.Supplier)
				.HasForeignKey(e => e.SupplierId);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Products1)
				.WithOptional(e => e.Supplier1)
				.HasForeignKey(e => e.SupplierAltId);

			modelBuilder.Entity<Till>()
				.Property(e => e.Status)
				.IsUnicode(false);

			modelBuilder.Entity<Till>()
				.Property(e => e.Location)
				.IsUnicode(false);

			modelBuilder.Entity<Till>()
				.Property(e => e.Operator)
				.IsUnicode(false);

			modelBuilder.Entity<Till>()
				.HasMany(e => e.Transactions)
				.WithRequired(e => e.Till)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Transaction>()
				.Property(e => e.TotalAmount)
				.HasPrecision(18, 0);
		}
	}
}
