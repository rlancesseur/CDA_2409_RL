document.addEventListener('mousemove', (e) => {
    const style = document.documentElement.style;
    style.setProperty('--x', `${e.clientX}px`);
    style.setProperty('--y', `${e.clientY}px`);
});