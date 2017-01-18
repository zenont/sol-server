CREATE TABLE [dbo].[Invoice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[DeliveryPointId] INT NOT NULL,
	[Start] DATETIME2 NOT NULL,
	[End] DATETIME2 NOT NULL,
	[ZoneId] INT NOT NULL,
	[EvaluationState] INT NOT NULL DEFAULT 0,
	[LastEvaluation] DATETIME2 NULL,
	[LastEvaluatedBy] VARCHAR(30) NULL,
    [CreateUtc] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(), 
    [ModifyUtc] DATETIME2 NULL, 
    [Timestamp] TIMESTAMP NOT NULL, 
    CONSTRAINT [FK_Invoice_ToDeliveryPoint] FOREIGN KEY ([DeliveryPointId]) REFERENCES [dbo].[DeliveryPoint]([Id]),
	CONSTRAINT [FK_Invoice_ToZone] FOREIGN KEY ([ZoneId]) REFERENCES [dbo].[Zone]([Id])
)

GO

CREATE INDEX [IX_Invoice_DeliveryPoint_Start_End] ON [dbo].[Invoice] ([DeliveryPointId], [Start], [End])

GO
