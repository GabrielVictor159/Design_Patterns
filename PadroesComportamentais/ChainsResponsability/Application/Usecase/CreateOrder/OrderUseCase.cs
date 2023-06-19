using Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability.Application.Usecase.CreateOrder
{
    public class OrderUseCase
    {
        private readonly ValidateOrderHandler validateOrderHandler;
        public OrderUseCase()
        {
            validateOrderHandler = new ValidateOrderHandler();
            validateOrderHandler
                .SetNext(new ApplyDiscountCouponHandler())
                .SetNext(new SaveOrderHandler())
                .SetNext(new NotifcationCustomerHandler());
               
        }

        public void Execute()
        {
            var order = new Order(Guid.NewGuid(), DateTime.UtcNow, 1000);
            validateOrderHandler.ProcessRequest(order, "blackfriday");

        }
    }
}
