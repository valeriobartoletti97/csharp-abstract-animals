﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("Sono un passerotto e sto mangiando");
        }
        public override void Verso()
        {
            Console.WriteLine("Cip cip");
        }
    }
}
