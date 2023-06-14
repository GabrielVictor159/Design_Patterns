using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesEstruturais.Decorator
{
    public interface PersonagemMolde
    {
        string Name { get; set; }
        string Weapons { get; set; }
        void ToConsole();
    }
}