using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator.Example1
{
    public class MakeDecorator
    {
        public static void make()
        {
            PersonagemMolde personagem = new Personagem("Guerreiro");
            personagem.ToConsole();
            Console.WriteLine("------------------------");
            personagem = new Sword(personagem);
            personagem.ToConsole();
            Console.WriteLine("------------------------");
            personagem = new Shield(personagem);
            personagem.ToConsole();
            Console.WriteLine("------------------------");
        }
    }
}