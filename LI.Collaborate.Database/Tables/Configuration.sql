CREATE TABLE [dbo].[Configuration]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Theme] VARCHAR(32) NULL, 
    [RemindMeViaMail] BIT NULL, 
    [RemindMeViaSMS] BIT NULL, 
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL


)
