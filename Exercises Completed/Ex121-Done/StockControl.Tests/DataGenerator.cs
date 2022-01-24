namespace StockControl.Tests
{
    using System.Collections.Generic;
    using Data;

    public static class DataGenerator
	{
		public static void RepopulateTestData()
		{
			ClearAllTestData();
			InsertTestData();
		}

		private static void ClearAllTestData()
        {
            using StockControlEntities db = new();

            List<Transaction> trxList = new();
            foreach (Transaction trx in db.Transactions) trxList.Add(trx);
            foreach (Transaction trx in trxList) db.Transactions.Remove(trx);
            List<Till> tillList = new();
            foreach (Till till in db.Tills) tillList.Add(till);
            foreach (Till till in tillList) db.Tills.Remove(till);
            List<Order> oList = new();
            foreach (Order o in db.Orders) oList.Add(o);
            foreach (Order o in oList) db.Orders.Remove(o);
            List<Supplier> sList = new();
            foreach (Supplier s in db.Suppliers) sList.Add(s);
            foreach (Supplier s in sList) db.Suppliers.Remove(s);
            List<Product> pList = new();
            foreach (Product p in db.Products) pList.Add(p);
            foreach (Product p in pList) db.Products.Remove(p);
            db.SaveChanges();
        }

		private static void InsertTestData()
        {
            using StockControlEntities db = new();

            string[] suppliers =
            {
                "International Savory\t1533 Tasty Drive\tLanham\tMD\t20706\tUSA",
                "Soups & Stews Are Us\t44-166 Curvy Road\tBrighton\tNY\t14610\tUSA",
                "Canadian Favorites Ltd.\t1 Yummy Place\tToronto\tON\tM4C 4Y7\tCanada",
                "General Products Inc.\t15-1115 Midwest Lane\tSouth Bend\tNE\t68058\tUSA",
                "Bath Essentials Pty.\tMoors Presence\tBeverly\tYorkshire\t1SW\tUK"
            };
            string[] products =
            {
                "000001\tSuculent Sage, 4 gm. box\t4.33\t20\t10\t40",
                "111111\tBest Baked Beans, 8 oz. tin\t2.35\t17\t10\t30",
                "111112\tBest Baked Beans, 24 oz. tin\t5.55\t21\t10\t30",
                "111113\tSlurpers Tomato Soup, 12 oz. tin\t1.19\t44\t25\t50",
                "123456\tBeefy Pot Pie, 1 box frozen\t4.33\t9\t10\t40",
                "222222\tPC White Vinegar, 1 ltr.\t3.18\t5\t2\t10",
                "234567\tMacIntosh Toffee, 1 bar\t1.10\t12\t30\t30",
                "333333\tWriting Paper, 1 pad\t1.99\t10\t5\t20",
                "333334\tEnvelopes, 12 pack\t1.99\t10\t5\t20",
                "345678\tNifty pen pack, 6 colors\t2.35\t17\t20\t30",
                "444444\tHP Sauce, 1 bottle\t3.15\t21\t10\t30",
                "456789\tDelicious Clotted Cream, .25 ltr.\t3.19\t18\t25\t50"
            };

            string[] tills =
            {
                "1\tExpress Lane\tAvailable",
                "2\tFront Lane 2\tAvailable",
                "3\tFront Lane 3\tAvailable",
                "4\tFront Lane 4\tAvailable",
                "5\tFront Lane 5\tAvailable",
                "6\tFront Lane 6\tAvailable",
                "7\tCustomer Service Position 1\tAvailable",
                "8\tCustomer Service Position 2\tAvailable",
            };

            for (int ix = 0; ix < tills.Length; ix++)
            {
                string line = tills[ix];
                string[] fields = line.Split('\t');
                Till till = new()
                {
                    Id = int.Parse(fields[0]),
                    Location = fields[1],
                    Status = fields[2]
                };
                db.Tills.Add(till);
            }

            for (int ix = 0; ix < suppliers.Length; ix++)
            {
                string line = suppliers[ix];
                string[] fields = line.Split('\t');
                Supplier sup = new()
                {
                    Name = fields[0],
                    Address1 = fields[1],
                    City = fields[2],
                    StateProvinceCounty = fields[3],
                    PostalCode = fields[4],
                    Country = fields[5]
                };

                db.Suppliers.Add(sup);
					
                foreach(string product in products)
                {
                    if (product.StartsWith(ix.ToString()))
                    {
                        string[] prodFields = product.Split('\t');
							
                        Product p = new()
                        {
                            UniversalCode = prodFields[0],
                            Name = prodFields[1],
                            Price = decimal.Parse(prodFields[2]),
                            QuantityOnHand = int.Parse(prodFields[3]),
                            ReorderThreshold = int.Parse(prodFields[4]),
                            ReorderQuantity = int.Parse(prodFields[5])
                        };

                        sup.Products.Add(p);
                    }
                }
            }

            db.SaveChanges();
        }
	}
}
