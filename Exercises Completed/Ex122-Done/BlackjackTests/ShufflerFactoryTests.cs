using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardLib;

namespace BlackjackTests
{
	[TestClass]
	public class ShufflerFactoryTests
	{
		[TestMethod]
		public void ShufflerCreationTest()
		{
			IShuffler shuffler = ShufflerFactory.Create("Simple Knuth Shuffler");
			Assert.IsNotNull(shuffler);
			Assert.AreEqual("KnuthShuffler", shuffler.GetType().Name);
			shuffler = ShufflerFactory.Create("Modified Knuth Shuffler");
			Assert.IsNotNull(shuffler);
			Assert.AreEqual("ModifiedKnuthShuffler", shuffler.GetType().Name);
			shuffler = ShufflerFactory.Create("No Such Shuffler");
			Assert.IsNull(shuffler);
		}
	}
}
