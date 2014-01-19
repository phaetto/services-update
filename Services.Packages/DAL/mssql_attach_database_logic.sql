/** Services.Packages.Package CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaRead] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPa]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaDelete] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaPa]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaCreate] 
	@PackageName [nvarchar](1024), @VersionLabel [nvarchar](1024), @UploadDate [datetime], @ApiKey_Id [uniqueidentifier], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaPa]
	([PackageName], [VersionLabel], [UploadDate], [ApiKey_Id], [Owner_Name])
	VALUES (@PackageName, @VersionLabel, @UploadDate, @ApiKey_Id, @Owner_Name);
	
	SELECT * FROM [SePaPa] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaUpdate] 
	@Id [int], @PackageName [nvarchar](1024), @VersionLabel [nvarchar](1024), @UploadDate [datetime], @ApiKeyHasChanged [bit], @ApiKey_Id [uniqueidentifier], @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaPa]
	SET [PackageName] = @PackageName, [VersionLabel] = @VersionLabel, [UploadDate] = @UploadDate
	WHERE (([Id] = @Id));
	
	IF (@ApiKeyHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPa]
		SET [ApiKey_Id] = @ApiKey_Id
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPa]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaSeByPaNa] 
	@PackageName [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' 
	ORDER BY [UploadDate] DESC;
END
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaPaged] 
	@PackageName [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' 
	ORDER BY [UploadDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaCount] 
	@PackageName [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' ;
END
GO


/** Services.Packages.LocalPackage CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoPaRead] 
	@PackageName [nvarchar](1024)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoPa]
	WHERE ([PackageName] = @PackageName);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoPaDelete] 
	@PackageName [nvarchar](1024)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaLoPa]
	WHERE (([PackageName] = @PackageName));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoPaCreate] 
	@PackageName [nvarchar](1024), @Id [int], @VersionLabel [nvarchar](1024)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaLoPa]
	([PackageName], [Id], [VersionLabel])
	VALUES (@PackageName, @Id, @VersionLabel);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoPaUpdate] 
	@PackageName [nvarchar](1024), @Id [int], @VersionLabel [nvarchar](1024)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaLoPa]
	SET [PackageName] = @PackageName, [Id] = @Id, [VersionLabel] = @VersionLabel
	WHERE (([PackageName] = @PackageName));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoPaSeByPaNa] 
	@PackageName [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' 
	;
END
GO

CREATE PROCEDURE [dbo].[LoPaSeByPaNaPaged] 
	@PackageName [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' 
	;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[LoPaSeByPaNaCount] 
	@PackageName [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoPa]
	WHERE [PackageName] LIKE @PackageName ESCAPE '\' ;
END
GO


/** Services.Packages.ApiKey CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeRead] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaApKe]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeDelete] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaApKe]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeCreate] 
	@Id [uniqueidentifier], @CompanyInfo [nvarchar](1024), @IssueDate [datetime], @FromDate [datetime], @ToDate [datetime], @IsTest [bit], @Customer_Name [nvarchar](256), @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaApKe]
	([Id], [CompanyInfo], [IssueDate], [FromDate], [ToDate], [IsTest], [Customer_Name], [Owner_Name])
	VALUES (@Id, @CompanyInfo, @IssueDate, @FromDate, @ToDate, @IsTest, @Customer_Name, @Owner_Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeUpdate] 
	@Id [uniqueidentifier], @CompanyInfo [nvarchar](1024), @IssueDate [datetime], @FromDate [datetime], @ToDate [datetime], @IsTest [bit], @CustomerHasChanged [bit], @Customer_Name [nvarchar](256), @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaApKe]
	SET [Id] = @Id, [CompanyInfo] = @CompanyInfo, [IssueDate] = @IssueDate, [FromDate] = @FromDate, [ToDate] = @ToDate, [IsTest] = @IsTest
	WHERE (([Id] = @Id));
	
	IF (@CustomerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaApKe]
		SET [Customer_Name] = @Customer_Name
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaApKe]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoIn] 
	@CompanyInfo [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaApKe]
	WHERE [CompanyInfo] LIKE @CompanyInfo ESCAPE '\' 
	ORDER BY [IssueDate] DESC;
END
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInPaged] 
	@CompanyInfo [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaApKe]
	WHERE [CompanyInfo] LIKE @CompanyInfo ESCAPE '\' 
	ORDER BY [IssueDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInCount] 
	@CompanyInfo [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe]
	WHERE [CompanyInfo] LIKE @CompanyInfo ESCAPE '\' ;
END
GO


/** Services.Packages.Log.ApplicationException CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExRead] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExDelete] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaLoApEx]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExCreate] 
	@Message [nvarchar](512), @Source [nvarchar](512), @StackTrace [ntext], @Page [ntext], @OnDate [datetime], @IsSolved [bit], @ApiKey_Id [uniqueidentifier], @ParentException_Id [int], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaLoApEx]
	([Message], [Source], [StackTrace], [Page], [OnDate], [IsSolved], [ApiKey_Id], [ParentException_Id], [Owner_Name])
	VALUES (@Message, @Source, @StackTrace, @Page, @OnDate, @IsSolved, @ApiKey_Id, @ParentException_Id, @Owner_Name);
	
	SELECT * FROM [SePaLoApEx] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExUpdate] 
	@Id [int], @Message [nvarchar](512), @Source [nvarchar](512), @StackTrace [ntext], @Page [ntext], @OnDate [datetime], @IsSolved [bit], @ApiKeyHasChanged [bit], @ApiKey_Id [uniqueidentifier], @ParentExceptionHasChanged [bit], @ParentException_Id [int], @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaLoApEx]
	SET [Message] = @Message, [Source] = @Source, [StackTrace] = @StackTrace, [Page] = @Page, [OnDate] = @OnDate, [IsSolved] = @IsSolved
	WHERE (([Id] = @Id));
	
	IF (@ApiKeyHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaLoApEx]
		SET [ApiKey_Id] = @ApiKey_Id
		WHERE (([Id] = @Id));
	END;
	
	IF (@ParentExceptionHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaLoApEx]
		SET [ParentException_Id] = @ParentException_Id
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaLoApEx]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExSeByNa] 
	@Message [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' 
	ORDER BY [OnDate] DESC;
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaPaged] 
	@Message [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' 
	ORDER BY [OnDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaCount] 
	@Message [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSo] 
	@Message [ntext], @IsSolved [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved 
	ORDER BY [OnDate] DESC;
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoPaged] 
	@Message [ntext], @IsSolved [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved 
	ORDER BY [OnDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoCount] 
	@Message [ntext], @IsSolved [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE [Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved ;
END
GO


/** Services.Packages.Customer CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuRead] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuDelete] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaCu]
	WHERE (([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuCreate] 
	@Name [nvarchar](256), @FullNameOfResponsible [nvarchar](512), @EmailOfResponsible [nvarchar](256), @Description [nvarchar](256), @IsPartner [bit], @CompanyName [nvarchar](256), @VATNo [nvarchar](256), @Phone [nvarchar](128), @Address [nvarchar](256), @PostCode [nvarchar](64), @City [nvarchar](128), @Country [nvarchar](256), @InvoiceAddress [nvarchar](256), @InvoicePostCode [nvarchar](64), @InvoiceCity [nvarchar](128), @InvoiceCountry [nvarchar](256), @IsPaymentAccepted [bit], @LastPaymentDate [datetime], @Partner_Name [nvarchar](256), @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaCu]
	([Name], [FullNameOfResponsible], [EmailOfResponsible], [Description], [IsPartner], [CompanyName], [VATNo], [Phone], [Address], [PostCode], [City], [Country], [InvoiceAddress], [InvoicePostCode], [InvoiceCity], [InvoiceCountry], [IsPaymentAccepted], [LastPaymentDate], [Partner_Name], [Owner_Name])
	VALUES (@Name, @FullNameOfResponsible, @EmailOfResponsible, @Description, @IsPartner, @CompanyName, @VATNo, @Phone, @Address, @PostCode, @City, @Country, @InvoiceAddress, @InvoicePostCode, @InvoiceCity, @InvoiceCountry, @IsPaymentAccepted, @LastPaymentDate, @Partner_Name, @Owner_Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUpdate] 
	@Name [nvarchar](256), @FullNameOfResponsible [nvarchar](512), @EmailOfResponsible [nvarchar](256), @Description [nvarchar](256), @IsPartner [bit], @CompanyName [nvarchar](256), @VATNo [nvarchar](256), @Phone [nvarchar](128), @Address [nvarchar](256), @PostCode [nvarchar](64), @City [nvarchar](128), @Country [nvarchar](256), @InvoiceAddress [nvarchar](256), @InvoicePostCode [nvarchar](64), @InvoiceCity [nvarchar](128), @InvoiceCountry [nvarchar](256), @IsPaymentAccepted [bit], @LastPaymentDate [datetime], @PartnerHasChanged [bit], @Partner_Name [nvarchar](256), @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaCu]
	SET [Name] = @Name, [FullNameOfResponsible] = @FullNameOfResponsible, [EmailOfResponsible] = @EmailOfResponsible, [Description] = @Description, [IsPartner] = @IsPartner, [CompanyName] = @CompanyName, [VATNo] = @VATNo, [Phone] = @Phone, [Address] = @Address, [PostCode] = @PostCode, [City] = @City, [Country] = @Country, [InvoiceAddress] = @InvoiceAddress, [InvoicePostCode] = @InvoicePostCode, [InvoiceCity] = @InvoiceCity, [InvoiceCountry] = @InvoiceCountry, [IsPaymentAccepted] = @IsPaymentAccepted, [LastPaymentDate] = @LastPaymentDate
	WHERE (([Name] = @Name));
	
	IF (@PartnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaCu]
		SET [Partner_Name] = @Partner_Name
		WHERE (([Name] = @Name));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaCu]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Name] = @Name));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPa] 
	@Name [ntext], @IsPartner [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPartner] LIKE @IsPartner 
	ORDER BY [Name] ASC;
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaPaged] 
	@Name [ntext], @IsPartner [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPartner] LIKE @IsPartner 
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaCount] 
	@Name [ntext], @IsPartner [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPartner] LIKE @IsPartner ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuSeByNa] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaPaged] 
	@Name [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaCount] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaPa] 
	@Name [ntext], @IsPaymentAccepted [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted 
	ORDER BY [LastPaymentDate] ASC;
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaPaPaged] 
	@Name [ntext], @IsPaymentAccepted [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted 
	ORDER BY [LastPaymentDate] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaPaCount] 
	@Name [ntext], @IsPaymentAccepted [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE [Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted ;
END
GO


/** Services.Packages.CustomerUserEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnRead] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUsEn]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnDelete] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaCuUsEn]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnCreate] 
	@UserLogin_Name [nvarchar](128), @Customer_Name [nvarchar](256), @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaCuUsEn]
	([UserLogin_Name], [Customer_Name], [Owner_Name])
	VALUES (@UserLogin_Name, @Customer_Name, @Owner_Name);
	
	SELECT * FROM [SePaCuUsEn] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnUpdate] 
	@Id [int], @UserLoginHasChanged [bit], @UserLogin_Name [nvarchar](128), @CustomerHasChanged [bit], @Customer_Name [nvarchar](256), @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF (@UserLoginHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaCuUsEn]
		SET [UserLogin_Name] = @UserLogin_Name
		WHERE (([Id] = @Id));
	END;
	
	IF (@CustomerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaCuUsEn]
		SET [Customer_Name] = @Customer_Name
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaCuUsEn]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



/** Services.Packages.Purchase CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuRead] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPu]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuDelete] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaPu]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuCreate] 
	@CreationDate [datetime], @ApiKey_Id [uniqueidentifier], @Client_Name [nvarchar](128), @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaPu]
	([CreationDate], [ApiKey_Id], [Client_Name], [Owner_Name])
	VALUES (@CreationDate, @ApiKey_Id, @Client_Name, @Owner_Name);
	
	SELECT * FROM [SePaPu] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUpdate] 
	@Id [int], @CreationDate [datetime], @ApiKeyHasChanged [bit], @ApiKey_Id [uniqueidentifier], @ClientHasChanged [bit], @Client_Name [nvarchar](128), @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaPu]
	SET [CreationDate] = @CreationDate
	WHERE (([Id] = @Id));
	
	IF (@ApiKeyHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPu]
		SET [ApiKey_Id] = @ApiKey_Id
		WHERE (([Id] = @Id));
	END;
	
	IF (@ClientHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPu]
		SET [Client_Name] = @Client_Name
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPu]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuGeAl] 
	@dummy [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPu]
	
	;
END
GO

CREATE PROCEDURE [dbo].[PuGeAlPaged] 
	@dummy [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPu]
	
	;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuGeAlCount] 
	@dummy [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu]
	;
END
GO


/** Services.Packages.PurchaseLine CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiRead] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLi]
	WHERE ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiDelete] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaPuLi]
	WHERE (([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiCreate] 
	@ProductKey [nvarchar](256), @ProductDescription [ntext], @PricePurchased [float], @RecurrentFeePurchased [float], @IsPaid [bit], @PurchaseOrder_Id [int], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaPuLi]
	([ProductKey], [ProductDescription], [PricePurchased], [RecurrentFeePurchased], [IsPaid], [PurchaseOrder_Id], [Owner_Name])
	VALUES (@ProductKey, @ProductDescription, @PricePurchased, @RecurrentFeePurchased, @IsPaid, @PurchaseOrder_Id, @Owner_Name);
	
	SELECT * FROM [SePaPuLi] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUpdate] 
	@Id [int], @ProductKey [nvarchar](256), @ProductDescription [ntext], @PricePurchased [float], @RecurrentFeePurchased [float], @IsPaid [bit], @PurchaseOrderHasChanged [bit], @PurchaseOrder_Id [int], @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaPuLi]
	SET [ProductKey] = @ProductKey, [ProductDescription] = @ProductDescription, [PricePurchased] = @PricePurchased, [RecurrentFeePurchased] = @RecurrentFeePurchased, [IsPaid] = @IsPaid
	WHERE (([Id] = @Id));
	
	IF (@PurchaseOrderHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPuLi]
		SET [PurchaseOrder_Id] = @PurchaseOrder_Id
		WHERE (([Id] = @Id));
	END;
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaPuLi]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Id] = @Id));
	END;
END
GO



/** Services.Packages.Security.ModelUser CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRead] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsDelete] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeMoUs]
	WHERE (([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsCreate] 
	@Name [nvarchar](128), @PasswordHash [nvarchar](256), @Email [nvarchar](256), @Enabled [bit], @SecretQuestion [nvarchar](512), @SecretAnswer [nvarchar](512), @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeMoUs]
	([Name], [PasswordHash], [Email], [Enabled], [SecretQuestion], [SecretAnswer], [Owner_Name])
	VALUES (@Name, @PasswordHash, @Email, @Enabled, @SecretQuestion, @SecretAnswer, @Owner_Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsUpdate] 
	@Name [nvarchar](128), @PasswordHash [nvarchar](256), @Email [nvarchar](256), @Enabled [bit], @SecretQuestion [nvarchar](512), @SecretAnswer [nvarchar](512), @OwnerHasChanged [bit], @Owner_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeMoUs]
	SET [Name] = @Name, [PasswordHash] = @PasswordHash, [Email] = @Email, [Enabled] = @Enabled, [SecretQuestion] = @SecretQuestion, [SecretAnswer] = @SecretAnswer
	WHERE (([Name] = @Name));
	
	IF (@OwnerHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaSeMoUs]
		SET [Owner_Name] = @Owner_Name
		WHERE (([Name] = @Name));
	END;
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsSeByNa] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
END
GO

CREATE PROCEDURE [dbo].[MoUsSeByNaPaged] 
	@Name [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsSeByNaCount] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUs]
	WHERE [Name] LIKE @Name ESCAPE '\' ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsSeByEm] 
	@Email [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' 
	ORDER BY [Email] ASC;
END
GO

CREATE PROCEDURE [dbo].[MoUsSeByEmPaged] 
	@Email [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' 
	ORDER BY [Email] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsSeByEmCount] 
	@Email [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsSeEnByNaAnEm] 
	@Name [ntext], @Email [ntext], @Enabled [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' AND [Name] LIKE @Name ESCAPE '\' AND [Enabled] = @Enabled 
	ORDER BY [Name] ASC;
END
GO

CREATE PROCEDURE [dbo].[MoUsSeEnByNaAnEmPaged] 
	@Name [ntext], @Email [ntext], @Enabled [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' AND [Name] LIKE @Name ESCAPE '\' AND [Enabled] = @Enabled 
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsSeEnByNaAnEmCount] 
	@Name [ntext], @Email [ntext], @Enabled [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUs]
	WHERE [Email] LIKE @Email ESCAPE '\' AND [Name] LIKE @Name ESCAPE '\' AND [Enabled] = @Enabled ;
END
GO


/** Services.Packages.Security.ModelSession CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoSeRead] 
	@SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoSe]
	WHERE ([SessionToken] = @SessionToken);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoSeDelete] 
	@SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeMoSe]
	WHERE (([SessionToken] = @SessionToken));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoSeCreate] 
	@SessionToken [nvarchar](384), @TimeIssued [datetime], @TimeIssuedFor [int], @User_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeMoSe]
	([SessionToken], [TimeIssued], [TimeIssuedFor], [User_Name])
	VALUES (@SessionToken, @TimeIssued, @TimeIssuedFor, @User_Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoSeUpdate] 
	@SessionToken [nvarchar](384), @TimeIssued [datetime], @TimeIssuedFor [int], @UserHasChanged [bit], @User_Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeMoSe]
	SET [SessionToken] = @SessionToken, [TimeIssued] = @TimeIssued, [TimeIssuedFor] = @TimeIssuedFor
	WHERE (([SessionToken] = @SessionToken));
	
	IF (@UserHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaSeMoSe]
		SET [User_Name] = @User_Name
		WHERE (([SessionToken] = @SessionToken));
	END;
END
GO



/** Services.Packages.Security.ModelUserRights CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiRead] 
	@Name [nvarchar](128), @UserName [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUsRi]
	WHERE ([Name] = @Name) AND ([UserName] = @UserName);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiDelete] 
	@Name [nvarchar](128), @UserName [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeMoUsRi]
	WHERE (([Name] = @Name) AND ([UserName] = @UserName));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiCreate] 
	@Name [nvarchar](128), @UserName [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeMoUsRi]
	([Name], [UserName])
	VALUES (@Name, @UserName);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiUpdate] 
	@Name [nvarchar](128), @UserName [nvarchar](128), @UserHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeMoUsRi]
	SET [Name] = @Name, [UserName] = @UserName
	WHERE (([Name] = @Name) AND ([UserName] = @UserName));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNa] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaPaged] 
	@Name [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [Name] LIKE @Name ESCAPE '\' 
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaCount] 
	@Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [Name] LIKE @Name ESCAPE '\' ;
END
GO


/** Services.Packages.Security.Securable CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SeRead] 
	@Type [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSe]
	WHERE ([Type] = @Type);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SeDelete] 
	@Type [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeSe]
	WHERE (([Type] = @Type));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SeCreate] 
	@Type [nvarchar](256), @Enabled [bit], @TimeSessionIsIssued [int], @AllowAnonymousAccess [bit], @GenerationPasswordLength [int], @IPsMustBePreregistered [bit], @AllowedIPFailures [int], @IPFailureTimeDenying [int], @DisableIPFiltering [bit], @SessionsPerIPAllowed [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeSe]
	([Type], [Enabled], [TimeSessionIsIssued], [AllowAnonymousAccess], [GenerationPasswordLength], [IPsMustBePreregistered], [AllowedIPFailures], [IPFailureTimeDenying], [DisableIPFiltering], [SessionsPerIPAllowed])
	VALUES (@Type, @Enabled, @TimeSessionIsIssued, @AllowAnonymousAccess, @GenerationPasswordLength, @IPsMustBePreregistered, @AllowedIPFailures, @IPFailureTimeDenying, @DisableIPFiltering, @SessionsPerIPAllowed);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SeUpdate] 
	@Type [nvarchar](256), @Enabled [bit], @TimeSessionIsIssued [int], @AllowAnonymousAccess [bit], @GenerationPasswordLength [int], @IPsMustBePreregistered [bit], @AllowedIPFailures [int], @IPFailureTimeDenying [int], @DisableIPFiltering [bit], @SessionsPerIPAllowed [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeSe]
	SET [Type] = @Type, [Enabled] = @Enabled, [TimeSessionIsIssued] = @TimeSessionIsIssued, [AllowAnonymousAccess] = @AllowAnonymousAccess, [GenerationPasswordLength] = @GenerationPasswordLength, [IPsMustBePreregistered] = @IPsMustBePreregistered, [AllowedIPFailures] = @AllowedIPFailures, [IPFailureTimeDenying] = @IPFailureTimeDenying, [DisableIPFiltering] = @DisableIPFiltering, [SessionsPerIPAllowed] = @SessionsPerIPAllowed
	WHERE (([Type] = @Type));
END
GO



/** Services.Packages.Security.IPRegistered CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPReRead] 
	@IP [nvarchar](64)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeIPRe]
	WHERE ([IP] = @IP);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPReDelete] 
	@IP [nvarchar](64)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeIPRe]
	WHERE (([IP] = @IP));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPReCreate] 
	@IP [nvarchar](64), @Allowed [bit], @Failures [int], @DenialIssuedUntilTime [datetime]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeIPRe]
	([IP], [Allowed], [Failures], [DenialIssuedUntilTime])
	VALUES (@IP, @Allowed, @Failures, @DenialIssuedUntilTime);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPReUpdate] 
	@IP [nvarchar](64), @Allowed [bit], @Failures [int], @DenialIssuedUntilTime [datetime]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeIPRe]
	SET [IP] = @IP, [Allowed] = @Allowed, [Failures] = @Failures, [DenialIssuedUntilTime] = @DenialIssuedUntilTime
	WHERE (([IP] = @IP));
END
GO



/** Services.Packages.Security.IPSessionRegistration CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReRead] 
	@HostName [nvarchar](128), @UserAgent [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeIPSeRe]
	WHERE ([HostName] = @HostName) AND ([UserAgent] = @UserAgent);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReDelete] 
	@HostName [nvarchar](128), @UserAgent [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeIPSeRe]
	WHERE (([HostName] = @HostName) AND ([UserAgent] = @UserAgent));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReCreate] 
	@HostName [nvarchar](128), @UserAgent [nvarchar](128), @IP_IP [nvarchar](64), @Session_SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeIPSeRe]
	([HostName], [UserAgent], [IP_IP], [Session_SessionToken])
	VALUES (@HostName, @UserAgent, @IP_IP, @Session_SessionToken);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReUpdate] 
	@HostName [nvarchar](128), @UserAgent [nvarchar](128), @IPHasChanged [bit], @IP_IP [nvarchar](64), @SessionHasChanged [bit], @Session_SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeIPSeRe]
	SET [HostName] = @HostName, [UserAgent] = @UserAgent
	WHERE (([HostName] = @HostName) AND ([UserAgent] = @UserAgent));
	
	IF (@IPHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaSeIPSeRe]
		SET [IP_IP] = @IP_IP
		WHERE (([HostName] = @HostName) AND ([UserAgent] = @UserAgent));
	END;
	
	IF (@SessionHasChanged = 1)
	BEGIN
		UPDATE [dbo].[SePaSeIPSeRe]
		SET [Session_SessionToken] = @Session_SessionToken
		WHERE (([HostName] = @HostName) AND ([UserAgent] = @UserAgent));
	END;
END
GO



/** Services.Packages.Security.PackageAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiRead] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePaAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePaAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [int], @UserHasChanged [bit], @PackageHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePaAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.PackageAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePaAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePaAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePaAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.ApiKeyAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiRead] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeApKeAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [uniqueidentifier], @UserHasChanged [bit], @ApiKeyHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeApKeAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.ApiKeyAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeApKeAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [uniqueidentifier], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeApKeAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiRead] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaLoSeApExAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [int], @UserHasChanged [bit], @ApplicationExceptionHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaLoSeApExAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaLoSeApExAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaLoSeApExAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.CustomerAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiRead] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiDelete] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeCuAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiCreate] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeCuAcCoLi]
	([UserName], [Name])
	VALUES (@UserName, @Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiUpdate] 
	@UserName [nvarchar](128), @Name [nvarchar](256), @UserHasChanged [bit], @CustomerHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeCuAcCoLi]
	SET [UserName] = @UserName, [Name] = @Name
	WHERE (([UserName] = @UserName) AND ([Name] = @Name));
END
GO



/** Services.Packages.Security.CustomerAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeCuAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeCuAcCoEn]
	([Descriptor], [UserName], [Allow], [Name])
	VALUES (@Descriptor, @UserName, @Allow, @Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Name [nvarchar](256), @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeCuAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Name] = @Name
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name));
END
GO



/** Services.Packages.Security.CustomerUserEntryAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiRead] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeCuUsEnAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [int], @UserHasChanged [bit], @CustomerUserEntryHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeCuUsEnAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.CustomerUserEntryAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeCuUsEnAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeCuUsEnAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.PurchaseAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiRead] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePuAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePuAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [int], @UserHasChanged [bit], @PurchaseHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePuAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.PurchaseAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePuAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePuAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePuAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.PurchaseLineAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiRead] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiDelete] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiCreate] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePuLiAcCoLi]
	([UserName], [Id])
	VALUES (@UserName, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiUpdate] 
	@UserName [nvarchar](128), @Id [int], @UserHasChanged [bit], @PurchaseLineHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePuLiAcCoLi]
	SET [UserName] = @UserName, [Id] = @Id
	WHERE (([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.PurchaseLineAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSePuLiAcCoEn]
	([Descriptor], [UserName], [Allow], [Id])
	VALUES (@Descriptor, @UserName, @Allow, @Id);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Id [int], @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSePuLiAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Id] = @Id
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Id] = @Id));
END
GO



/** Services.Packages.Security.Security.ModelUserAccessControlList CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiRead] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE ([UserName] = @UserName) AND ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiDelete] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE (([UserName] = @UserName) AND ([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiCreate] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeSeMoUsAcCoLi]
	([UserName], [Name])
	VALUES (@UserName, @Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiUpdate] 
	@UserName [nvarchar](128), @Name [nvarchar](128), @UserHasChanged [bit], @ModelUserHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeSeMoUsAcCoLi]
	SET [UserName] = @UserName, [Name] = @Name
	WHERE (([UserName] = @UserName) AND ([Name] = @Name));
END
GO



/** Services.Packages.Security.Security.ModelUserAccessControlEntry CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnRead] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE ([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnDelete] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnCreate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaSeSeMoUsAcCoEn]
	([Descriptor], [UserName], [Allow], [Name])
	VALUES (@Descriptor, @UserName, @Allow, @Name);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnUpdate] 
	@Descriptor [nvarchar](128), @UserName [nvarchar](128), @Allow [bit], @Name [nvarchar](128), @ACLHasChanged [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaSeSeMoUsAcCoEn]
	SET [Descriptor] = @Descriptor, [UserName] = @UserName, [Allow] = @Allow, [Name] = @Name
	WHERE (([Descriptor] = @Descriptor) AND ([UserName] = @UserName) AND ([Name] = @Name));
END
GO



/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReOpRead] 
	@EntityType [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReOp]
	WHERE ([EntityType] = @EntityType);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReOpDelete] 
	@EntityType [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[PlMoUnReSePaUnReOp]
	WHERE (([EntityType] = @EntityType));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReOpCreate] 
	@EntityType [nvarchar](128), @ItemsAllowed [bigint], @IsEnabled [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[PlMoUnReSePaUnReOp]
	([EntityType], [ItemsAllowed], [IsEnabled])
	VALUES (@EntityType, @ItemsAllowed, @IsEnabled);
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReOpUpdate] 
	@EntityType [nvarchar](128), @ItemsAllowed [bigint], @IsEnabled [bit]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[PlMoUnReSePaUnReOp]
	SET [EntityType] = @EntityType, [ItemsAllowed] = @ItemsAllowed, [IsEnabled] = @IsEnabled
	WHERE (([EntityType] = @EntityType));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReOpSeByEnTy] 
	@EntityType [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReOp]
	WHERE [EntityType] LIKE @EntityType ESCAPE '\' 
	ORDER BY [EntityType] ASC;
END
GO

CREATE PROCEDURE [dbo].[UnReOpSeByEnTyPaged] 
	@EntityType [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReOp]
	WHERE [EntityType] LIKE @EntityType ESCAPE '\' 
	ORDER BY [EntityType] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[UnReOpSeByEnTyCount] 
	@EntityType [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[PlMoUnReSePaUnReOp]
	WHERE [EntityType] LIKE @EntityType ESCAPE '\' ;
END
GO


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReGrRead] 
	@Id [bigint], @UndoRedoEntityType [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReGr]
	WHERE ([Id] = @Id) AND ([UndoRedoEntityType] = @UndoRedoEntityType);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReGrDelete] 
	@Id [bigint], @UndoRedoEntityType [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[PlMoUnReSePaUnReGr]
	WHERE (([Id] = @Id) AND ([UndoRedoEntityType] = @UndoRedoEntityType));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReGrCreate] 
	@EntryName [nvarchar](128), @UndoRedoEntityType [nvarchar](128), @UndoRedoRecordId [bigint]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[PlMoUnReSePaUnReGr]
	([EntryName], [UndoRedoEntityType], [UndoRedoRecordId])
	VALUES (@EntryName, @UndoRedoEntityType, @UndoRedoRecordId);
	
	SELECT * FROM [PlMoUnReSePaUnReGr] WHERE [Id] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReGrUpdate] 
	@Id [bigint], @EntryName [nvarchar](128), @UndoRedoEntityType [nvarchar](128), @UndoRedoRecordId [bigint]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[PlMoUnReSePaUnReGr]
	SET [EntryName] = @EntryName, [UndoRedoEntityType] = @UndoRedoEntityType, [UndoRedoRecordId] = @UndoRedoRecordId
	WHERE (([Id] = @Id) AND ([UndoRedoEntityType] = @UndoRedoEntityType));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UnReGrSeByEnTy] 
	@UndoRedoEntityType [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReGr]
	WHERE [UndoRedoEntityType] LIKE @UndoRedoEntityType ESCAPE '\' 
	ORDER BY [UndoRedoEntityType] ASC;
END
GO

CREATE PROCEDURE [dbo].[UnReGrSeByEnTyPaged] 
	@UndoRedoEntityType [ntext],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[PlMoUnReSePaUnReGr]
	WHERE [UndoRedoEntityType] LIKE @UndoRedoEntityType ESCAPE '\' 
	ORDER BY [UndoRedoEntityType] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[UnReGrSeByEnTyCount] 
	@UndoRedoEntityType [ntext]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[PlMoUnReSePaUnReGr]
	WHERE [UndoRedoEntityType] LIKE @UndoRedoEntityType ESCAPE '\' ;
END
GO


/** Services.Packages.CustomerUndoRedo CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReRead] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	WHERE ([UndoRedoId] = @UndoRedoId);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReDelete] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaCuUnRe]
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReCreate] 
	@IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Name [nvarchar](256), @FullNameOfResponsible [nvarchar](512), @EmailOfResponsible [nvarchar](256), @Description [nvarchar](256), @IsPartner [bit], @CompanyName [nvarchar](256), @VATNo [nvarchar](256), @Phone [nvarchar](128), @Address [nvarchar](256), @PostCode [nvarchar](64), @City [nvarchar](128), @Country [nvarchar](256), @InvoiceAddress [nvarchar](256), @InvoicePostCode [nvarchar](64), @InvoiceCity [nvarchar](128), @InvoiceCountry [nvarchar](256), @IsPaymentAccepted [bit], @LastPaymentDate [datetime], @Partner_Name [ntext], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaCuUnRe]
	([IsCreatedUndoDeletes], [IsDeletedUndoCreates], [IsUpdatedUndoUpdates], [IsUndone], [Name], [FullNameOfResponsible], [EmailOfResponsible], [Description], [IsPartner], [CompanyName], [VATNo], [Phone], [Address], [PostCode], [City], [Country], [InvoiceAddress], [InvoicePostCode], [InvoiceCity], [InvoiceCountry], [IsPaymentAccepted], [LastPaymentDate], [Partner_Name], [Owner_Name])
	VALUES (@IsCreatedUndoDeletes, @IsDeletedUndoCreates, @IsUpdatedUndoUpdates, @IsUndone, @Name, @FullNameOfResponsible, @EmailOfResponsible, @Description, @IsPartner, @CompanyName, @VATNo, @Phone, @Address, @PostCode, @City, @Country, @InvoiceAddress, @InvoicePostCode, @InvoiceCity, @InvoiceCountry, @IsPaymentAccepted, @LastPaymentDate, @Partner_Name, @Owner_Name);
	
	SELECT * FROM [SePaCuUnRe] WHERE [UndoRedoId] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReUpdate] 
	@UndoRedoId [bigint], @IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Name [nvarchar](256), @FullNameOfResponsible [nvarchar](512), @EmailOfResponsible [nvarchar](256), @Description [nvarchar](256), @IsPartner [bit], @CompanyName [nvarchar](256), @VATNo [nvarchar](256), @Phone [nvarchar](128), @Address [nvarchar](256), @PostCode [nvarchar](64), @City [nvarchar](128), @Country [nvarchar](256), @InvoiceAddress [nvarchar](256), @InvoicePostCode [nvarchar](64), @InvoiceCity [nvarchar](128), @InvoiceCountry [nvarchar](256), @IsPaymentAccepted [bit], @LastPaymentDate [datetime], @Partner_Name [ntext], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaCuUnRe]
	SET [IsCreatedUndoDeletes] = @IsCreatedUndoDeletes, [IsDeletedUndoCreates] = @IsDeletedUndoCreates, [IsUpdatedUndoUpdates] = @IsUpdatedUndoUpdates, [IsUndone] = @IsUndone, [Name] = @Name, [FullNameOfResponsible] = @FullNameOfResponsible, [EmailOfResponsible] = @EmailOfResponsible, [Description] = @Description, [IsPartner] = @IsPartner, [CompanyName] = @CompanyName, [VATNo] = @VATNo, [Phone] = @Phone, [Address] = @Address, [PostCode] = @PostCode, [City] = @City, [Country] = @Country, [InvoiceAddress] = @InvoiceAddress, [InvoicePostCode] = @InvoicePostCode, [InvoiceCity] = @InvoiceCity, [InvoiceCountry] = @InvoiceCountry, [IsPaymentAccepted] = @IsPaymentAccepted, [LastPaymentDate] = @LastPaymentDate, [Partner_Name] = @Partner_Name, [Owner_Name] = @Owner_Name
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUn] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUnPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUnCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOr] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSo] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUnRe]
	;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFi] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFiPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUnRe]
	
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUnReGeAlWiNoFiCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUnRe]
	;
END
GO


/** Services.Packages.PurchaseUndoRedo CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReRead] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	WHERE ([UndoRedoId] = @UndoRedoId);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReDelete] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaPuUnRe]
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReCreate] 
	@IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Id [int], @CreationDate [datetime], @ApiKey_Id [uniqueidentifier], @Client_Name [ntext], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaPuUnRe]
	([IsCreatedUndoDeletes], [IsDeletedUndoCreates], [IsUpdatedUndoUpdates], [IsUndone], [Id], [CreationDate], [ApiKey_Id], [Client_Name], [Owner_Name])
	VALUES (@IsCreatedUndoDeletes, @IsDeletedUndoCreates, @IsUpdatedUndoUpdates, @IsUndone, @Id, @CreationDate, @ApiKey_Id, @Client_Name, @Owner_Name);
	
	SELECT * FROM [SePaPuUnRe] WHERE [UndoRedoId] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReUpdate] 
	@UndoRedoId [bigint], @IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Id [int], @CreationDate [datetime], @ApiKey_Id [uniqueidentifier], @Client_Name [ntext], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaPuUnRe]
	SET [IsCreatedUndoDeletes] = @IsCreatedUndoDeletes, [IsDeletedUndoCreates] = @IsDeletedUndoCreates, [IsUpdatedUndoUpdates] = @IsUpdatedUndoUpdates, [IsUndone] = @IsUndone, [Id] = @Id, [CreationDate] = @CreationDate, [ApiKey_Id] = @ApiKey_Id, [Client_Name] = @Client_Name, [Owner_Name] = @Owner_Name
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUn] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUnPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUnCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOr] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSo] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuUnRe]
	;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFi] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFiPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuUnRe]
	
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuUnReGeAlWiNoFiCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuUnRe]
	;
END
GO


/** Services.Packages.PurchaseLineUndoRedo CRUD sp's **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReRead] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	WHERE ([UndoRedoId] = @UndoRedoId);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReDelete] 
	@UndoRedoId [bigint]
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [dbo].[SePaPuLiUnRe]
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReCreate] 
	@IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Id [int], @ProductKey [nvarchar](256), @ProductDescription [ntext], @PricePurchased [float], @RecurrentFeePurchased [float], @IsPaid [bit], @PurchaseOrder_Id [int], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[SePaPuLiUnRe]
	([IsCreatedUndoDeletes], [IsDeletedUndoCreates], [IsUpdatedUndoUpdates], [IsUndone], [Id], [ProductKey], [ProductDescription], [PricePurchased], [RecurrentFeePurchased], [IsPaid], [PurchaseOrder_Id], [Owner_Name])
	VALUES (@IsCreatedUndoDeletes, @IsDeletedUndoCreates, @IsUpdatedUndoUpdates, @IsUndone, @Id, @ProductKey, @ProductDescription, @PricePurchased, @RecurrentFeePurchased, @IsPaid, @PurchaseOrder_Id, @Owner_Name);
	
	SELECT * FROM [SePaPuLiUnRe] WHERE [UndoRedoId] = @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReUpdate] 
	@UndoRedoId [bigint], @IsCreatedUndoDeletes [bit], @IsDeletedUndoCreates [bit], @IsUpdatedUndoUpdates [bit], @IsUndone [bit], @Id [int], @ProductKey [nvarchar](256), @ProductDescription [ntext], @PricePurchased [float], @RecurrentFeePurchased [float], @IsPaid [bit], @PurchaseOrder_Id [int], @Owner_Name [ntext]
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [dbo].[SePaPuLiUnRe]
	SET [IsCreatedUndoDeletes] = @IsCreatedUndoDeletes, [IsDeletedUndoCreates] = @IsDeletedUndoCreates, [IsUpdatedUndoUpdates] = @IsUpdatedUndoUpdates, [IsUndone] = @IsUndone, [Id] = @Id, [ProductKey] = @ProductKey, [ProductDescription] = @ProductDescription, [PricePurchased] = @PricePurchased, [RecurrentFeePurchased] = @RecurrentFeePurchased, [IsPaid] = @IsPaid, [PurchaseOrder_Id] = @PurchaseOrder_Id, [Owner_Name] = @Owner_Name
	WHERE (([UndoRedoId] = @UndoRedoId));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUn] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOr] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrPaged] 
	@IsUndone [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone 
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrCount] 
	@IsUndone [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLiUnRe]
	WHERE [IsUndone] = @IsUndone ;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSo] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	
	ORDER BY [UndoRedoId] ASC;
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	
	ORDER BY [UndoRedoId] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLiUnRe]
	;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFi] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	
	ORDER BY [UndoRedoId] DESC;
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiPaged] 
	@dummy [bit],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLiUnRe]
	
	ORDER BY [UndoRedoId] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiCount] 
	@dummy [bit]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLiUnRe]
	;
END
GO


/** Services.Packages.Package Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaGetByApKe] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PaGetByApKePaged] 
	@Id [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PaGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PaGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PaGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaFoApKe] 
	@PackageName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[PackageName] LIKE @PackageName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaFoApKePaged] 
	@PackageName [ntext], @ApKeId [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[PackageName] LIKE @PackageName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaFoApKeCount] 
	@PackageName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[PackageName] LIKE @PackageName ESCAPE '\' )
END
GO

/** Services.Packages.LocalPackage Relations SPs **/


