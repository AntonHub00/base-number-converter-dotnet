using System;

namespace number_base_converter
{

	public enum ValidBases
	{
		base2 = 2,
		base10 = 10,
		base16 = 16
	}

	public class NotValidBaseException : Exception
	{
		private string errorBase;
		public NotValidBaseException(string errorBase)
		{
			this.errorBase = errorBase;
		}
		public override string Message
		{
			get
			{
				return $"Not valid base: {this.errorBase}";
			}
		}
	}

	public static class BaseConverter
	{
		public static string ConvertBase(string value, ValidBases fromBase, ValidBases toBase)
		{
			BaseConverter.ValidateBase(fromBase);
			BaseConverter.ValidateBase(toBase);

			// Convert string representation with "fromBase" base to a 32-bit
			// Integer.
			int valueConvertedFromBase = Convert.ToInt32(value, (int)fromBase);

			// Return the 32-bit Integer string representation with the given
			// base.
			return Convert.ToString(valueConvertedFromBase, (int)toBase);
		}

		static private void ValidateBase(ValidBases givenBase)
		{
			if (!Enum.IsDefined(typeof(ValidBases), givenBase))
				throw new NotValidBaseException(givenBase.ToString());
		}
	}
}
