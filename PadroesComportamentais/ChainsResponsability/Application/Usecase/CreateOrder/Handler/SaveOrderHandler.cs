using Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability.Application.Usecase.CreateOrder
{
    public class SaveOrderHandler : Handler
    {
        public override void ProcessRequest(Order order, string coupon)
        {
            Console.WriteLine("SaveOrderHandler");

            nextHander?.ProcessRequest(order, coupon);
        }
    }
}
