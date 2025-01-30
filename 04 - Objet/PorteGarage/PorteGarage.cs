using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorteGarage
{
    public class PorteGarage
    {
        Boolean estOuverte;
        Boolean estVerrouille;

        public PorteGarage()
        {
            estOuverte = false;
            estVerrouille = true;
        }

        public PorteGarage(Boolean _porteOuverte, Boolean _porteVerrouille)
        {
            this.estOuverte = _porteOuverte;
            this.estVerrouille = _porteVerrouille;
        }

        public Boolean verrouillerPorte()
        {
            Boolean result = false;
            if(this.estOuverte == false && this.estVerrouille == false)
            {
                this.estVerrouille = true;
                result = true;
            }
            return result;
        }

        public Boolean deverrouillerPorte()
        {
            Boolean result = false;
            if (this.estOuverte == false && this.estVerrouille == true)
            {
                this.estVerrouille = false;
                result = true;
            }
            return result;
        }

        public Boolean ouvrirPorte()
        {
            Boolean result = false;
            if(this.estVerrouille == false && this.estOuverte == false)
            {
                this.estOuverte = true;
                result = true;
            }
            return result;
        }

        public Boolean fermerPorte()
        {
            Boolean result = false;
            if (this.estVerrouille == false && this.estOuverte == true)
            {
                this.estOuverte = false;
                result = true;
            }
            return result;
        }

    }
}
