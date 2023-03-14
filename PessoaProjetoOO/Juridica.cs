using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaProjetoOO
{
    internal class Juridica : Pessoa
    {
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        public override void SerPessoa()
        {
            Console.WriteLine("Olá sou uma pessoa JURIDICA!");
        }

        public override string ToString()
        {
            return Nome + " " + NomeFantasia + " " + Cpf + " " + Cnpj + " " + Endereco + " " + Email + " " + Telefone1 + " " + Telefone2;
        }
    }
}
