﻿USE llpdb
GO

/****** Object:  StoredProcedure [dbo]..InsertInvoiceNote    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertInvoiceNote]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertInvoiceNote]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE InsertInvoiceNote
(
	@Id int OUTPUT,
	@CompanyId uniqueidentifier,
	@InvoiceId int,
	@Note nvarchar(max),
	@AddedDate datetime,
	@AddedBy uniqueidentifier
)
AS
    INSERT INTO [dbo].[InvoiceNote] 
	(
	[CompanyId],
	[InvoiceId],
	[Note],
	[AddedDate],
	[AddedBy]
    ) 
	VALUES 
	(
	@CompanyId,
	@InvoiceId,
	@Note,
	@AddedDate,
	@AddedBy
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

/****** Object:  StoredProcedure [dbo].UpdateInvoiceNote    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateInvoiceNote]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateInvoiceNote]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateInvoiceNote
(
	@Id int,
	@CompanyId uniqueidentifier,
	@InvoiceId int,
	@Note nvarchar(max),
	@AddedDate datetime,
	@AddedBy uniqueidentifier
)
AS
    UPDATE [dbo].[InvoiceNote] 
	SET
	[CompanyId] = @CompanyId,
	[InvoiceId] = @InvoiceId,
	[Note] = @Note,
	[AddedDate] = @AddedDate,
	[AddedBy] = @AddedBy
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

/****** Object:  StoredProcedure [dbo].DeleteInvoiceNote    Script Date: 4/18/2018 4:00:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteInvoiceNote]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteInvoiceNote]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteInvoiceNote
(
	@Id int
)
AS
	DELETE [dbo].[InvoiceNote] 

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

/****** Object:  StoredProcedure [dbo].GetAllInvoiceNote    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllInvoiceNote]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllInvoiceNote]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllInvoiceNote
AS
	SELECT *		
	FROM
		[dbo].[InvoiceNote]

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetInvoiceNoteById    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInvoiceNoteById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInvoiceNoteById]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInvoiceNoteById
(
	@Id int
)
AS
	SELECT *		
	FROM
		[dbo].[InvoiceNote]
	WHERE ( Id = @Id )

RETURN @@ROWCOUNT
GO

/****** Object:  StoredProcedure [dbo].GetInvoiceNoteMaximumId    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInvoiceNoteMaximumId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInvoiceNoteMaximumId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInvoiceNoteMaximumId
AS
	DECLARE @Result int
	SET @Result = 0
	
	SELECT @Result = MAX(Id) 		
	FROM
		[dbo].[InvoiceNote]

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

/****** Object:  StoredProcedure [dbo].GetInvoiceNoteRowCount    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInvoiceNoteRowCount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInvoiceNoteRowCount]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInvoiceNoteRowCount
AS
	DECLARE @Result int
	SET @Result = 0
	SELECT @Result = COUNT(*) 		
	FROM
		[dbo].[InvoiceNote]
		
RETURN @Result
GO

/****** Object:  StoredProcedure [dbo].GetPagedInvoiceNote    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPagedInvoiceNote]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetPagedInvoiceNote]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetPagedInvoiceNote
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

SET @SQL1 = 'WITH InvoiceNoteEntries AS (
			SELECT ROW_NUMBER() OVER ('+ @SortColumn +')AS Row,
	[Id],
	[CompanyId],
	[InvoiceId],
	[Note],
	[AddedDate],
	[AddedBy]
				FROM 
				[dbo].[InvoiceNote]
					'+ @WhereClause +'
				)
				SELECT 
	[Id],
	[CompanyId],
	[InvoiceId],
	[Note],
	[AddedDate],
	[AddedBy]
				FROM 
					InvoiceNoteEntries
				WHERE 
					Row between '+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) + 1) +'And ('+ CONVERT(nvarchar(10), (@PageIndex * @RowPerPage) +@RowPerPage+ 1) +')'
	

SET @SQL2 =		' SELECT @TotalRows = COUNT(*) 
				FROM 
				[dbo].[InvoiceNote] ' + @WhereClause
								
EXEC sp_executesql @SQL2, N'@TotalRows int output', @TotalRows = @TotalRows output

EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

/****** Object:  StoredProcedure [dbo].GetInvoiceNoteByQuery    Script Date: 4/18/2018 4:00:58 PM  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInvoiceNoteByQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInvoiceNoteByQuery]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetInvoiceNoteByQuery
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
				[dbo].[InvoiceNote] ' + @Query
								
EXEC sp_executesql @SQL1

RETURN @@ROWCOUNT
END
GO

