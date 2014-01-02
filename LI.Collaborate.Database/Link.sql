CREATE TABLE [dbo].[Link]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [EventId1] VARCHAR(36) NOT NULL, 
    [EventName1] NVARCHAR(MAX) NOT NULL, 
    [EventId2] VARCHAR(36) NOT NULL, 
    [EventName2] NVARCHAR(MAX) NOT NULL, 
    [Type] INT NOT NULL, 
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifierTime] DATETIME NOT NULL
)
