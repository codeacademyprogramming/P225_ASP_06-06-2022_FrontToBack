$(document).ready(function () {
    $('.navlink').click(function (e) {
        //e.preventDefault();
        console.log(window.location)
        let path = window.location.pathname.split('/')[1]
        console.log(path)

        let navlinks = document.querySelectorAll('.navlink')
        console.log(navlinks)

        for (var i = 0; i < navlinks.length; i++) {
            navlinks[i].classList.remove('active')
        }

        for (var i = 0; i < navlinks.length; i++) {
            //console.log(navlinks[i].getAttribute('href').includes(path))

            if (navlinks[i].getAttribute('href').includes(path)) {
                $(this).addClass('active')
                console.log('test')
                console.log(path)
            }
        }
    })
})