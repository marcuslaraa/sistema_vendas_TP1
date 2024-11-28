using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Collections.Generic;
using sistema_vendas_TP1.model;

namespace sistema_vendas_TP1.controller
{
    public interface IClientController
    {
        void CreateClient(string nome, int idade, string cpf);
        Client GetClientByCode(string code);
        string GetClients();
        bool DeleteClientByCode(string code);
    }
}