CREATE PROCEDURE SP_GetCustomer
@IdCustomer BIGINT = NULL
AS
BEGIN
	SELECT
		IdCustomer,
		Identification,
		Name,
		Telephone,
		Email,
		Adress
	FROM
		TB_Customer WITH(NOLOCK)
	WHERE IdCustomer = ISNULL(@IdCustomer,IdCustomer)
END