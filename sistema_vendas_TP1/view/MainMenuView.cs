using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.view
{
  public class MainMenuView
  {
    public static void Show()
    {
      Console.Clear();
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
        Console.WriteLine("4. Encerrar Sistema");
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
            SaleMenuView.show();
            break;
          case "4":
            running = false;
            break;
          default:
            Console.WriteLine("Opção inválida! Por favor, tente novamente.");
            break;
        }
      }

      Console.WriteLine("Obrigado por usar o nosso Sistema de Vendas!");
    }
  }
}