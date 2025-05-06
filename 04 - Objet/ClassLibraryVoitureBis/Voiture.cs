using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureBis
{
    public class Voiture
    {
        string marque;
        string modele;
        Moteur monMoteur;
        Roue maRoueAvantDroite;
        Roue maRoueAvantGauche;
        Roue maRoueArriereDroite;
        Roue maRoueArriereGauche;
        private Roue roueDeSecours = null;

        /// <summary>
        /// Constructeur principal
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_model"></param>
        /// <param name="_typeMoteur"></param>
        /// <param name="_estDemarre"></param>
        /// <param name="_marqueRoue"></param>
        /// <param name="_tourne"></param>
        /// <param name="_usureEnMm"></param>
        public Voiture(string _marque, string _model, string _typeMoteur, bool _estDemarre, string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            marque = _marque;
            modele = _model;
            monMoteur = new Moteur(_typeMoteur, _estDemarre);
            maRoueAvantDroite = new Roue(_marqueRoue, _tourne, _usureEnMm);
            maRoueAvantGauche = new Roue(_marqueRoue, _tourne, _usureEnMm);
            maRoueArriereDroite = new Roue(_marqueRoue, _tourne, _usureEnMm);
            maRoueArriereGauche = new Roue(_marqueRoue, _tourne, _usureEnMm);
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Voiture() : this("Toyota", "Auris", "Diesel", false, "Michelin", false, 0.5f)
        {
        }

        /// <summary>
        /// Constructeur par clonage
        /// </summary>
        /// <param name="voitureACopier"></param>
        public Voiture(Voiture voitureACopier)
        {
            marque = voitureACopier.marque;
            modele = voitureACopier.modele;
            monMoteur = new Moteur(voitureACopier.monMoteur);
            maRoueAvantDroite = new Roue(voitureACopier.maRoueAvantDroite);
            maRoueAvantGauche = new Roue(voitureACopier.maRoueAvantGauche);
            maRoueArriereDroite = new Roue(voitureACopier.maRoueArriereDroite);
            maRoueArriereGauche = new Roue(voitureACopier.maRoueArriereGauche);
        }

        /// <summary>
        /// Méthode pour démarrer la voiture
        /// </summary>
        /// <returns></returns>
        public bool DemarrerVoiture()
        {
            return monMoteur.DemarrerMoteur();
        }

        /// <summary>
        /// Méthode pour arrêter la voiture
        /// </summary>
        /// <returns></returns>
        public bool ArreterVoiture()
        {
            if (monMoteur.ArreterMoteur())
            {
                ArreterAvancer();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode pour faire avancer la voiture (active les roues)
        /// </summary>
        /// <returns></returns>
        public bool Avancer()
        {
            if(monMoteur.Entrainer2RouesMotrices(maRoueAvantGauche, maRoueAvantDroite))
            {
                ModifierRotationRouesAriere(true);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode pour arrêter la voiture
        /// </summary>
        /// <returns></returns>
        public bool ArreterAvancer()
        {
            if (monMoteur.Arreter2RouesMotrices(maRoueAvantGauche, maRoueAvantDroite))
            {
                ModifierRotationRouesAriere(false);
                return true;
            }
            return false;
        }

        // Méthode privée pour modifier la rotation des roues arrière
        private void ModifierRotationRouesAriere(bool tourne)
        {
            maRoueArriereGauche.tourne = tourne;
            maRoueArriereDroite.tourne = tourne;
        }

        // Méthode pour ajouter une roue de secours si elle n'existe pas déjà
        public Roue AjouterRoueDeSecours()
        {
            if (roueDeSecours == null)
            {
                roueDeSecours = new Roue();
                return roueDeSecours;
            }
            return null;
        }

        // Méthode pour modifier l'une des roues de la voiture
        public Roue ModifierRoue(Roue roueAModifier, string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            Roue nouvelleRoue = new Roue("Michelin", false, 0);
            if (roueAModifier == maRoueAvantGauche) maRoueAvantGauche = nouvelleRoue;
            else if (roueAModifier == maRoueAvantDroite) maRoueAvantDroite = nouvelleRoue;
            else if (roueAModifier == maRoueArriereGauche) maRoueArriereGauche = nouvelleRoue;
            else if (roueAModifier == maRoueArriereDroite) maRoueArriereDroite = nouvelleRoue;
            return nouvelleRoue;
        }

        public override string ToString()
        {
            return base.ToString() + "; Marque : " + marque + "; Modele : " + modele + "; \n" + monMoteur.ToString() + "; " + maRoueAvantGauche.ToString();
        }
    }
}
