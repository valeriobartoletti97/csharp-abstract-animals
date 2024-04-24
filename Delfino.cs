using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale, INuotatore
    {
        public override void Mangia()
        {
            Console.WriteLine("Sono un delfino e sto mangiando");
        }
        public override void Verso()
        {
            Console.WriteLine("Fssssk");
        }
        public void Nuota()
        {
            Console.WriteLine("Sono un delfino e sto nuotando");
        }
    }
}
