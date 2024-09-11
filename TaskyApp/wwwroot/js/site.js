// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function RegisterWindow() {
    const mainWindow = document.getElementById('mainWindow');
    const overlay = document.getElementById('overlay');

    // Remove the 'hide' class to make it visible
    mainWindow.classList.remove('hide');
    mainWindow.style.display = 'block';
    overlay.style.display = 'block';
}

// Function to hide the registration window and overlay with animation
function CloseWindow() {
    const mainWindow = document.getElementById('mainWindow');
    const overlay = document.getElementById('overlay');

    // Add the 'hide' class to trigger the fade-out effect
    mainWindow.classList.add('hide');

    // Wait for the fade-out animation to finish before hiding completely
    setTimeout(function () {
        mainWindow.style.display = 'none';
        overlay.style.display = 'none';
    }, 500); // Matches the CSS transition time (0.5s)
}

