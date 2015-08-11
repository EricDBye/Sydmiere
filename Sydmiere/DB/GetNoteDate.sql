USE [Sydmiere]
GO
/****** Object:  StoredProcedure [dbo].[ExistsUsername]    Script Date: 8/10/2015 9:47:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eric Bye
-- Create date: 08/05/2015
-- Description:	Get Password Hash by Username
-- =============================================
ALTER PROCEDURE [dbo].[GetNoteDate]
	@Date DATETIME,
	@Username varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CreateDate as Date FROM Notes
	JOIN Player
	ON Player.PlayerID = Notes.PlayerID
	WHERE Username = @Username
	AND CONVERT(DATE, CreateDate) = CONVERT(DATE, @Date)
END
