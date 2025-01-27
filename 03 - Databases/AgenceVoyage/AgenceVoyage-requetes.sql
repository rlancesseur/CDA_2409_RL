USE agencevoyage;

/* 1. Afficher les informations de toutes les villes (informations du pays incluses). */
SELECT city_name, country_name, country_code
FROM city
NATURAL JOIN country;

-- 2. Sélectionner tous les clients (code et nom de son commercial inclus).
SELECT client_lastname, client_firstname, com_code, com_name
FROM client
NATURAL JOIN commercial;

-- 3. Sélectionner le client n°3 (code et nom du commercial associé inclus).
SELECT client_lastname, client_firstname, com_code, com_name
FROM client
NATURAL JOIN commercial
WHERE client_id = 3;

-- 4. Sélectionner tous les clients ayant réservé au moins un voyage (le nombre de voyages réservés inclus)
SELECT client_lastname, client_firstname, trip_title, order_quantity
FROM client
NATURAL JOIN reserver 
NATURAL JOIN trip
WHERE order_quantity > 1;

-- 5.  Sélectionner le dernier voyage du client n°3 (nom de la ville et du pays inclus).

-- 6. Sélectionner toutes les réservations non payées (code et nom de client inclus).

-- 7.  Afficher le total payé par le client n°3 (pour chaque voyage : prix * nombre de places réservées).

