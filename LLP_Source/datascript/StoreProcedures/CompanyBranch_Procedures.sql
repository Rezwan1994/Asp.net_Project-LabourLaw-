﻿USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertCompanyBranch    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertCompanyBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertCompanyBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertCompanyBranch
(
	@Id int OUTPUT,
	@CompanyId uniqueidentifier,
	@Name nvarchar(150),
	@Street nvarchar(250),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@Logo nvarchar(250),
	@ColorLogo nvarchar(250),
	@EmailLogo nvarchar(250),
	@TimeZone nvarchar(250),
	@Tax float,
	@IsMainBranch bit
)
AS
    INSERT INTO [dbo].[CompanyBranch] 
	(
	[CompanyId],
	[Name],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Logo],
	[ColorLogo],
	[EmailLogo],
	[TimeZone],
	[Tax],
	[IsMainBranch]
    ) 
	VALUES 
	(
	@CompanyId,
	@Name,
	@Street,
	@City,
	@State,
	@ZipCode,
	@Logo,
	@ColorLogo,
	@EmailLogo,
	@TimeZone,
	@Tax,
	@IsMainBranch
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

/****** Object:  StoredProcedure [dbo].UpdateCompanyBranch    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCompanyBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateCompanyBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateCompanyBranch
(
	@Id int,
	@CompanyId uniqueidentifier,
	@Name nvarchar(150),
	@Street nvarchar(250),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@Logo nvarchar(250),
	@ColorLogo nvarchar(250),
	@EmailLogo nvarchar(250),
	@TimeZone nvarchar(250),
	@Tax float,
	@IsMainBranch bit
)
AS
    UPDATE [dbo].[CompanyBranch] 
	SET
	[CompanyId] = @CompanyId,
	[Name] = @Name,
	[Street] = @Street,
	[City] = @City,
	[State] = @State,
	[ZipCode] = @ZipCode,
	[Logo] = @Logo,
	[ColorLogo] = @ColorLogo,
	[EmailLogo] = @EmailLogo,
	[TimeZone] = @TimeZone,
	[Tax] = @Tax,
	[IsMainBranch] = @IsMainBranch
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

/****** Object:  StoredProcedure [dbo].DeleteCompanyBranch    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCompanyBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteCompanyBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteCompanyBranch
(
	@Id int
)
AS
	DELETE [dbo].[CompanyBranch] 

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

/****** Object:  StoredProcedure [dbo].GetAllCompanyBranch    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllCompanyBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllCompanyBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllCompanyBranch
AS
	SELECT *		
	FROM
		[dbo].[CompanyBranch]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetCompanyBranchById    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyBranchById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyBranchById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyBranchById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[CompanyBranch]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetCompanyBranchMaximumId    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyBranchMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyBranchMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyBranchMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[CompanyBranch]

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

/****** Object:  StoredProcedure [dbo].GetCompanyBranchRowCount    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyBranchRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyBranchRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyBranchRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[CompanyBranch]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedCompanyBranch    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedCompanyBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedCompanyBranch]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedCompanyBranch
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

SET @SQL1 = 'WITH CompanyBranchEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[CompanyId],
	[Name],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Logo],
	[ColorLogo],
	[EmailLogo],
	[TimeZone],
	[Tax],
	[IsMainBranch]
				FROM 
				[dbo].[CompanyBranch]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[CompanyId],
	[Name],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Logo],
	[ColorLogo],
	[EmailLogo],
	[TimeZone],
	[Tax],
	[IsMainBranch]
				FROM 
					CompanyBranchEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[CompanyBranch] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetCompanyBranchByQuery    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyBranchByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyBranchByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyBranchByQuery
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
				[dbo].[CompanyBranch] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

