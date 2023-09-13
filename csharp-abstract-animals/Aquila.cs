using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override void GetName()
        {
            Console.WriteLine("Jonny");
        }
        public override void Verso()
        {
            Console.WriteLine("Verso Aquila");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Mangio piccoli mammiferi");
        }
    }
}
