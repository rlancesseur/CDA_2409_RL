DROP DATABASE IF EXISTS ticketCaisse;
CREATE DATABASE ticketCaisse;
USE ticketCaisse;

CREATE TABLE serveur
(
	serveur_id INT AUTO_INCREMENT PRIMARY KEY,
    serveur_nom VARCHAR(30) NOT NULL,
    serveur_prenom VARCHAR(30) NOT NULL
);

CREATE TABLE tableConso
(
	tableConso_id INT AUTO_INCREMENT PRIMARY KEY,
    serveur_id INT,
    CONSTRAINT fk_tableConso FOREIGN KEY(serveur_id) REFERENCES serveur(serveur_id)
);

CREATE TABLE consommation
(
	consommation_id INT AUTO_INCREMENT PRIMARY KEY,
    consommation_libelle VARCHAR(50) NOT NULL,
    consommation_prix SMALLINT NOT NULL
);

CREATE TABLE commande(
   commande_id INT AUTO_INCREMENT PRIMARY KEY,
   commande_date DATE NOT NULL,
   commande_heure TIME NOT NULL,
   tableConso_id INT NOT NULL,
   CONSTRAINT fk_commande FOREIGN KEY(tableConso_id) REFERENCES tableConso(tableConso_id)
);

CREATE TABLE ticket(
   ticket_id INT AUTO_INCREMENT PRIMARY KEY,
   tableConso_id INT NOT NULL,
   CONSTRAINT fk_ticket FOREIGN KEY(tableConso_id) REFERENCES tableConso(tableConso_id)
);


CREATE TABLE contenir(
   consommation_id INT,
   commande_id INT,
   quantite INT NOT NULL,
   montant_ligne DECIMAL(19,4),
   PRIMARY KEY(consommation_id, commande_id),
   CONSTRAINT fk_contenir_consommation FOREIGN KEY(consommation_id) REFERENCES consommation(consommation_id),
   CONSTRAINT fk_contenir_commande FOREIGN KEY(commande_id) REFERENCES commande(commande_id)
);
