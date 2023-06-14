using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator.Example1
{
    public class Shield : DecoratorWeapon
    {
        public string Defense { get; set; } = "";
        public Shield(PersonagemMolde personagem) : base(personagem)
        {
            Weapons += "Escudo, ";
            Defense = "100";
        }
        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Defense: {Defense}");
        }
    }

}