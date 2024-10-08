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
            double[] tableauDouble = new double[_carteBleue.Length];
            string split;
            double A;
            double sommeTableau = 0;

            for (int i = 0; i < _carteBleue.Length; i++)
            {
                tableauDouble[i] = double.Parse(_carteBleue[i].ToString());
            }

            for (int i = tableauDouble.Length; i >= 2; i-= 2)
            {
                tableauDouble[i - 2] *= 2;
                A = 0;
                
                if(tableauDouble[i - 2] > 9)
                {
                    split = tableauDouble[i - 2].ToString();
                    for (int j = 0; j < split.Length; j++)
                    {
                        A += double.Parse(split[j].ToString());
                    }
                    tableauDouble[i - 2] = A;
                }
                
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
