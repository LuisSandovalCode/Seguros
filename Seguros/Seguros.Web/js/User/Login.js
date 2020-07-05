const LoginEndPoint = "User/Auth";
$(document).ready(function () {

    //$("#LoginForm").validate({
    //    debug: true,
    //    rules: {
    //        email: {
    //            required: true
    //        },
    //        password: {
    //            required: true
    //        }
    //    },
    //    messages: {
    //        email: {
    //            required: "Email is required"
    //        },
    //        password: {
    //            required: "Password is required"
    //        }
    //    },
    //    submitForm: function (form) {
    //        LoginUser();
    //        return false;
    //    }
    //});
    $("#login").click(function () {
        console.log("login");
        LoginUser();
    });
});


function LoginUser() {
    Post({
        EndPoint: LoginEndPoint,
        data: ObjectToJson({ Identification: $("#email").val(), Password: $("#password").val() }),
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