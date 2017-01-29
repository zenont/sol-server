﻿CREATE TABLE [dbo].[Container]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(), 
	[WarehouseId] UNIQUEIDENTIFIER NOT NULL,
	[Name] VARCHAR(30) NOT NULL,
    [CreatedUtc] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(), 
	[ModifiedUtc] DATETIME2 NULL, 
	[RowVersion] ROWVERSION NOT NULL, 
    CONSTRAINT [PK_Container] PRIMARY KEY NONCLUSTERED ([Id]),
	CONSTRAINT [FK_Container_ToWarehouse] FOREIGN KEY ([WarehouseId]) REFERENCES [dbo].[Warehouse]([Id])
)

GO

CREATE CLUSTERED INDEX [IX_Container_Clustered] ON [dbo].[Container] ([CreatedUtc])
