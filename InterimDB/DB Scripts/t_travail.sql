USE [E:\C#\SQLDATABASE\SQLDATABASE\INTERIMDB.MDF]
GO

/****** Object:  Table [dbo].[t_travail]    Script Date: 5/4/2018 12:12:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_travail](
	[Id_travail] [int] IDENTITY(1,1) NOT NULL,
	[nom_travail] [nvarchar](50) NOT NULL,
	[prix_travail] [float] NOT NULL,
	[date_debut] [datetime] NOT NULL,
	[date_fin] [datetime] NOT NULL,
	[id_categ] [int] NOT NULL,
	[id_fact] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_travail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[t_travail]  WITH CHECK ADD  CONSTRAINT [id_categ] FOREIGN KEY([id_categ])
REFERENCES [dbo].[t_categorie] ([id_categ])
GO

ALTER TABLE [dbo].[t_travail] CHECK CONSTRAINT [id_categ]
GO

ALTER TABLE [dbo].[t_travail]  WITH CHECK ADD  CONSTRAINT [id_fact] FOREIGN KEY([id_fact])
REFERENCES [dbo].[t_facture] ([id_fact])
GO

ALTER TABLE [dbo].[t_travail] CHECK CONSTRAINT [id_fact]
GO

