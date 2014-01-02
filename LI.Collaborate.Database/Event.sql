CREATE TABLE [dbo].[Table1]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [FinishDate] DATETIME NOT NULL, 
    [Remark] NVARCHAR(MAX) NOT NULL, 
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
