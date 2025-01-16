-- 1. Quels sont les vols au départ de Paris entre 12h et 14h ?
SELECT vol
FROM vol
WHERE vd = 'PARIS' AND hd IN (12, 14);

-- 2. Quels sont les pilotes dont le nom commence par "S" ?
SELECT pilnom
FROM pilote
WHERE pilnom LIKE "S%";

-- 3. Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent.
SELECT loc, count(av) AS 'Nombre d\'avion', min(cap), max(cap)
FROM avion
GROUP BY loc;

-- 4. Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion.
SELECT loc, avtype AS 'Type d\'avion', avg(cap)
FROM avion
GROUP BY loc, avtype;

-- 5. Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ?
SELECT loc, count(av), avg(cap)
FROM avion
GROUP BY loc
HAVING count(av) > 1;

-- 6. Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un airbus ?
SELECT pilnom
FROM pilote, avion
WHERE pilote.adr = avion.loc AND avion.avmarq = 'AIRBUS';

-- 7. Quels sont les noms des pilotes qui conduisent un Airbus ET qui habitent dans la ville de localisation d'un Airbus ?
SELECT pilnom
FROM pilote, avion
WHERE pilote.adr = avion.loc AND avion.avmarq = 'AIRBUS'
AND pilnom IN (SELECT pilnom FROM vol JOIN pilote ON pilote.pil = vol.pil JOIN avion ON avion.av = vol.av WHERE avion.avmarq = 'AIRBUS');

-- 8. Quels sont les noms des pilotes qui conduisent un Airbus OU qui habitent dans la ville de localisation d'un Airbus ?
SELECT pilnom
FROM pilote, avion
WHERE pilote.adr = avion.loc AND avion.avmarq = 'AIRBUS'
OR pilnom IN (SELECT pilnom FROM vol JOIN pilote ON pilote.pil = vol.pil JOIN avion ON avion.av = vol.av WHERE avion.avmarq = 'AIRBUS')
GROUP BY pilnom;

 -- 9. Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?
SELECT pilnom
FROM pilote, avion
WHERE pilote.adr = avion.loc AND avion.avmarq != 'AIRBUS'
AND pilnom IN (SELECT pilnom FROM vol JOIN pilote ON pilote.pil = vol.pil JOIN avion ON avion.av = vol.av WHERE avion.avmarq = 'AIRBUS')
GROUP BY pilnom;
 
-- 10. Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?
SELECT vol 
FROM vol
WHERE vd IN (SELECT vd FROM vol JOIN pilote ON vol.pil = pilote.pil WHERE pilnom = 'SERGE')
AND va IN (SELECT va FROM vol JOIN pilote ON vol.pil = pilote.pil WHERE pilnom = 'SERGE'); 

-- 11. Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).
SELECT p1.pilnom, p2.pilnom
FROM pilote p1
JOIN pilote p2
WHERE p1.adr = p2.adr AND p1.pilnom != p2.pilnom;

-- 12. Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ? 
SELECT pilnom
FROM pilote
JOIN vol ON pilote.pil = vol.pil
WHERE av IN (SELECT av FROM vol WHERE pil = 1);

-- 13. Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée. 
SELECT vd ,va
FROM vol
JOIN avion ON avion.av = vol.av
WHERE avion.loc IN (SELECT adr FROM pilote);

-- 14. Sélectionner les numéros des pilotes qui conduisent tous les Airbus ? 
SELECT DISTINCT pil
FROM pilote
WHERE pil IN (SELECT pil FROM vol JOIN avion ON avion.av = vol.av WHERE avmarq = "AIRBUS"); /* Vérifie pas TOUS */
