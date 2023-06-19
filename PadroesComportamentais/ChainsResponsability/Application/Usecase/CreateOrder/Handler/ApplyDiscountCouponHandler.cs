﻿using Design_Pattern.PadroesComportamentais.ChainsResponsability.Domain;

namespace Design_Pattern.PadroesComportamentais.ChainsResponsability.Application.Usecase.CreateOrder
{
    public class ApplyDiscountCouponHandler : Handler
    {
        public override void ProcessRequest(Order order, string coupon)
        {
            Console.WriteLine("ApplyDiscountCouponHandler");

            nextHander?.ProcessRequest(order, coupon);
        }
    }
}
