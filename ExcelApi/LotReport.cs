using System.Collections.Generic;

namespace ExcelApi
{
	public class LotReport : ILotReport
	{
		#region Constructors

		public LotReport(string lotId)
		{
			this.LotId = lotId;
			this.Nozzles = new List<INozzle>();
		}

		#endregion

		#region Properties

		public string LotId { get; }

		public List<INozzle> Nozzles { get; }

		#endregion
	}
}