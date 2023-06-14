using Autofac;
using Autofac.Features.Indexed;
using Design_Pattern.PadroesComportamentais.Strategy.Interface;
using Design_Patterns.PadroesCriacionais.FactoryMethod.Singleton;

namespace Design_Pattern.PadroesComportamentais.Strategy
{
    public class ClientStrategy
    {
        //1- Primeira Compra:
        //2- Frete Grátis:
        //3- Acima de Um Valor de Compra:
        //4- Site Todo:
        //5- Lista de Produtos:
        //6- Exclusivo um Produto:
        //7- Exclusivo para Aplicativo:

        public static void ApplyDiscount(string coupon)
        {
            var order = new Order(Guid.NewGuid(), 1000);

            if (coupon == " Primeira Compra")
            {
                //Validar se cliente é a primeira
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 10 / 100);
            }
            else if (coupon == " Frete Grátis")
            {
                //Verifcar se cliente é de SAO PAULO
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 20 / 100);
            }
            else if (coupon == "Acima de Um Valor de Compra")
            {
                //Verificar se o cliente fez uma compra acima de 100
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 30 / 100);
            }
            else if (coupon == " Site Todo")
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 15 / 100);
            else if (coupon == " Lista de Produtos")
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 18 / 100);
            else if (coupon == " Exclusivo um Produto")
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 12 / 100);
            else if (coupon == " Exclusivo para Aplicativo")
                order.TotalAmount = order.TotalAmount - (order.TotalAmount * 50 / 100);


        }

        public static void ApplyCouponStrategy(TipoDesconto tipoDesconto)
        {
            var order = new Order(Guid.NewGuid(), 1000);
            var strategy = RegisterModule.Build().Resolve<IIndex<TipoDesconto, IDescontoStrategy>>();

            strategy[tipoDesconto].AplicarDesconto(order);
        }
    }

    public class Order
    {
        public Guid OrderId { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(Guid orderId, decimal totalAmount)
        {
            OrderId = orderId;
            TotalAmount = totalAmount;
        }

    }


}
