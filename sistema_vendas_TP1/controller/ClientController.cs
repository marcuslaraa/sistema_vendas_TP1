using System.Collections.Generic;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.repository;

namespace sistema_vendas_TP1.controller
{
    public class ClientController : IClientController
    {
        private readonly IClientRepository clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public void CreateClient(string nome, int idade, string cpf)
        {
            Client newClient = new Client(nome, idade, cpf);
            clientRepository.CreateClient(newClient);
        }

        public Client GetClientByCode(string code)
        {
            return clientRepository.GetClientByCode(code);
        }

        public List<Client> GetClients()
        {
            return clientRepository.GetAllClients();
        }

        public bool DeleteClientByCode(string code)
        {
            return clientRepository.DeleteClientByCode(code);
        }
    }
}