USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertCompany    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertCompany]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertCompany]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertCompany
(
	@Id int OUTPUT,
	@CompanyId uniqueidentifier,
	@CompanyName nvarchar(50),
	@UserName nvarchar(150),
	@EmailAdress nvarchar(150),
	@FirstName nvarchar(150),
	@LastName nvarchar(150),
	@Phone nvarchar(50),
	@Fax nvarchar(50),
	@Address nvarchar(max),
	@Street nvarchar(500),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@Website nvarchar(50),
	@CompanyType nvarchar(50),
	@Note nvarchar(max),
	@CompanyLogo nvarchar(250)
)
AS
    INSERT INTO [dbo].[Company] 
	(
	[CompanyId],
	[CompanyName],
	[UserName],
	[EmailAdress],
	[FirstName],
	[LastName],
	[Phone],
	[Fax],
	[Address],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Website],
	[CompanyType],
	[Note],
	[CompanyLogo]
    ) 
	VALUES 
	(
	@CompanyId,
	@CompanyName,
	@UserName,
	@EmailAdress,
	@FirstName,
	@LastName,
	@Phone,
	@Fax,
	@Address,
	@Street,
	@City,
	@State,
	@ZipCode,
	@Website,
	@CompanyType,
	@Note,
	@CompanyLogo
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

/****** Object:  StoredProcedure [dbo].UpdateCompany    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCompany]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateCompany]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateCompany
(
	@Id int,
	@CompanyId uniqueidentifier,
	@CompanyName nvarchar(50),
	@UserName nvarchar(150),
	@EmailAdress nvarchar(150),
	@FirstName nvarchar(150),
	@LastName nvarchar(150),
	@Phone nvarchar(50),
	@Fax nvarchar(50),
	@Address nvarchar(max),
	@Street nvarchar(500),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@Website nvarchar(50),
	@CompanyType nvarchar(50),
	@Note nvarchar(max),
	@CompanyLogo nvarchar(250)
)
AS
    UPDATE [dbo].[Company] 
	SET
	[CompanyId] = @CompanyId,
	[CompanyName] = @CompanyName,
	[UserName] = @UserName,
	[EmailAdress] = @EmailAdress,
	[FirstName] = @FirstName,
	[LastName] = @LastName,
	[Phone] = @Phone,
	[Fax] = @Fax,
	[Address] = @Address,
	[Street] = @Street,
	[City] = @City,
	[State] = @State,
	[ZipCode] = @ZipCode,
	[Website] = @Website,
	[CompanyType] = @CompanyType,
	[Note] = @Note,
	[CompanyLogo] = @CompanyLogo
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

/****** Object:  StoredProcedure [dbo].DeleteCompany    Script Date: 4/18/2018 4:00:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCompany]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteCompany]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteCompany
(
	@Id int
)
AS
	DELETE [dbo].[Company] 

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

/****** Object:  StoredProcedure [dbo].GetAllCompany    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllCompany]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllCompany]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllCompany
AS
	SELECT *		
	FROM
		[dbo].[Company]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetCompanyById    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[Company]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetCompanyMaximumId    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[Company]

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

/****** Object:  StoredProcedure [dbo].GetCompanyRowCount    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[Company]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedCompany    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedCompany]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedCompany]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedCompany
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

SET @SQL1 = 'WITH CompanyEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[CompanyId],
	[CompanyName],
	[UserName],
	[EmailAdress],
	[FirstName],
	[LastName],
	[Phone],
	[Fax],
	[Address],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Website],
	[CompanyType],
	[Note],
	[CompanyLogo]
				FROM 
				[dbo].[Company]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[CompanyId],
	[CompanyName],
	[UserName],
	[EmailAdress],
	[FirstName],
	[LastName],
	[Phone],
	[Fax],
	[Address],
	[Street],
	[City],
	[State],
	[ZipCode],
	[Website],
	[CompanyType],
	[Note],
	[CompanyLogo]
				FROM 
					CompanyEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[Company] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetCompanyByQuery    Script Date: 4/18/2018 4:00:55 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCompanyByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCompanyByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetCompanyByQuery
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
				[dbo].[Company] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

