// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*Snippet from user myfunkyside on stackoverflow (I use this pretty often so I figured it's nice to give the guy credit)*/
$(window).on("load", function () {
    $(window).scroll(function () {
        var windowBottom = $(this).scrollTop() + $(this).innerHeight();
        $(".fade").each(function () {
            /* Check the location of each desired element */
            var objectBottom = $(this).offset().top + $(this).outerHeight();

            /* If the element is completely within bounds of the window, fade it in */
            if (objectBottom < windowBottom) { //object comes into view (scrolling down)
                if ($(this).css("opacity") == 0) { $(this).fadeTo(250, 1); }
            } else { //object goes out of view (scrolling up)
                if ($(this).css("opacity") == 1) { $(this).fadeTo(250, 0); }
            }
        });
    }).scroll(); //invoke scroll-handler on page-load
});