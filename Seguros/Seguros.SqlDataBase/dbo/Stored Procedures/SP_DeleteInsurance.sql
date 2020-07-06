CREATE PROCEDURE SP_DeleteInsurance
@IdInsurancePolicy BIGINT
AS
BEGIN
	DELETE FROM TB_InsurancePolicy WHERE IdInsurancePolicy = @IdInsurancePolicy
END