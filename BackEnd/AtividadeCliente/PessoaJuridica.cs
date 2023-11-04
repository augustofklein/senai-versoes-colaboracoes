namespace AtividadeCliente
{
    class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public virtual void PagarImposto(float valor)
        {
            Valor = valor;
            ValorImposto = valor * 20/100;
            Total = Valor + ValorImposto;
        }
    }
}