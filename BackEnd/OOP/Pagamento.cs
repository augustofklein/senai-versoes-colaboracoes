namespace OOP
{
    class Pagamento : IPagamento
    {
        public string CodigoDeBarras { get; set; }

        public void Pagar(double valor)
        {
            // Implementação do código do pagamento
        }
    }

    interface IPagamento
    {
        string CodigoDeBarras { get; set; }

        void Pagar(double valor);
    }
}