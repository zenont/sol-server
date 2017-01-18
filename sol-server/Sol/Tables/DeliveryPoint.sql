CREATE TABLE [dbo].[DeliveryPoint]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(20) NOT NULL,
	[CreateUtc] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(), 
    [ModifyUtc] DATETIME2 NULL, 
    [Timestamp] TIMESTAMP NOT NULL
)

GO

CREATE INDEX [IX_DeliveryPoint_Name] ON [dbo].[DeliveryPoint] ([Name])
