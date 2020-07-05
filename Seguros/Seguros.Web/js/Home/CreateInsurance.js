var EndPointRisks = "Insurance/Risks";
var EndPointCoverages = "Insurance/Coverages";

$(document).ready(function () {
    GetRisks(function (risks) {
        console.log(risks);
        risks.map(risk => $("#SelectRisk").append(new Option(risk.Name, risk.IdRisk)));
    });
    GetCoverages(function (coverages) {
        coverages.map(cover => $("#SelectCoverage").append(new Option(cover.Name, cover.IdCoverage)));
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