USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertInventory    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertInventory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertInventory]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertInventory
(
	@Id int OUTPUT,
	@InventoryId uniqueidentifier,
	@EquipmentId uniqueidentifier,
	@CompanyId uniqueidentifier,
	@Quantity int,
	@Type nvarchar(50),
	@SupplierCost float,
	@Cost float,
	@Retail float,
	@CreatedDate datetime,
	@CreatedBy nvarchar(50)
)
AS
    INSERT INTO [dbo].[Inventory] 
	(
	[InventoryId],
	[EquipmentId],
	[CompanyId],
	[Quantity],
	[Type],
	[SupplierCost],
	[Cost],
	[Retail],
	[CreatedDate],
	[CreatedBy]
    ) 
	VALUES 
	(
	@InventoryId,
	@EquipmentId,
	@CompanyId,
	@Quantity,
	@Type,
	@SupplierCost,
	@Cost,
	@Retail,
	@CreatedDate,
	@CreatedBy
    )
	DECLARE @Err int
	DECLARE @Result int

	SET @Result = @@ROWCOUNT
	SET @Err = @@ERROR 
	If @Err <> 0 
	BEGIN
		SET @Id = -1
		RETURN @Err
	END
	ELSE
	BEGIN
		If @Result = 1 
		BEGIN
			-- Everything is OK
			SET @Id = @@IDENTITY
		END
		ELSE
		BEGIN
			SET @Id = -1
			RETURN 0
		END
	END

	RETURN @Id
GO

/****** Object:  StoredProcedure [dbo].UpdateInventory    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateInventory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateInventory]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateInventory
(
	@Id int,
	@InventoryId uniqueidentifier,
	@EquipmentId uniqueidentifier,
	@CompanyId uniqueidentifier,
	@Quantity int,
	@Type nvarchar(50),
	@SupplierCost float,
	@Cost float,
	@Retail float,
	@CreatedDate datetime,
	@CreatedBy nvarchar(50)
)
AS
    UPDATE [dbo].[Inventory] 
	SET
	[InventoryId] = @InventoryId,
	[EquipmentId] = @EquipmentId,
	[CompanyId] = @CompanyId,
	[Quantity] = @Quantity,
	[Type] = @Type,
	[SupplierCost] = @SupplierCost,
	[Cost] = @Cost,
	[Retail] = @Retail,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy
	WHERE ( Id = @Id )

	DECLARE @Err int
	DECLARE @Result int
	SET @Result = @@ROWCOUNT
	SET @Err = @@ERROR 

	If @Err <> 0 
	BEGIN
		SET @Result = -1
	END

	RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].DeleteInventory    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteInventory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteInventory]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteInventory
(
	@Id int
)
AS
	DELETE [dbo].[Inventory] 

    WHERE ( Id = @Id )

	DECLARE @Err int
	DECLARE @Result int

	SET @Result = @@ROWCOUNT
	SET @Err = @@ERROR 

	If @Err <> 0 
	BEGIN
		SET @Result = -1
	END

	RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetAllInventory    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllInventory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllInventory]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllInventory
AS
	SELECT *		
	FROM
		[dbo].[Inventory]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetInventoryById    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInventoryById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInventoryById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInventoryById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[Inventory]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetInventoryMaximumId    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInventoryMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInventoryMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInventoryMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[Inventory]

	If @Result > 0 
		BEGIN
			-- Everything is OK
			RETURN @Result
		END
		ELSE
		BEGIN
			RETURN 0
		END
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetInventoryRowCount    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInventoryRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInventoryRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInventoryRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[Inventory]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedInventory    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedInventory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedInventory]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedInventory
(
	@TotalRows		int	OUTPUT,
	@PageIndex	int,
	@RowPerPage		int,
	@WhereClause	nvarchar(4000),
	@SortColumn		nvarchar(128),
	@SortOrder		nvarchar(4)
)
AS
BEGIN 

SET @PageIndex = isnull(@PageIndex, -1)
SET @RowPerPage = isnull(@RowPerPage, -1)
SET @WhereClause = isnull(@WhereClause, '')
SET @SortColumn = isnull(@SortColumn, '')
SET @SortOrder = isnull(@SortOrder, '')
SET @TotalRows = 0
SET @RowPerPage = @RowPerPage -1
DECLARE @SQL1 nvarchar(4000)
DECLARE @SQL2 nvarchar(4000)

IF (@WhereClause != '')
BEGIN
	SET @WhereClause = 'WHERE ' + char(13) + @WhereClause	
END

IF (@SortColumn != '')
BEGIN
	SET @SortColumn = 'ORDER BY ' + @SortColumn

	IF (@SortOrder != '')
	BEGIN
		SET @SortColumn = @SortColumn + ' ' + @SortOrder
	END
END
ELSE
BEGIN
	SET @SortColumn = @SortColumn + ' ORDER BY [Id] ASC'
END

SET @SQL1 = 'WITH InventoryEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[InventoryId],
	[EquipmentId],
	[CompanyId],
	[Quantity],
	[Type],
	[SupplierCost],
	[Cost],
	[Retail],
	[CreatedDate],
	[CreatedBy]
				FROM 
				[dbo].[Inventory]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[InventoryId],
	[EquipmentId],
	[CompanyId],
	[Quantity],
	[Type],
	[SupplierCost],
	[Cost],
	[Retail],
	[CreatedDate],
	[CreatedBy]
				FROM 
					InventoryEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[Inventory] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetInventoryByQuery    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInventoryByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInventoryByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInventoryByQuery
(
	@Query	nvarchar(4000)
)
AS
BEGIN 

SET @Query = isnull(@Query, '')
DECLARE @SQL1 nvarchar(4000)

IF (@Query != '')
BEGIN
	SET @Query = 'WHERE ' + char(13) + @Query	
END

SET @SQL1 =		'SELECT * 
				FROM 
				[dbo].[Inventory] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

