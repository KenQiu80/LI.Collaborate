CREATE TABLE [dbo].[Table1]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
	[TeamLeaderId] varchar(36) NOT NULL,
	[TeamLeaderName] nvarchar(MAX) NOT NULL,
    [Title] NVARCHAR(MAX) NOT NULL, 
    [StartAt] DATETIME NOT NULL, 
    [FinishAt] DATETIME NOT NULL, 
	[Bonus1] int NOT NULL,
	[Bonus2] int NOT NULL,
	[Bonus3] int NOT NULL,
	[Bonus4] int NOT NULL,
	[Bonus5] int NOT NULL,
    [Remark] NVARCHAR(MAX) NOT NULL, 
    [CreatorId] VARCHAR(36) NOT NULL, 
    [CreatorName] NVARCHAR(MAX) NOT NULL, 
    [CreatedTime] DATETIME NOT NULL, 
    [ModifierId] VARCHAR(36) NOT NULL, 
    [ModifierName] NVARCHAR(MAX) NOT NULL, 
    [ModifiedTime] DATETIME NOT NULL
)
