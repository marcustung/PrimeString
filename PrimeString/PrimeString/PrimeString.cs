using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
	public class PrimeString
	{
		private int startIndex = 2;

		public bool isPerminString(string input)
		{
			bool isPerminString = true;

			for (int i = startIndex; i < input.Length; i++)
			{
				if ((input.Replace(input.Substring(0, i), string.Empty).Length == 0))
					isPerminString = false;
			}

			return isPerminString;
		}
	}
}
