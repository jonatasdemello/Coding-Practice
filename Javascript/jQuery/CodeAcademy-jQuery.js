//#
//# CodeAcademy https://www.codecademy.com/learn/learn-jquery
//#

$(document).ready(() => {
    const $menuButton = $('.menu-button');
    const $navDropdown = $('#nav-dropdown');
  
    $menuButton.on('click', () => {
      $navDropdown.show();
    })
    
    $navDropdown.on('mouseleave', () => {
      $navDropdown.hide();
    })
  })

  $(document).ready(() => {
    $('.menu-button').on('click',() => {
      $('#nav-dropdown').slideToggle('slow');
    });
      
    $(".login-button").on("click", () => {
      $(".login-form").slideToggle();
    });
    
    $(".arrow-one").on("click", () => {
      $(".shoe-details-one").toggle();
    });
    
    $(".sizes-one").on("click", () => {
      $(".text-one").fadeIn(1000);
    });
    
    $(".arrow-two").on("click", () => {
      $(".shoe-details-two").toggle();
    });
    
    $(".sizes-two").on("click", () => {
      $(".text-two").fadeIn();
    });
    
    $(".arrow-three").on("click", () => {
      $(".shoe-details-three").toggle();
    });
    
    $(".sizes-three").on("click", () => {
      $(".text-three").fadeIn(1000);
    });
   
  });

  $(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
  });

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
});

$(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
    
    $('.show-button').on('click', () => {
      $('.first-image').show();
    });
    
    $('.toggle-button').on('click', () => {
      $('.first-image').toggle();
    });
    
  });

  $(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
    
    $('.show-button').on('click', () => {
      $('.first-image').show();
    });
    
    $('.toggle-button').on('click', () => {
      $('.first-image').toggle();
    });
    
    $('.fade-out-button').on('click', () => {
      $('.fade-image').fadeOut(500);
    });
    
    $('.fade-in-button').on('click', () => {
      $('.fade-image').fadeIn(4000);
    });
    
  });

  $(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
    
    $('.show-button').on('click', () => {
      $('.first-image').show();
    });
    
    $('.toggle-button').on('click', () => {
      $('.first-image').toggle();
    });
    
    $('.fade-out-button').on('click', () => {
      $('.fade-image').fadeOut(500);
    });
    
    $('.fade-in-button').on('click', () => {
      $('.fade-image').fadeIn(4000);
    });
    
    $('.fade-toggle-button').on('click', () => {
          $('.fade-image').fadeToggle('fast');
    });
  });

  $(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
    
    $('.show-button').on('click', () => {
      $('.first-image').show();
    });
    
    $('.toggle-button').on('click', () => {
      $('.first-image').toggle();
    });
    
    $('.fade-out-button').on('click', () => {
      $('.fade-image').fadeOut(500);
    });
    
    $('.fade-in-button').on('click', () => {
      $('.fade-image').fadeIn(4000);
    });
    
    $('.fade-toggle-button').on('click', () => {
      $('.fade-image').fadeToggle();
    });
    
    $('.up-button').on('click', () => {
          $('.slide-image').slideUp(100);
    });
    
    $('.down-button').on('click', () => {
      $('.slide-image').slideDown('slow');
    });
    
    $('.slide-toggle-button').on('click', () => {
      $('.slide-image').slideToggle('slow');
    });
    
  });

  $(document).ready(() => {
    $('.hide-button').on('click', () => {
      $('.first-image').hide();
    });
    
    $('.show-button').on('click', () => {
      $('.first-image').show();
    });
    
    $('.toggle-button').on('click', () => {
      $('.first-image').toggle();
    });
    
    $('.fade-out-button').on('click', () => {
      $('.fade-image').fadeOut(500);
    });
    
    $('.fade-in-button').on('click', () => {
      $('.fade-image').fadeIn(4000);
    });
    
    $('.fade-toggle-button').on('click', () => {
      $('.fade-image').fadeToggle();
    });
    
    $('.up-button').on('click', () => {
          $('.slide-image').slideUp(100);
    });
    
    $('.down-button').on('click', () => {
      $('.slide-image').slideDown('slow');
    });
    
    $('.slide-toggle-button').on('click', () => {
      $('.slide-image').slideToggle('slow');
    });
    
  });


  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    })
  }); 

  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    });
    $('.menu-button').on('mouseenter', () => {
      $('.nav-menu').show();
    });
  }); 
  
  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    });
    
    $('.menu-button').on('mouseenter', () => {
      $('.nav-menu').show();
    })
    $('.nav-menu').on('mouseleave', () => {
      $('.nav-menu').hide();
    });
    
  }); 
  
  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    });
    
    $('.menu-button').on('mouseenter', () => {
      $('.nav-menu').show()
    });
    
    $('.nav-menu').on('mouseleave', () => {
      $('.nav-menu').hide();
    });
    
    $('.product-photo').on('mouseenter', () => {
      $('.product-photo').addClass('photo-active');
    }).on('mouseleave', () => {
      $('.product-photo').removeClass('photo-active');
    });
  }); 

  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    });
    
    $('.menu-button').on('mouseenter', () => {
      $('.nav-menu').show()
    })
    
    $('.nav-menu').on('mouseleave', () => {
      $('.nav-menu').hide();
    })
    
    $('.product-photo').on('mouseenter', event => {
      $(event.currentTarget).addClass('photo-active')
    }).on('mouseleave', event => {
      $(event.currentTarget).removeClass('photo-active')
    })
    
  }); 
  

  $(document).ready(() => {
 
    $('.login-button').on('click', () => {
      $('.login-form').toggle();
    });
    
    $('.menu-button').on('mouseenter', () => {
      $('.menu-button').addClass('button-active');
      $('.nav-menu').removeClass('hide');
    })
    
    $('.nav-menu').on('mouseleave', () => {
      $('.nav-menu').hide();
    })
    
  }); 

  $(document).ready(() => {
    $('.login-button').on('click', () => {
      $('.login-form').show();
    });
    
    $('.menu-button').on('click', () => {
      $('.nav-menu').toggleClass('hide');
      $('.menu-button').toggleClass('button-active');
    })  
  }); 
  
  $(document).ready(() => {
 
    $('.login-button').on('click', () => {
      $('.login-form').toggle();
    });
    
    $('.menu-button').on('mouseenter', () => {
      $('.menu-button').addClass('button-active');
      $('.nav-menu').removeClass('hide');
    })
    
    $('.nav-menu').on('mouseleave', () => {
      $('.nav-menu').hide();
    })
    
  });

  $(document).ready(() => {
  
    $('.shoe-details').show();
    
    $('.more-details-button').on('click', event => {
      
    });  
    
    $('.shoe-details li').on('click', event => {
      $(event.currentTarget).addClass('active');
      $(event.currentTarget).siblings().removeClass('active');
      
      $('.shoe-details').children().removeClass('disabled');
  
    });
    
    
    
    ///////////////////////////////////////////
    $('.login-button').on('click', () => {
      $('.login-form').toggle();
      $('.login-button').toggleClass('button-active');
    });
  
    $('.product-photo').on('mouseenter', () => {
      $(this).addClass('photo-active');
    }).on('mouseleave', function() {
      $(this).removeClass('photo-active');
    });
  
    $('.menu-button').on('click', () => {
      $('.menu-button').toggleClass('button-active');
      $('.nav-menu').toggleClass('hide');
    });
  })

  $(document).ready(() => {
  
    $('.shoe-details').show();
    
    $('.more-details-button').on('click', event => {
      $(event.currentTarget).closest('.product-details').children().removeClass('disabled');   
      $(event.currentTarget).closest('.product-details').next().toggle();
    });  
    
    $('.shoe-details li').on('click', event => {
      $(event.currentTarget).addClass('active');
      $(event.currentTarget).siblings().removeClass('active');
        $(event.currentTarget).closest('.shoe-details').children().removeClass('disabled');   
  
    });
    
    
    
    
    ///////////////////////////////////////////
    $('.login-button').on('click', () => {
      $('.login-form').toggle();
      $('.login-button').toggleClass('button-active');
    });
  
    $('.product-photo').on('mouseenter', () => {
      $(this).addClass('photo-active');
    }).on('mouseleave', function() {
      $(this).removeClass('photo-active');
    });
  
    $('.menu-button').on('click', () => {
      $('.menu-button').toggleClass('button-active');
      $('.nav-menu').toggleClass('hide');
    });
  })



