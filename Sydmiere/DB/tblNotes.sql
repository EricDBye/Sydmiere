USE [Sydmiere]
GO

/****** Object:  Table [dbo].[Notes]    Script Date: 8/8/2015 10:23:31 AM ******/
DROP TABLE [dbo].[Notes]
GO

/****** Object:  Table [dbo].[Notes]    Script Date: 8/8/2015 10:23:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notes](
	[NoteID] [int] NOT NULL IDENTITY PRIMARY KEY,
	[PlayerID] [int] NOT NULL,
	[Notes] [nvarchar](MAX) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	FOREIGN KEY (PlayerID) REFERENCES Player(PlayerID)
) ON [PRIMARY]

GO


