CREATE TABLE [dbo].[Cars]
(
	[CarNumber] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [CarBrand] VARCHAR(50) NOT NULL, 
    [CarModel] VARCHAR(50) NOT NULL, 
    [CarDate] DATE NOT NULL, 
    [CarColor] VARCHAR(50) NOT NULL, 
    [OwnerName] VARCHAR(50) NOT NULL
)
