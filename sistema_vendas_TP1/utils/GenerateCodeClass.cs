using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.utils
{
	public static class GenerateCodeClass
	{
		public static string GenerateCode(string prefix, int code)
		{
			code++;
			return $"{prefix}{code:D4}";
		}

		public static string CleanCpf(string cpf)
		{
			return Regex.Replace(cpf, @"[.\-]", "");
		}

	}

}