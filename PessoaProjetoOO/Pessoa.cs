using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaProjetoOO
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        public virtual void SerPessoa()
        {
            Console.WriteLine("Olá sou uma pessoa!");
        }

        public override string ToString()
        {
            return Nome + " " + Cpf + " " + Endereco + " " + Email + " " + Telefone1 + " " + Telefone2;
        }
    }
}
