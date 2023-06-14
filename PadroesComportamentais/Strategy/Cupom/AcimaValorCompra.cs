using Design_Pattern.PadroesComportamentais.Strategy.Interface;

namespace Design_Pattern.PadroesComportamentais.Strategy.Cupom
{
    public class AcimaValorCompra : IDescontoStrategy
    {
        public void AplicarDesconto(Order order)
        {
            order.TotalAmount = order.TotalAmount - (order.TotalAmount * 40 / 100);

            Console.WriteLine($"Total do Pedido:{order.TotalAmount}");
        }
    }
}
