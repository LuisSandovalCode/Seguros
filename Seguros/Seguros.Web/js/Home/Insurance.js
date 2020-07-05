var EndPointInsurances = "Insurance/InsurancesList";
var EndPointDeleteInsurances = "Insurance/Delete";

$(document).ready(function () {
    $("#TableInsurances").DataTable();
    $(".dataTables_filter").hide();
    $(".dataTables_length").hide();

    GetInsurances(function (insurances) {
        $("#TableInsurances").DataTable().clear().draw();
        insurances.map(insurance => {
            $("#TableInsurances").DataTable().rows.add(
                [
                    [
                        insurance.Name || "",
                        insurance.Description || "",
                        insurance.PolicyStart || "",
                        insurance.Term || "",
                        insurance.RiskName || "",
                        insurance.CoverageName || "",
                        GenerateColumsUpdateDelete(insurance.IdInsurancePolicy)
                    ]
                ]
            ).draw();
        });
    });
});


function GenerateColumsUpdateDelete(IdInsurancePolicy) {
    return "<div>"
        + "<a href='javascript:' style='margin-right: 30px;' rel='nofollow' onclick='Delete(" + IdInsurancePolicy + ")'>Delete</a>"
        + "<a href='javascript:' rel='nofollow' onclick='Update(" + IdInsurancePolicy + ")'>Update</a>"
        + "</div >";
}

function GetInsurances(FunctionCallback) {
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

function Update(IdInsurancePolicy) {
    RedirectoTo("/Home/CreateInsurance?Insurance=" + IdInsurancePolicy)
}

function Delete(IdInsurancePolicy) {

    if (confirm("Are you sure you want to delete it?")) {
        Post({
            EndPoint: EndPointDeleteInsurances,
            data: ObjectToJson({ IdInsurancePolicy: IdInsurancePolicy }),
            Success: function (data) {
                if (data) {
                    alert("Insurance was delete it successfully!");
                    GetInsurances(function (insurances) {
                        $("#TableInsurances").DataTable().clear().draw();
                        insurances.map(insurance => {
                            $("#TableInsurances").DataTable().rows.add(
                                [
                                    [
                                        insurance.Name || "",
                                        insurance.Description || "",
                                        insurance.PolicyStart || "",
                                        insurance.Term || "",
                                        insurance.RiskName || "",
                                        insurance.CoverageName || "",
                                        GenerateColumsUpdateDelete(insurance.IdInsurancePolicy)
                                    ]
                                ]
                            ).draw();
                        });
                    });
                }
                else {
                    alert("Insurance was not delete it!");
                }
            },
            Error: function (error) {
                console.log(error);
                alert("Ups, There is an error!");
            }
        });
    }
}