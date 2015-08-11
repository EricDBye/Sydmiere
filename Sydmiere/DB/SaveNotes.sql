USE [Sydmiere]
GO
/****** Object:  StoredProcedure [dbo].[SaveNotes]    Script Date: 8/10/2015 9:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eric Bye
-- Create date: 08/05/2015
-- Description:	Save Notes created by a user.
-- =============================================
ALTER PROCEDURE [dbo].[SaveNotes]
	@Username varchar(100),
	@Notes varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @PlayerId INT

	SELECT @PlayerId = PlayerID FROM Player
	WHERE Username = @Username

	INSERT INTO Notes (Notes, PlayerId, CreateDate)
	VALUES (@Notes, @PlayerId, GetDate())
END
