DROP DATABASE IF EXISTS ecf_kiloutout_lancesseur;
CREATE DATABASE ecf_kiloutout_lancesseur;
USE ecf_kiloutout_lancesseur;

CREATE TABLE proprietaire(
   proprietaire_id INT AUTO_INCREMENT PRIMARY KEY,
   proprietaire_nom VARCHAR(30) NOT NULL,
   proprietaire_prenom VARCHAR(30) NOT NULL,
   proprietaire_tel VARCHAR(15) NOT NULL,
   proprietaire_ville VARCHAR(30) NOT NULL,
   proprietaire_cp INT NOT NULL,
   proprietaire_rue VARCHAR(255) NOT NULL
);

CREATE TABLE type_logement(
   type_logement_id INT AUTO_INCREMENT PRIMARY KEY,
   type_logement_libelle VARCHAR(15) NOT NULL
);

CREATE TABLE logement(
   logement_id INT AUTO_INCREMENT PRIMARY KEY,
   logement_surface SMALLINT NOT NULL,
   logement_loyer SMALLINT NOT NULL,
   logement_ville VARCHAR(30) NOT NULL,
   logement_cp INT NOT NULL,
   logement_rue VARCHAR(255) NOT NULL,
   type_logement_id INT NOT NULL,
   CONSTRAINT fk_logement FOREIGN KEY(type_logement_id) REFERENCES type_logement(type_logement_id)
);

CREATE TABLE locataire(
   locataire_id INT AUTO_INCREMENT PRIMARY KEY,
   locataire_nom VARCHAR(30) NOT NULL,
   locataire_prenom VARCHAR(30) NOT NULL,
   locataire_tel VARCHAR(15) NOT NULL
);

CREATE TABLE louer(
   logement_id INT,
   locataire_id INT,
   location_id INT NOT NULL,
   location_date_debut DATE NOT NULL,
   location_duree SMALLINT NOT NULL,
   PRIMARY KEY(logement_id, locataire_id),
   CONSTRAINT fk_louer_logement FOREIGN KEY(logement_id) REFERENCES logement(logement_id),
   CONSTRAINT fk_louer_locataire FOREIGN KEY(locataire_id) REFERENCES locataire(locataire_id)
);

CREATE TABLE posseder(
   proprietaire_id INT,
   logement_id INT,
   PRIMARY KEY(proprietaire_id, logement_id),
   CONSTRAINT fk_posseder_proprietaire FOREIGN KEY(proprietaire_id) REFERENCES proprietaire(proprietaire_id),
   CONSTRAINT fk_posseder_logement FOREIGN KEY(logement_id) REFERENCES logement(logement_id)
);

CREATE TABLE donner_gestion(
   proprietaire_id INT,
   logement_id INT,
   duree INT,
   pourcentage_loyer TINYINT,
   PRIMARY KEY(proprietaire_id, logement_id),
   CONSTRAINT fk_donner_gestion_proprietaire FOREIGN KEY(proprietaire_id) REFERENCES proprietaire(proprietaire_id),
   CONSTRAINT fk_donner_gestion_logement FOREIGN KEY(logement_id) REFERENCES logement(logement_id)
);

