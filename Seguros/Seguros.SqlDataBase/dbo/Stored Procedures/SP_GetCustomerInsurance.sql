CREATE PROCEDURE SP_GetCustomerInsurance
@IdCustomer BIGINT
AS
BEGIN
	SELECT 
		INSP.Name,
		INSP.Description,
		INSP.Term,
		INSP.Price,
		R.Name as RiskName,
		C.Name as CoverageName,
		PC.CoveragePercentage
	FROM
		TB_Policy_X_Customer PC (NOLOCK)
	INNER JOIN
		TB_InsurancePolicy INSP (NOLOCK)
	ON	
		PC.IdInsurancePolicy = INSP.IdInsurancePolicy
	INNER JOIN
		TB_Risk R (NOLOCK)
	ON
		R.IdRisk = INSP.IdRisk
	INNER JOIN
		TB_Coverage C (NOLOCK)
	ON
		C.IdCoverage = INSP.IdCoverage
	WHERE
		PC.IdCustomer = @IdCustomer
END