namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Product
{
    public class Bicycle : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Bicycle on the box");
        }
    }
}