/** Services.Packages.ApiKey Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeGetByCu] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApKeGetByCuPaged] 
	@Name [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApKeGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApKeGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApKeGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInOnCu] 
	@CompanyInfo [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[CompanyInfo] LIKE @CompanyInfo ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInOnCuPaged] 
	@CompanyInfo [ntext], @CuNa [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[CompanyInfo] LIKE @CompanyInfo ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInOnCuCount] 
	@CompanyInfo [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[CompanyInfo] LIKE @CompanyInfo ESCAPE '\' )
END
GO

/** Services.Packages.Log.ApplicationException Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExGetByApKe] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExGetByApKePaged] 
	@Id [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExGetByPaEx] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[ParentException_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExGetByPaExPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[ParentException_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExGetByPaExCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[ParentException_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExSeByNaOnApKe] 
	@Message [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaOnApKePaged] 
	@Message [ntext], @ApKeId [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaOnApKeCount] 
	@Message [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoOnApKe] 
	@Message [ntext], @IsSolved [bit], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' AND a.[IsSolved] = @IsSolved );
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoOnApKePaged] 
	@Message [ntext], @IsSolved [bit], @ApKeId [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' AND a.[IsSolved] = @IsSolved );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoOnApKeCount] 
	@Message [ntext], @IsSolved [bit], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[Message] LIKE @Message ESCAPE '\' AND a.[IsSolved] = @IsSolved )
END
GO

/** Services.Packages.Customer Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuGetByPa] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuGetByPaPaged] 
	@Name [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuGetByPaCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuSeByNaOnPa] 
	@Name [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaOnPaPaged] 
	@Name [ntext], @CuNa [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaOnPaCount] 
	@Name [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaOnPa] 
	@Name [ntext], @IsPaymentAccepted [bit], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' AND a.[IsPaymentAccepted] = @IsPaymentAccepted );
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaOnPaPaged] 
	@Name [ntext], @IsPaymentAccepted [bit], @CuNa [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' AND a.[IsPaymentAccepted] = @IsPaymentAccepted );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaOnPaCount] 
	@Name [ntext], @IsPaymentAccepted [bit], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Partner_Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' AND a.[IsPaymentAccepted] = @IsPaymentAccepted )
END
GO

/** Services.Packages.CustomerUserEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByUsLo] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserLogin_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByUsLoPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserLogin_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnGetByUsLoCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserLogin_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByCu] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByCuPaged] 
	@Name [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Customer_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



/** Services.Packages.Purchase Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuGetByApKe] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuGetByApKePaged] 
	@Id [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[ApiKey_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuGetByCl] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Client_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuGetByClPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Client_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuGetByClCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Client_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



/** Services.Packages.PurchaseLine Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiGetByPuOr] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[PurchaseOrder_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuLiGetByPuOrPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[PurchaseOrder_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuLiGetByPuOrCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[PurchaseOrder_Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuLiGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuLiGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



/** Services.Packages.Security.ModelUser Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsGetByOw] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUs] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoUsGetByOwPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUs] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoUsGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUs] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Owner_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



/** Services.Packages.Security.ModelSession Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoSeGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoSe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[User_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoSeGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoSe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[User_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoSeGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoSe] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[User_Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



/** Services.Packages.Security.ModelUserRights Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoUsRiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaAnUs] 
	@Name [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaAnUsPaged] 
	@Name [ntext], @MoUsNa [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaAnUsCount] 
	@Name [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUsRi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[Name] LIKE @Name ESCAPE '\' )
END
GO

/** Services.Packages.Security.Securable Relations SPs **/


