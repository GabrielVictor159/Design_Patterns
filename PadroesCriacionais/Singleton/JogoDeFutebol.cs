using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesCriacionais.Singleton
{
    public class JogoDeFutebol
    {
        private static JogoDeFutebol jogo = null;
        public static DateTime InicioDaPartida;
        public static JogoDeFutebol getJogo
        {
            get
            {
                if (jogo == null)
                {
                    jogo = new JogoDeFutebol();
                    InicioDaPartida = DateTime.Now;
                }
                return jogo;
            }
        }
        public DateTime getInicioDaPartida()
        {
            return InicioDaPartida;
        }
        public Double tempoDeJogo()
        {
            return DateTime.Now.Subtract(InicioDaPartida).TotalSeconds;
        }
    }
}