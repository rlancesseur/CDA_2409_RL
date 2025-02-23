using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeEvolution
    {
        public Oeuf()
        {
            
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas.");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
