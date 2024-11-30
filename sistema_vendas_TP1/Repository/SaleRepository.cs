using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.Repository
{
  public class SaleRepository
  {
    private List<Sale> _sales = new List<Sale>();

    public void addSale(Sale sale)
    {
      _sales.Add(sale);
    }

    public string getAllSales()
    {
      StringBuilder sb = new StringBuilder();

      foreach (var sale in _sales)
      {
        sb.AppendLine(sale.ToString());
        sb.AppendLine("----------");
      }

      return sb.ToString();
    }

    public Sale getSaleByCode(int code)
    {
      Sale sale = _sales.Find(s => s.Code == code);
      if (sale == null)
      {
        throw new Exception($"Venda não encontrada com o código {code}");
      }
      return sale;
    }


  }
}