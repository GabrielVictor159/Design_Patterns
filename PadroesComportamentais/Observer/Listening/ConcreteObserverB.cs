using Design_Pattern.PadroesComportamentais.Observer.Listening.Interfaces;

namespace Design_Pattern.PadroesComportamentais.Observer.Listening
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer B received: " + message);
        }
    }
}