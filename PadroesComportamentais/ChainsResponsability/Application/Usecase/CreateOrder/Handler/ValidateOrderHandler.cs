using Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability.Application.Usecase.CreateOrder
{
    public class ValidateOrderHandler : Handler
    {
        public override void ProcessRequest(Order order, string coupon)
        {
            var isInValid = false;

            if (isInValid)
            {
                Console.WriteLine(string.Join(',', order.Notifications.Select(s => s.message).ToList()));
                return;
            }
            Console.WriteLine("ValidateOrderHandler");

            nextHander?.ProcessRequest(order, coupon);
        }
    }
}
