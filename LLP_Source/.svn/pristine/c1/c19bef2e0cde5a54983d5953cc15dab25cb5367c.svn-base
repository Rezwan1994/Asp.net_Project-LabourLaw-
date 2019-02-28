USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertUserBranch    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertUserBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertUserBranch
(
	@Id int OUTPUT,
	@CompanyId uniqueidentifier,
	@UserId uniqueidentifier,
	@BranchId int
)
AS
    INSERT INTO [dbo].[UserBranch] 
	(
	[CompanyId],
	[UserId],
	[BranchId]
    ) 
	VALUES 
	(
	@CompanyId,
	@UserId,
	@BranchId
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

/****** Object:  StoredProcedure [dbo].UpdateUserBranch    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUserBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateUserBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateUserBranch
(
	@Id int,
	@CompanyId uniqueidentifier,
	@UserId uniqueidentifier,
	@BranchId int
)
AS
    UPDATE [dbo].[UserBranch] 
	SET
	[CompanyId] = @CompanyId,
	[UserId] = @UserId,
	[BranchId] = @BranchId
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

/****** Object:  StoredProcedure [dbo].DeleteUserBranch    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteUserBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteUserBranch
(
	@Id int
)
AS
	DELETE [dbo].[UserBranch] 

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

/****** Object:  StoredProcedure [dbo].GetAllUserBranch    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllUserBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllUserBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllUserBranch
AS
	SELECT *		
	FROM
		[dbo].[UserBranch]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetUserBranchById    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserBranchById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserBranchById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserBranchById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[UserBranch]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetUserBranchMaximumId    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserBranchMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserBranchMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserBranchMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[UserBranch]

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

/****** Object:  StoredProcedure [dbo].GetUserBranchRowCount    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserBranchRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserBranchRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserBranchRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[UserBranch]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedUserBranch    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedUserBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedUserBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedUserBranch
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

SET @SQL1 = 'WITH UserBranchEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[CompanyId],
	[UserId],
	[BranchId]
				FROM 
				[dbo].[UserBranch]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[CompanyId],
	[UserId],
	[BranchId]
				FROM 
					UserBranchEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[UserBranch] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetUserBranchByQuery    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserBranchByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserBranchByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserBranchByQuery
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
				[dbo].[UserBranch] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

