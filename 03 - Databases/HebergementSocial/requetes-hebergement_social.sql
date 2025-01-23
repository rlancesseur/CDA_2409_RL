USE hebergement_social;

/* 1. Sélectionner tous les éducateurs. */
SELECT individu_nom, individu_prenom, individu_date_naissance, role_libelle 
FROM individu
NATURAL JOIN role
WHERE role_id = 5;

/* 2. Sélectionner tous les employés autre que le directeur. */
SELECT role_libelle, individu_nom, individu_prenom 
FROM individu
NATURAL JOIN role
WHERE role_id != 1;

/* 3. Sélectionner toutes les personnes triées par rôle puis par nom. */
SELECT role_id, individu_nom, individu_prenom
FROM individu
ORDER BY role_id, individu_nom;

/* 4. Sélectionner tous les rôles avec le nombre de personnes associées à chaque rôle. */
SELECT role_libelle, count(individu_id) AS "Nbr d'individus par rôle"
FROM role
NATURAL JOIN individu
GROUP BY (role_id);

/* 5. Sélectionner tous les résidents actifs du plus jeune au plus âgé. */
SELECT role_id, individu_nom, individu_prenom, individu_date_naissance
FROM individu
NATURAL JOIN role
WHERE role_id = 7
ORDER BY individu_date_naissance DESC;

/* 6. Sélectionner tous les résidents suivis par un médecin avec nom et prénom du médecin attitré. */
SELECT individu_id, individu_id_1, individu_nom, individu_prenom
FROM soigner
NATURAL JOIN individu;

/* 7. Sélectionner tous les médecins avec le nombre de résidents qu’il suivent. */
SELECT role_id, individu_nom, individu_prenom, count(individu_id)
FROM individu
NATURAL JOIN role
GROUP BY role_id;
