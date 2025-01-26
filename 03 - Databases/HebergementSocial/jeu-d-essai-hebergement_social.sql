USE hebergement_social;

INSERT INTO role
(role_libelle)
VALUES
("Directeur"),
("Gardien"),
("Cuisinier"),
("Technicien"),
("Educateur"),
("Médecin"),
("Résident");

INSERT INTO individu
(individu_nom, individu_prenom, individu_date_naissance, role_id)
VALUES
("Dupond", "Toto", "1980-10-25", 1),
("Dupont", "Tata", "1985-11-20", 3),
("Dupon", "Titi", "1990-05-02", 4),
("Dulond", "Tete", "2000-12-25", 2),
("Dujardin", "Tutu", "1978-10-25", 2),
("Duplomb", "Touitoui", "1999-10-25", 6),
("Blop", "Touintouin", "2002-10-25", 6),
("Jépadidée", "Coincoin", "2003-10-15", 6),
("Bupon", "Baba", "1982-12-25", 5),
("Lupon", "Bibi", "1983-11-25", 5),
("Cupon", "Bubu", "1984-08-25", 5),
("Trupon", "Bouiboui", "1965-03-15", 5),
("residentNom1", "residentPrenom1", "1999-10-25", 7),
("residentNom2", "residentPrenom2", "1990-11-24", 7),
("residentNom3", "residentPrenom3", "1970-01-23", 7),
("residentNom4", "residentPrenom4", "1950-05-27", 7),
("residentNom5", "residentPrenom5", "1940-10-29", 7),
("residentNom6", "residentPrenom6", "1985-10-27", 7),
("residentNom7", "residentPrenom7", "1986-10-26", 7),
("residentNom8", "residentPrenom8", "1987-10-16", 7),
("residentNom9", "residentPrenom9", "1988-10-15", 7),
("residentNom10", "residentPrenom10", "1989-10-22", 7);

UPDATE individu
SET individu_id_medecin = 6
WHERE individu_id IN (13, 14);

UPDATE individu
SET individu_id_medecin = 7
WHERE individu_id = 15;

ALTER TABLE individu
ADD CONSTRAINT fk_individu_medecin FOREIGN KEY (individu_id_medecin) REFERENCES individu(individu_id_medecin); 

INSERT INTO activite
(activite_intitule, activite_date, activite_heure_debut, activite_heure_fin, activite_nbr_participant_min, activite_nbr_participant_max, activite_etat, individu_id)
VALUES
("Natation", "2025-01-29", "18:00", "20:00", 2, 20, "ouvert", 9),
("Musculation", "2025-03-29", "19:00", "21:00", 1, 10, "ouvert", 10);
