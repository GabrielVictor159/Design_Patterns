using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator.Example1
{
    public class Personagem : PersonagemMolde
    {
        public string Name { get; set; } = "";
        public string Weapons { get; set; } = "";

        public Personagem(string name)
        {
            Name = name;
        }

        public void ToConsole()
        {
            Console.WriteLine($"{Name}:");
            Console.WriteLine($"Weapons: {Weapons}");
        }
    }
}