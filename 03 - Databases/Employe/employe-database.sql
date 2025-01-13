DROP DATABASE IF EXISTS employe;
CREATE DATABASE employe;
USE employe;

CREATE TABLE dept
(
	deptno TINYINT,
    dname VARCHAR(50) NOT NULL,
    loc VARCHAR(50) NOT NULL,
    CONSTRAINT pk_dept PRIMARY KEY (deptno)
);

CREATE TABLE emp
(
	empno SMALLINT,
    ename VARCHAR(50) NOT NULL,
    job VARCHAR(50) NOT NULL,
    mgr SMALLINT,
    hiredate DATE NOT NULL,
    sal SMALLINT,
    comm SMALLINT,
    deptno TINYINT,
    CONSTRAINT pk_emp PRIMARY KEY (empno),
    CONSTRAINT fk_emp_deptno FOREIGN KEY (deptno) REFERENCES dept (deptno)
);

INSERT INTO dept 
(deptno, dname, loc)
VALUES
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

INSERT INTO emp
(empno, ename, job, mgr, hiredate, sal, comm, deptno)
VALUES
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-07-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1982-12-09', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1983-01-12', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

ALTER TABLE emp 
ADD CONSTRAINT fk_emp_mgr FOREIGN KEY (mgr) REFERENCES emp (empno);

-- 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
SELECT ename, job, empno, sal
FROM emp
WHERE deptno = 10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT ename, job, sal
FROM emp
WHERE job = 'MANAGER' AND sal > 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30
SELECT *
FROM emp
WHERE job = 'MANAGER' AND deptno != 30;

-- 4. Liste des employés de salaire compris entre 1200 et 1400
SELECT *
FROM emp
WHERE sal BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT *
FROM emp
WHERE deptno IN (10, 30)
ORDER BY ename;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT *
FROM emp 
WHERE deptno = 30
ORDER BY sal;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants
SELECT *
FROM emp
ORDER BY job ASC, sal DESC;

-- 8. Liste des différents emplois
SELECT job
FROM emp
GROUP BY job;

-- 9. Donner le nom du département où travaille ALLEN
SELECT dname 
FROM dept
JOIN emp 
ON emp.deptno = dept.deptno
WHERE ename = 'ALLEN';

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.
SELECT dept.dname, ename, job, sal
FROM emp
JOIN dept
ON dept.deptno = emp.deptno
ORDER BY dname AND sal DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT ename, sal, comm, sal + comm
FROM emp
WHERE job = 'SALESMAN';

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'
SELECT ename, job, DATE_FORMAT(hiredate, "%W %e %M %Y")
FROM emp
WHERE deptno = 20;

-- 13. Donner le salaire le plus élevé par département
SELECT MAX(sal)
FROM emp
GROUP BY deptno;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT SUM(sal), COUNT(empno), AVG(sal)
FROM emp
GROUP BY deptno;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés
-- SELECT SUM(sal), COUNT(empno), AVG(sal)
-- FROM emp
-- GROUP BY deptno;

-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES
-- ELECT ename, dname, sal
-- FROM emp
-- JOIN dept
-- ON dept.deptno = emp.deptno
-- WHERE 

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
SELECT ename, sal
FROM emp
WHERE sal > AVG(sal);

-- 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
-- 101, ALPHA, 96000
-- 102, BETA, 82000
-- 103, GAMMA, 15000

-- 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102

-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet

-- 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet

-- 22.Donner le nom du projet associé à chaque manager
