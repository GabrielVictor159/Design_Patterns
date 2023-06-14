using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator
{
    public abstract class DecoratorWeapon : PersonagemMolde
    {
        protected readonly PersonagemMolde _personagem;

        public string Name
        {
            get => _personagem.Name;
            set => _personagem.Name = value;
        }

        public string Weapons
        {
            get => _personagem.Weapons;
            set => _personagem.Weapons = value;
        }

        public DecoratorWeapon(PersonagemMolde personagem)
        {
            _personagem = personagem;
        }

        public virtual void ToConsole()
        {
            _personagem.ToConsole();
        }
    }
}