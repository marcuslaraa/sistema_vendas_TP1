using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_vendas_TP1.utils;

namespace sistema_vendas_TP1.model
{
  public class Sale : IGenericProps
  {
    private static int _count = 0;
    public string Code { get; private set; }
    public string ClientCode { get; set; }
    public List<string> ProductCodes { get; set; }
    public double TotalValue { get; private set; }

    public Sale(string clientCode, List<string> productCodes)
    {
      Code = GenerateCodeClass.GenerateCode("S", _count);
      ClientCode = clientCode;
      ProductCodes = productCodes;
      TotalValue = 0;
    }

    // private string GenerateCode()
    // {
    //   _count++;
    //   return $"S{_count:D4}";
    // }

    public void AddProduct(string productCode, double productPrice)
    {
      ProductCodes.Add(productCode);
      TotalValue += productPrice;
    }

    public void CalculateTotalValue(double productPrice)
    {
      TotalValue += productPrice;
    }

    public override string ToString()
    {
      int index = 1;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Código: {Code}");
      sb.AppendLine($"Código do Cliente: {ClientCode}");
      foreach (string productCode in ProductCodes)
      {
        if (productCode != "0")
        {
          sb.AppendLine($"Código do Produto {index}: {string.Join(", ", productCode)}");
        }
        index++;
      }
      sb.AppendLine($"Valor Total: {TotalValue}");

      return sb.ToString();
    }
  }
}
