using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.view
{
  public class ProductMenuView
  {

    //  private static readonly IProductController productController = new ProductController(new ProductRepository());
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

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            createProduct();
            break;
          case 2:

            break;
          case 3:

            break;
          case 4:

            break;
          case 5:
            running = false;
            Console.WriteLine();
            break;
          default:
            Console.WriteLine("Opção inválida! Por favor, tente novamente.");
            break;
        }
      }
    }

    private static void createProduct()
    {
      Console.Clear();
      Console.WriteLine("Cadastrar Produto");
      Console.Write("Nome: ");
      string name = Console.ReadLine();
      Console.Write("Preço: ");
      double price = double.Parse(Console.ReadLine());
      Console.Write("Marca: ");
      string brand = Console.ReadLine();
      Console.Write("Modelo: ");
      string model = Console.ReadLine();
      Console.WriteLine("Descrição: ");
      string description = Console.ReadLine();

      // Product product = new Product(name, price, quantity, code);
      // productController.Create(product);
    }
  }
}