using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CardLib
{
	[Serializable()]
	public class BlackjackConfigurationData
	{
		private int maximumBet = 50;
		public int MaximumBet { get { return maximumBet; } set { maximumBet = value; } }

		private int betIncrement = 5;
		public int BetIncrement { get { return betIncrement; } set { betIncrement = value; } }
		
		private double payoffOnBlackjack = 3.0 / 2.0;		// 3:2
		public double PayoffOnBlackjack { get { return payoffOnBlackjack; } set { payoffOnBlackjack = value; } }
		
		private bool dealerDrawsOnSoft17;					// false
		public bool DealerDrawsOnSoft17 { get { return dealerDrawsOnSoft17; } set { dealerDrawsOnSoft17 = value; } }

		private bool payDealerOnTie = false;
		public bool PayDealerOnTie { get { return payDealerOnTie; } set { payDealerOnTie = value; } }

		private bool surrenderAllowed = true;
		public bool SurrenderAllowed { get { return surrenderAllowed; } set { surrenderAllowed = value; } }

		private bool lateSurrender;							// false
		public bool LateSurrender { get { return lateSurrender; } set { lateSurrender = value; } }

		private bool insuranceAllowed = true;
		public bool InsuranceAllowed { get { return insuranceAllowed; } set { insuranceAllowed = value; } }

		private bool onlyEvenMoneyAllowed;					// false
		public bool OnlyEvenMoneyAllowed { get { return onlyEvenMoneyAllowed; } set { onlyEvenMoneyAllowed = value; } }

		private bool canSplitOn10s;							// false
		public bool CanSplitOn10s { get { return canSplitOn10s; } set { canSplitOn10s = value; } }

		private int maximumSplitsOnAces = 2;
		public int MaximumSplitsOnAces { get { return maximumSplitsOnAces; } set { maximumSplitsOnAces = value; } }

		private int maximumSplitsOnNonAces = 4;
		public int MaximumSplitsOnNonAces { get { return maximumSplitsOnNonAces; } set { maximumSplitsOnNonAces = value; } }

		private int decksInShoe = 4;
		public int DecksInShoe { get { return decksInShoe; } set { decksInShoe = value; } }

		private bool dealerGetsASingleUpCardOnFirstDeal;	// false
		public bool DealerGetsASingleUpCardOnFirstDeal { get { return dealerGetsASingleUpCardOnFirstDeal; } set { dealerGetsASingleUpCardOnFirstDeal = value; } }
	}

	public class BlackjackConfiguration
	{
		public const string BlackjackConfigurationFile = "blackjack.prefs";
		private BlackjackConfigurationData data = new BlackjackConfigurationData();
		public BlackjackConfigurationData Data { get { return data; } }
		private BlackjackConfiguration() { }
		private static BlackjackConfiguration config;
		public static BlackjackConfiguration Instance
		{
			get
			{
				if (config == null) config = new BlackjackConfiguration();
				return config;
			}
		}
		public void ResetDefaults()
		{
			if (File.Exists(BlackjackConfigurationFile))
				File.Delete(BlackjackConfigurationFile);
			data.MaximumBet = 50;
			data.BetIncrement = 5;
			data.PayoffOnBlackjack = 3.0 / 2.0; // 3:2
			data.DealerDrawsOnSoft17 = false;
			data.PayDealerOnTie = false;
			data.SurrenderAllowed = true;
			data.LateSurrender = false;
			data.InsuranceAllowed = true;
			data.OnlyEvenMoneyAllowed = false;
			data.CanSplitOn10s = false;
			data.MaximumSplitsOnAces = 2;
			data.MaximumSplitsOnNonAces = 4;
			data.DecksInShoe = 4;
			data.DealerGetsASingleUpCardOnFirstDeal = false;
		}

		public void Save()
		{
			BinaryFormatter bf = new BinaryFormatter();
			if (File.Exists(BlackjackConfigurationFile)) File.Delete(BlackjackConfigurationFile);
			Stream stream = new FileStream(BlackjackConfigurationFile, FileMode.Create, FileAccess.Write, FileShare.None);
			bf.Serialize(stream, data);
			stream.Close();
		}

		public void Load()
		{
			BinaryFormatter bf = new BinaryFormatter();
			Stream stream = null;
			try
			{
				stream = new FileStream(BlackjackConfigurationFile, FileMode.Open, FileAccess.Read, FileShare.None);
				data = (BlackjackConfigurationData)bf.Deserialize(stream);
				stream.Close();
			}
			catch (IOException exc)
			{
				if ((exc != null) && (stream != null)) stream.Close();
				ResetDefaults();
			}
		}

		public static bool HasBeenSaved { get { return File.Exists(BlackjackConfigurationFile); } }
	}
}
