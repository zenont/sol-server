SET IDENTITY_INSERT [dbo].[DeliveryPoint] ON
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (1, N'DELIVERY1', N'2017-01-18 08:45:23', NULL)
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (2, N'DELIVERY2', N'2017-01-18 08:45:27', NULL)
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (3, N'DELIVERY3', N'2017-01-18 08:45:29', NULL)
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (4, N'DELIVERY4', N'2017-01-18 08:45:32', NULL)
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (5, N'DELIVERY5', N'2017-01-18 08:45:35', NULL)
INSERT INTO [dbo].[DeliveryPoint] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (6, N'DELIVERY6', N'2017-01-18 08:45:38', NULL)
SET IDENTITY_INSERT [dbo].[DeliveryPoint] OFF

SET IDENTITY_INSERT [dbo].[Market] ON
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (1, N'CAL', N'2017-01-18 08:47:20', NULL)
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (2, N'ERTC', N'2017-01-18 08:47:26', NULL)
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (3, N'NYE', N'2017-01-18 08:47:37', NULL)
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (4, N'NYW', N'2017-01-18 08:47:38', NULL)
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (5, N'PJMW', N'2017-01-18 08:47:47', NULL)
INSERT INTO [dbo].[Market] ([Id], [Name], [CreateUtc], [ModifyUtc]) VALUES (6, N'PJME', N'2017-01-18 08:47:50', NULL)
SET IDENTITY_INSERT [dbo].[Market] OFF

SET IDENTITY_INSERT [dbo].[Zone] ON
INSERT INTO [dbo].[Zone] ([Id], [MarketId], [Name], [CreateUtc], [ModifyUtc]) VALUES (1, 1, N'CAL_ZE', N'2017-01-18 08:49:11', NULL)
INSERT INTO [dbo].[Zone] ([Id], [MarketId], [Name], [CreateUtc], [ModifyUtc]) VALUES (2, 1, N'CAL_ZW', N'2017-01-18 08:49:20', NULL)
INSERT INTO [dbo].[Zone] ([Id], [MarketId], [Name], [CreateUtc], [ModifyUtc]) VALUES (3, 1, N'CAL_SE', N'2017-01-18 08:49:24', NULL)
INSERT INTO [dbo].[Zone] ([Id], [MarketId], [Name], [CreateUtc], [ModifyUtc]) VALUES (4, 2, N'KY_SW', N'2017-01-18 08:51:48', NULL)
INSERT INTO [dbo].[Zone] ([Id], [MarketId], [Name], [CreateUtc], [ModifyUtc]) VALUES (5, 2, N'KY_NW', N'2017-01-18 08:51:52', NULL)
SET IDENTITY_INSERT [dbo].[Zone] OFF


