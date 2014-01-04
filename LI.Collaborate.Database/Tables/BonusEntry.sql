CREATE TABLE [dbo].[BonusEntry]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EventId] VARCHAR(36) NOT NULL,
	[EventTitle] NVARCHAR(MAX) NOT NULL,
	[Type] INT NOT NULL,
	[Bonus1] MONEY NOT NULL,
	[Bonus2] MONEY NOT NULL,
	[Bonus3] MONEY NOT NULL,
	[Bonus4] MONEY NOT NULL,
	[Bonus5] MONEY NOT NULL,
    [Remark] NVARCHAR(MAX) NOT NULL, 
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
