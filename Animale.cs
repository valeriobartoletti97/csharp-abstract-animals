using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        //Dormi() si può definire già in animal poichè è generale per ogni istanza che creeremo dagli altri animali
        public void Dormi()
        {
            Console.WriteLine($"Zzz");
        }
        public abstract void Verso();
        public abstract void Mangia();
    }
    public interface IVolante
    {
        public void Vola();

    }
    public interface INuotatore
    {
        public void Nuota();
    }
   
}
