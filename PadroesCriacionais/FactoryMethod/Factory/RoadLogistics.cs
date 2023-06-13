using Design_Patterns.PadroesCriacionais.FactoryMethod.Product;

namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Factory
{
    public class RoadLogistics : ILogistics
    {
        public ITransport CreateTransport(TransportType type)
        {
            return type switch
            {
                TransportType.Truck => new Truck(),
                TransportType.Motocycle => new MotoCycle(),
                TransportType.Bicycle => new Bicycle(),
                _ => throw new NotImplementedException(nameof(TransportType))
            };
        }
    }
}