//There are multiple +1 buttons, and we only want the current button to change when a user's mouse enters and leaves.
//Change the .btn callback functions so only the current button is impacted by mouse enter and mouse leave events.
    
$(event.currentTarget).removeClass('btn-hover');

$(document).ready(() => {
    $('.menu').on('mouseover', () => {
        $('.nav-menu').show();
    });
    $('.nav-menu').on('mouseleave', () => {
        $('.nav-menu').hide();
    });

    $('.btn').on('mouseover', event => {
        $(event.currentTarget).addClass('btn-hover');
    }).on('mouseleave', event => {
        $(event.currentTarget).removeClass('btn-hover');
    });

    $('.postText').on('keyup', event => {
        var post = $(event.currentTarget).val();
        var remaining = 140 - post.length;
        $('.characters').html(remaining);
        if (remaining <= 0) {
            $('.wordcount').addClass('red');
        } else {
            $('.wordcount').removeClass('red');
        }
    }).focus();

});


$(document).ready(() => {

    $('.login-button').on('click', () => {
        $('.login-form').toggle();
    });

    $('.menu-button').on('mouseenter', () => {
        $('.menu-button').css({
            color: '#C3FF00',
            backgroundColor: '#535353'
        });
        $('.nav-menu').show();
    })

    $('.nav-menu').on('mouseleave', () => {
        $('.menu-button').css({
            color: '#EFEFEF',
            backgroundColor: '#303030'
        });
        $('.nav-menu').hide();
    })

    $('.menu-button').animate({
        fontSize: '24px'
    }, 200);

});

$("p").css("background-color", "yellow");
$("p").css({
    "background-color": "yellow",
    "font-size": "200%"
});

$('.preview').css('fontFamily', $(event.currentTarget).val());


$(document).ready(() => {
    $('#text').on('keyup', (event) => {
        $('.preview').html($(event.currentTarget).val());
        $('#font').on('change', (event) => {
            $('.preview').css('font-family', $(event.currentTarget).val());
        });
        $('#weight').on('change', (event) => {
            $('.preview').css('font-weight', $(event.currentTarget).val());
        });
        $('#size').on('keyup', (event) => {
            var fontSize = $(event.currentTarget).val() + 'px';
            $('.preview').css('font-size', fontSize);
        });
    });
})

//   In this lesson, you learned:

//   The .css() method can change style properties of an element.
//   The .css() method can accept multiple styles at once if you pass it a JavaScript object as its argument.
//   The .animate() method can change specific style properties over a period of time.
//   The .addClass() will add a CSS class to an element, and the .removeClass() method will remove a CSS class.
//   The .toggleClass() method will toggle a class on or off an element.

//   <div id="accordion">
//     <h3>Section 1</h3>
//     <div>
//     </div>
//   </div>

//   <div class="collapse">
//       <h3>Collapse / Expand</h3>
//       <div class="panel panel-default">
//       </div>
//   </div>
