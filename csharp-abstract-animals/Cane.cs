using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public override void GetName()
        {
            Console.WriteLine("Gianni");
        }
        public override void Verso()
        {
            Console.WriteLine("Verso cane");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Mangio croccantini e premietti");
        }
    }
}
