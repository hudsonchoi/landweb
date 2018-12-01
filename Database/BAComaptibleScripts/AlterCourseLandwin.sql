/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.courses ADD
	course_code varchar(20) NULL,
	year_no int NULL,
	semester_no int NULL,
	teacher_name nvarchar(80) NULL,
	start_date date NULL,
	start_time varchar(8) NULL,
	day_of_week int NULL,
	duration_hour decimal(5, 1) NULL,
	lecture_period_week int NULL,
	end_date date NULL,
	credit decimal(5, 1) NULL,
	difficulty char(1) NULL,
	prerequisite_course_id int NULL,
	active_yn char(1) NULL,
	create_date datetime NULL,
	create_by nvarchar(50) NULL,
	delete_date datetime NULL,
	delete_by nvarchar(50) NULL
GO
ALTER TABLE dbo.courses SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
