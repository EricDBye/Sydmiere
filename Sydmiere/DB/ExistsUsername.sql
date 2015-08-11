USE [Sydmiere]
GO
/****** Object:  StoredProcedure [dbo].[GetHash]    Script Date: 8/9/2015 2:38:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eric Bye
-- Create date: 08/05/2015
-- Description:	Get Password Hash by Username
-- =============================================
ALTER PROCEDURE [dbo].[ExistsUsername]
	@Username nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT Username FROM Player
	WHERE Username = @Username
END
