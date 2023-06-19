using Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability
{
    public abstract class Handler
    {
        public Handler? nextHander;

        public Handler SetNext(Handler handler)
        {
            nextHander = handler;

            return handler;
        }

        public abstract void ProcessRequest(Order order, string coupon);
       
    }
}
