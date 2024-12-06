using sistema_vendas_TP1.controller;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.view
{
  public class SaleMenuView
  {

    private static readonly SaleController saleController = new SaleController(new SaleRepository());
    private static readonly ClientRepository clientRepository = new ClientRepository();
    public static void show()
    {
      bool running = true;
      while (running)
      {
        Console.Clear();
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
      List<string> productCodes = new List<string>();
      int countProductsCode = 0;

      Console.Clear();
      Console.WriteLine("Cadastrar Venda");
      Console.Write("Insira o código do cliente: ");

      string clientCode = Console.ReadLine();

      Client clientExist = clientRepository.GetByCode(clientCode);

      // if (clientExist == null)
      // {
      //   Console.Clear();
      //   Console.WriteLine("Cliente não existe!");
      //   Console.WriteLine("Pressione qualquer tecla para voltar o menu...");
      //   Console.ReadKey();
      //   return;
      // }

      while (true)
      {
        Console.Write($"Insira o {countProductsCode + 1}º código do produto: ");
        string addProduct = Console.ReadLine().ToUpper();
        productCodes.Add(addProduct);
        countProductsCode++;

        if (addProduct == "0")
        {
          break;
        }
      }

      Sale sale = new Sale(clientCode, productCodes);
      saleController.Create(sale);
      Console.WriteLine("Venda cadastrada com sucesso!");
    }

    private static void ListSales()
    {
      Console.Clear();
      Console.WriteLine("Listar Produtos");
      List<Sale> sales = saleController.GetAll();
      if (sales.Count == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Nenhuma venda cadastrada.");
        Console.WriteLine();
        return;
      }
      foreach (var sale in sales)
      {
        Console.WriteLine(sale.ToString());
        Console.WriteLine("----------");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static Sale FindSaleByCode()
    {
      Console.Clear();
      Console.WriteLine("Buscar Produto por Código");
      Console.Write("Insira o código: ");
      string code = Console.ReadLine();
      Sale sale = saleController.GetByCode(code);
      if (sale != null)
      {
        Console.WriteLine(sale);
      }
      else
      {
        Console.WriteLine("Venda não encontrada!");
      }
      return sale;
    }
  }
}