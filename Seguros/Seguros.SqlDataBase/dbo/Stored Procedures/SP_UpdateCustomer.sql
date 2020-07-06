CREATE PROCEDURE SP_UpdateCustomer
@IdCustomer BIGINT,
@Identification NVARCHAR(25),
@Name NVARCHAR(30),
@Telephone VARCHAR(8),
@Email NVARCHAR(10),
@Adress NVARCHAR(30),
@IdInsurancePolicy BIGINT
AS
BEGIN
	UPDATE
	TB_Customer
	SET
		Identification = @Identification,
		Name = @Name,
		Telephone = @Telephone,
		Email = @Email,
		Adress = @Adress,
		IdInsurancePolicy = @IdInsurancePolicy
	WHERE
		IdCustomer = @IdCustomer
END