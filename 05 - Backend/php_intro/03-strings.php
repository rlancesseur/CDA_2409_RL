<?php

function getMC2(): string
{
    return "Albert Einstein";
}


function getUserName(string $name, string $username): string
{
    return $name . $username;
}


function getFullName(string $name, string $username): string
{
    return ucfirst(strtolower($name)) . ' ' . strtoupper($username);
}


function askUser(string $name, string $username): string
{
    return "Bonjour" . " " . getFullName($name, $username) . ". Connaissez-vous " . getMC2() . ' ?';
}


function capitalCity(string $val, bool $isCountry = true): string
{
    $capital = [
        'France' => 'Paris',
        'Allemagne' => 'Berlin',
        'Italie' => 'Rome',
        'Maroc' => 'Rabat',
        'Espagne' => 'Madrid',
        'Portugal' => 'Lisbonne',
        'Angleterre' => 'Londres'
    ];

    $capital['Suède'] = 'Oslo';


    return $isCountry ? $capital[$val] : array_search($val, $capital);
}
