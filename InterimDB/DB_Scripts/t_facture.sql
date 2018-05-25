USE [E:\C#\SQLDATABASE\SQLDATABASE\INTERIMDB.MDF]
GO

/****** Object:  Table [dbo].[t_facture]    Script Date: 5/4/2018 12:11:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_facture](
	[id_fact] [int] IDENTITY(1,1) NOT NULL,
	[date_fact] [datetime] NOT NULL,
	[id_inte] [int] NOT NULL,
	[id_entre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[t_facture]  WITH CHECK ADD  CONSTRAINT [id_entre] FOREIGN KEY([id_entre])
REFERENCES [dbo].[t_entreprise] ([id_entre])
GO

ALTER TABLE [dbo].[t_facture] CHECK CONSTRAINT [id_entre]
GO

ALTER TABLE [dbo].[t_facture]  WITH CHECK ADD  CONSTRAINT [id_inte] FOREIGN KEY([id_inte])
REFERENCES [dbo].[t_interimeur] ([id_inte])
GO

ALTER TABLE [dbo].[t_facture] CHECK CONSTRAINT [id_inte]
GO

