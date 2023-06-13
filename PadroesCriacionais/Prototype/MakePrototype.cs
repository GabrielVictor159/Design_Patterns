using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesCriacionais.Prototype
{
    public class MakePrototype
    {
        public static void make()
        {
            var Pedido1 = new Pedidos() { DataDeCriação = DateTime.Now, Valor = 50 };
            var Pedido2 = Pedido1.Clone() as Pedidos;
            Pedido2.Valor = 80;
            Console.WriteLine($"Os valores da Pedido1: Id = {Pedido1.Id}, Data De Criação = {Pedido1.DataDeCriação}, Valor = {Pedido1.Valor}");
            Console.WriteLine($"Os valores da Pedido2: Id = {Pedido2.Id}, Data De Criação = {Pedido2.DataDeCriação}, Valor = {Pedido2.Valor}");
        }
    }
}