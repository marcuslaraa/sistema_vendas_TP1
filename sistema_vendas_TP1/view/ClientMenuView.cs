using System;

namespace sistema_vendas_TP1.view
{
  public static class ClientMenuView
  {
    public static void Show()
    {
      bool running = true;
      while (running)
      {
        Console.Clear();
        Console.WriteLine("Menu de Clientes");
        Console.WriteLine();
        Console.WriteLine("1. Cadastrar Cliente");
        Console.WriteLine("2. Buscar Cliente por Código");
        Console.WriteLine("3. Listar Clientes");
        Console.WriteLine("4. Deletar Cliente por Código");
        Console.WriteLine("5. Voltar ao Menu Principal");
        Console.Write("Selecione uma opção: ");

        string? choice = Console.ReadLine();
        switch (choice)
        {
          case "1":

            break;
          case "2":

            break;
          case "3":

            break;
          case "4":

            break;
          case "5":
            running = false;
            Console.WriteLine();
            break;
          default:
            Console.WriteLine("Opção inválida! Por favor, tente novamente.");
            break;
        }
      }
    }
  }
}