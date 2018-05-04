namespace ExcelApi
{
	/// <summary>
	///     Defines an ExcelGenerator which generates Excel reports containing information from a LotReport
	/// </summary>
	public interface IExcelGenerator
	{
		/// <summary>
		///     Create an excel report
		/// </summary>
		/// <param name="report"></param>
		/// <returns></returns>
		bool PublishReport(ILotReport report);

		/// <summary>
		///     Open an existing excel report
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		ILotReport OpenReport(string filename);
	}
}