/** Services.Packages.Security.IPRegistered Relations SPs **/


/** Services.Packages.Security.IPSessionRegistration Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReGetByIP] 
	@IP [nvarchar](64)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeIPRe] as b
		ON a.[IP_IP] = b.[IP]
	WHERE (b.[IP] = @IP OR (@IP IS NULL AND b.[IP] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[IPSeReGetByIPPaged] 
	@IP [nvarchar](64),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeIPRe] as b
		ON a.[IP_IP] = b.[IP]
	WHERE (b.[IP] = @IP OR (@IP IS NULL AND b.[IP] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [IPSeReGetByIPCount] 
	@IP [nvarchar](64)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeIPRe] as b
		ON a.[IP_IP] = b.[IP]
	WHERE (b.[IP] = @IP OR (@IP IS NULL AND b.[IP] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IPSeReGetBySe] 
	@SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeMoSe] as b
		ON a.[Session_SessionToken] = b.[SessionToken]
	WHERE (b.[SessionToken] = @SessionToken OR (@SessionToken IS NULL AND b.[SessionToken] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[IPSeReGetBySePaged] 
	@SessionToken [nvarchar](384),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeMoSe] as b
		ON a.[Session_SessionToken] = b.[SessionToken]
	WHERE (b.[SessionToken] = @SessionToken OR (@SessionToken IS NULL AND b.[SessionToken] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [IPSeReGetBySeCount] 
	@SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeIPSeRe] as a LEFT OUTER JOIN [dbo].[SePaSeMoSe] as b
		ON a.[Session_SessionToken] = b.[SessionToken]
	WHERE (b.[SessionToken] = @SessionToken OR (@SessionToken IS NULL AND b.[SessionToken] IS NULL));
END
GO



/** Services.Packages.Security.PackageAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PaAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByPa] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByPaPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PaAcCoLiGetByPaCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGeACLs] 
	@UserName [ntext], @PaId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PaId OR (@PaId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGeACLsPaged] 
	@UserName [ntext], @PaId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PaId OR (@PaId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGeACLsCount] 
	@UserName [ntext], @PaId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPa] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PaId OR (@PaId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.PackageAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PaAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGeEn] 
	@Descriptor [ntext], @PaAcCoLiUsNa [nvarchar](128), @PaAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGeEnPaged] 
	@Descriptor [ntext], @PaAcCoLiUsNa [nvarchar](128), @PaAcCoLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGeEnCount] 
	@Descriptor [ntext], @PaAcCoLiUsNa [nvarchar](128), @PaAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePaAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.ApiKeyAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApKeAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByApKe] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByApKePaged] 
	@Id [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApKeAcCoLiGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGeACLs] 
	@UserName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGeACLsPaged] 
	@UserName [ntext], @ApKeId [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGeACLsCount] 
	@UserName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaApKe] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApKeId OR (@ApKeId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.ApiKeyAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApKeAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGeEn] 
	@Descriptor [ntext], @ApKeAcCoLiUsNa [nvarchar](128), @ApKeAcCoLiId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGeEnPaged] 
	@Descriptor [ntext], @ApKeAcCoLiUsNa [nvarchar](128), @ApKeAcCoLiId [uniqueidentifier],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGeEnCount] 
	@Descriptor [ntext], @ApKeAcCoLiUsNa [nvarchar](128), @ApKeAcCoLiId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeApKeAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByApEx] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByApExPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExAcCoLiGetByApExCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGeACLs] 
	@UserName [ntext], @ApExId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApExId OR (@ApExId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGeACLsPaged] 
	@UserName [ntext], @ApExId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApExId OR (@ApExId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGeACLsCount] 
	@UserName [ntext], @ApExId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaLoApEx] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @ApExId OR (@ApExId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [ApExAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGeEn] 
	@Descriptor [ntext], @ApExAcCoLiUsNa [nvarchar](128), @ApExAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGeEnPaged] 
	@Descriptor [ntext], @ApExAcCoLiUsNa [nvarchar](128), @ApExAcCoLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGeEnCount] 
	@Descriptor [ntext], @ApExAcCoLiUsNa [nvarchar](128), @ApExAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaLoSeApExAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.CustomerAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByCu] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByCuPaged] 
	@Name [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuAcCoLiGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGeACLs] 
	@UserName [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGeACLsPaged] 
	@UserName [ntext], @CuNa [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGeACLsCount] 
	@UserName [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCu] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @CuNa OR (@CuNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.CustomerAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Name [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGeEn] 
	@Descriptor [ntext], @CuAcCoLiUsNa [nvarchar](128), @CuAcCoLiNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGeEnPaged] 
	@Descriptor [ntext], @CuAcCoLiUsNa [nvarchar](128), @CuAcCoLiNa [nvarchar](256),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGeEnCount] 
	@Descriptor [ntext], @CuAcCoLiUsNa [nvarchar](128), @CuAcCoLiNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEn] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEnPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnAcCoLiGetByCuUsEnCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGeACLs] 
	@UserName [ntext], @CuUsEnId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGeACLsPaged] 
	@UserName [ntext], @CuUsEnId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGeACLsCount] 
	@UserName [ntext], @CuUsEnId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaCuUsEn] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [CuUsEnAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGeEn] 
	@Descriptor [ntext], @CuUsEnAcCoLiUsNa [nvarchar](128), @CuUsEnAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGeEnPaged] 
	@Descriptor [ntext], @CuUsEnAcCoLiUsNa [nvarchar](128), @CuUsEnAcCoLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGeEnCount] 
	@Descriptor [ntext], @CuUsEnAcCoLiUsNa [nvarchar](128), @CuUsEnAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeCuUsEnAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.PurchaseAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByPu] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByPuPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuAcCoLiGetByPuCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGeACLs] 
	@UserName [ntext], @PuId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuId OR (@PuId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGeACLsPaged] 
	@UserName [ntext], @PuId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuId OR (@PuId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGeACLsCount] 
	@UserName [ntext], @PuId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPu] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuId OR (@PuId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.PurchaseAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGeEn] 
	@Descriptor [ntext], @PuAcCoLiUsNa [nvarchar](128), @PuAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGeEnPaged] 
	@Descriptor [ntext], @PuAcCoLiUsNa [nvarchar](128), @PuAcCoLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGeEnCount] 
	@Descriptor [ntext], @PuAcCoLiUsNa [nvarchar](128), @PuAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.PurchaseLineAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuLiAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByPuLi] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByPuLiPaged] 
	@Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuLiAcCoLiGetByPuLiCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGeACLs] 
	@UserName [ntext], @PuLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuLiId OR (@PuLiId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGeACLsPaged] 
	@UserName [ntext], @PuLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuLiId OR (@PuLiId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGeACLsCount] 
	@UserName [ntext], @PuLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaPuLi] as b
		ON a.[Id] = b.[Id]
	WHERE (b.[Id] = @PuLiId OR (@PuLiId IS NULL AND b.[Id] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.PurchaseLineAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Id [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [PuLiAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @Id OR (@Id IS NULL AND b.[Id] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGeEn] 
	@Descriptor [ntext], @PuLiAcCoLiUsNa [nvarchar](128), @PuLiAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGeEnPaged] 
	@Descriptor [ntext], @PuLiAcCoLiUsNa [nvarchar](128), @PuLiAcCoLiId [int],
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGeEnCount] 
	@Descriptor [ntext], @PuLiAcCoLiUsNa [nvarchar](128), @PuLiAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSePuLiAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Id] = b.[Id]
	WHERE (b.[UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND b.[Id] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Services.Packages.Security.Security.ModelUserAccessControlList Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoUsAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByMoUs] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByMoUsPaged] 
	@Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoUsAcCoLiGetByMoUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[Name] = b.[Name]
	WHERE (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGeACLs] 
	@UserName [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGeACLsPaged] 
	@UserName [ntext], @MoUsNa [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGeACLsCount] 
	@UserName [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi] as a LEFT OUTER JOIN [dbo].[SePaSeMoUs] as b
		ON a.[UserName] = b.[Name]
	WHERE (b.[Name] = @MoUsNa OR (@MoUsNa IS NULL AND b.[Name] IS NULL)) AND (a.[UserName] LIKE @UserName ESCAPE '\' )
END
GO

/** Services.Packages.Security.Security.ModelUserAccessControlEntry Relations SPs **/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGetByACL] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGetByACLPaged] 
	@UserName [nvarchar](128), @Name [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [MoUsAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @UserName OR (@UserName IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @Name OR (@Name IS NULL AND b.[Name] IS NULL));
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGeEn] 
	@Descriptor [ntext], @MoUsAcCoLiUsNa [nvarchar](128), @MoUsAcCoLiNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGeEnPaged] 
	@Descriptor [ntext], @MoUsAcCoLiUsNa [nvarchar](128), @MoUsAcCoLiNa [nvarchar](128),
	@PagingStart [bigint],
	@PagingCount [bigint]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    SELECT *
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' );
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGeEnCount] 
	@Descriptor [ntext], @MoUsAcCoLiUsNa [nvarchar](128), @MoUsAcCoLiNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoEn] as a LEFT OUTER JOIN [dbo].[SePaSeSeMoUsAcCoLi] as b
		ON a.[UserName] = b.[UserName] AND a.[Name] = b.[Name]
	WHERE (b.[UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND b.[UserName] IS NULL)) AND (b.[Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND b.[Name] IS NULL)) AND (a.[Descriptor] LIKE @Descriptor ESCAPE '\' )
END
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions Relations SPs **/


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup Relations SPs **/


/** Services.Packages.CustomerUndoRedo Relations SPs **/


/** Services.Packages.PurchaseUndoRedo Relations SPs **/


/** Services.Packages.PurchaseLineUndoRedo Relations SPs **/


