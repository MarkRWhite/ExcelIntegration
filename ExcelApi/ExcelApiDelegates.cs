using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApi
{
	public static class ExcelApiDelegates
	{
		public delegate bool SetLotDelegate(string lotId);

		public delegate bool AddSerialDelegate(string serial);

		public delegate void ReportDelegate(ILotReport report);

		public delegate void NozzleDelegate(INozzle nozzle);
	}
}
