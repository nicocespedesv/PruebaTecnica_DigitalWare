CREATE PROCEDURE [dbo].[SP_GET_STUDENTS]
AS
	SET NOCOUNT ON;
	SELECT TOP 10 *
	FROM [dbo].[Student]
	ORDER BY ID
GO