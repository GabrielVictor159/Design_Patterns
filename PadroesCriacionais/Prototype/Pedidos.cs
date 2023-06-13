
namespace Design_Patterns.PadroesCriacionais
{
    using System;
    public class Pedidos : ICloneable
    {
        public Guid Id = Guid.NewGuid();
        public DateTime DataDeCriação { get; set; }
        public Decimal Valor { get; set; }
        public object Clone()
               => MemberwiseClone();
    }
}