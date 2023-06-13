namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Product
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by ship on the container");

        }
    }
}
