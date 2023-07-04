$( window ).on( "load", function() {
    
    function setHeaderStatus() {
        if ($(window).scrollTop() > 0) {
            $('.header-of-page').addClass('header-scrolls');
        } else {
            $('.header-of-page').removeClass('header-scrolls');
        }
    }
    $(window).scroll(function() {
        setHeaderStatus();
    });
    
    setHeaderStatus();

    $(window).resize(function() {
        if (window.innerWidth > 1099) {
            $('.header-of-page .header-nav .active').find('.second-menu').css('display', 'none');
        } else {
            $('.header-of-page .header-nav .active').find('.second-menu').css('display', 'block');
            $('.header-of-page .header-nav .active').siblings('.nav-item').find('.second-menu').css('display', 'none')
        }
    });

    $('.header-of-page .nav-item').hover(function() {
        if (window.innerWidth > 1099) {
            $(this).find('.second-menu').css('display', 'block');
        }
    }, function() {
        if (window.innerWidth > 1099) {
            $(this).find('.second-menu').css('display', 'none');
        }
    });

    $('.header-of-page .nav-item .first-nav').click(function() {
        if (window.innerWidth <= 1099) {
            if ($(this).parents('.nav-item').hasClass('active')) {
                $(this).parents('.nav-item').removeClass('active').find('.second-menu').slideUp(300);
            } else {
                $(this).parents('.nav-item').addClass('active').find('.second-menu').slideDown(300);
            }
        } 
    });
});