CREATE PROCEDURE SP_GetCoverage
AS
BEGIN
	SELECT
		IdCoverage,
		Name
	FROM
		TB_Coverage (NOLOCK)
END