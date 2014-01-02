CREATE TABLE [dbo].[Attachment]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [EventId] VARCHAR(36) NULL, 
    [MD5] VARCHAR(MAX) NULL, 
    [Filename] NVARCHAR(MAX) NULL,
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
