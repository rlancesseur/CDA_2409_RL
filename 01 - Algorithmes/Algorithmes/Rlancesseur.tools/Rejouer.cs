using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rlancesseur.tools
{
    public class Rejouer
    {
        public static bool RejouerProgramme()
        {
            bool result = true;

            Console.WriteLine("Recommencer une partie ? (o/n)");
            ConsoleKeyInfo loop = Console.ReadKey(true);

            if (loop.KeyChar == 'o')
            {
                result = true;
            }
            else if (loop.KeyChar == 'n')
            {
                result = false;
            }

            return result;

        }
    }
}
