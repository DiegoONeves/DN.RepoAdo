USE StoreControlDB;
GO
IF (OBJECT_ID('pr_Store_get_byDistrictName') IS NOT NULL)
  DROP PROCEDURE [dbo].[pr_Store_get_byDistrictName];
GO
CREATE PROCEDURE [dbo].[pr_Store_get_byDistrictName]
	@DistrictName VARCHAR(200)
AS
BEGIN
	SET NOCOUNT ON

	SELECT 
		StoreId
		,DistrictName
		,IsActive
	FROM [dbo].[Store] (NOLOCK)
	WHERE DistrictName = @DistrictName;

END



