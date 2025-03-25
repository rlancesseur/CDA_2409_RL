<template>
    <header>
        <div id="imgBanniere">
        
        </div>
        <nav>
            <ul>
                <li><RouterLink to="/sales">Ventes</RouterLink></li>
                <li><RouterLink to="/newSales">Nouvelle vente</RouterLink></li>
            </ul>
            <ul>
                <li><RouterLink to="/legumes">Légumes</RouterLink></li>
                <li><RouterLink to="/newLegume">Nouveau légume</RouterLink></li>
            </ul>
        </nav>
    </header>
    <main>
        <RouterView />
    </main>
</template>

<script setup></script>
