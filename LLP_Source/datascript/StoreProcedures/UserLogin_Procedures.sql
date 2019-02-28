USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertUserLogin    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertUserLogin]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertUserLogin
(
	@Id int OUTPUT,
	@UserId uniqueidentifier,
	@UserName nvarchar(250),
	@Password nvarchar(100),
	@EmailAddress nvarchar(500),
	@IsActive bit,
	@IsDeleted bit,
	@LastUpdatedBy nvarchar(250),
	@LastUpdatedDate datetime
)
AS
    INSERT INTO [dbo].[UserLogin] 
	(
	[UserId],
	[UserName],
	[Password],
	[EmailAddress],
	[IsActive],
	[IsDeleted],
	[LastUpdatedBy],
	[LastUpdatedDate]
    ) 
	VALUES 
	(
	@UserId,
	@UserName,
	@Password,
	@EmailAddress,
	@IsActive,
	@IsDeleted,
	@LastUpdatedBy,
	@LastUpdatedDate
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

/****** Object:  StoredProcedure [dbo].UpdateUserLogin    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUserLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateUserLogin]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateUserLogin
(
	@Id int,
	@UserId uniqueidentifier,
	@UserName nvarchar(250),
	@Password nvarchar(100),
	@EmailAddress nvarchar(500),
	@IsActive bit,
	@IsDeleted bit,
	@LastUpdatedBy nvarchar(250),
	@LastUpdatedDate datetime
)
AS
    UPDATE [dbo].[UserLogin] 
	SET
	[UserId] = @UserId,
	[UserName] = @UserName,
	[Password] = @Password,
	[EmailAddress] = @EmailAddress,
	[IsActive] = @IsActive,
	[IsDeleted] = @IsDeleted,
	[LastUpdatedBy] = @LastUpdatedBy,
	[LastUpdatedDate] = @LastUpdatedDate
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

/****** Object:  StoredProcedure [dbo].DeleteUserLogin    Script Date: 4/18/2018 4:00:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteUserLogin]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteUserLogin
(
	@Id int
)
AS
	DELETE [dbo].[UserLogin] 

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

/****** Object:  StoredProcedure [dbo].GetAllUserLogin    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllUserLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllUserLogin]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllUserLogin
AS
	SELECT *		
	FROM
		[dbo].[UserLogin]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetUserLoginById    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserLoginById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserLoginById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserLoginById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[UserLogin]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetUserLoginMaximumId    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserLoginMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserLoginMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserLoginMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[UserLogin]

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

/****** Object:  StoredProcedure [dbo].GetUserLoginRowCount    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserLoginRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserLoginRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserLoginRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[UserLogin]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedUserLogin    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedUserLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedUserLogin]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedUserLogin
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

SET @SQL1 = 'WITH UserLoginEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[UserId],
	[UserName],
	[Password],
	[EmailAddress],
	[IsActive],
	[IsDeleted],
	[LastUpdatedBy],
	[LastUpdatedDate]
				FROM 
				[dbo].[UserLogin]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[UserId],
	[UserName],
	[Password],
	[EmailAddress],
	[IsActive],
	[IsDeleted],
	[LastUpdatedBy],
	[LastUpdatedDate]
				FROM 
					UserLoginEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[UserLogin] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetUserLoginByQuery    Script Date: 4/18/2018 4:00:59 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserLoginByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserLoginByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetUserLoginByQuery
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
				[dbo].[UserLogin] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

