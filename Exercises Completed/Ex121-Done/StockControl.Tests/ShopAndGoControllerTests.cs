namespace StockControl.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Logic;

	[TestClass]
	public class ShopAndGoControllerTests
	{
		[TestMethod]
		public void CartEmpty_ValidCardTappedTests()
		{
			ShopAndGoController controller = new();
            Assert.IsTrue(controller.CanDo(ShopAndGoOp.CardTapped));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.StoreExited));
			controller.CardTapped("12345678");
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.CardTapped));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.StoreExited));
		}

		[TestMethod]
		public void CartEmpty_invalidCardTappedTests()
		{
			ShopAndGoController controller = new();
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.CardTapped));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.StoreExited));
			controller.CardTapped("98765432");
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.CardTapped));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.StoreExited));
		}

		[TestMethod]
		public void Shopping_ValidScan_Test()
		{
			ShopAndGoController controller = new();
			controller.CardTapped("12345678");
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.AreEqual(0, controller.SaleItems.Count);
			string p = "111111";
			controller.ItemAdded(p);
			Assert.AreEqual(1, controller.SaleItems.Count);
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.StoreExited));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.CardTapped));
		}

		[TestMethod]
		public void Shopping_InvalidScan_Test()
		{
			ShopAndGoController controller = new();
			controller.CardTapped("12345678");
			string p = "918273";	// Invalid UPC
			controller.ItemAdded(p);
			Assert.AreEqual(0, controller.SaleItems.Count);
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.StoreExited));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.CardTapped));
		}

		[TestMethod]
		public void Shopping_MultipeItemsAdded_Test()
		{
			ShopAndGoController controller = new();
			controller.CardTapped("12345678");
			controller.ItemAdded("111111");
			controller.ItemAdded("222222");
			Assert.AreEqual(2, controller.SaleItems.Count);
			Assert.AreEqual(5.53m, controller.Total);
			Assert.AreSame(controller.LastItemScanned, controller.SaleItems[1]);
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.StoreExited));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.CardTapped));
		}

		[TestMethod]
		public void ExitStoreTest()
		{
			ShopAndGoController controller = new();
			controller.CardTapped("12345678");
			controller.ItemAdded("111111");
			controller.ItemAdded("222222");
			Assert.AreEqual(2, controller.SaleItems.Count);
			Assert.AreEqual(5.53m, controller.Total);
			Assert.IsNotNull(controller.LastItemScanned);
			controller.StoreExited();
			Assert.AreEqual(0, controller.SaleItems.Count);
			Assert.AreEqual(0.00m, controller.Total);
			Assert.IsNull(controller.LastItemScanned);
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.StoreExited));
			Assert.IsFalse(controller.CanDo(ShopAndGoOp.ItemAdded));
			Assert.IsTrue(controller.CanDo(ShopAndGoOp.CardTapped));
		}
	}
}
