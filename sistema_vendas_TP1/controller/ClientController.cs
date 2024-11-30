using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.controller
{
    public class ClientController : BaseController<Client>
    {
        public ClientController(ClientRepository clientRepository) : base(clientRepository)
        {
        }
    }
}