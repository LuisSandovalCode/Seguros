CREATE PROCEDURE SP_CreateInsurance
@Name NVARCHAR(50),
@Description NVARCHAR(200),
@PolicyStart DATETIME,
@Term NVARCHAR(20),
@Price NUMERIC,
@IdRisk INT,
@IdCoverage INT
AS
BEGIN
	INSERT 
	INTO
	TB_InsurancePolicy
	(
		Name,
		Description,
		PolicyStart,
		Term,
		Price,
		IdRisk,
		IdCoverage
	)
	VALUES
	(
		@Name,
		@Description,
		@PolicyStart,
		@Term,
		@Price,
		@IdRisk,
		@IdCoverage
	)
END