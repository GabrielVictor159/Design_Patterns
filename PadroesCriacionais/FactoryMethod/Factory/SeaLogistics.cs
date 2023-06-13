using Design_Patterns.PadroesCriacionais.FactoryMethod.Product;

namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Factory
{
    internal class SeaLogistics : ILogistics
    {
        public ITransport CreateTransport(TransportType type)
        {
            return new Ship();
        }
    }
}
