﻿CREATE PROCEDURE SP_GetRiks
AS
BEGIN
	SELECT
		IdRisk,
		Name
	FROM
		TB_Risk (NOLOCK)
END