**1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10**
```
db.emp.find({deptno: {$eq: 10}}, {ename : 1, job : 1, sal : 1, deptno : 1})
```

**2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800**
```
db.emp.find({job : {$eq : "MANAGER"}, sal : {$gte:2800}}, {ename : 1, job : 1, sal : 1})
```

**3. Donner la liste des MANAGER n'appartenant pas au département 30**
```
db.emp.find({job : {$eq : "MANAGER"}, deptno : {$ne : 30}})
```

**4. Liste des employés de salaire compris entre 1200 et 1400**
```
db.emp.find({sal : {$gte : 1200, $lte : 1400}})
```

**5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique**
```
db.emp.find({$or : [{deptno : {$eq : 10}}, {deptno : {$eq : 30}}]}).sort({ename : 1})
```

**6. Liste des employés du département 30 classés dans l'ordre des salaires croissants**
```
db.emp.find({deptno : {$eq : 30}}).sort({sal : 1})
```

**7. Liste de tous les employés classés par emploi et salaires décroissants**
```
db.emp.find({}).sort({job: 1, sal: -1})
```

**8. Liste des différents emplois**
```
db.emp.distinct("job")
```

**9. Donner le nom du département où travaille ALLEN**
```
db.emp.find({ename : {$eq : "ALLEN"}}, {dname : 1})
```


**10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.**
```
db.emp.find({},{dname : 1, ename : 1, job : 1, sal : 1}).sort({dname : 1, sal : -1})
```


**11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions**
```
db.emp.find({job : {$eq : "SALESMAN"}}, {dname : 1, sal : 1, comm : 1, SalaireCommission: {$add : ["$sal", "$comm"]}})
```


**12. Donner le salaire le plus élevé par département**
```
db.emp.aggregate({$group:{_id: "$dname", sal_max: {$max: "$sal"}}})
```


**13. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.**
```
db.emp.aggregate([{$group:{_id: {departement: "$dname", job: "$job"}, masse_salariale: {$sum:"$sal"}, nbr_employes: {$sum: 1}, salaire_moyen: {$avg: "$sal"}}}])
```
