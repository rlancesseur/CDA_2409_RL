using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeEvolution
    {
        public Chenille()
        {

        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je rampe.");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
