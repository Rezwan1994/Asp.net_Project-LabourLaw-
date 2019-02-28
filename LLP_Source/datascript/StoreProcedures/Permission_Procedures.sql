﻿USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertPermission    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertPermission]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertPermission]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertPermission
(
	@Id int,
	@CompanyId uniqueidentifier,
	@ParentId int,
	@Name nvarchar(500),
	@DisplayText nvarchar(500),
	@IsActive bit
)
AS
    INSERT INTO [dbo].[Permission] 
	(
	[Id],
	[CompanyId],
	[ParentId],
	[Name],
	[DisplayText],
	[IsActive]
    ) 
	VALUES 
	(
	@Id,
	@CompanyId,
	@ParentId,
	@Name,
	@DisplayText,
	@IsActive
    )
	DECLARE @Err int
	DECLARE @Result int

	SET @Result = @@ROWCOUNT
	SET @Err = @@ERROR 
	If @Err <> 0 
	BEGIN
		RETURN @Err
	END
	ELSE
	BEGIN
		If @Result = 1 
		BEGIN
			-- Everything is OK
			RETURN @Result
		END
		ELSE
		BEGIN
			RETURN 0
		END
	END

	RETURN @Result
	
GO

/****** Object:  StoredProcedure [dbo].UpdatePermission    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePermission]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdatePermission]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdatePermission
(
	@Id int,
	@CompanyId uniqueidentifier,
	@ParentId int,
	@Name nvarchar(500),
	@DisplayText nvarchar(500),
	@IsActive bit
)
AS
    UPDATE [dbo].[Permission] 
	SET
	[CompanyId] = @CompanyId,
	[ParentId] = @ParentId,
	[Name] = @Name,
	[DisplayText] = @DisplayText,
	[IsActive] = @IsActive
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

/****** Object:  StoredProcedure [dbo].DeletePermission    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePermission]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeletePermission]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeletePermission
(
	@Id int
)
AS
	DELETE [dbo].[Permission] 

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

/****** Object:  StoredProcedure [dbo].GetAllPermission    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllPermission]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllPermission]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllPermission
AS
	SELECT *		
	FROM
		[dbo].[Permission]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetPermissionById    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[Permission]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetPermissionMaximumId    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[Permission]

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

/****** Object:  StoredProcedure [dbo].GetPermissionRowCount    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[Permission]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedPermission    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedPermission]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedPermission]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedPermission
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

SET @SQL1 = 'WITH PermissionEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[CompanyId],
	[ParentId],
	[Name],
	[DisplayText],
	[IsActive]
				FROM 
				[dbo].[Permission]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[CompanyId],
	[ParentId],
	[Name],
	[DisplayText],
	[IsActive]
				FROM 
					PermissionEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[Permission] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetPermissionByQuery    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionByQuery
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
				[dbo].[Permission] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

