CREATE PROCEDURE SP_AddPolicyCustomer
@IdCustomer BIGINT,
@IdInsurancePolicy  BIGINT,
@CoveragePercentage NUMERIC
AS
BEGIN
	INSERT 
	INTO
	TB_Policy_X_Customer
	(
		IdInsurancePolicy,
		IdCustomer,
		CoveragePercentage
	)
	VALUES
	(
		@IdInsurancePolicy,
		@IdCustomer,
		@CoveragePercentage
	)
END