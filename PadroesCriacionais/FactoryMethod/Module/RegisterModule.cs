using Autofac;
using Design_Pattern.PadroesComportamentais.Strategy.Cupom;
using Design_Pattern.PadroesComportamentais.Strategy.Interface;
using Design_Patterns.PadroesCriacionais.FactoryMethod.Product;

namespace Design_Patterns.PadroesCriacionais.FactoryMethod.Singleton
{
    public class RegisterModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Bicycle>().Keyed<ITransport>(TransportType.Bicycle);
            builder.RegisterType<MotoCycle>().Keyed<ITransport>(TransportType.Motocycle);
            builder.RegisterType<Truck>().Keyed<ITransport>(TransportType.Truck);

            builder.RegisterType<PrimeiraCompra>().Keyed<IDescontoStrategy>(TipoDesconto.PrimeiraCompra);
            builder.RegisterType<FreteGratis>().Keyed<IDescontoStrategy>(TipoDesconto.FreteGratis);
            builder.RegisterType<AcimaValorCompra>().Keyed<IDescontoStrategy>(TipoDesconto.AcimaValorCompra);
            base.Load(builder);
        }

        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<RegisterModule>();

            return builder.Build();

        }
    }
}
