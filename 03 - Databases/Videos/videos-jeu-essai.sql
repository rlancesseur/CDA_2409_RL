/*
INSERER LE JEU D'ESSAI
Sous langage : DML / LMD
Data Modeling Language
Language de modélisation des données
Principales instructions :
INSERT : Ajouter des nouvelles données dans une table
UPDATE : Mettre à jour des données
DELETE : Supprimer des données existantes dans une table
TRUNCATE : VIDER une table (et réinitialise l'auto_increment)
*/
USE videos;

INSERT INTO realisateur
VALUES
(NULL, "besson", "luc"),
(NULL, "spielberg", "steven"),
(NULL, "carpenter", "john");

INSERT INTO acteur
(acteur_prenom, acteur_nom)
VALUES
("Jean", "Réno"),
("Mel", "Gibson"),
("Tom", "Holland"),
("Eva", "Green"),
("Emma", "Watson");
