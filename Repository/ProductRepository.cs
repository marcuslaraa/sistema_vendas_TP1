using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.repository;

namespace sistema_vendas_TP1.Repository
{
  public class ProductRepository : BaseRepository<Product>
  {
    private static ProductRepository _instance;

    private ProductRepository() : base()
    {
    }

    public static ProductRepository Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new ProductRepository();
        }
        return _instance;
      }
    }

  }
}