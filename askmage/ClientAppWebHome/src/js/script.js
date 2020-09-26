
$( document ).ready(function() {
    /* progress bar */
    if($('#loadingBar').length > 0){
        var i = 0;
        if(i == 0){
            i = 1;
            var width = 1;
            var id = setInterval(frame, 15);
            function frame() {
                if (width >= 100) {
                    clearInterval(id);
                    i = 0;
                    window.location.replace("home.html");
                } else {
                    width++;
                    $('.bar').css("width",width +"%");
                    $('.loading-percent').text(width + "%");
                }
            }
            
        }
    }
    /* script run select option */
    if($('select').length > 0){
        $('select').niceSelect();
    }

    /* Begin script run side bar */
    $('.panel-menu .accordion').on('show.bs.collapse', function (e) {
        $(e.target).prev('.card-header').addClass('active');
    })
   
    $('.panel-menu .accordion').on('hide.bs.collapse', function (e) {
       $(this).find('.card-header').not($(e.target)).removeClass('active');
    });

    $('.navbar-item-toggler').on('click', function(){
        $('.sidebar').addClass("open");
    })
    $('.close-sidebar').on('click',function(){
        $('.sidebar').removeClass("open");
    })
    /* End script run side bar */

    /* smartwizard */
    if($('#smartwizard').length > 0){
        $('#smartwizard').smartWizard({
            enableURLhash: false,
            anchorSettings: {
                anchorClickable: true,
                enableAllAnchors: true, 
                markDoneStep: true,
                markAllPreviousStepsAsDone: true,
                removeDoneStepOnNavigateBack: false,
                enableAnchorOnDoneStep: true
            },
            lang: { 
                next: 'Tương lai',
                previous: 'Quá khứ'
            },
        });
    }

    if($('#imagesSlider').length > 0){
        $('#imagesSlider').refineSlide({
            maxWidth: 500
        });
    }
    

});