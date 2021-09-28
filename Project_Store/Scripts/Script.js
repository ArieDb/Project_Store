(document).ready(function () {

    $('.datepicker').datepicker({
        format: 'dd-mm-yyyy',
        i18n: {
            months: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"],
            monthsShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Set", "Oct", "Nov", "Dic"],
            weekdays: ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"],
            weekdaysShort: ["Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab"],
            weekdaysAbbrev: ["D", "L", "M", "M", "J", "V", "S"],
            cancel: 'Cancelar',
            clear: 'Limpiar',
            done: 'Aceptar',
            previousMonth: '< Anterior',
            nextMonth: 'Siguiente >',
        },
        showDaysInNextAndPreviousMonths: true,
        yearRange: [1900, 2040],
        changeMonth: true,
        changeYear: true,
    });

    $('.sidenav').sidenav();
    $('select').formSelect();
    $('.modal').modal();
    $('.timepicker').timepicker({
        i18n: {
            cancel: 'Cancelar',
            done: 'Aceptar'
        },
        format: "hh:mm:ss",
        twelveHour: false
    });

    $('.carousel.carousel-slider').carousel({
        fullWidth: true,
        indicators: true
    });
   
})