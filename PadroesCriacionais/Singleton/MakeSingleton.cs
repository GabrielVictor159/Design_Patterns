using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesCriacionais.Singleton
{
    public class MakeSingleton
    {
        public static void make()
        {
            var jogo1 = JogoDeFutebol.getJogo;
            Console.WriteLine($"O jogo 1 começou a: {jogo1.tempoDeJogo().ToString()} e a data de inicio foi: {jogo1.getInicioDaPartida().ToString()}");
            Thread.Sleep(1000);
            var jogo2 = JogoDeFutebol.getJogo;
            Console.WriteLine($"O jogo 2 começou a: {jogo2.tempoDeJogo().ToString()} e a data de inicio foi: {jogo2.getInicioDaPartida().ToString()}");
        }
    }
}