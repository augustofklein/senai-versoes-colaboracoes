namespace AtividadeCliente
{
    class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public override void PagarImposto(float valor)
        {
            Valor = valor;
            ValorImposto = valor * 20/100;
            Total = Valor + ValorImposto;
        }

        public override string ToString()
        {
            string newLine = Environment.NewLine;

            return "---------- Pessoa Jurídica ----------" + newLine +
                   "Nome ..........: " + Nome + newLine +
                   "Endereco ......: " + Endereco + newLine +
                   "CNPJ ..........: " + Cnpj + newLine +
                   "IE ............: " + Ie + newLine +
                   "Valor da Compra: " + Valor.ToString("C") + newLine +
                   "Imposto .......: " + ValorImposto.ToString("C") + newLine +
                   "Valor a Pagar .: " + Total.ToString("C");
        }
    }
}