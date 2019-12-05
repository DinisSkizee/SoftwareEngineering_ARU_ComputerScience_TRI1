CREATE TABLE [dbo].[PatientDetails]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [LastName] NCHAR(30) NOT NULL, 
    [Height] INT NOT NULL, 
    [Weight] INT NOT NULL, 
    [DiMin] INT NOT NULL, 
    [SyMin] INT NOT NULL, 
    [PrMin] INT NOT NULL, 
    [BrMin] INT NOT NULL, 
    [TpMin] INT NOT NULL, 
    [DiMax] INT NOT NULL, 
    [SyMax] INT NOT NULL, 
    [PrMax] INT NOT NULL, 
    [BrMax] INT NOT NULL, 
    [TpMax] INT NOT NULL
)
