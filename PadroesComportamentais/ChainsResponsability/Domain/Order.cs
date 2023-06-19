using System.Net;
using System.Reflection.Metadata;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain
{
    public class Order
    {
        public record Notification(string message, bool valid);
        public List<Notification> Notifications = new List<Notification>();
        public Guid OrderId { get; private set; }
        public DateTime? OrderDate { get; private set; }
        public decimal Amount { get; set; }

        public Order(Guid orderId, DateTime? orderDate, decimal amount)
        {
            if (orderId == Guid.Empty)
                Notifications.Add(new Notification($"Order Id: {orderId} is invalid ", false));

            if (orderDate == null)
                Notifications.Add(new Notification($"orderDate: {orderId} is not be null ", false));

            if (Amount == 0)
                Notifications.Add(new Notification($"Amount: {orderId} shoud be greter 0 ", false));

            OrderId = orderId;
            OrderDate = orderDate;
            Amount = amount;
        }


    }
}
