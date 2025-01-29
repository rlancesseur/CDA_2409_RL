USE ecf_kiloutout_lancesseur;

-- TRIGGER pour empêcher l'entrée
CREATE TABLE Erreur
(
erreur_id TINYINT AUTO_INCREMENT PRIMARY KEY,
erreur_text VARCHAR(255)
);

INSERT INTO ERREUR 
(erreur_text)
VALUES
("Le loyer doit être strictement inférieur à 2000€ par mois");

DELIMITER |
CREATE TRIGGER VerifMontantLoyer BEFORE INSERT
ON donner_gestion FOR EACH ROW
BEGIN
	IF NEW.logement_loyer >= 2000
    THEN
    INSERT INTO Erreur
    (erreur_text)
    VALUES ("Le loyer doit être strictement inférieur à 2000€ par mois");
    END IF;
END |
DELIMITER ;


-- PROCEDURE pour vérifier le montant du loyer
DELIMITER |
CREATE PROCEDURE VerifMontantLoyer(IN logement INT)
BEGIN
SELECT logement_loyer
FROM logement
WHERE logement_id = logement;
END|
DELIMITER ;


-- Insertion des nouvelles données
INSERT INTO proprietaire
(proprietaire_nom, proprietaire_prenom, proprietaire_tel, proprietaire_ville , proprietaire_cp, proprietaire_rue)
VALUES
("DEV", "Mike", "06-02-03-04-05", "Vieux-Condé", 59690, "637 rue Jean Jaurès");

INSERT INTO logement
(logement_surface, logement_loyer, logement_ville, logement_cp, logement_rue, type_logement_id)
VALUES
(30, 320, "Mulhouse", "68100", "23 rue des Macarons", 1),
(205, 2050, "Wittenheim", "68270", "97 rue de la frangipane", 2);

INSERT INTO posseder
(proprietaire_id, logement_id)
VALUES
(4, 6),
(4, 7);

INSERT INTO donner_gestion
(proprietaire_id, logement_id, duree, pourcentage_loyer)
VALUES
(4, 6, 20, 6),
(4, 7, 20, 3);

CALL VerifMontantLoyer(6);
CALL VerifMontantLoyer(7);