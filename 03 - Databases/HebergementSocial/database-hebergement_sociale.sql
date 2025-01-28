DROP DATABASE IF EXISTS hebergement_social;
CREATE DATABASE hebergement_social;
USE hebergement_social;

CREATE TABLE role(
   role_id INT AUTO_INCREMENT PRIMARY KEY,
   role_libelle VARCHAR(10) NOT NULL
);

CREATE TABLE activite(
   activite_id INT AUTO_INCREMENT PRIMARY KEY,
   activite_intitule VARCHAR(30) NOT NULL,
   activite_date DATE NOT NULL,
   activite_heure_debut TIME,
   activite_heure_fin TIME,
   activite_nbr_participant_min TINYINT NOT NULL,
   activite_nbr_participant_max TINYINT NOT NULL,
   activite_etat VARCHAR(10) NOT NULL
);

CREATE TABLE individu(
   individu_id INT AUTO_INCREMENT PRIMARY KEY,
   individu_nom VARCHAR(30) NOT NULL,
   individu_prenom VARCHAR(30) NOT NULL,
   individu_date_naissance DATE NOT NULL,
   individu_date_arrivee DATE,
   individu_date_depart DATE,
   individu_chambre TINYINT,
   individu_id_medecin INT,
   role_id INT NOT NULL,
   CONSTRAINT fk_individu_role FOREIGN KEY(role_id) REFERENCES role(role_id)
);

CREATE TABLE suivi_medical(
   suivi_medical_id INT AUTO_INCREMENT PRIMARY KEY,
   suivi_medical_info TEXT NOT NULL,
   individu_id INT NOT NULL,
   individu_id_1 INT NOT NULL,
   UNIQUE(individu_id_1),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(individu_id_1) REFERENCES individu(individu_id)
);

CREATE TABLE inscrire(
   individu_id INT,
   activite_id INT,
   PRIMARY KEY(individu_id, activite_id),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(activite_id) REFERENCES activite(activite_id)
);

CREATE TABLE animer(
   individu_id INT,
   activite_id INT,
   PRIMARY KEY(individu_id, activite_id),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(activite_id) REFERENCES activite(activite_id)
);

