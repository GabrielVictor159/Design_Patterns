using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator
{
    public class MakeDecorator
    {
        public static void make()
        {
            PersonagemMolde personagem = new Personagem("Gabriel");
            personagem.ToConsole();
            personagem = new Sword(personagem);
            personagem.ToConsole();
            personagem = new Shield(personagem);
            personagem.ToConsole();
        }
    }
}