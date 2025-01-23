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

INSERT INTO soigner
(individu_id, individu_id_1)
VALUES
(6, 13),
(6, 14),
(7, 15);
