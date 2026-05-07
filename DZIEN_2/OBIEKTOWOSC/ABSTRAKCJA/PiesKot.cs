using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakcja
{
   class Pies : Zwierze
    {
        public Pies(string imie) : base(imie)
        {
        }
        public override void WydajDzwiek()
        {
            Console.WriteLine("Hau hau!");
        }
    }
    class Kot : Zwierze
    {
        public Kot(string imie) : base(imie)
        {
        }
        public override void WydajDzwiek()
        {
            Console.WriteLine("Miau miau!");
        }
    }

    class Pajak : Zwierze
    {
        public Pajak(string imie) : base(imie)
        {
        }
        public override void WydajDzwiek()
        {
            return;
    }
}
}
