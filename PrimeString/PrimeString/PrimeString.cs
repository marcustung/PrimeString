using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
	public class PrimeString
	{
		public bool isPerminString(string input)
		{
			bool isPerminString = true;

			for (int i = 2; i < input.Length; i++)
			{
				var oristr = input;
				var str = oristr.Substring(0, i);

				if ((oristr.Replace(str, string.Empty).Length == 0))
				{
					isPerminString = false;
				}
			}

			return isPerminString;
		}
	}
}
