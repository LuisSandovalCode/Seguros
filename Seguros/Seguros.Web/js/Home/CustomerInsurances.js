var EndPointCustomerInsurances = "Customer/CustomerInsurances";

$(document).ready(function () {

    $("#TableInsurances").DataTable();
    $(".dataTables_filter").hide();
    $(".dataTables_length").hide();
    if (GetParameterFromURI() != undefined) {

        var IdCustomerSelected = GetParameterFromURI().IdCustomer;

        Post({
            EndPoint: EndPointCustomerInsurances,
            data: ObjectToJson({ IdCustomer: IdCustomerSelected }),
            Success: function (data) {
                if (data) {
                    console.log(data);
                    data.map(insurance => {
                        $("#TableInsurances").DataTable().rows.add([
                            [
                                insurance.Name || "",
                                insurance.Description || "",
                                insurance.PolicyStart || "",
                                insurance.Term || "",
                                insurance.RiskName || "",
                                insurance.CoverageName || "",
                                insurance.CoveragePercentage || ""
                            ]
                        ]).draw();
                    });

                }
            },
            Error: function (error) {
                console.log(error);
            }
        });
    }

});

