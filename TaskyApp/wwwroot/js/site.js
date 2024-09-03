// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function RegisterWindow() {
    document.getElementById('mainWindow').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
}

// Function to hide the registration window and overlay
function CloseWindow() {
    document.getElementById('mainWindow').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}


