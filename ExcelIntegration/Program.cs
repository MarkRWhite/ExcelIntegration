using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApi;

namespace ExcelIntegration
{
	static class Program
	{
		private static IReportManager _reportManager;

		private static ItemMarkingForm _form;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			_form = new ItemMarkingForm();
			_reportManager = new ReportManager(new ExcelGenerator(Properties.Settings.Default.TemplatePath,
				Properties.Settings.Default.OutputPath));

			_form.SetActiveLot += _reportManager.SetActiveLot;
			_form.AddSerial += _reportManager.AddSerial;
			_form.PublishReport += _reportManager.PublishReport;

			_reportManager.ActiveReportSet += _form.DisplayReport;

			Application.Run(_form);
		}
	}
}
