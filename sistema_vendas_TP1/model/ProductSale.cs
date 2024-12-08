using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.model
{
    public class ProductSale
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Código do Produto: {ProductCode} - Quantidade: {Quantity} - Preço: {Price}";
        }
    }
}