DROP DATABASE IF EXISTS parcoursCombattant;
CREATE DATABASE parcoursCombattant;
USE parcoursCombattant;

CREATE TABLE grade
(
	grade_id INT AUTO_INCREMENT,
    grade_nom VARCHAR(30),
    PRIMARY KEY(grade_id)
);

CREATE TABLE difficulte
(
	difficulte_id INT AUTO_INCREMENT,
    difficulte_type VARCHAR(10),
    PRIMARY KEY(difficulte_id)
);

CREATE TABLE soldat(
   soldat_id INT AUTO_INCREMENT,
   soldat_nom VARCHAR(30) NOT NULL,
   soldat_prenom VARCHAR(30) NOT NULL,
   soldat_date_naissance DATE NOT NULL,
   grade_id INT NOT NULL,
   PRIMARY KEY(soldat_id),
   FOREIGN KEY(grade_id) REFERENCES grade(grade_id)
);

CREATE TABLE obstacle(
   obstacle_id INT AUTO_INCREMENT,
   obstacle_nom VARCHAR(30) NOT NULL,
   obstacle_note_minimum TINYINT NOT NULL,
   difficulte_id INT NOT NULL,
   PRIMARY KEY(obstacle_id),
   FOREIGN KEY(difficulte_id) REFERENCES difficulte(difficulte_id)
);

CREATE TABLE passer(
   soldat_id INT,
   obstacle_id INT,
   note_instructeur TINYINT NOT NULL,
   temps_par_obstacle TINYINT,
   PRIMARY KEY(soldat_id, obstacle_id),
   FOREIGN KEY(soldat_id) REFERENCES soldat(soldat_id),
   FOREIGN KEY(obstacle_id) REFERENCES obstacle(obstacle_id)
);
