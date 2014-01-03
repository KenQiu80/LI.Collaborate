CREATE TABLE [dbo].[Attachment]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [EventId] VARCHAR(36) NOT NULL, 
    [MD5] VARCHAR(MAX) NOT NULL, 
    [Filename] NVARCHAR(MAX) NOT NULL,
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
