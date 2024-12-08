using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_vendas_TP1.controller;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.view
{
  public class ProductMenuView
  {

    private static readonly controller.ProductController productController = new controller.ProductController(Repository.ProductRepository.Instance);
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
            CreateProduct();
            break;
          case 2:
            FindProductByCode();
            break;
          case 3:
            ListProducts();
            break;
          case 4:
            DeleteProductByCode();
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

    private static void CreateProduct()
    {
      Console.Clear();
      Console.WriteLine("Cadastrar Produto");
      Console.Write("Marca: ");
      string brand = Console.ReadLine();
      Console.Write("Modelo: ");
      string model = Console.ReadLine();
      Console.WriteLine("Descrição: ");
      string description = Console.ReadLine();
      Console.Write("Preço: ");
      double price = double.Parse(Console.ReadLine());

      Product product = new Product(brand, model, description, price);
      productController.Create(product);
    }

    private static void FindProductByCode()
    {
      Console.Clear();
      Console.WriteLine("Buscar Produto por Código");
      Console.Write("Insira o código: ");
      string code = Console.ReadLine().ToUpper();
      Product product = productController.GetByCode(code);
      if (product != null)
      {
        Console.WriteLine(product.ToString());
      }
      else
      {
        Console.WriteLine("Produto não encontrado!");
      }
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void ListProducts()
    {
      Console.Clear();
      Console.WriteLine("Listar Produtos");
      List<Product> products = productController.GetAll();
      if (products.Count == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Nenhum produto cadastrado.");
        Console.WriteLine();
        return;
      }
      foreach (Product product in products)
      {
        Console.WriteLine(product.ToString());
        Console.WriteLine("----------");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void DeleteProductByCode()
    {
      Console.Clear();
      Console.WriteLine("Deletar Produto por Código");
      Console.Write("Insira o código: ");
      string code = Console.ReadLine().ToUpper();
      bool success = productController.DeleteByCode(code);
      if (success)
      {
        Console.WriteLine("Produto deletado com sucesso!");
      }
      else
      {
        Console.WriteLine("Produto não encontrado!");
      }
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }
  }
}