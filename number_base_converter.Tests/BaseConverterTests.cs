using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace number_base_converter.Tests
{
	[TestClass]
	public class TestBaseConverter
	{
		[TestMethod]
		public void TestBase10ToBase2()
		{
			// Arrange
			string valueToConvert = "3";
			ValidBases fromBase = ValidBases.base10;
			ValidBases toBase = ValidBases.base2;
			string expectedResult = "11";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestBase10ToBase16()
		{
			// Arrange
			string valueToConvert = "10";
			ValidBases fromBase = ValidBases.base10;
			ValidBases toBase = ValidBases.base16;
			string expectedResult = "a";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestBase2ToBase10()
		{
			// Arrange
			string valueToConvert = "111";
			ValidBases fromBase = ValidBases.base2;
			ValidBases toBase = ValidBases.base10;
			string expectedResult = "7";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestBase2ToBase16()
		{
			// Arrange
			string valueToConvert = "1111";
			ValidBases fromBase = ValidBases.base2;
			ValidBases toBase = ValidBases.base16;
			string expectedResult = "f";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestBase16ToBase10()
		{
			// Arrange
			string valueToConvert = "C";
			ValidBases fromBase = ValidBases.base16;
			ValidBases toBase = ValidBases.base10;
			string expectedResult = "12";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestBase16ToBase2()
		{
			// Arrange
			string valueToConvert = "B";
			ValidBases fromBase = ValidBases.base16;
			ValidBases toBase = ValidBases.base2;
			string expectedResult = "1011";

			// Act
			string result = BaseConverter.ConvertBase(valueToConvert, fromBase, toBase);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod]
		public void TestNotValidFromBase()
		{
			// Arrange
			string valueToConvert = "B";
			ValidBases fromBase = (ValidBases)8;
			ValidBases toBase = ValidBases.base2;
			System.Type expectedResult = typeof(NotValidBaseException);

			// Act
			var result = Assert.ThrowsException<NotValidBaseException>(
				() => BaseConverter.ConvertBase(valueToConvert, fromBase, toBase)
			);

			// Assert
			Assert.IsInstanceOfType(result, expectedResult);
		}

		[TestMethod]
		public void TestNotValidToBase()
		{
			// Arrange
			string valueToConvert = "B";
			ValidBases fromBase = ValidBases.base10;
			ValidBases toBase = (ValidBases)3;
			System.Type expectedResult = typeof(NotValidBaseException);

			// Act
			var result = Assert.ThrowsException<NotValidBaseException>(
				() => BaseConverter.ConvertBase(valueToConvert, fromBase, toBase)
			);

			// Assert
			Assert.IsInstanceOfType(result, expectedResult);
		}
	}
}
