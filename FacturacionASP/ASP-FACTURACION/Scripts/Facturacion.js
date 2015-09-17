$(function () {
    $("#fecha").datepicker({
        dateFormat: "yy-mm-dd" 
    });

    var reglas = {

        cedula: { required: true, digits: true },
        nombre: { required: true },
        fecha: { required: true },
        email: { required: true, email:true },
        precio: { required: true, number: true, min: 100 },
        cantidad: { required: true, digits: true, min: 1 }

    }

    var mensajes = {

        cedula: { required: "Este campo es obligatorio", digits: "Solo numeros naturales" },
        nombre: { required: "Esta campo es obligatorio" },
        fecha: { required: "Este campo es obligatorio" },
        email: { required: "Este campo es obligatorio", email: "No es un email valido" },
        precio: { required: "Este campo es obligatorio", number: "No es un numero", min: "El minimo es 100" },
        cantidad: { required: "Este campo es obligatorio", digits: "Solo numeros naturales", min: "El minimo es 1" }

    }

    $("#form1").validate({
        rules: reglas,
        messages: mensajes
    });

})