using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rlancesseur.tools
{
    public class AlgoLuhn
    {
        public static bool ConformiteCarteBleue(string _carteBleue)
        {
            _carteBleue = _carteBleue.Replace(" ","");
            string[] tableauString = _carteBleue.Split(" ");
            double[] tableauDouble = new double[tableauString.Length];
            double sommeTableau = 0;

            for (int i = 0; i < tableauString.Length; i++)
            {
                tableauDouble[i] = double.Parse(tableauString[i]);
            }

            for (int i = tableauDouble.Length; i >= 2; i--)
            {
                tableauDouble[i - 2] *= 2;
                /*
                if(tableauInt[i - 2] > 9)
                {
                    tableauInt[i - 2] = 
                }
                */
            }

            for(int i = 0; i < tableauDouble.Length - 1; i++)
            {
                sommeTableau += tableauDouble[i];
            }

            if(sommeTableau % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
