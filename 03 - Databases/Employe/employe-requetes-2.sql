-- 1. Afficher la liste des managers des départements 20 et 30
SELECT *
FROM emp
WHERE job = 'MANAGER' AND deptno IN (20, 30);

-- 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
SELECT *
FROM emp
WHERE job != 'MANAGER' AND hiredate LIKE '%1981%';

-- 3. Afficher la liste des employés ayant une commission
SELECT *
FROM emp
WHERE comm > 0;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de département et JOB les derniers embauches d'abord.
SELECT ename, deptno, job, hiredate
FROM emp 
ORDER BY deptno, job, hiredate DESC;

-- 5. Afficher la liste des employés travaillant à DALLAS
SELECT *
FROM emp
JOIN dept
ON dept.deptno = emp.deptno
WHERE loc = 'DALLAS';

-- 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.
SELECT e.ename, m.ename, e.hiredate, m.hiredate
FROM emp e
JOIN emp m 
ON e.mgr = m.empno
WHERE e.hiredate < m.hiredate;

-- 7. Lister les numéros des employés n'ayant pas de subordonné.
SELECT empno
FROM emp
WHERE empno NOT IN (SELECT mgr FROM emp WHERE mgr IS NOT NULL);

-- 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.
SELECT ename, hiredate
FROM emp
WHERE hiredate < (SELECT hiredate FROM emp WHERE ename = 'BLAKE');

-- 9. Afficher les employés embauchés le même jour que FORD.
SELECT ename
FROM emp
WHERE hiredate = (SELECT hiredate FROM emp WHERE ename = 'FORD') AND ename != 'FORD';

-- 10. Lister les employés ayant le même manager que CLARK.
SELECT *
FROM emp
WHERE mgr IN (SELECT mgr FROM emp WHERE ename = 'CLARK') AND ename != 'CLARK';

-- 11. Lister les employés ayant même job et même manager que TURNER.
SELECT *
FROM emp 
WHERE job = (SELECT job FROM emp WHERE ename = 'TURNER') AND mgr IN (SELECT mgr FROM emp WHERE ename = 'TURNER') AND ename != 'TURNER';

-- 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.
SELECT * 
FROM emp 
JOIN dept ON dept.deptno = emp.deptno
WHERE dname = 'RESEARCH' AND hiredate IN (SELECT hiredate FROM emp JOIN dept ON dept.deptno = emp.deptno WHERE dname = 'SALES');


-- 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.
SELECT ename, date_format(hiredate, '%W') AS 'jour-d-embauche'
FROM emp;

-- 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.
SELECT ename, timestampdiff(month, hiredate, CURDATE())
FROM emp;

-- 15. Afficher la liste des employés ayant un M et un A dans leur nom.
SELECT *
FROM emp
WHERE ename LIKE "%M%" AND ename LIKE "%A%";

-- 16. Afficher la liste des employés ayant deux 'A' dans leur nom.
SELECT *
FROM emp
WHERE ename LIKE "%A%A%";

-- 17. Afficher les employés embauchés avant tous les employés du département 10.
SELECT *
FROM emp 
WHERE hiredate < ALL (SELECT hiredate FROM emp WHERE deptno = 10);

-- 18. Sélectionner le métier où le salaire moyen est le plus faible.
SELECT job
FROM emp
GROUP BY job
HAVING AVG(sal) <= ALL (SELECT AVG(sal) FROM emp GROUP BY job);

-- 19. Sélectionner le département ayant le plus d'employés.
SELECT dname, COUNT(dname)
FROM dept
JOIN emp ON emp.deptno = dept.deptno
GROUP BY dept.deptno
HAVING count(dname) >= ALL (SELECT count(dname) FROM dept JOIN emp ON emp.deptno = dept.deptno GROUP BY dname);

-- 20.Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci dessous
--    Département   Répartition en %
--     ---------   ----------------
--        10           21.43
--        20           35.71
--        30           42.86

SELECT dept.deptno, (COUNT(emp.empno) / (SELECT COUNT(emp.empno) FROM emp)) * 100
FROM dept 
JOIN emp ON dept.deptno = emp.deptno 
GROUP BY dept.deptno;
