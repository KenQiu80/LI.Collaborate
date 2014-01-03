CREATE TABLE [dbo].[Bonus]
(
	[Id] varchar(36) NOT NULL PRIMARY KEY,
	[EventId] varchar(36) NOT NULL,
	[EventTitle] nvarchar(MAX) NOT NULL,
	[Bonus1] DECIMAL(18, 1) NOT NULL,
	[Bonus2] DECIMAL(18, 1) NOT NULL,
	[Bonus3] DECIMAL(18, 1) NOT NULL,
	[Bonus4] DECIMAL(18, 1) NOT NULL,
	[Bonus5] DECIMAL(18, 1) NOT NULL, 
	[Remark] nvarchar(MAX) NOT NULL,
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
