// theme.js is responsible for managing theme interop functionality, updating the body class and persisting the theme preference in localStorage.

document.addEventListener("DOMContentLoaded", function() {
    const themeToggleButton = document.getElementById("theme-toggle");
    const currentTheme = localStorage.getItem("theme") || "light";

    // Apply the current theme on page load
    document.body.classList.add(currentTheme);

    // Toggle theme function
    function toggleTheme() {
        if (document.body.classList.contains("light")) {
            document.body.classList.remove("light");
            document.body.classList.add("dark");
            localStorage.setItem("theme", "dark");
        } else {
            document.body.classList.remove("dark");
            document.body.classList.add("light");
            localStorage.setItem("theme", "light");
        }
    }

    // Event listener for the theme toggle button
    if (themeToggleButton) {
        themeToggleButton.addEventListener("click", toggleTheme);
    }
});