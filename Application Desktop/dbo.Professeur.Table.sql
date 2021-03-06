USE [NetExamen]
GO
/****** Object:  Table [dbo].[Professeur]    Script Date: 1/13/2020 9:33:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professeur](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Matricule] [varchar](50) NULL,
	[NomComplet] [varchar](50) NULL,
	[DateTravail] [date] NULL,
 CONSTRAINT [PK_Professeur] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
