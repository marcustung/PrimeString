using NUnit.Framework;
using PrimeString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString.Tests
{
	[TestFixture()]
	public class PrimeStringTests
	{
		[Test()]
		[TestCase("abab", false)]
		public void isPerminStringTest(string inputValue, bool isPrimeString)
		{
			// Arrange
			PrimeString primeStr = new PrimeString();

			// Act
			bool result = primeStr.isPerminString(inputValue);

			// Assert
			Assert.AreEqual(isPrimeString, result);
		}
	}
}