// JavaScript source code

$(function () {
    var cadena = $('#mensaje').text();
    var palabra = $('#mensaje span').text();
    var dialogo = $('#dialog').dialog();

    $('#dialog p').append(cadena.length + " caracateres!!");
    $('#dialog').append("<p>La palabra " + palabra + " tiene " + palabra.length + " caracateres!!");
        
});