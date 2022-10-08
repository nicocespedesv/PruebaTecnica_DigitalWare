CREATE PROCEDURE [dbo].[SP_GET_GRADES]
	@ID AS INT
AS

	SET NOCOUNT ON;
	SELECT AR.ar_studentId, ST.student_fullname, AR.ar_subjectId, SU.subject_name, AR.ar_firstPeriodGrade, AR.ar_secondPeriodGrade, AR.ar_thirdPeriodGrade, AR.ar_fourthPeriodGrade
	FROM [dbo].[AcademicRecord] AR
	INNER JOIN [dbo].[Student] ST ON ST.student_id = AR.ar_studentId
	INNER JOIN [dbo].[Subject] SU ON SU.subject_id = AR.ar_subjectId
	WHERE AR.ar_studentId = 11111
GO