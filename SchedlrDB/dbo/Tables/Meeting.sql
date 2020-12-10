CREATE TABLE [dbo].[Meeting]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [MeetingID] NCHAR(10) NOT NULL, 
    [MeetingDate] NCHAR(10) NOT NULL, 
    [MeetingTime] NCHAR(10) NOT NULL, 
    [EmployeeID] NCHAR(10) NOT NULL, 
    [MeetingType] NCHAR(10) NOT NULL, 
    [MeetingLocation] NCHAR(10) NOT NULL 
)
