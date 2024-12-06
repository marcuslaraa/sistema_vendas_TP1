using System.Text;
using sistema_vendas_TP1.utils;

namespace sistema_vendas_TP1.model
{
  public class Client : IGenericProps
  {
    private static int _count = 0;
    public string Code { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Cpf { get; set; }

    public Client(string name, int age, string cpf)
    {
      Code = GenerateCodeClass.GenerateCode("P", _count);
      Name = name;
      Age = age;
      Cpf = cpf;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Código: {Code}");
      sb.AppendLine($"Nome: {Name}");
      sb.AppendLine($"Idade: {Age}");
      sb.AppendLine($"CPF: {Cpf}");

      return sb.ToString();
    }
  }
}
