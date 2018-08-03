using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLaynet
{
    public abstract class Animal
    {
        public void marcher() { }
    }

    public class Mamifère : Animal
    { }

    public class Oiseau : Animal
    { }

    public sealed class Poule : Animal
    { }

    public class Chien : Animal
    {
        public void aboyer() { }
    }

    public class Chat : Animal
    {
        public void miauler() { }
    }
               
}


