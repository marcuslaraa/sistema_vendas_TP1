using System;
using sistema_vendas_TP1.controller;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.view
{
  public static class ClientMenuView
  {

    private static readonly ClientController clientController = new ClientController(new ClientRepository());

    public static void Show()
    {
      bool running = true;
      while (running)
      {
        // Console.Clear();
        Console.WriteLine("Menu de Clientes");
        Console.WriteLine();
        Console.WriteLine("1. Cadastrar Cliente");
        Console.WriteLine("2. Buscar Cliente por Código");
        Console.WriteLine("3. Listar Clientes");
        Console.WriteLine("4. Deletar Cliente por Código");
        Console.WriteLine("5. Voltar ao Menu Principal");
        Console.Write("Selecione uma opção: ");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            createClient();
            break;
          case 2:
            SearchClientByCode();
            break;
          case 3:
            ListClients();
            break;
          case 4:
            DeleteClientByCode();
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

    private static void createClient()
    {
      Console.Clear();
      Console.WriteLine("Cadastrar Cliente");
      Console.Write("Nome: ");
      string name = Console.ReadLine();
      Console.Write("Idade: ");
      int age = int.Parse(Console.ReadLine() ?? "0");
      Console.Write("CPF: ");
      string cpf = Console.ReadLine();

      Client client = new Client(name, age, cpf);
      clientController.Create(client);

      Console.WriteLine("Cliente cadastrado com sucesso!");
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void SearchClientByCode()
    {
      Console.Clear();
      Console.WriteLine("Buscar Cliente por Código");
      Console.Write("Insira o código: ");
      string code = Console.ReadLine();

      var client = clientController.GetByCode(code);
      if (client != null)
      {
        Console.WriteLine(client.ToString());
      }
      else
      {
        Console.WriteLine("Cliente não encontrado.");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void ListClients()
    {
      Console.Clear();
      Console.WriteLine("Listar Clientes");
      List<Client> clients = clientController.GetAll();
      if (clients.Count == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Nenhum cliente cadastrado.");
        Console.WriteLine();
        return;
      }
      foreach (var client in clients)
      {
        Console.WriteLine(client.ToString());
        Console.WriteLine("----------");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }

    private static void DeleteClientByCode()
    {
      Console.Clear();
      Console.WriteLine("Deletar Cliente por Código");
      Console.Write("Código: ");
      string code = Console.ReadLine();

      bool success = clientController.DeleteByCode(code);
      if (success)
      {
        Console.WriteLine("Cliente deletado com sucesso.");
      }
      else
      {
        Console.WriteLine("Cliente não encontrado.");
      }

      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }
  }
}