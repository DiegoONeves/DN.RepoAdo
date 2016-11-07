USE StoreControlDB;

IF OBJECT_ID (N'Store', N'U') IS NOT NULL 
BEGIN
	DROP TABLE [dbo].[Store];
END
CREATE TABLE [dbo].[Store]
(
	StoreId			INT IDENTITY(1,1)	NOT NULL,
	DistrictName	VARCHAR(200)		NOT NULL,
    IsActive		BIT					NOT NULL,
	CONSTRAINT PK_Store PRIMARY KEY(StoreId)
);
