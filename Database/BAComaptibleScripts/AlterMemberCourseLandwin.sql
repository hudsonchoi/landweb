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
ALTER TABLE dbo.member_course ADD
	graduate_yn varchar(1) NULL,
	create_date datetime NULL,
	create_by nvarchar(150) NULL,
	delete_date datetime NULL,
	delete_by nvarchar(150) NULL
GO
ALTER TABLE dbo.member_course SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
