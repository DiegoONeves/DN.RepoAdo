USE StoreControlDB;
GO
IF (OBJECT_ID('pr_Store_get_All') IS NOT NULL)
  DROP PROCEDURE [dbo].[pr_Store_get_All];
GO
CREATE PROCEDURE [dbo].[pr_Store_get_All]
AS
BEGIN
	SET NOCOUNT ON

	SELECT 
		StoreId
		,DistrictName
		,IsActive
	FROM [dbo].[Store] (NOLOCK)

END



