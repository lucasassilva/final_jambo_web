AOS.init({
    duration: 1500,
    delay: 55,
});

TweenMax.from(
    document.getElementsByClassName('intro'),
    {
        opacity: 0,
        duration: 1,
        delay: .5,
        ease: "Power2.easeInOut",
        y: -50
    });


$('form').submit(function () {

    var data = {
        first_name: $('#first_name').val().trim(),
        last_name: $("#last_name").val().trim(),
        email: $("#email").val().trim(),
        subject: $("#subject").val().trim(),
        message: $("#message").val().trim(),
    }

    $.ajax({
        url: "/", /*"@Url.Action("SendEmail", "Home")"*/
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        beforeSend: function () {
            $('#full-screen-spin').show()
            $('html, body').css('overflowY', 'hidden'); 
        },    
        data: JSON.stringify({
            first_name: data.first_name,
            last_name: data.last_name,
            email: data.email,
            subject: data.subject,
            message: data.message,
        }),
        success: function (response) {
            $('#full-screen-spin').hide()
            $('#first_name').val('')
            $("#last_name").val('')
            $("#email").val('')
            $("#subject").val('')
            $("#message").val('')
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: response.message, 
                showConfirmButton: false,
                timer: 3500,
            }).then(function(){
                $('html, body').css('overflowY', 'auto'); 
              });              
        },
        error: function (response) {
            console.log(response)
        }
    })

    return false

});
/*var el = document.querySelector('.btn-custom')
//var elPosition = ((window.pageYOffset || el.scrollTop)  - (el.clientTop || 0) - 100)
//console.log(((window.pageYOffset || el.scrollTop)  - (el.clientTop || 0)- 300))
window.addEventListener('scroll',function(){

    if(window.pageYOffset >= 1900){
        el.setAttribute("data-aos", "fade-up");
    }else{
        el.removeAttribute("data-aos");
    }
})*/


