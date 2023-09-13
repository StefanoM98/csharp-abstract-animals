using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante
    {
        public override void GetName()
        {
            Console.WriteLine("Pasquale");
        }
        public override void Verso()
        {
            Console.WriteLine("Verso passerotto");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Mangio la mela e semini");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando Jack!");
        }
    }
}
