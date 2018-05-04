using System.Collections.Generic;

namespace ExcelApi
{
	/// <summary>
	///     Manages Lot Reports
	/// </summary>
	public class ReportManager : IReportManager
	{
		#region Fields

		/// <summary>
		/// Excel report generator
		/// </summary>
		private readonly IExcelGenerator _excelGenerator;

		/// <summary>
		///     Contains all Lot reports by serial
		/// </summary>
		private readonly Dictionary<string, ILotReport> _reports = new Dictionary<string, ILotReport>();

		/// <summary>
		///     The currently active report
		/// </summary>
		private string _activeReport;

		/// <summary>
		///     Controls access to the _reports object
		/// </summary>
		private readonly object _lock = new object();

		#endregion

		#region Events

		public event ExcelApiDelegates.ReportDelegate ActiveReportSet;

		#endregion

		#region Constructors

		/// <summary>
		/// Create a new instance of an ReportManager
		/// </summary>
		public ReportManager(IExcelGenerator excelGenerator)
		{
			this._excelGenerator = excelGenerator;
			_activeReport = string.Empty;
		}

		#endregion

		#region Public Methods

		/// <summary>
		///     Set the active LotId
		/// </summary>
		/// <param name="lotId"></param>
		/// <returns></returns>
		public bool SetActiveLot(string lotId)
		{
			lock (_lock)
			{
				if (!_reports.ContainsKey(lotId))
					CreateLot(lotId);

				_activeReport = lotId;
				RefreshActiveReport(lotId);
				return true;
			}
		}

		/// <summary>
		///     Create a new lot
		/// </summary>
		/// <param name="lotId"></param>
		/// <returns></returns>
		public bool CreateLot(string lotId)
		{
			lock (_lock)
			{
				if (_reports.ContainsKey(lotId))
					return false;

				_reports[lotId] = new LotReport(lotId);
				return true;
			}
		}

		/// <summary>
		///     Add a serial to a lot
		/// </summary>
		/// <param name="lotId"></param>
		/// <param name="serial"></param>
		/// <returns></returns>
		public bool AddSerial(string serial)
		{
			lock (_lock)
			{
				if (!_reports.ContainsKey(_activeReport))
					return false;

				_reports[_activeReport].Nozzles.Add(new Nozzle(serial));
				RefreshActiveReport(_activeReport);
				return true;
			}
		}

		/// <summary>
		/// Publish an Excel report with the active Lot
		/// </summary>
		/// <returns></returns>
		public void PublishReport()
		{
			lock (_lock)
			{
				if (!this._reports.ContainsKey(_activeReport))
				{
					// TODO: Log Warning
					return;
				}

				// Generate a report
				var result = this._excelGenerator.PublishReport(this._reports[this._activeReport]);
			}
		}

		#endregion

		#region Private Methods

		/// <summary>
		///     Signals that the active report has been updated
		/// </summary>
		private void RefreshActiveReport(string lotId)
		{
			ActiveReportSet?.Invoke(_reports[lotId]);
		}

		#endregion
	}
}