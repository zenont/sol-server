CREATE TABLE [dbo].[ContainerItem]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(), 
	[ContainerId] UNIQUEIDENTIFIER NOT NULL,
	[Name] VARCHAR(30) NOT NULL,
    [CreatedUtc] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(), 
	[ModifiedUtc] DATETIME2 NULL, 
    CONSTRAINT [PK_ContainerItem] PRIMARY KEY NONCLUSTERED ([Id]),
	CONSTRAINT [FK_ContainerItem_ToContainer] FOREIGN KEY ([ContainerId]) REFERENCES [dbo].[Container]([Id])
)

GO

CREATE CLUSTERED INDEX [IX_Container_Clustered] ON [dbo].[ContainerItem] ([CreatedUtc])
