﻿CREATE TABLE [dbo].[Zone]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[MarketId] INT NOT NULL,
	[Name] VARCHAR(20) NOT NULL,
	[CreateUtc] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(), 
    [ModifyUtc] DATETIME2 NULL, 
    [Timestamp] TIMESTAMP NOT NULL, 
    CONSTRAINT [FK_Zone_ToMarket] FOREIGN KEY ([MarketId]) REFERENCES [dbo].[Market]([Id])
)

GO

CREATE UNIQUE INDEX [IX_Zone_Market_Name] ON [dbo].[Zone] ([MarketId], [Name])
