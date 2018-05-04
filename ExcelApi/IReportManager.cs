namespace ExcelApi
{
	public interface IReportManager
	{
		#region Events

		event ExcelApiDelegates.ReportDelegate ActiveReportSet;

		#endregion

		#region Methods

		bool SetActiveLot(string lotId);

		bool CreateLot(string lotId);

		bool AddSerial(string serial);

		void PublishReport();

		#endregion
	}
}