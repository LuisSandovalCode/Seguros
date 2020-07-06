CREATE PROCEDURE SP_DeleteCustomer
@IdCustomer BIGINT
AS
BEGIN
	DELETE FROM TB_Customer WHERE IdCustomer = @IdCustomer
END