USE StoreControlDB;
GO
IF (OBJECT_ID('pr_Store_create') IS NOT NULL)
  DROP PROCEDURE [dbo].[pr_Store_create];
GO
CREATE PROCEDURE [dbo].[pr_Store_create]
	@DistrictName VARCHAR(200),
    @IsActive BIT
AS
BEGIN
	SET NOCOUNT ON

	INSERT INTO [dbo].[Store] (DistrictName,IsActive)
	VALUES(@DistrictName,@IsActive)

	SELECT 
		StoreId
		,DistrictName
		,IsActive
	FROM [dbo].[Store] (NOLOCK)
	WHERE StoreId = SCOPE_IDENTITY();
END



