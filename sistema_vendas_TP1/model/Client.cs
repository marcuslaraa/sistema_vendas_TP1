using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuProjeto.Utils;

namespace sistema_vendas_TP1.model
{
    internal class Client
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }

        public Client(string name, int age, string cpf)
        {
            Code = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
            Cpf = cpf;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Código: {Code}");
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"Idade: {Age}");
            sb.AppendLine($"CPF: {Cpf}");

            return sb.ToString();
        }
    }
}
