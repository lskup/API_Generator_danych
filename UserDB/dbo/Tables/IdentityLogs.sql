CREATE TABLE [dbo].[IdentityLogs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IpAddress] NCHAR(50) NOT NULL, 
    [RequestURL] NCHAR(50) NOT NULL, 
    [DateTime] DATETIME NOT NULL
)
