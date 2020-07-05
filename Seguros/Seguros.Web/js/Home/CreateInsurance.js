var EndPointRisks = "Insurance/Risks";
var EndPointCoverages = "Insurance/Coverages";
var EndPointCreateInsurance = "Insurance/Create";
var EndPointUpdateInsurance = "Insurance/Update";
var EndPointGetInsurance = "Insurance/InsurancesList";
var IdInsuranceUpdate = null;

$(document).ready(function () {
    var IsUpdate = false;
    if (GetParameterFromURI() != undefined) {
        $("#txtTitle").val("Update Insurance");
        $("#BtnSave").text("Update");
        var IdInsurance = GetParameterFromURI().Insurance;
        IsUpdate = true;
        Post({
            EndPoint: EndPointGetInsurance,
            data: ObjectToJson({ IdInsurancePolicy: IdInsurance }),
            Success: function (data) {
                if (data) {
                    IdInsuranceUpdate = IdInsurance;
                    $("#TxtNameInsurance").val(data[0].Name);
                    $("#TxtDescriptionInsurance").val(data[0].Description);
                    $("#txtPolicyStart").val(data[0].PolicyStart);
                    $("#TxtTermsInsurance").val(data[0].Term);
                    $("#TxtPriceInsurance").val(data[0].Price);

                    GetRisks(function (risks) {
                        risks.map(risk => $("#SelectRisk").append(new Option(risk.Name, risk.IdRisk)));
                        $("#SelectRisk").val(data[0].IdRisk);
                    });
                    GetCoverages(function (coverages) {
                        coverages.map(cover => $("#SelectCoverage").append(new Option(cover.Name, cover.IdCoverage)));
                        $("#SelectCoverage").val(data[0].IdCoverage);
                    });
                }
            },
            Error: function (error) {
                console.log(error);
            }
        });
    }
    else {
        GetRisks(function (risks) {
            risks.map(risk => $("#SelectRisk").append(new Option(risk.Name, risk.IdRisk)));
        });
        GetCoverages(function (coverages) {
            coverages.map(cover => $("#SelectCoverage").append(new Option(cover.Name, cover.IdCoverage)));
        });
    }



    $("#BtnSave").click(function () {
        DoActionInsurance(IsUpdate);
    });
});

function GetRisks(FunctionCallBack) {
    Post({
        EndPoint: EndPointRisks,
        Success: function (data) {
            if (data) {
                FunctionCallBack(data);
            }
            else {
                FunctionCallBack([]);
            }
        },
        Error: function (error) {
            console.log(error);
            FunctionCallBack([]);
        }
    });
}

function GetCoverages(FunctionCallaBack) {
    Post({
        EndPoint: EndPointCoverages,
        Success: function (data) {
            if (data) {
                FunctionCallaBack(data);
            }
            else {
                FunctionCallaBack([]);
            }
        },
        Error: function (error) {
            console.log(error);
            FunctionCallaBack([]);
        }
    });
}

function DoActionInsurance(IsUpdate) {
    var EndPointToDO = IsUpdate ? EndPointUpdateInsurance : EndPointCreateInsurance;

    Post({
        EndPoint: EndPointToDO,
        data: GetInsuranceData(),
        Success: function (data) {
            if (data) {
                !IsUpdate ? alert("The Insurance was created successfully") : alert("The Insurance was updated successfully");
            }
        },
        Error: function (error) {
            console.log(error);
        }
    });
}

function GetInsuranceData() {
    var Insurance = {
        IdInsurancePolicy: IdInsuranceUpdate,
        Name: $("#TxtNameInsurance").val(),
        Description: $("#TxtDescriptionInsurance").val(),
        PolicyStart: $("#txtPolicyStart").val(),
        Term: $("#TxtTermsInsurance").val(),
        Price: $("#TxtPriceInsurance").val(),
        IdRisk: $("#SelectRisk").val(),
        IdCoverage: $("#SelectCoverage").val(),
    }

    return ObjectToJson(Insurance);
}