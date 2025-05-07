using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    public class Manche
    {
        int nbrLance;
        public int pointManche;
        public bool estTerminee;
        List<De> mes3Des;

        public Manche()
        {
            nbrLance = 0;
            pointManche = 0;
            estTerminee = false;
            mes3Des = new List<De>();

            for(int i = 0; i < 3; i++)
            {
                mes3Des.Add(new De());
            }
        }

        public void LancerDes()
        {
            foreach(De de in mes3Des)
            {
                de.Jeter();
            }
            nbrLance++;

            if(nbrLance == 3)
            {
                estTerminee = true;
            }
        }
    }
}
