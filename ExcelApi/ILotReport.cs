using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApi
{
	public interface ILotReport
	{
		string LotId { get; }

		List<INozzle> Nozzles { get; }
	}
}
