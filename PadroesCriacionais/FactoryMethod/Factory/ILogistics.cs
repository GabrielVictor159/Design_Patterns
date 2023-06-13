
using Design_Patterns.PadroesCriacionais.FactoryMethod.Product;

namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Factory
{
    public interface ILogistics
    {
        ITransport CreateTransport(TransportType type);
    }
}
