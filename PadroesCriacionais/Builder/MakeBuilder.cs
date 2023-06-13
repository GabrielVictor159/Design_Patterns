using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;

namespace Design_Patterns.PadroesCriacionais.Builder
{
    public class MakeBuilder
    {
        public static void make()
        {
            Faker faker = new Faker("pt_BR");
            for (int i = 0; i < 3; i++)
            {
                var car = CarBuilder.New(faker).Build();
                car.DisplayInfo(i);
            }
            var car3 = CarBuilder.New(faker).WithColor("CorAlterada").WithYear(2038).Build();
            car3.DisplayInfo(3);
        }
    }
}