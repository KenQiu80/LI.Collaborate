CREATE TABLE [dbo].[Table1]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
	[TeamLeaderId] varchar(36) NOT NULL,
	[TeamLeaderName] nvarchar(MAX) NOT NULL,
    [Title] NVARCHAR(MAX) NOT NULL, 
    [StartAt] DATETIME NOT NULL, 
    [FinishAt] DATETIME NOT NULL, 
	[Repeat] DATETIME NOT NULL,
	[EnableRemindMe] BIT NOT NULL,
	[RemindMeAt] DATETIME NOT NULL,
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
