namespace ModelsPatterns.Structural.Facade.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
