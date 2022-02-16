namespace StockControl.Data
{
	public class Repository : IDisposable
	{
		private StockControlEntities _db = new();

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Rollback()
		{
			_db.Dispose();
			_db = new StockControlEntities();
		}

		public Product LookupProduct(string universalCode)
		{
			var result = from p in _db.Products
						 where p.UniversalCode == universalCode
						 select p;
		
            return result.FirstOrDefault();
		}

		public IQueryable<Product> ProductsAll
		{
			get
			{
				var result = from p in _db.Products
							 orderby p.UniversalCode
							 select p;

				return result;
			}
		}

		private bool _disposedValue;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
					_db.Dispose();
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				_disposedValue = true;
			}
		}

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~Repository()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
