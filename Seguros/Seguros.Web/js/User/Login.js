const LoginEndPoint = "User/Auth";
$(document).ready(function () {

    $("#login").click(function () {
        LoginUser();
    });
});


function LoginUser() {
    Post({
        EndPoint: LoginEndPoint,
        data: ObjectToJson({ Identification: $("#Identification").val(), Password: $("#password").val() }),
        Success: function (data) {
            if (data) {
                RedirectoTo(URL_ADMIN);
            }
            else {
                alert("Identification or Password are incorrect, please verify!!")
            }
        },
        Error: function (error) {
            console.log(error);
        }
    });
}