CREATE TABLE [dbo].[Bills]
(
	[BillNum] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarNum] VARCHAR(50) NOT NULL, 
    [BillingDate] DATE NOT NULL, 
    [MechFees] INT NOT NULL, 
    [PartFees] INT NULL, 
    [TotalFees] INT NOT NULL, 
    [EmployeeName] VARCHAR(50) NOT NULL
)
