CREATE TABLE [dbo].[AcademicRecord](
	[ar_subjectId] [INT] FOREIGN KEY REFERENCES [dbo].[Subject](subject_id),
	[ar_studentId] [INT] FOREIGN KEY REFERENCES [dbo].[Student](student_id),
	[ar_firstPeriodGrade] [NUMERIC] NOT NULL,
	[ar_secondPeriodGrade] [NUMERIC] NOT NULL,
	[ar_thirdPeriodGrade] [NUMERIC] NOT NULL,
	[ar_fourthPeriodGrade] [NUMERIC] NOT NULL,
)
