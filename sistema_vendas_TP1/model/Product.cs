using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas_TP1.model
{
    public class Product
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string brand, string model, string description, double price)
        {
            Code = Guid.NewGuid().ToString();
            Brand = brand;
            Model = model;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Código: {Code}");
            sb.AppendLine($"Marca: {Brand}");
            sb.AppendLine($"Modelo: {Model}");
            sb.AppendLine($"Descrição: {Description}");
            sb.AppendLine($"Preço: {Price}");

            return sb.ToString();
        }
    }
}