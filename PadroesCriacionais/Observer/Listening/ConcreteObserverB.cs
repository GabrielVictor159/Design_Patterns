using Observer.Listening.Interfaces;

namespace Design_Patterns.PadroesCriacionais.Observer.Listening
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer B received: " + message);
        }
    }
}