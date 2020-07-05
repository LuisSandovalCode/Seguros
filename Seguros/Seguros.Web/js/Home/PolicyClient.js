var EndPointInsurances = "Insurance/InsurancesList";
var EndPointAddPolicy = "Customer/AddPolicy";
var IdCustomerSelected;
var HighRisk = 4;
var PoliciesList = [];
$(document).ready(function () {

    $("#FormPolicy").validate({
        rules: {
            Coverage: {
                required: true,
                range: [0, 100]
            }
        },
        submitHandler: function (form) {

            
            Post({
                EndPoint: EndPointAddPolicy,
                data: GetPolicyCustomerData(),
                Success: function (data) {
                    if (data) {
                        alert("The insurance policy was added successfully");
                        history.back();
                    }
                    else {
                        alert("The insurance was not able to add it");
                    }
                },
                Error: function (error) {
                    alert("Ups!! An error has happened");
                    console.log(error);
                }
            });

            return false;
        }

        

    });

    $("#SelectPolicies").change(function () {
        var policy = PoliciesList.filter(policy => {
            return policy.IdInsurancePolicy == $("#SelectPolicies").val();
        })

        if (policy.length == 0)
            return;

        if (policy[0].IdRisk === HighRisk) {
            $("#txtCoveragePercentage").removeAttr("max");
            $("#txtCoveragePercentage").attr("max", 50);
        }
        else {
            $("#txtCoveragePercentage").removeAttr("max");
            $("#txtCoveragePercentage").attr("max", 100);
        }

    });

    if (GetParameterFromURI() != undefined) {

        IdCustomerSelected = GetParameterFromURI().IdCustomer;
        $("#txtCustomerName").val(GetParameterFromURI().CustomerName);

        GetPolicyInsurances(function (insurances) {
            PoliciesList = insurances;
            insurances.map(insurance => {
                $("#SelectPolicies").append(new Option(insurance.Name, insurance.IdInsurancePolicy));
                $("#SelectPolicies").val($("#SelectPolicies option:first").val()).change();
            });
        });
    }


});

function GetPolicyInsurances(FunctionCallback) {
    Post({
        EndPoint: EndPointInsurances,
        Success: function (data) {
            if (data) {
                FunctionCallback(data);
            }
            else {
                FunctionCallback([]);
            }
        },
        Error: function (error) {
            console.log(error);
            FunctionCallback([]);
        }
    });
}


function GetPolicyCustomerData() {
    var CustomerPolicy = {
        IdCustomer: IdCustomerSelected,
        IdInsurancePolicy: $("#SelectPolicies").val(),
        CoveragePercentage: $("#txtCoveragePercentage").val()
    };

    return ObjectToJson(CustomerPolicy);
}
