// ReSharper disable ConvertToUsingDeclaration
namespace StockControl.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Data;

	[TestClass]
	public class StockDataTests
	{
		[TestInitialize]
		public void GenerateTestData()
		{
			DataGenerator.RepopulateTestData();
		}

		[TestMethod]
		public void DataContextCreationTest()
        {
            using StockControlEntities db = new();

            Assert.IsNotNull(db);
        }

		[TestMethod]
		public void ProductToStringTest()
		{
			Product p = new()
			{
				UniversalCode = "987654",
				Name = "Something good",
				Price = 5.99M
			};
			Assert.AreEqual("987654 $  5.99 Something good", p.ToString());
		}

		[TestMethod]
		public void RepositoryCreationTest()
        {
            using Repository repo = new();
            Assert.IsNotNull(repo);
        }

		[TestMethod]
		public void ProductLookupTest()
        {
            using Repository repo = new();

            Product p = repo.LookupProduct("111111");
            Assert.IsNotNull(p);
            Assert.AreEqual(2.35M, p.Price);
        }
		
        [TestMethod]
		public void ProductCountTest()
        {
            using Repository repo = new();
            
            int count = repo.ProductsAll.Count();
            Assert.AreEqual(12, count);
        }
	}
}
