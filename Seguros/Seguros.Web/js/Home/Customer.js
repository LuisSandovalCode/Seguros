var CustomersEndPoint = "Customer/CustomerList";
var customerList = [];
$(document).ready(function () {
    $("#TbCustomer").DataTable();
    $(".dataTables_filter").hide();
    $(".dataTables_length").hide();
    GetCustomers(function (customers) {
        customerList = customers;
        customers.map(customer => {
            $("#TbCustomer").DataTable().clear().draw();
            $("#TbCustomer").DataTable().rows.add(
                [
                    [
                        customer.Identification,
                        customer.Name,
                        customer.Telephone,
                        customer.Email,
                        customer.Adress,
                        GenerateColumsViewPolicies(customer.IdCustomer),
                        GenerateColumsAddPolicy(customer.IdCustomer, customer.Name),
                    ]
                ]
            ).draw();
        });
    });
});


function GenerateColumsAddPolicy(IdCustomer) {
    return "<div>"
        + "<a href='javascript:' style='margin-right: 30px;' rel='nofollow' onclick='AddPolicy(" + IdCustomer + ")'>Add Policy</a>"
        + "</div >";
}

function GenerateColumsViewPolicies(IdCustomer) {
    return "<div>"
        + "<a href='javascript:' style='margin-right: 30px;' rel='nofollow' onclick='ViewInsurances(" + IdCustomer + ")'>Add Policy</a>"
        + "</div >";
}

function ViewInsurances(IdCustomer) {
    RedirectoTo("/Home/CustomerInsurancePolicy?IdCustomer=" + IdCustomer);
}

function AddPolicy(IdCustomer) {

    var customer = customerList.filter(customer => {
        return customer.IdCustomer == IdCustomer;
    });

    RedirectoTo("/Home/PolicyCustomer?IdCustomer=" + IdCustomer + "&CustomerName=" + customer[0].Name);
}

function GetCustomers(FunctionCallBack) {
    Post({
        EndPoint: CustomersEndPoint,
        Success: function (data) {
            if (data) {
                FunctionCallBack(data);
            }
            else {
                FunctionCallBack([]);
            }
        },
        error: function (error) {
            FunctionCallBack([]);
            console.log(error);
        }
    });
}

function ViewPolicesCustomer(IdCustomer) {

}