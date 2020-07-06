CREATE PROCEDURE SP_UpdateInsurance
@IdInsurancePolicy BIGINT,
@Name NVARCHAR(50),
@Description NVARCHAR(200),
@PolicyStart DATETIME,
@Term NVARCHAR(20),
@Price NUMERIC,
@IdRisk INT,
@IdCoverage INT
AS
BEGIN
	UPDATE
	TB_InsurancePolicy
	SET
		Name = @Name,
		Description = @Description,
		PolicyStart = @PolicyStart,
		Term = @Term,
		Price  = @Price,
		IdRisk = @IdRisk,
		IdCoverage = @IdCoverage
	WHERE
		IdInsurancePolicy = @IdInsurancePolicy
END