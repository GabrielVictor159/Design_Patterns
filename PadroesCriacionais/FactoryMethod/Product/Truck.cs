namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Product
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by truck on the box");

        }
    }
}
