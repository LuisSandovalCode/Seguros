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


