namespace sistema_vendas_TP1.utils
{
	public static class GenerateCodeClass
	{
		private static int _countCodeClient = 0;
		private static int _countCodeProduct = 0;
		private static int _countCodeSale = 0;
		public static string GenerateCode(string prefix)
		{

			switch (prefix)
			{
				case "C":
					return GenerateCodeClient(prefix);
				case "P":
					return GenerateCodeProduct(prefix);
				case "S":
					return GenerateCodeSale(prefix);
				default:
					return null;
			}
		}

		private static string GenerateCodeClient(string prefix)
		{
			_countCodeClient++;
			return $"{prefix}{_countCodeClient:D4}";
		}

		private static string GenerateCodeProduct(string prefix)
		{
			_countCodeProduct++;
			return $"{prefix}{_countCodeProduct:D4}";
		}

		private static string GenerateCodeSale(string prefix)
		{
			_countCodeSale++;
			return $"{prefix}{_countCodeSale:D4}";
		}
	}
}