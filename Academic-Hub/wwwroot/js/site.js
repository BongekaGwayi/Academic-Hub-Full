// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var x = document.getElementById('sidePane');
var b = document.getElementById('paneToggler');
var l = document.getElementById('main-pane');
function toggleSide() {
    if (x.style.display === "none") {
        x.style.display = "flex";
        l.style.width = "800px";
        b.style.display = "none"
    }
    else {
        x.style.display = "none";
        b.style.display = "inline-block";
        l.style.width = "100%";

    }
}