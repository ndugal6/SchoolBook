
jQuery(function ($) {

    'use strict';
	 $.backstretch(
        [
            "img/slider/img1.jpg",
            "img/slider/img2.jpg",
            "img/slider/img3.jpg"
            
        ],

        {
            duration: 4500,
            fade: 1500
        }
    );	
	
	/*==============================================================*/
    // owlCarousel
    /*==============================================================*/
	$("#features-slider").owlCarousel({ 
		autoPlay: 3000, //Set AutoPlay to 3 seconds	 
		items : 3,		
		itemsDesktop : [1199,3],
		itemsDesktopSmall : [979,3],
		itemsTablet	:	[767,2],
		itemsMobile	:	[479,1],
		pagination	: false,
		navigation:true,
		navigationText: [
		  "<i class='fa fa-angle-left '></i>",
		  "<i class='fa fa-angle-right'></i>"
		],
		
		
		afterAction: function(el){
		   //remove class active
		   this
		   .$owlItems
		   .removeClass('active')
		  
		   //add class active
		   this
		   .$owlItems //owl internal $ object containing items
		   .eq(this.currentItem + 1)
		   .addClass('active')
		  
		}
	});
	
	$("#screenshot-slider").owlCarousel({ 
		autoPlay: 4000, //Set AutoPlay to 4 seconds	 
		items : 4,
		itemsDesktop : [1199,4],
		itemsDesktopSmall : [979,3],
		itemsTablet : [768,3],
		itemsMobile	: [479,1],
		pagination	: true,
	});
  
	$("#review-slider").owlCarousel({ 
		autoPlay: 3000, //Set AutoPlay to 4 seconds	 
		items : 2,
		itemsDesktop : [1199,2],
		itemsDesktopSmall : [979,2],
		itemsTablet : [768,2],
		itemsMobile	: [479,1],
		pagination	: false,
		navigation:true,
		navigationText: [
		  "<i class='fa fa-angle-left '></i>",
		  "<i class='fa fa-angle-right'></i>"
		],
	});
	
});

/* ==== 15) Random number counter ==== */

	$.fn.waypoint.defaults = {
		context: window,
		continuous: true,
		enabled: true,
		horizontal: false,
		offset: 'bottom-in-view',
		triggerOnce: true
	}

	$('#counter-1, #counter-2, #counter-3, #counter-4').kCounter({ initial: 0, duration: 2000, easing: 'swing', width: 25 }) ;

	var $counter = $('.counter');
	if ( $counter.length){
		$('.counter').waypoint(function(direction) {
			$('#counter-1').kCounter('update', 90) ;
			$('#counter-2').kCounter('update', 85) ;
			$('#counter-3').kCounter('update', 75) ;
			$('#counter-4').kCounter('update', 65) ;
		});
	}


/*==============================================================*/
//Mobile Toggle Control
/*==============================================================*/
$(function () {
    var navMain = $("#navigation");
    navMain.on("click", "a", null, function () {
        navMain.collapse('hide');
    });
});

	/*==============================================================*/
    // Menu add class
    /*==============================================================*/
	(function () {	
		function menuToggle(){
			var windowWidth = $(window).width();
			if(windowWidth > 767 ){
				$(window).on('scroll', function(){
					if( $(window).scrollTop()>700 ){
						$('.navbar').addClass('main-nav');
					} else {
						$('.navbar').removeClass('main-nav');
					};
					if( $(window).scrollTop()>61 ){
						$('.menu-hide-page #navigation').removeClass('menu-hide');						
					} else {
						$('.menu-hide-page #navigation').addClass('menu-hide');
					}
				});
			}else{
				$('.menu-hide-page #navigation').removeClass('menu-hide');	
				$('.navbar').addClass('main-nav');
			};	
		}

		menuToggle();
	}());
	
	/*==============================================================*/
    // Menu Scrolling
    /*==============================================================*/
	$('#navigation .navbar-nav').onePageNav({
			currentClass: 'active',
			filter: ':not(.exclude)',
		});
	
