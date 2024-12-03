using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

namespace sistema_vendas_TP1.controller
{
    public class SaleController : BaseController<Sale>
    {
        public SaleController(SaleRepository saleRepository) : base(saleRepository)
        {
        }
    }
}