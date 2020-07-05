var CustomersEndPoint = "Customer/CustomerList";

$(document).ready(function () {
    $("#TbCustomer").DataTable();
    $(".dataTables_filter").hide();
    $(".dataTables_length").hide();
    GetCustomers();
});


function GetCustomers() {
    Post({
        EndPoint: CustomersEndPoint,
        Success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
}