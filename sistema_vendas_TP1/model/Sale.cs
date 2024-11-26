using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.model
{
  public class Sale
  {

  }
}
public class Sale
{
  private static int _count = 0;
  public int Code { get; private set; }
  public string ClientCode { get; set; }
  public List<string> ProductCodes { get; set; }
  public double TotalValue { get; private set; }

  public Sale(string clientCode)
  {
    Code = generateCode();
    ClientCode = clientCode;
    ProductCodes = new List<string>();
    TotalValue = 0;
  }

  private int generateCode()
  {
    return ++_count;
  }

  public void addProduct(string productCode, double productPrice)
  {
    ProductCodes.Add(productCode);
    TotalValue += productPrice;
  }

  public void calculateTotalValue(double productPrice)
  {
    TotalValue += productPrice;
  }

  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.AppendLine($"Código: {Code}");
    sb.AppendLine($"Código do Cliente: {ClientCode}");
    sb.AppendLine($"Códigos dos Produtos: {string.Join(", ", ProductCodes)}");
    sb.AppendLine($"Valor Total: {TotalValue}");

    return sb.ToString();
  }
}