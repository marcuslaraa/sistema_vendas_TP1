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
    public string Code { get; private set; }
    public string ClientCode { get; set; }
    public List<ProductSale> ProductSale { get; set; }
    public double TotalValue { get; private set; }

    public Sale(string clientCode, List<ProductSale> productCodes)
    {
      Code = GenerateCodeClass.GenerateCode("S");
      ClientCode = clientCode;
      ProductSale = productCodes;
      TotalValue = CalculateTotalValue();
    }

    private double CalculateTotalValue()
    {
      double totalValue = 0;
      foreach (ProductSale product in ProductSale)
      {
        totalValue += product.Quantity * product.Price;
      }
      return totalValue;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Código: {Code}");
      sb.AppendLine($"Código do Cliente: {ClientCode}");
      foreach (ProductSale productCode in ProductSale)
      {
        if (productCode.ProductCode != "0")
        {
          sb.AppendLine(productCode.ToString());
        }
      }
      sb.AppendLine($"Valor Total: {Format.FormatToBRL(TotalValue)}");

      return sb.ToString();
    }
  }
}
