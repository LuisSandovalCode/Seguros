CREATE TABLE [dbo].[TB_Policy_X_Customer] (
    [IdInsurancePolicy]  BIGINT       NULL,
    [IdCustomer]         BIGINT       NULL,
    [CoveragePercentage] NUMERIC (18) NULL,
    FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].[TB_Customer] ([IdCustomer]),
    FOREIGN KEY ([IdInsurancePolicy]) REFERENCES [dbo].[TB_InsurancePolicy] ([IdInsurancePolicy])
);

