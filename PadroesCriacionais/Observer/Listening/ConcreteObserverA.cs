using Observer.Listening.Interfaces;

namespace Design_Patterns.PadroesCriacionais.Observer.Listening
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer A received: " + message);
        }
    }
}