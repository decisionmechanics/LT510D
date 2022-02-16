
namespace StockControl.Logic
{
    using Data;

    public enum ShopAndGoOp { CardTapped, ItemAdded, StoreExited }
	public class ShopAndGoController : Publisher
	{
		public List<Product> SaleItems { get; private set; } = new List<Product>();
		public Product LastItemScanned { get; private set; }
		public decimal Total { get; private set; }
		private Repository repo = new();

		private BaseState State { get; set; }
		private bool[] Ops { get; set; }
		public bool CanDo(ShopAndGoOp op) { return Ops[(int)op]; }
		
        public ShopAndGoController()
		{
			Ops = new bool[Enum.GetValues(typeof(ShopAndGoOp)).Length];
			State = new CartEmpty(this);
		}
		
        public void CardTapped(string p) { State.CardTapped(p); Notify(); }
		public void ItemAdded(string p) { State.ItemAdded(p); Notify(); }
		public void StoreExited() { State.StoreExited(); Notify(); }
		
        private abstract class BaseState
		{
			protected ShopAndGoController controller;
			protected void Invalid() { throw new InvalidOperationException(); }
			
            public BaseState(ShopAndGoController controller)
			{
				this.controller = controller;
                for (int i = 0; i < controller.Ops.Length; i++)
                {
                    controller.Ops[i] = false;
                }
            }

			public virtual void CardTapped(string p) { Invalid(); }
			public virtual void ItemAdded(string p) { Invalid(); }
			public virtual void StoreExited() { Invalid(); }
		}
		class CartEmpty : BaseState
		{
			public CartEmpty(ShopAndGoController controller) : base(controller)
			{
				controller.Ops[(int)ShopAndGoOp.CardTapped] = true;
			}

			public override void CardTapped(string p)
			{
				bool error = false;

				if (p.StartsWith("9")) 
                    error = true;

				if (!error) 
                    controller.State = new Shopping(controller);
			}
		}

		class Shopping : BaseState
		{
			public Shopping(ShopAndGoController controller) : base(controller)
			{
				controller.Ops[(int)ShopAndGoOp.CardTapped] = false;
				controller.Ops[(int)ShopAndGoOp.ItemAdded] = true;
				controller.Ops[(int)ShopAndGoOp.StoreExited] = true;
			}

			public override void ItemAdded(string universalCode)
			{
				Product p = controller.repo.LookupProduct(universalCode);
				controller.LastItemScanned = p;
				
                if (p != null)
				{
					controller.SaleItems.Add(p);
					controller.Total += p.Price;
				}
			}

			public override void StoreExited()
			{
				//Charge the card and print receipt
				controller.SaleItems.Clear();
				controller.Total = 0;
				controller.LastItemScanned = null;
				controller.State = new CartEmpty(controller);
			}
		}
	}

	public abstract class Publisher
	{
		public event EventHandler StateChanged;
		
        protected void Notify()
		{
			if (StateChanged != null) StateChanged(this,EventArgs.Empty);
		}
	}
}
