using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApi.Utility
{
	public static class ModelHelpers
	{
		#region Fields

		private static readonly Random _rand = new Random();

		#endregion

		#region Methods

		/// <summary>
		/// Returns a random text string of the specified length
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public static string GetRandomText(int length)
		{
			if (length <= 0)
			{
				return string.Empty;
			}

			const int AsciiStart = 32;
			const int AsciiEnd = 127;

			var bytes = new byte[length];
			for (var i = 0; i < bytes.Length; i++)
			{
				bytes[i] = (byte) _rand.Next(AsciiStart, AsciiEnd);
			}

			return Encoding.ASCII.GetString(bytes);
		}

		#endregion
	}
}
