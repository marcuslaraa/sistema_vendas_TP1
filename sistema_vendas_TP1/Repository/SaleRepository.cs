using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.repository;

namespace sistema_vendas_TP1.Repository
{
  public class SaleRepository : BaseRepository<Sale>
  {
    private static SaleRepository _instance;

    private SaleRepository() : base()
    {
    }

    public static SaleRepository Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new SaleRepository();
        }
        return _instance;
      }
    }

  }

}