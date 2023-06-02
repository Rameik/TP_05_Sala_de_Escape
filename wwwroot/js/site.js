// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const menuTrigger = document.getElementById('menu-trigger');
const menu = document.getElementById('menu');

menuTrigger.addEventListener('click', function() {
  if (menu.style.display === 'none') {
    menu.style.display = 'inline-block';
  } else {
    menu.style.display = 'none';
  }
});

document.addEventListener('DOMContentLoaded', function() {
  menu.style.display = 'none';
});