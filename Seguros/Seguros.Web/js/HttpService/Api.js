var URL_API = "http://localhost:58218/api/v1/";


var Post = function (props) {
    $.ajax({
        url: `${URL_API}${props.EndPoint}`,
        method: 'POST',
        data: props.data,
        success: props.Success,
        error: props.Error
    });
}


function GetParameterFromURI() {
    var loc = document.location.href;
    if (loc.indexOf('?') > 0) {

        var getString = loc.split('?')[1];
        var GET = getString.split('&');
        var get = {};

        for (var i = 0, l = GET.length; i < l; i++) {
            var tmp = GET[i].split('=');
            get[tmp[0]] = unescape(decodeURI(tmp[1]));
        }
        return get;
    }
}

