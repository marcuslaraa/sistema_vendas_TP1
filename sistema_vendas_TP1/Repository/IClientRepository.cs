using System.Collections.Generic;
using sistema_vendas_TP1.model;

namespace sistema_vendas_TP1.repository
{
    public interface IClientRepository
    {
        void CreateClient(Client client);
        Client GetClientByCode(string code);
        string GetAllClients();
        bool DeleteClientByCode(string code);
    }
}