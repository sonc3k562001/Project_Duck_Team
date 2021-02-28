$(function () {
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar,#content').toggleClass('active')
    });
});


$(document).ready(function () {
    $('.sidebar-menu li.has-child > a ').click(function (e) {
        e.preventDefault();
        $(this).parent().toggleClass('menu-open');
    });
})
