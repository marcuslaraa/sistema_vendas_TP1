using System;
using sistema_vendas_TP1.controller;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.view
{
  public static class ClientMenuView
  {

    private static readonly IClientController clientController = new ClientController(new ClientRepository());

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

        string choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            createClient();
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

      clientController.CreateClient(name, age, cpf);

      Console.WriteLine("Cliente cadastrado com sucesso!");
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
      Console.ReadKey();
    }
  }
}