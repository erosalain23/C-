USE [E:\C#\SQLDATABASE\SQLDATABASE\INTERIMDB.MDF]
GO

/****** Object:  Table [dbo].[t_categorie]    Script Date: 5/4/2018 12:10:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_categorie](
	[id_categ] [int] NOT NULL,
	[nom_categ] [nvarchar](50) NOT NULL,
	[sal_categ] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

