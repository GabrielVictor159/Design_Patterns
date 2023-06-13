namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Product
{
    internal class MotoCycle : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by motocycle on the box");
        }
    }
}
