<?php 
session_start();
echo $_SESSION['name'];

?>

<!DOCTYPE html>

<html lang="fr">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Basic Template</title>
        <link rel="stylesheet" href="css/style.css">
    </head>

    <body>
        <header>
            <h1>Mon blog technique</h1>
        </header>

        <nav>
            <label for="hamburger" class="label-hamburger">&#9776;</label>
            <input type="checkbox" id="hamburger">
            <h2>Menu</h2>
            <ul>
                <li><a href="/pages/accueil.php">Accueil</a></li>
                <li><a href="">Articles</a></li>
                <li><a href="">Tutoriaux</a></li>
                <li><a href="">A propos</a></li>
                <li><a href="">Contact</a></li>
            </ul>
        </nav>

        <main>
            <article>
                <h2>Bienvenue sur notre site</h2>
                <section>
                    <h3>Article #1</h3>
                    <p></p>
                </section>
                <section>
                    <h3>Article #2</h3>
                    <p></p>
                </section>
                <section>
                    <h3>Article #3</h3>
                    <p></p>
                </section>
                <section>
                    <h3>Article #4</h3>
                    <p></p>
                </section>
                <section>
                    <h3>Article #5</h3>
                    <p></p>
                </section>
                <section>
                    <h3>Article #6</h3>
                    <p></p>
                </section>
            </article>

            <aside>
                <h3>Publicité</h3>
                <img src="img/basic-template-aside.jpg" alt="Pub livre algorithme" />
                <p>Ce livre sur l'algorithme s'adresse à tout personne désireuse de maîtriser les bases essentielles de la programmation.
                    Pour apprendre à programmer, il faut d'abord comprendre ce qu'est vraiment un ordinateur, comment il fonctionne et
                    surtout comment il peut faire fonctionner des programmes, comment il manipule et stocke les données et les instructions;
                    quelle est sa logique. Alors, au fur et à mesure, le reste devient évidence : variables, conditions, boucles...
                </p>
                <button>J'achète !</button>
            </aside>
        </main>
    </body>
</html>