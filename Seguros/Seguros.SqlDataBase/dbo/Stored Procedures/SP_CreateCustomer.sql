CREATE PROCEDURE SP_CreateCustomer
@Identification NVARCHAR(25),
@Name NVARCHAR(30),
@Telephone VARCHAR(8),
@Email NVARCHAR(10),
@Adress NVARCHAR(30),
@IdInsurancePolicy BIGINT
AS
BEGIN
	INSERT
	INTO
	TB_Customer
	(
		Identification,
		Name,
		Telephone,
		Email,
		Adress,
		IdInsurancePolicy
	)
	VALUES
	(
		@Identification,
		@Name,
		@Telephone,
		@Email,
		@Adress,
		@IdInsurancePolicy
	)
END