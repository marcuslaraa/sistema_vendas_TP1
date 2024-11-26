using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_vendas_TP1.model;

namespace sistema_vendas_TP1.Repository
{
  public class ProductRepository
  {
    private List<Product> _products = new List<Product>();

    public void addProduct(Product product)
    {
      _products.Add(product);
    }

    public string getAllProducts()
    {
      StringBuilder sb = new StringBuilder();

      foreach (var product in _products)
      {
        sb.AppendLine(product.ToString());
        sb.AppendLine("----------");
      }

      return sb.ToString();
    }

    public Product getProductByCode(string code)
    {
      Product? product = _products.Find(p => p.Code == code);
      if (product == null)
      {
        throw new Exception($"Produto não encontrado com o código {code}");
      }
      return product;
    }

    public void deleteProductByCode(string code)
    {
      Product? product = getProductByCode(code);
      if (product == null)
      {
        throw new Exception($"Produto não encontrado com o código {code}");
      }
      _products.Remove(product);
    }
  }
}