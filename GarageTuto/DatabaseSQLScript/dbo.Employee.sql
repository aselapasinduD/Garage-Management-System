CREATE TABLE [dbo].[Employee]
(
	[EmpId] INT NOT NULL PRIMARY KEY IDENTITY,
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGender] VARCHAR(10) NOT NULL, 
    [EmpAddress] VARCHAR(100) NOT NULL, 
    [EmpPassword] VARCHAR(50) NOT NULL
)
