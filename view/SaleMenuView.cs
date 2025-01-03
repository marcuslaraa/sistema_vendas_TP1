using System.Globalization;
using sistema_vendas_TP1.controller;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;
using sistema_vendas_TP1.utils;

namespace sistema_vendas_TP1.view
{
  public class SaleMenuView
  {

    private static readonly SaleController saleController = new SaleController(SaleRepository.Instance);
    private static readonly ClientController clientController = new ClientController(ClientRepository.Instance);
    private static readonly ProductController productController = new ProductController(ProductRepository.Instance);
    public static void show()
    {
      bool running = true;
      while (running)
      {
        //Console.Clear();
        Console.WriteLine("Menu de Vendas");
        Console.WriteLine();
        Console.WriteLine("1. Cadastrar Venda");
        Console.WriteLine("2. Buscar Venda por Código");
        Console.WriteLine("3. Listar Vendas");
        Console.WriteLine("4. Total de Vendas");
        Console.WriteLine("5. Voltar ao Menu Principal");
        Console.Write("Selecione uma opção: ");

        string choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            CreateSale();
            break;
          case "2":
            FindSaleByCode();
            break;
          case "3":
            ListSales();
            break;
          case "4":
            TotalValueSales();
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

    private static void CreateSale()
    {
      List<ProductSale> productSales = new List<ProductSale>();
      int countProductsCode = 0;

      // Console.Clear();
      Console.WriteLine("Cadastrar Venda");
      Console.Write("Insira o código do cliente: ");

      string clientCode = Console.ReadLine().ToUpper();

      Client clientExist = clientController.GetByCode(clientCode);

      if (clientExist == null)
      {
        Console.Clear();
        Console.WriteLine("Cliente não existe!");
        Console.WriteLine("Pressione qualquer tecla para voltar o menu...");
        Console.ReadKey();
        return;
      }

      while (true)
      {
        Console.Write($"Insira o código do produto ou '0' para finalizar: ");
        string productCode = Console.ReadLine().ToUpper();


        if (productCode == "0")
        {
          break;
        }

        Product product = productController.GetByCode(productCode);
        while (product == null)
        {
          Console.WriteLine("Produto não existe!");
          Console.Write("Insira um código de produto válido ou '0' para finalizar: ");
          productCode = Console.ReadLine().ToUpper();

          if (productCode == "0")
          {
            break;
          }

          product = productController.GetByCode(productCode);
        }

        ProductSale existingProductSale = productSales.Find(ps => ps.ProductCode == productCode);
        if (existingProductSale != null)
        {
          existingProductSale.Quantity++;
        }
        else
        {
          productSales.Add(new ProductSale { ProductCode = productCode, Quantity = 1, Price = product.Price });
        }

        countProductsCode++;


      }

      if (productSales.Count == 0)
      {
        Console.WriteLine("Venda não cadastrada! Nenhum produto foi adicionado.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        return;
      }

      Sale sale = new Sale(clientCode, productSales);
      saleController.Create(sale);
      Console.WriteLine("Venda cadastrada com sucesso!");
    }

    private static void ListSales()
    {
      Console.WriteLine();
      Console.WriteLine("Listar Vendas");

      List<Sale> sales = saleController.GetAll();

      if (sales.Count == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Nenhuma venda cadastrada.");
        Console.WriteLine();
        return;
      }

      foreach (Sale sale in sales)
      {
        Console.WriteLine(sale.ToString());
        Console.WriteLine("----------");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void FindSaleByCode()
    {
      Console.Clear();
      Console.WriteLine("Buscar venda por Código");
      Console.Write("Insira o código: ");
      string code = Console.ReadLine().ToUpper();
      Sale sale = saleController.GetByCode(code);
      if (sale != null)
      {
        Console.WriteLine(sale.ToString());
      }
      else
      {
        Console.WriteLine("Venda não encontrada!");
      }
    }

    private static void TotalValueSales()
    {
      double totalValue = 0;
      int countTotalSales = 0;
      List<Sale> sales = saleController.GetAll();
      foreach (Sale sale in sales)
      {
        totalValue += sale.TotalValue;
        countTotalSales++;
      }
      Console.WriteLine($"Total de Vendas: {countTotalSales}");
      Console.WriteLine($"Valor Total: {Format.FormatToBRL(totalValue)}");

      Console.WriteLine();

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }
  }
}
