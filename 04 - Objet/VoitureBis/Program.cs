using ClassLibraryVoitureBis;

Roue maRoue = new Roue("Michelin", false, 1);
Roue maRoueParDefaut = new Roue();
Roue maRoueClone = new Roue(maRoue);
maRoue.Tourner();
maRoue.ArreterTourner();
maRoue.ToString();

Moteur monMoteur = new Moteur("Essence", false);
Moteur monMoteurParDefaut = new Moteur();
Moteur monMoteurClone = new Moteur(monMoteur);
monMoteur.DemarrerMoteur();
monMoteur.ArreterMoteur();
monMoteur.ToString();

Voiture maVoiture = new Voiture("Renault", "Clio", "Diesel", false, "Michelin", false, 0.5f);
Voiture maVoitureParDefaut = new Voiture();
Voiture maVoitureClone = new Voiture(maVoiture);

maVoiture.GetHashCode();
maVoitureClone.GetHashCode();

maVoiture.DemarrerVoiture();
maVoiture.Avancer();
maVoiture.ArreterVoiture();
maVoiture.Avancer();

string  retour = maVoiture.ToString();
