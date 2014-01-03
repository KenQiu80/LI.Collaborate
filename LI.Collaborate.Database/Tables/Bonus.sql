CREATE TABLE [dbo].[Bonus]
(
	[Id] varchar(36) NOT NULL PRIMARY KEY,
	[EventId] varchar(36) NOT NULL,
	[EventTitle] nvarchar(MAX) NOT NULL,
	[Bonus1] int NOT NULL,
	[Bonus2] int NOT NULL,
	[Bonus3] int NOT NULL,
	[Bonus4] int NOT NULL,
	[Bonus5] int NOT NULL, 
	[Remark] nvarchar(MAX) NOT NULL,
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
