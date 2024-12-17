DROP DATABASE IF EXISTS clubSelect;
CREATE DATABASE IF NOT EXISTS clubSelect;
USE clubSelect;

CREATE TABLE membre(
   membre_id INT AUTO_INCREMENT,
   membre_nom VARCHAR(30) NOT NULL,
   membre_prenom VARCHAR(30) NOT NULL,
   membre_date_naissance DATE NOT NULL,
   membre_adresse VARCHAR(300) NOT NULL,
   membre_mail VARCHAR(100) NOT NULL,
   membre_date_adhesion DATE NOT NULL,
   PRIMARY KEY(membre_id)
);

CREATE TABLE conference(
   conference_id INT AUTO_INCREMENT,
   conference_nom VARCHAR(100) NOT NULL,
   conference_date DATE NOT NULL,
   conference_heure_debut TIME NOT NULL,
   conference_duree VARCHAR(5) NOT NULL,
   PRIMARY KEY(conference_id)
);

CREATE TABLE parrainer(
   membre_id INT,
   membre_id_1 INT,
   date_parainage DATE,
   PRIMARY KEY(membre_id, membre_id_1),
   FOREIGN KEY(membre_id) REFERENCES membre(membre_id),
   FOREIGN KEY(membre_id_1) REFERENCES membre(membre_id)
);

CREATE TABLE participer(
   membre_id INT,
   conference_id INT,
   PRIMARY KEY(membre_id, conference_id),
   FOREIGN KEY(membre_id) REFERENCES membre(membre_id),
   FOREIGN KEY(conference_id) REFERENCES conference(conference_id)
);

INSERT INTO membre
(membre_nom, membre_prenom, membre_date_naissance, membre_adresse, membre_mail, membre_date_adhesion)
VALUES
('Dupont', 'Henri', '1950-01-01', '1 rue du Soleil, 75001 Paris', 'dupont.henri@email.com', '2020-01-01'),
('Dubois', 'Thomas', '1990-05-05', '5 rue de la Concorde, 75005 Paris', 'dubois.thomas@email.com', '2020-05-05'),
('Martin', 'Marie', '1960-02-02', '2 avenue de la Lune, 75002 Paris', 'martin.marie@email.com', '2021-02-02'),
('Durand', 'Pierre', '1970-03-03', '3 boulevard des Étoiles, 75003 Paris', 'durand.pierre@email.com', '2022-03-03'),
('Lefebvre', 'Claire', '1980-04-04', '4 place de la République, 75004 Paris', 'lefebvre.claire@email.com', '2023-04-04');

INSERT INTO conference
(conference_nom, conference_date, conference_heure_debut, conference_duree)
VALUES
('L’intelligence artificielle: mythe ou réalité?', '2023-10-04', '17:30', '1h30'),
('Les défis de la transition énergétique', '2023-11-15', '20:00', '2h00'),
('La mondialisation: une chance ou une menace?', '2023-12-22', '19:30', '1h00'),
('L’avenir de la démocratie', '2024-01-10', '17:45', '1h30'),
('L’art et la technologie: une alliance possible?', '2024-02-07', '20:00', '2h00');

SELECT membre_nom FROM membre ORDER BY membre_date_adhesion DESC;
