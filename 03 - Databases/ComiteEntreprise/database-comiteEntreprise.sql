DROP DATABASE IF EXISTS comiteEntreprise;
CREATE DATABASE IF NOT EXISTS comiteEntreprise;
USE comiteEntreprise;

CREATE TABLE individu
(
	individu_id INT AUTO_INCREMENT PRIMARY KEY,
	individu_nom VARCHAR(30) NOT NULL,
	individu_prenom VARCHAR(30) NOT NULL,
	individu_tel VARCHAR(10),
	individu_date_naissance DATE NOT NULL
);

CREATE TABLE affilier(
   individu_id INT,
   individu_id_1 INT,
   PRIMARY KEY(individu_id, individu_id_1),
   FOREIGN KEY(individu_id) REFERENCES individu(individu_id),
   FOREIGN KEY(individu_id_1) REFERENCES individu(individu_id)
);

INSERT INTO individu
(individu_nom, individu_prenom, individu_tel)
VALUES
('DURAND', 'Albert', '01.02.03.04.05'),
('LACOMBE ', 'Josette', '05.98.87.65.54'),
('MARTIN ', 'Roger', '04.32.21.45.56');
