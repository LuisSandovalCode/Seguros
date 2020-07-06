CREATE TABLE [dbo].[TB_USER] (
    [IdUser]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [Identification] NVARCHAR (30) NULL,
    [Password]       NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

