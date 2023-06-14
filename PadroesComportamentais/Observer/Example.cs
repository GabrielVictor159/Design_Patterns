using Design_Pattern.PadroesComportamentais.Listening;
using Design_Pattern.PadroesComportamentais.Observer.Listening;

namespace Design_Pattern.PadroesComportamentais.Observer
{
    public class ObserverMethod
    {
        public static void RunObserver(String A, String B)
        {

            Subject subject = new Subject();

            ConcreteObserverA observerA = new ConcreteObserverA();
            ConcreteObserverB observerB = new ConcreteObserverB();

            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.Notify(A);

            subject.Detach(observerB);

            subject.Notify(B);

            Console.ReadLine();
        }

    }
}