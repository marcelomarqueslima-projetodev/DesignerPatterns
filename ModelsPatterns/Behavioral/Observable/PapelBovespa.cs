namespace ModelsPatterns.Behavioral.Observable
{
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco)
            : base(simbolo, preco)
        {
        }
    }
}
