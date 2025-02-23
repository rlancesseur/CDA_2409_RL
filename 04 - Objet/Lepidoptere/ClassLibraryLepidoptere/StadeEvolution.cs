using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public abstract class StadeEvolution
    {
        public StadeEvolution()
        {

        }
        public abstract void SeDeplacer();

        public abstract StadeEvolution SeMetamorphoser();
    }
}
