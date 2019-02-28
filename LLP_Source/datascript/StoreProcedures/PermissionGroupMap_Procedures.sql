﻿USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertPermissionGroupMap    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertPermissionGroupMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertPermissionGroupMap]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertPermissionGroupMap
(
	@Id int OUTPUT,
	@PermissionGroupId int,
	@PermissionId int,
	@IsActive bit
)
AS
    INSERT INTO [dbo].[PermissionGroupMap] 
	(
	[PermissionGroupId],
	[PermissionId],
	[IsActive]
    ) 
	VALUES 
	(
	@PermissionGroupId,
	@PermissionId,
	@IsActive
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

/****** Object:  StoredProcedure [dbo].UpdatePermissionGroupMap    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePermissionGroupMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdatePermissionGroupMap]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdatePermissionGroupMap
(
	@Id int,
	@PermissionGroupId int,
	@PermissionId int,
	@IsActive bit
)
AS
    UPDATE [dbo].[PermissionGroupMap] 
	SET
	[PermissionGroupId] = @PermissionGroupId,
	[PermissionId] = @PermissionId,
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

/****** Object:  StoredProcedure [dbo].DeletePermissionGroupMap    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePermissionGroupMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeletePermissionGroupMap]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeletePermissionGroupMap
(
	@Id int
)
AS
	DELETE [dbo].[PermissionGroupMap] 

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

/****** Object:  StoredProcedure [dbo].GetAllPermissionGroupMap    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllPermissionGroupMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllPermissionGroupMap]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllPermissionGroupMap
AS
	SELECT *		
	FROM
		[dbo].[PermissionGroupMap]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetPermissionGroupMapById    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionGroupMapById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionGroupMapById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionGroupMapById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[PermissionGroupMap]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetPermissionGroupMapMaximumId    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionGroupMapMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionGroupMapMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionGroupMapMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[PermissionGroupMap]

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

/****** Object:  StoredProcedure [dbo].GetPermissionGroupMapRowCount    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionGroupMapRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionGroupMapRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionGroupMapRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[PermissionGroupMap]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedPermissionGroupMap    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedPermissionGroupMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedPermissionGroupMap]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedPermissionGroupMap
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

SET @SQL1 = 'WITH PermissionGroupMapEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[PermissionGroupId],
	[PermissionId],
	[IsActive]
				FROM 
				[dbo].[PermissionGroupMap]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[PermissionGroupId],
	[PermissionId],
	[IsActive]
				FROM 
					PermissionGroupMapEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[PermissionGroupMap] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetPermissionGroupMapByQuery    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPermissionGroupMapByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPermissionGroupMapByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPermissionGroupMapByQuery
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
				[dbo].[PermissionGroupMap] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO
