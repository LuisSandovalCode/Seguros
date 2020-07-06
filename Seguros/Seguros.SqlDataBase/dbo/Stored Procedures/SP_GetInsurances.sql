CREATE PROCEDURE SP_GetInsurances
@IdInsurancePolicy BIGINT = NULL
AS
BEGIN
	SELECT
		I.IdInsurancePolicy,
		I.Name,
		I.Description,
		I.PolicyStart,
		I.Term,
		I.Price,
		I.IdRisk,
		I.IdCoverage,
		R.Name as RiskName,
		C.Name as CoverageName
	FROM
		TB_InsurancePolicy I (NOLOCK)
	INNER JOIN
		TB_Risk R (NOLOCK)
	ON
		I.IdRisk = R.IdRisk
	INNER JOIN
		TB_Coverage C (NOLOCK)
	ON
		C.IdCoverage = I.IdCoverage
	WHERE
		IdInsurancePolicy = ISNULL(@IdInsurancePolicy,IdInsurancePolicy)

END