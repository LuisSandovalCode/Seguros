CREATE PROCEDURE SP_AuthUser 
@Identification NVARCHAR(30),
@Password NVARCHAR(30)
AS
BEGIN
	DECLARE @UserAuth INT;
	SELECT
		@UserAuth = COUNT(1)
	FROM
		TB_USER WITH(NOLOCK)
	WHERE
		Identification = @Identification
		AND
		Password = @Password

	IF(@UserAuth >= 1)
	BEGIN
		SELECT CONVERT(BIT,1)
	END
	ELSE
	BEGIN
		SELECT CONVERT(BIT,0)
	END
END