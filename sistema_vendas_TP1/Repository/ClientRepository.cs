using sistema_vendas_TP1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.Repository
{
  internal class ClientRepository
  {
    private List<Client> _clients = new List<Client>();

    public void addClient(Client client)
    {
      _clients.Add(client);
    }

    public string getAllClients()
    {
      StringBuilder sb = new StringBuilder();

      foreach (var client in _clients)
      {
        sb.AppendLine(client.ToString());
        sb.AppendLine("----------");
      }

      return sb.ToString();
    }

    public Client getClientByCode(string code)
    {
      Client? client = _clients.Find(c => c.Code == code);
      if (client == null)
      {
        throw new Exception($"Cliente não encontrado com o código {code}");
      }
      return client;
    }

    public void deleteClientByCode(string code)
    {
      Client? client = getClientByCode(code);
      if (client == null)
      {
        throw new Exception($"Cliente não encontrado com o código {code}");
      }
      _clients.Remove(client);
    }

  }
}
