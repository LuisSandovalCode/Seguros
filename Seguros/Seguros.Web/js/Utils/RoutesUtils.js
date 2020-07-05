var URL_ADMIN = "/Home";

var RedirectoTo = function (Route) {
    console.log(window.location.origin + Route);
    window.location.href = window.location.origin + Route;
}