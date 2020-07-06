CREATE TABLE [dbo].[TB_InsurancePolicy] (
    [IdInsurancePolicy] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (50)  NULL,
    [Description]       NVARCHAR (200) NULL,
    [PolicyStart]       DATETIME       NULL,
    [Term]              NVARCHAR (20)  NULL,
    [Price]             NUMERIC (18)   NULL,
    [IdRisk]            BIGINT         NULL,
    [IdCoverage]        BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([IdInsurancePolicy] ASC),
    FOREIGN KEY ([IdCoverage]) REFERENCES [dbo].[TB_Coverage] ([IdCoverage]),
    FOREIGN KEY ([IdRisk]) REFERENCES [dbo].[TB_Risk] ([IdRisk])
);

