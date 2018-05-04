using System;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelApi
{
	/// <summary>
	///     Generates Excel reports containing information from a LotReport
	/// </summary>
	public class ExcelGenerator : IExcelGenerator
	{
		#region Fields

		/// <summary>
		///     Excel Template Path
		/// </summary>
		private readonly string _templatePath;

		/// <summary>
		///     Excel Report Output Path
		/// </summary>
		private readonly string _outputPath;

		private readonly object _lock = new object();

		#endregion

		#region Constructors

		/// <summary>
		///     Create a new instance of an Excel Report Generator
		/// </summary>
		/// <param name="templatePath"></param>
		/// <param name="outputPath"></param>
		public ExcelGenerator(string templatePath, string outputPath)
		{
			_templatePath = templatePath;
			_outputPath = outputPath;
		}

		#endregion

		#region Public Methods

		/// <summary>
		///     Publish an Excel report
		/// </summary>
		/// <param name="report"></param>
		/// <returns></returns>
		public bool PublishReport(ILotReport report)
		{
			lock (_lock)
			{
				const string EXTENSION = ".xlsx";
				var outputFile = _outputPath + report.LotId + EXTENSION;

				if (File.Exists(outputFile))
					return false;

				var cloned = CloneTemplate(_templatePath, outputFile);

				// TODO: Make sure clone worked
				var populated = PopulateReport(outputFile, report);

				return true;
			}
		}

		/// <summary>
		///     Get an existing Excel report
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public ILotReport OpenReport(string filename)
		{
			lock (_lock)
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region Private Methods

		/// <summary>
		///     Populate the excel file with the report information
		/// </summary>
		/// <param name="file"></param>
		/// <param name="report"></param>
		/// <returns></returns>
		private bool PopulateReport(string file, ILotReport report)
		{
			try
			{
				var app = new Excel.Application();
				var workbook = app.Workbooks.Open(file);
				var sheet = (Excel._Worksheet) workbook.ActiveSheet;

				// TODO: If the workbook is populated, make sure we don't overwrite just part of it

				for (int i = 0; i < report.Nozzles.Count; i++)
				{
					sheet.Cells[i + 2, 1] = report.Nozzles[i].Serial;
					sheet.Cells[i + 2, 2] = report.Nozzles[i].Marked;
					sheet.Cells[i + 2, 3] = report.Nozzles[i].Temp;
				}

				workbook.Close(true);	// Save & Close
				app.Quit();
				return true;
			}
			catch (Exception ex)
			{
				// TODO: Log error
				return false;
			}
		}

		/// <summary>
		///     Create an excel report at the specified location using the specified template
		/// </summary>
		/// <param name="template"></param>
		/// <param name="outputPath"></param>
		/// <returns></returns>
		private bool CloneTemplate(string template, string outputPath)
		{
			if (File.Exists(outputPath))
				return false;

			try
			{
				File.Copy(template, outputPath);
				return true;
			}
			catch (Exception ex)
			{
				// TODO: Log exception
				return false;
			}
		}

		#endregion
	}
}