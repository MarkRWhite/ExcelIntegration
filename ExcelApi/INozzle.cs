using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApi
{
	public interface INozzle
	{
		string Serial { get; }

		bool Marked { get; set; }

		decimal Temp { get; set; }
	}
}
