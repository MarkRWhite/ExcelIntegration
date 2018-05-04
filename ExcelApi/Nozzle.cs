using System;

namespace ExcelApi
{
	public class Nozzle : INozzle
	{
		#region Static Methods

		private static readonly Random _rand = new Random();

		#endregion

		#region Constructors

		/// <summary>
		/// Create a new Nozzle Instance
		/// </summary>
		/// <param name="serial"></param>
		/// <param name="test"></param>
		public Nozzle(string serial, bool test = false)
		{
			this.Serial = serial;

			if (test)
			{
				this.Marked = _rand.Next(0, 2) > 0;
				this.Temp = (decimal)_rand.Next(0, 50000) / 100;
			}
		}

		/// <summary>
		/// Test constructor
		/// </summary>
		/// <param name="test"></param>
		public Nozzle(bool test = false)
		{
			if (test)
			{
				this.Serial = Utility.ModelHelpers.GetRandomText(_rand.Next(0, 10));
				this.Marked = _rand.Next(0, 2) > 0;
				this.Temp = (decimal)_rand.Next(0, 50000) / 100;
			}
		}

		#endregion

		#region Properties

		public string Serial { get; }

		public bool Marked { get; set; }

		public decimal Temp { get; set; }

		#endregion
	}
}