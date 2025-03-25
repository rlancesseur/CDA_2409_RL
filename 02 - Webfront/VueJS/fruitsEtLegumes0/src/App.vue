<template>
  <header>
    <div id="imgBanniere"></div>
    <nav>
      <RouterLink to="/sales">Sales</RouterLink>
      <RouterLink to="/">Légumes</RouterLink>
    </nav>
  </header>
  <main>
    <RouterView />
  </main>
</template>

<script setup></script>
