namespace ModelsPatterns.Behavioral.Observable
{
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
