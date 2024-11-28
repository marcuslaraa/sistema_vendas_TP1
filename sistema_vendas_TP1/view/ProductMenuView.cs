using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.view
{
  public class ProductMenuView
  {
    public static void show()
    {
      bool running = true;
      while (running)
      {
        Console.Clear();
        Console.WriteLine("Menu de Produtos");
        Console.WriteLine();
        Console.WriteLine("1. Cadastrar Produto");
        Console.WriteLine("2. Buscar Produto por Código");
        Console.WriteLine("3. Listar Produto");
        Console.WriteLine("4. Deletar Produto por Código");
        Console.WriteLine("5. Voltar ao Menu Principal");
        Console.Write("Selecione uma opção: ");

        string choice = Console.ReadLine();
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