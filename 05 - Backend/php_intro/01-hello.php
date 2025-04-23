<?php

// Affiche "Hello World !"
function helloWorld(): void
{
    echo "Hello World !";
}


// Retourne "Hello $name !"
function hello(string $name): string
{
    if ($name !== "") {
        return 'Hello' . $name;
    } else {
        return "Nobody";
    }
}
