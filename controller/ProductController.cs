using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.controller
{
    public class ProductController : BaseController<Product>
    {
        public ProductController(Repository.ProductRepository productRepository) : base(productRepository)
        {
        }
    }
}