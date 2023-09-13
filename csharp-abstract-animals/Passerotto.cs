using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
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
    }
}
