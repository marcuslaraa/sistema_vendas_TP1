using sistema_vendas_TP1.model;
using sistema_vendas_TP1.repository;

namespace sistema_vendas_TP1.Repository
{
  public class ClientRepository : BaseRepository<Client>
  {
    private static ClientRepository _instance;

    private ClientRepository() : base()
    {
    }

    public static ClientRepository Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new ClientRepository();
        }
        return _instance;
      }
    }
  }
}
