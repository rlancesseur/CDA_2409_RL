namespace Voiture
{
    public class Program
    {
        static void Main(string[] args)
        {
            Voiture maVoiture = new("Renault", 80, false, false);

            bool allumerPhares = maVoiture.AllumerPhares();
            Console.WriteLine(allumerPhares ? "Les phares se sont allumés." : "Les phares étaient déjà allumés, ou la voiture n'a plus de batterie.");

            allumerPhares = maVoiture.AllumerPhares();
            Console.WriteLine(allumerPhares ? "Les phares se sont allumés." : "Les phares étaient déjà allumés, ou la voiture n'a plus de batterie.");

            bool eteindrePhares = maVoiture.EteindrePhares();
            Console.WriteLine(eteindrePhares ? "Les phares se sont éteints." : "Les phares étaient déjà éteints.");

            eteindrePhares = maVoiture.EteindrePhares();
            Console.WriteLine(eteindrePhares ? "Les phares se sont éteints." : "Les phares étaient déjà éteints.");

            bool fermerPorte = maVoiture.FermerPorte();
            Console.WriteLine(fermerPorte ? "La porte s'est fermée." : "La porte était déjà fermée.");

            bool ouvrirPorte = maVoiture.OuvrirPorte();
            Console.WriteLine(ouvrirPorte ? "La porte s'est ouverte." : "La porte était déjà ouverte.");

            ouvrirPorte = maVoiture.OuvrirPorte();
            Console.WriteLine(ouvrirPorte ? "La porte s'est ouverte." : "La porte était déjà ouverte.");



            VoitureEssence maVoitureEssence = new("Porsche", 50, false, false, false, 40, 50, false);

            bool demarrerVoiture = maVoitureEssence.DemarrerMoteur();
            Console.WriteLine(demarrerVoiture ? "La voiture a démarré." : "La voiture n'a pas pu démarrer");

            demarrerVoiture = maVoitureEssence.DemarrerMoteur();
            Console.WriteLine(demarrerVoiture ? "La voiture a démarré." : "La voiture n'a pas pu démarrer");

            bool arreterVoiture = maVoitureEssence.EteindreMoteur();
            Console.WriteLine(arreterVoiture ? "Le moteur s'est arrêté." : "Le moteur était déjà arrêté.");

            bool remplirReservoir = maVoitureEssence.RemplirReservoirQuantite(20);
            Console.WriteLine(remplirReservoir ? "Le réservoir a pu être rempli.": "Le résevoir n'a pas pu être rempli.");

            remplirReservoir = maVoitureEssence.RemplirReservoirQuantite(10);
            Console.WriteLine(remplirReservoir ? "Le réservoir a pu être rempli." : "Le résevoir n'a pas pu être rempli.");

            bool voitureAvance = maVoitureEssence.Avancer();
            Console.WriteLine(voitureAvance ? "La voiture avance." : "La voiture ne peut pas avancer, ou avance déjà.");

            demarrerVoiture = maVoitureEssence.DemarrerMoteur();
            voitureAvance = maVoitureEssence.Avancer();
            Console.WriteLine(voitureAvance ? "La voiture avance." : "La voiture ne peut pas avancer, ou avance déjà.");

            bool voitureArret = maVoitureEssence.Arreter();
            Console.WriteLine(voitureArret ? "La voiture s'arrête." : "La voiture était déjà à l'arrêt.");

            voitureArret = maVoitureEssence.Arreter();
            Console.WriteLine(voitureArret ? "La voiture s'arrête." : "La voiture était déjà à l'arrêt.");

        }
    }
}
