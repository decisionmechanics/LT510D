using System;
using System.Text;
using System.Security.Cryptography;

namespace Util
{
	public static class CybersecurityExtensions
	{
		public static string Encrypt(this string plainText)
		{
			StringBuilder sb = new StringBuilder();
			using (SHA256 hash = SHA256Managed.Create())
			{
				Encoding encoding = Encoding.UTF8;
				Byte[] result = hash.ComputeHash(encoding.GetBytes(plainText));
				foreach (Byte b in result) sb.Append(b.ToString("x2"));
			}
			return sb.ToString().Substring(0, 48);
		}
	}
}
