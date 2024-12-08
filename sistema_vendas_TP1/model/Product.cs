using System.Text;
using sistema_vendas_TP1.utils;

namespace sistema_vendas_TP1.model
{
  public class Product : IGenericProps
  {
    public string Code { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product(string brand, string model, string description, double price)
    {
      Code = GenerateCodeClass.GenerateCode("P");
      Brand = brand;
      Model = model;
      Description = description;
      Price = price;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Código: {Code}");
      sb.AppendLine($"Marca: {Brand}");
      sb.AppendLine($"Modelo: {Model}");
      sb.AppendLine($"Descrição: {Description}");
      sb.AppendLine($"Preço: {Format.FormatToBRL(Price)}");

      return sb.ToString();
    }
  }
}