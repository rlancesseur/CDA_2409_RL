USE ecf_kiloutout_lancesseur;

INSERT INTO proprietaire
(proprietaire_nom, proprietaire_prenom, proprietaire_tel, proprietaire_ville , proprietaire_cp, proprietaire_rue)
VALUES
("Durant", "Pascal", "03-89-89-87-87", "Colmar", "68000", "10 rue de la marine"),
("Martinez", "Joëlle", "03-89-12-13-14", "Mulhouse", "68100", "18 avenue des peupliers"),
("Bowé", "Samira", "07-32-21-16-65", "Strasbourg", "67000", "21 rue du musée");

INSERT INTO type_logement
(type_logement_libelle)
VALUES
("Appartement"),
("Maison");

INSERT INTO logement
(logement_surface, logement_loyer, logement_ville, logement_cp, logement_rue, type_logement_id)
VALUES
(100, 800, "Mulhouse", "68100", "32 rue de Cherbourg", 1),
(65, 490, "Colmar", "68000", "325 boulevard des majorettes", 1),
(160, 1450, "Riedisheim", "68400", "11 rue de Mulhouse", 2),
(85, 750, "Mulhouse", "68100", "17A avenue des peupliers", 1),
(70, 625, "Mulhouse", "68100", "17B avenue des peupliers", 1);

INSERT INTO locataire
(locataire_nom, locataire_prenom, locataire_tel)
VALUES
("Dubosc", "Jacqueline", "06-99-99-88-77"),
("Di Marco", "Philippe", "09-72-73-74-75");

INSERT INTO louer
(logement_id, locataire_id, location_id, location_date_debut, location_duree)
VALUES
(2, 1, 0000, "2025-02-01", 6),
(5, 2, 0001, "2024-11-01", 3);

INSERT INTO posseder
(proprietaire_id, logement_id)
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5);

INSERT INTO donner_gestion
(proprietaire_id, logement_id, duree, pourcentage_loyer)
VALUES
(1, 1, 10, 5),
(1, 2, 10, 8),
(2, 3, 10, 5),
(2, 4, 10, 10),
(3, 5, 8, 10);