﻿USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertChatUser    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertChatUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertChatUser]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertChatUser
(
	@Id int OUTPUT,
	@ChatUserId uniqueidentifier,
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Phone nvarchar(50),
	@JoinDate datetime,
	@ChatEnd datetime,
	@Ip nvarchar(50),
	@UserAgent nvarchar(max),
	@EmployeeId uniqueidentifier
)
AS
    INSERT INTO [dbo].[ChatUser] 
	(
	[ChatUserId],
	[Name],
	[Email],
	[Phone],
	[JoinDate],
	[ChatEnd],
	[Ip],
	[UserAgent],
	[EmployeeId]
    ) 
	VALUES 
	(
	@ChatUserId,
	@Name,
	@Email,
	@Phone,
	@JoinDate,
	@ChatEnd,
	@Ip,
	@UserAgent,
	@EmployeeId
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

/****** Object:  StoredProcedure [dbo].UpdateChatUser    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateChatUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateChatUser]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateChatUser
(
	@Id int,
	@ChatUserId uniqueidentifier,
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Phone nvarchar(50),
	@JoinDate datetime,
	@ChatEnd datetime,
	@Ip nvarchar(50),
	@UserAgent nvarchar(max),
	@EmployeeId uniqueidentifier
)
AS
    UPDATE [dbo].[ChatUser] 
	SET
	[ChatUserId] = @ChatUserId,
	[Name] = @Name,
	[Email] = @Email,
	[Phone] = @Phone,
	[JoinDate] = @JoinDate,
	[ChatEnd] = @ChatEnd,
	[Ip] = @Ip,
	[UserAgent] = @UserAgent,
	[EmployeeId] = @EmployeeId
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

/****** Object:  StoredProcedure [dbo].DeleteChatUser    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteChatUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteChatUser]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteChatUser
(
	@Id int
)
AS
	DELETE [dbo].[ChatUser] 

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

/****** Object:  StoredProcedure [dbo].GetAllChatUser    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllChatUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllChatUser]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllChatUser
AS
	SELECT *		
	FROM
		[dbo].[ChatUser]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetChatUserById    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChatUserById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetChatUserById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetChatUserById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[ChatUser]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetChatUserMaximumId    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChatUserMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetChatUserMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetChatUserMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[ChatUser]

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

/****** Object:  StoredProcedure [dbo].GetChatUserRowCount    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChatUserRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetChatUserRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetChatUserRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[ChatUser]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedChatUser    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedChatUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedChatUser]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedChatUser
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

SET @SQL1 = 'WITH ChatUserEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[ChatUserId],
	[Name],
	[Email],
	[Phone],
	[JoinDate],
	[ChatEnd],
	[Ip],
	[UserAgent],
	[EmployeeId]
				FROM 
				[dbo].[ChatUser]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[ChatUserId],
	[Name],
	[Email],
	[Phone],
	[JoinDate],
	[ChatEnd],
	[Ip],
	[UserAgent],
	[EmployeeId]
				FROM 
					ChatUserEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[ChatUser] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetChatUserByQuery    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChatUserByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetChatUserByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetChatUserByQuery
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
				[dbo].[ChatUser] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

