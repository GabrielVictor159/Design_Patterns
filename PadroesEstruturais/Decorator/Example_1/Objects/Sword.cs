using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator.Example1
{
    public class Sword : DecoratorWeapon
    {
        public Sword(PersonagemMolde personagem) : base(personagem)
        {
            Weapons += "Espada, ";
        }
    }
}