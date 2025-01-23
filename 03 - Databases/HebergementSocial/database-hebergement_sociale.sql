DROP DATABASE IF EXISTS hebergement_social;
CREATE DATABASE hebergement_social;
USE hebergement_social;

CREATE TABLE role(
   role_id INT AUTO_INCREMENT PRIMARY KEY,
   role_libelle VARCHAR(10) NOT NULL
);

CREATE TABLE suivi_medical(
   suivi_medical_id INT AUTO_INCREMENT PRIMARY KEY,
   suivi_medical_info TEXT NOT NULL
);

CREATE TABLE individu(
   individu_id INT AUTO_INCREMENT,
   individu_nom VARCHAR(30) NOT NULL,
   individu_prenom VARCHAR(30) NOT NULL,
   individu_date_naissance DATE NOT NULL,
   individu_date_arrivee DATE,
   individu_date_depart DATE,
   individu_chambre TINYINT,
   suivi_medical_id INT,
   role_id INT NOT NULL,
   PRIMARY KEY(individu_id),
   FOREIGN KEY(suivi_medical_id) REFERENCES suivi_medical(suivi_medical_id),
   FOREIGN KEY(role_id) REFERENCES role(role_id)
);

CREATE TABLE activite(
   activite_id INT AUTO_INCREMENT PRIMARY KEY,
   activite_intitule VARCHAR(30) NOT NULL,
   activite_date DATE NOT NULL,
   activite_heure_debut TIME,
   activite_heure_fin TIME,
   activite_nbr_participant_min TINYINT NOT NULL,
   activite_nbr_participant_max TINYINT NOT NULL,
   activite_etat VARCHAR(10) NOT NULL,
   individu_id INT NOT NULL,
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id)
);

CREATE TABLE inscrire(
   individu_id INT,
   activite_id INT,
   PRIMARY KEY(individu_id, activite_id),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(activite_id) REFERENCES activite(activite_id)
);

CREATE TABLE assurer(
   individu_id INT,
   suivi_medical_id INT,
   PRIMARY KEY(individu_id, suivi_medical_id),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(suivi_medical_id) REFERENCES suivi_medical(suivi_medical_id)
);

CREATE TABLE soigner(
   individu_id INT,
   individu_id_1 INT,
   PRIMARY KEY(individu_id, individu_id_1),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(individu_id_1) REFERENCES individu(individu_id)
);

