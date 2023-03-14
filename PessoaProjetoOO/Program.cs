using PessoaProjetoOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Fisica fisica = new Fisica();
        Console.WriteLine("Qual seu nome?");
        fisica.Nome = Console.ReadLine();
        Console.WriteLine("Qual seu cpf?");
        fisica.Cpf = Console.ReadLine();
        Console.WriteLine("Qual seu endereço?");
        fisica.Endereco = Console.ReadLine();
        Console.WriteLine("Qual seu email?");
        fisica.Email = Console.ReadLine();
        Console.WriteLine("Qual seu telefone 1?");
        fisica.Telefone1 = Console.ReadLine();
        Console.WriteLine("Qual seu telefone 2?");
        fisica.Telefone2 = Console.ReadLine();
        fisica.SerPessoa();
        Console.WriteLine(fisica.ToString());

        Juridica juridica = new Juridica();
        Console.WriteLine("Qual seu nome?");
        juridica.Nome = Console.ReadLine();
        Console.WriteLine("Qual seu nome fantasia?");
        juridica.NomeFantasia = Console.ReadLine();
        Console.WriteLine("Qual seu cnpj?");
        juridica.Cnpj = Console.ReadLine();
        Console.WriteLine("Qual seu endereço?");
        juridica.Endereco = Console.ReadLine();
        Console.WriteLine("Qual seu email?");
        juridica.Email = Console.ReadLine();
        Console.WriteLine("Qual seu telefone 1?");
        juridica.Telefone1 = Console.ReadLine();
        Console.WriteLine("Qual seu telefone 2?");
        juridica.Telefone2 = Console.ReadLine();
        juridica.SerPessoa();
        Console.WriteLine(juridica.ToString());

    }
}