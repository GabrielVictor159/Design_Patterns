using Design_Pattern.PadroesComportamentais.Observer.Listening.Interfaces;

namespace Design_Pattern.PadroesComportamentais.Listening
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer A received: " + message);
        }
    }
}