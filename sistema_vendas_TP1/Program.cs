using System;
using sistema_vendas_TP1.view;

namespace SalesSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Sistema de Vendas");
      Console.WriteLine("#####################################################");
      Console.WriteLine();

      bool running = true;
      while (running)
      {
        Console.WriteLine("Menu Principal");
        Console.WriteLine();
        Console.WriteLine("1. Gerenciar Clientes");
        Console.WriteLine("2. Gerenciar Produtos");
        Console.WriteLine("3. Gerenciar Vendas");
        Console.WriteLine("4. Exit");
        Console.Write("Selecione uma opção: ");

        string? choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            ClientMenuView.Show();
            break;
          case "2":
            ProductMenuView.show();
            break;
          case "3":

            break;
          case "4":
            running = false;
            break;
          default:
            Console.WriteLine("Opção inválida! Por favor, tente novamente.");
            break;
        }
      }

      Console.WriteLine("Obrigado por usar o Sistema de Vendas!");
    }
  }
}