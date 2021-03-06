begin transaction

GO
/****** Object:  Schema [bl]    Script Date: 02/14/2012 21:55:44 ******/
CREATE SCHEMA [bl] AUTHORIZATION [dbo]
GO
/****** Object:  Table [bl].[City]    Script Date: 02/14/2012 21:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bl].[City](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[UrlId] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_city] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bl].[Builder]    Script Date: 02/14/2012 21:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bl].[Builder](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CityId] [uniqueidentifier] NOT NULL,
	[UrlId] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_builder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
CONSTRAINT [FK_Builder_CityId_UrlId] UNIQUE NONCLUSTERED 
(
	[CityId] ASC,
	[UrlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bl].[Zone]    Script Date: 02/14/2012 21:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bl].[Zone](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CityId] [uniqueidentifier] NOT NULL,
    [Order] [int] DEFAULT 0,
	[UrlId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Zone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
CONSTRAINT [FK_Zone_CityId_UrlId] UNIQUE NONCLUSTERED 
(
	[CityId] ASC,
	[UrlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bl].[Community]    Script Date: 02/14/2012 21:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bl].[Community](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ZoneId] [uniqueidentifier] NOT NULL,
	[UrlId] [nvarchar](100) NOT NULL,
	[Developer] [nvarchar](50) NULL,
	[Established] [int] NOT NULL DEFAULT 0,
	[Coverage] [nvarchar](50) NULL,
	[Ward] [nvarchar](50) NULL,
	[GpsLocation] [nvarchar](100) NULL,
	[GpsBounds] [nvarchar](1000) NULL,
	[CurrentPhase] [nvarchar](50) NULL,
	[Remoteness] [int] NOT NULL DEFAULT 0,
	[HasLake] [bit] NOT NULL DEFAULT 0,
	[HasWaterFeature] [bit] NOT NULL DEFAULT 0,
	[HasClubOrFacility] [bit] NOT NULL DEFAULT 0,
	[HasMountainView] [bit] NOT NULL DEFAULT 0,
	[HasParksAndPathways] [bit] NOT NULL DEFAULT 0,
	[HasShoppingPlaza] [bit] NOT NULL DEFAULT 0,
	[NumberOfPlaygrounds] [int] NOT NULL DEFAULT 0,
	[NumberOfDwellings] [int] NOT NULL DEFAULT 0,
	[Population] [int] NOT NULL DEFAULT 0,
	[Transit Bus] [nvarchar](50) NULL,
	[Schools] [nvarchar](150) NULL,
 CONSTRAINT [PK_Community] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
CONSTRAINT [FK_Community_ZoneId_UrlId] UNIQUE NONCLUSTERED 
(
	[ZoneId] ASC,
	[UrlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bl].[community_builders]    Script Date: 02/14/2012 21:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bl].[Community_Builders](
	[CommunityId] [uniqueidentifier] NOT NULL,
	[BuilderId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_builder_city]    Script Date: 02/14/2012 21:55:44 ******/
ALTER TABLE [bl].[Builder]  WITH CHECK ADD  CONSTRAINT [FK_Builder_City] FOREIGN KEY([CityId])
REFERENCES [bl].[City] ([Id])
GO
ALTER TABLE [bl].[Builder] CHECK CONSTRAINT [FK_Builder_City]
GO

/****** Object:  ForeignKey [FK_community_zone]    Script Date: 02/14/2012 21:55:44 ******/
ALTER TABLE [bl].[Community]  WITH CHECK ADD  CONSTRAINT [FK_Community_Zone] FOREIGN KEY([ZoneId])
REFERENCES [bl].[Zone] ([Id])
GO
ALTER TABLE [bl].[Community] CHECK CONSTRAINT [FK_Community_Zone]
GO
/****** Object:  ForeignKey [FK_community_builders_TO_builder]    Script Date: 02/14/2012 21:55:44 ******/
ALTER TABLE [bl].[Community_Builders]  WITH CHECK ADD  CONSTRAINT [FK_Community_Builders_TO_Builder] FOREIGN KEY([BuilderId])
REFERENCES [bl].[Builder] ([Id])
GO
ALTER TABLE [bl].[Community_Builders] CHECK CONSTRAINT [FK_Community_Builders_TO_Builder]
GO
/****** Object:  ForeignKey [FK_community_builders_TO_community]    Script Date: 02/14/2012 21:55:44 ******/
ALTER TABLE [bl].[Community_Builders]  WITH CHECK ADD  CONSTRAINT [FK_Community_Builders_TO_Community] FOREIGN KEY([CommunityId])
REFERENCES [bl].[Community] ([Id])
GO
ALTER TABLE [bl].[Community_Builders] CHECK CONSTRAINT [FK_Community_Builders_TO_Community]
GO
/****** Object:  ForeignKey [FK_zone_city]    Script Date: 02/14/2012 21:55:44 ******/
ALTER TABLE [bl].[Zone]  WITH CHECK ADD  CONSTRAINT [FK_Zone_City] FOREIGN KEY([CityId])
REFERENCES [bl].[City] ([Id])
GO
ALTER TABLE [bl].[Zone] CHECK CONSTRAINT [FK_Zone_City]
GO

commit transaction
--rollback transaction