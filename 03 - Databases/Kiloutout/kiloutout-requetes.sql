USE ecf_kiloutout_lancesseur;

-- 1/ 
SELECT concat(logement_ville, " ", logement_cp, " ", logement_rue) AS Adresse, logement_loyer, pourcentage_loyer
FROM logement 
JOIN donner_gestion ON donner_gestion.logement_id = logement.logement_id
ORDER BY logement_loyer DESC;

-- 2 a.
SELECT concat(logement_ville, " ", logement_cp, " ", logement_rue) AS Adresse, logement_loyer
FROM logement
NATURAL JOIN louer
ORDER BY location_date_debut;

-- 2 b.
SELECT proprietaire_nom, proprietaire_prenom
FROM proprietaire
NATURAL JOIN posseder
NATURAL JOIN logement
NATURAL JOIN louer
ORDER BY location_date_debut;

-- 2 c.
SELECT locataire_nom, locataire_prenom, locataire_tel
FROM locataire
NATURAL JOIN louer
ORDER BY location_date_debut;

-- 2 d.
SELECT location_date_debut AS "Date de début du bail", location_duree, year(location_date_debut) + location_duree AS "Année de fin du bail"
FROM louer
ORDER BY location_date_debut;

-- 3 a.
SELECT proprietaire_id , proprietaire_nom , proprietaire_prenom, proprietaire_tel, 
		concat(proprietaire_ville, " ", proprietaire_cp, " ", proprietaire_rue) AS "Adresse propriétaire",
		COUNT(posseder.logement_id) AS "Logements possédés"
FROM proprietaire
NATURAL JOIN posseder
NATURAL JOIN logement
GROUP BY proprietaire_id;

-- 3 b.
SELECT proprietaire_id , proprietaire_nom , proprietaire_prenom, proprietaire_tel, 
		concat(proprietaire_ville, " ", proprietaire_cp, " ", proprietaire_rue) AS "Adresse propriétaire",
		SUM(logement_loyer) AS "Montant total des loyers"
FROM proprietaire
NATURAL JOIN logement
NATURAL JOIN posseder
GROUP BY proprietaire_id;


