CREATE TABLE [dbo].[TB_Customer] (
    [IdCustomer]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [Identification] NVARCHAR (25)  NULL,
    [Name]           NVARCHAR (30)  NULL,
    [Telephone]      VARCHAR (8)    NULL,
    [Email]          NVARCHAR (100) NULL,
    [Adress]         NVARCHAR (30)  NULL,
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC)
);

