CREATE TABLE [dbo].[Stock]
(
	[PartId] INT NOT NULL PRIMARY KEY IDENTITY(100, 1),
    [PartName] VARCHAR(50) NULL,
    [PartQuantity] INT NULL,
    [PartPrice] INT NULL
)
