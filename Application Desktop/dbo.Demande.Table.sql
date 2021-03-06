USE [NetExamen]
GO
/****** Object:  Table [dbo].[Demande]    Script Date: 1/13/2020 9:33:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demande](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Lycee_id] [int] NULL,
	[Professeur_id] [int] NULL,
	[Date_Demande] [datetime] NULL,
 CONSTRAINT [PK_Demande] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Demande]  WITH CHECK ADD  CONSTRAINT [FK_Demande_Lycee] FOREIGN KEY([Lycee_id])
REFERENCES [dbo].[Lycee] ([ID])
GO
ALTER TABLE [dbo].[Demande] CHECK CONSTRAINT [FK_Demande_Lycee]
GO
ALTER TABLE [dbo].[Demande]  WITH CHECK ADD  CONSTRAINT [FK_Demande_Professeur] FOREIGN KEY([Professeur_id])
REFERENCES [dbo].[Professeur] ([ID])
GO
ALTER TABLE [dbo].[Demande] CHECK CONSTRAINT [FK_Demande_Professeur]
GO
