USE [E:\C#\SQLDATABASE\SQLDATABASE\INTERIMDB.MDF]
GO

/****** Object:  Table [dbo].[t_interimeur]    Script Date: 5/4/2018 12:11:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_interimeur](
	[id_inte] [int] IDENTITY(1,1) NOT NULL,
	[nom_inte] [nvarchar](50) NOT NULL,
	[prenom_inte] [nvarchar](50) NOT NULL,
	[specialisation] [nvarchar](50) NOT NULL,
	[bonus_sal] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_inte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

