namespace AtividadeCliente
{
    class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public override string ToString()
        {
            string newLine = Environment.NewLine;

            return "---------- Pessoa Física ----------" + newLine +
                   "Nome ..........: " + Nome + newLine +
                   "Endereco ......: " + Endereco + newLine +
                   "CPF ...........: " + Cpf + newLine +
                   "RJ ............: " + Rg + newLine +
                   "Valor da Compra: " + Valor.ToString("C") + newLine +
                   "Imposto .......: " + ValorImposto.ToString("C") + newLine +
                   "Valor a Pagar .: " + Total.ToString("C");
        }
    }
}