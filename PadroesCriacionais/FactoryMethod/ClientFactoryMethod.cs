using Design_Patterns.PadroesCriacionais.FactoryMethod.Factory;
using Design_Patterns.PadroesCriacionais.FactoryMethod.Product;

namespace Design_Patterns.PadroesCriacionais.FactoryMethod
{
    public class ClientFactoryMethod
    {
        public static void Delivery(LogisticsType type, TransportType transportType)
        {
            ILogistics factory;

            if (type == LogisticsType.Sea)
                factory = new SeaLogistics();
            else
                factory = new RoadLogistics();

            var transport = factory.CreateTransport(transportType);
            transport.Deliver();

        }
    }
}
