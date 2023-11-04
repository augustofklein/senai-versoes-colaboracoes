using System;

namespace AtividadeCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço");
            string endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física(F) ou Jurídica(J)");
            string tipoCliente = Console.ReadLine();

            switch(tipoCliente)
            {
                case "F":
                    PessoaFisica pessoaFisica = new PessoaFisica();
                    pessoaFisica.Nome = nome;
                    pessoaFisica.Endereco = endereco;

                    Console.WriteLine("Informe o CPF");
                    pessoaFisica.Cpf = Console.ReadLine();

                    Console.WriteLine("Informe o RG");
                    pessoaFisica.Rg = Console.ReadLine();

                    Console.WriteLine("Informe o Valor da Compra");
                    float valorCompraPF = float.Parse(Console.ReadLine());

                    pessoaFisica.PagarImposto(valorCompraPF);

                    Console.WriteLine("---------- Pessoa Física ----------");
                    Console.WriteLine("Nome ..........: " + pessoaFisica.Nome);
                    Console.WriteLine("Endereco ......: " + pessoaFisica.Endereco);
                    Console.WriteLine("CPF ...........: " + pessoaFisica.Cpf);
                    Console.WriteLine("CPF ...........: " + pessoaFisica.Rg);
                    Console.WriteLine("Valor da Compra: " + pessoaFisica.Valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pessoaFisica.ValorImposto.ToString("C"));
                    Console.WriteLine("Valor a Pagar .: " + pessoaFisica.Total.ToString("C"));
                    
                    break;

                case "J":
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();

                    Console.WriteLine("Informe o CNPJ");
                    pessoaJuridica.Cnpj = Console.ReadLine();

                    Console.WriteLine("Informe a IE");
                    pessoaJuridica.Ie = Console.ReadLine();

                    Console.WriteLine("Informe o Valor da Compra");
                    float valorCompraPJ = float.Parse(Console.ReadLine());

                    pessoaJuridica.PagarImposto(valorCompraPJ);

                    Console.WriteLine("---------- Pessoa Jurídica ----------");
                    Console.WriteLine("Nome ..........: " + pessoaJuridica.Nome);
                    Console.WriteLine("Endereco ......: " + pessoaJuridica.Endereco);
                    Console.WriteLine("CNPJ ..........: " + pessoaJuridica.Cnpj);
                    Console.WriteLine("IE ............: " + pessoaJuridica.Ie);
                    Console.WriteLine("Valor da Compra: " + pessoaJuridica.Valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pessoaJuridica.ValorImposto.ToString("C"));
                    Console.WriteLine("Valor a Pagar .: " + pessoaJuridica.Total.ToString("C"));

                    break;

                default:
                    Console.WriteLine("Tipo de cliente incorreto!");
                    break;

            }
        }
    }
}