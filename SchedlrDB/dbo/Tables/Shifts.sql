CREATE TABLE [dbo].[Shifts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShiftId] INT NOT NULL, 
    [ShiftRole]  NVARCHAR(50) NOT NULL,
    [ShiftStart] NVARCHAR(50) NOT NULL, 
    [ShiftEnd] NVARCHAR(50) NOT NULL, 
    [EmployeeId] NVARCHAR(100) NOT NULL
)
