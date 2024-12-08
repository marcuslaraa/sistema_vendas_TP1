using sistema_vendas_TP1.utils;

namespace sistema_vendas_TP1.model
{
    public class ProductSale
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Código do Produto: {ProductCode} - Quantidade: {Quantity} - Preço: {Format.FormatToBRL(Price)}";
        }
    }
}