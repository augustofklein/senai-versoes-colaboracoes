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

            Console.WriteLine("Pessoa Física(1) ou Jurídica(2)");
            string tipoCliente = Console.ReadLine();

            EnumCliente enumCliente = (EnumCliente)Enum.Parse(typeof(EnumCliente), tipoCliente);

            switch(enumCliente)
            {
                case EnumCliente.PessoaFisica:
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

                    Console.WriteLine(pessoaFisica.ToString());
                    
                    break;

                case EnumCliente.PessoaJuridica:
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();

                    Console.WriteLine("Informe o CNPJ");
                    pessoaJuridica.Cnpj = Console.ReadLine();

                    Console.WriteLine("Informe a IE");
                    pessoaJuridica.Ie = Console.ReadLine();

                    Console.WriteLine("Informe o Valor da Compra");
                    float valorCompraPJ = float.Parse(Console.ReadLine());

                    pessoaJuridica.PagarImposto(valorCompraPJ);

                    Console.WriteLine(pessoaJuridica.ToString());

                    break;

                default:
                    Console.WriteLine("Tipo de cliente incorreto!");
                    break;

            }
        }
    }
}