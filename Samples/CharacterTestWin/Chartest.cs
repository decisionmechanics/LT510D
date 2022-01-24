namespace CharacterSetTest
{
    using System;
	using System.Text;

	public class CharTest
	{
		public const int CPL = 16;

		//public string ComposeHeader()								// Compose the header line
		//{
		//    StringBuilder sb = new StringBuilder("    ");			// Leading spaces
		//    for (int i = 0; i < CPL; i++)
		//    {
		//        sb.AppendFormat("  {0:X1}",i);
		//    }
		//    return sb.ToString();
		//}

		public string ComposeLine(int b)
		{
			StringBuilder ret = new StringBuilder();
			for (int i = b; i < b + CPL; i++)
			{
				if ((i % CPL) == 0)										// New line every 16 chars.
				{
//					ret.AppendFormat("{0,5} {1:X4}", i, i);				// Display decimal and hex.
					ret.AppendFormat("{0:X4}", i);						// Display decimal and hex.
				}
				if ((i == 7) || (i ==  8) || (i ==  9)					// Filter position control
						     || (i == 10) || (i == 13))					//  characters out.
				{
					ret.Append("   ");									// Show them as spaces.
				}
				else ret.AppendFormat("{0,3}", (char)i);				// Display the actual char.
			}
			return ret.ToString();
		}
	}
}
