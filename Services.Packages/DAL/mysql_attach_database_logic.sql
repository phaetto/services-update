/** Services.Packages.Package CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PaRead` 
	(_Id int)
BEGIN
    SELECT *
	FROM `SePaPa`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaDelete` 
	(_Id int)
BEGIN
	DELETE FROM `SePaPa`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaCreate` 
	(_PackageName varchar(1024), _VersionLabel varchar(1024), _UploadDate datetime, _ApiKey_Id char(36), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaPa`
	(`PackageName`, `VersionLabel`, `UploadDate`, `ApiKey_Id`, `Owner_Name`)
	VALUES (_PackageName, _VersionLabel, _UploadDate, _ApiKey_Id, _Owner_Name);
	
	SELECT * FROM `SePaPa` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PaUpdate` 
	(_Id int, _PackageName varchar(1024), _VersionLabel varchar(1024), _UploadDate datetime, _ApiKeyHasChanged bit, _ApiKey_Id char(36), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaPa`
	SET `PackageName` = _PackageName, `VersionLabel` = _VersionLabel, `UploadDate` = _UploadDate
	WHERE ((`Id` = _Id));
	
	IF (CAST(_ApiKeyHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPa`
		SET `ApiKey_Id` = _ApiKey_Id
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPa`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `PaSeByPaNa` 
	(_PackageName text)
BEGIN
    SELECT *
	FROM `SePaPa`
	WHERE `PackageName` LIKE _PackageName 
	ORDER BY `UploadDate` DESC;
END $$
GO

CREATE PROCEDURE `PaSeByPaNaPaged` 
	(_PackageName text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPa`
	WHERE `PackageName` LIKE _PackageName 
	ORDER BY `UploadDate` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaSeByPaNaCount` 
	(_PackageName text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPa`
	WHERE `PackageName` LIKE _PackageName ;
END $$
DELIMITER ;
GO


/** Services.Packages.LocalPackage CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `LoPaRead` 
	(_PackageName varchar(1024))
BEGIN
    SELECT *
	FROM `SePaLoPa`
	WHERE (`PackageName` = _PackageName);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `LoPaDelete` 
	(_PackageName varchar(1024))
BEGIN
	DELETE FROM `SePaLoPa`
	WHERE ((`PackageName` = _PackageName));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `LoPaCreate` 
	(_PackageName varchar(1024), _Id int, _VersionLabel varchar(1024))
BEGIN
	INSERT INTO `SePaLoPa`
	(`PackageName`, `Id`, `VersionLabel`)
	VALUES (_PackageName, _Id, _VersionLabel);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `LoPaUpdate` 
	(_PackageName varchar(1024), _Id int, _VersionLabel varchar(1024))
BEGIN
	
	
	UPDATE `SePaLoPa`
	SET `PackageName` = _PackageName, `Id` = _Id, `VersionLabel` = _VersionLabel
	WHERE ((`PackageName` = _PackageName));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `LoPaSeByPaNa` 
	(_PackageName text)
BEGIN
    SELECT *
	FROM `SePaLoPa`
	WHERE `PackageName` LIKE _PackageName 
	;
END $$
GO

CREATE PROCEDURE `LoPaSeByPaNaPaged` 
	(_PackageName text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoPa`
	WHERE `PackageName` LIKE _PackageName 
	
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `LoPaSeByPaNaCount` 
	(_PackageName text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoPa`
	WHERE `PackageName` LIKE _PackageName ;
END $$
DELIMITER ;
GO


/** Services.Packages.ApiKey CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApKeRead` 
	(_Id char(36))
BEGIN
    SELECT *
	FROM `SePaApKe`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeDelete` 
	(_Id char(36))
BEGIN
	DELETE FROM `SePaApKe`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeCreate` 
	(_Id char(36), _CompanyInfo varchar(1024), _IssueDate datetime, _FromDate datetime, _ToDate datetime, _IsTest bit, _Customer_Name varchar(256), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaApKe`
	(`Id`, `CompanyInfo`, `IssueDate`, `FromDate`, `ToDate`, `IsTest`, `Customer_Name`, `Owner_Name`)
	VALUES (_Id, _CompanyInfo, _IssueDate, _FromDate, _ToDate, _IsTest, _Customer_Name, _Owner_Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApKeUpdate` 
	(_Id char(36), _CompanyInfo varchar(1024), _IssueDate datetime, _FromDate datetime, _ToDate datetime, _IsTest bit, _CustomerHasChanged bit, _Customer_Name varchar(256), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaApKe`
	SET `Id` = _Id, `CompanyInfo` = _CompanyInfo, `IssueDate` = _IssueDate, `FromDate` = _FromDate, `ToDate` = _ToDate, `IsTest` = _IsTest
	WHERE ((`Id` = _Id));
	
	IF (CAST(_CustomerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaApKe`
		SET `Customer_Name` = _Customer_Name
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaApKe`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `ApKeSeByCoIn` 
	(_CompanyInfo text)
BEGIN
    SELECT *
	FROM `SePaApKe`
	WHERE `CompanyInfo` LIKE _CompanyInfo 
	ORDER BY `IssueDate` DESC;
END $$
GO

CREATE PROCEDURE `ApKeSeByCoInPaged` 
	(_CompanyInfo text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaApKe`
	WHERE `CompanyInfo` LIKE _CompanyInfo 
	ORDER BY `IssueDate` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeSeByCoInCount` 
	(_CompanyInfo text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaApKe`
	WHERE `CompanyInfo` LIKE _CompanyInfo ;
END $$
DELIMITER ;
GO


/** Services.Packages.Log.ApplicationException CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApExRead` 
	(_Id int)
BEGIN
    SELECT *
	FROM `SePaLoApEx`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExDelete` 
	(_Id int)
BEGIN
	DELETE FROM `SePaLoApEx`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExCreate` 
	(_Message varchar(512), _Source varchar(512), _StackTrace text, _Page text, _OnDate datetime, _IsSolved bit, _ApiKey_Id char(36), _ParentException_Id int, _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaLoApEx`
	(`Message`, `Source`, `StackTrace`, `Page`, `OnDate`, `IsSolved`, `ApiKey_Id`, `ParentException_Id`, `Owner_Name`)
	VALUES (_Message, _Source, _StackTrace, _Page, _OnDate, _IsSolved, _ApiKey_Id, _ParentException_Id, _Owner_Name);
	
	SELECT * FROM `SePaLoApEx` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExUpdate` 
	(_Id int, _Message varchar(512), _Source varchar(512), _StackTrace text, _Page text, _OnDate datetime, _IsSolved bit, _ApiKeyHasChanged bit, _ApiKey_Id char(36), _ParentExceptionHasChanged bit, _ParentException_Id int, _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaLoApEx`
	SET `Message` = _Message, `Source` = _Source, `StackTrace` = _StackTrace, `Page` = _Page, `OnDate` = _OnDate, `IsSolved` = _IsSolved
	WHERE ((`Id` = _Id));
	
	IF (CAST(_ApiKeyHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaLoApEx`
		SET `ApiKey_Id` = _ApiKey_Id
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_ParentExceptionHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaLoApEx`
		SET `ParentException_Id` = _ParentException_Id
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaLoApEx`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `ApExSeByNa` 
	(_Message text)
BEGIN
    SELECT *
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message 
	ORDER BY `OnDate` DESC;
END $$
GO

CREATE PROCEDURE `ApExSeByNaPaged` 
	(_Message text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message 
	ORDER BY `OnDate` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExSeByNaCount` 
	(_Message text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExSeByNaSo` 
	(_Message text, _IsSolved bit)
BEGIN
    SELECT *
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message AND `IsSolved` = _IsSolved 
	ORDER BY `OnDate` DESC;
END $$
GO

CREATE PROCEDURE `ApExSeByNaSoPaged` 
	(_Message text, _IsSolved bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message AND `IsSolved` = _IsSolved 
	ORDER BY `OnDate` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExSeByNaSoCount` 
	(_Message text, _IsSolved bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx`
	WHERE `Message` LIKE _Message AND `IsSolved` = _IsSolved ;
END $$
DELIMITER ;
GO


/** Services.Packages.Customer CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuRead` 
	(_Name varchar(256))
BEGIN
    SELECT *
	FROM `SePaCu`
	WHERE (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuDelete` 
	(_Name varchar(256))
BEGIN
	DELETE FROM `SePaCu`
	WHERE ((`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuCreate` 
	(_Name varchar(256), _FullNameOfResponsible varchar(512), _EmailOfResponsible varchar(256), _Description varchar(256), _IsPartner bit, _CompanyName varchar(256), _VATNo varchar(256), _Phone varchar(128), _Address varchar(256), _PostCode varchar(64), _City varchar(128), _Country varchar(256), _InvoiceAddress varchar(256), _InvoicePostCode varchar(64), _InvoiceCity varchar(128), _InvoiceCountry varchar(256), _IsPaymentAccepted bit, _LastPaymentDate datetime, _Partner_Name varchar(256), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaCu`
	(`Name`, `FullNameOfResponsible`, `EmailOfResponsible`, `Description`, `IsPartner`, `CompanyName`, `VATNo`, `Phone`, `Address`, `PostCode`, `City`, `Country`, `InvoiceAddress`, `InvoicePostCode`, `InvoiceCity`, `InvoiceCountry`, `IsPaymentAccepted`, `LastPaymentDate`, `Partner_Name`, `Owner_Name`)
	VALUES (_Name, _FullNameOfResponsible, _EmailOfResponsible, _Description, _IsPartner, _CompanyName, _VATNo, _Phone, _Address, _PostCode, _City, _Country, _InvoiceAddress, _InvoicePostCode, _InvoiceCity, _InvoiceCountry, _IsPaymentAccepted, _LastPaymentDate, _Partner_Name, _Owner_Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUpdate` 
	(_Name varchar(256), _FullNameOfResponsible varchar(512), _EmailOfResponsible varchar(256), _Description varchar(256), _IsPartner bit, _CompanyName varchar(256), _VATNo varchar(256), _Phone varchar(128), _Address varchar(256), _PostCode varchar(64), _City varchar(128), _Country varchar(256), _InvoiceAddress varchar(256), _InvoicePostCode varchar(64), _InvoiceCity varchar(128), _InvoiceCountry varchar(256), _IsPaymentAccepted bit, _LastPaymentDate datetime, _PartnerHasChanged bit, _Partner_Name varchar(256), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaCu`
	SET `Name` = _Name, `FullNameOfResponsible` = _FullNameOfResponsible, `EmailOfResponsible` = _EmailOfResponsible, `Description` = _Description, `IsPartner` = _IsPartner, `CompanyName` = _CompanyName, `VATNo` = _VATNo, `Phone` = _Phone, `Address` = _Address, `PostCode` = _PostCode, `City` = _City, `Country` = _Country, `InvoiceAddress` = _InvoiceAddress, `InvoicePostCode` = _InvoicePostCode, `InvoiceCity` = _InvoiceCity, `InvoiceCountry` = _InvoiceCountry, `IsPaymentAccepted` = _IsPaymentAccepted, `LastPaymentDate` = _LastPaymentDate
	WHERE ((`Name` = _Name));
	
	IF (CAST(_PartnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaCu`
		SET `Partner_Name` = _Partner_Name
		WHERE ((`Name` = _Name));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaCu`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Name` = _Name));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `CuSeByNaAnPa` 
	(_Name text, _IsPartner bit)
BEGIN
    SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPartner` LIKE _IsPartner 
	ORDER BY `Name` ASC;
END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaPaged` 
	(_Name text, _IsPartner bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPartner` LIKE _IsPartner 
	ORDER BY `Name` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaCount` 
	(_Name text, _IsPartner bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPartner` LIKE _IsPartner ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuSeByNa` 
	(_Name text)
BEGIN
    SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC;
END $$
GO

CREATE PROCEDURE `CuSeByNaPaged` 
	(_Name text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuSeByNaCount` 
	(_Name text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCu`
	WHERE `Name` LIKE _Name ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuSeByNaAnPaPa` 
	(_Name text, _IsPaymentAccepted bit)
BEGIN
    SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPaymentAccepted` = _IsPaymentAccepted 
	ORDER BY `LastPaymentDate` ASC;
END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaPaPaged` 
	(_Name text, _IsPaymentAccepted bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPaymentAccepted` = _IsPaymentAccepted 
	ORDER BY `LastPaymentDate` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaPaCount` 
	(_Name text, _IsPaymentAccepted bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCu`
	WHERE `Name` LIKE _Name AND `IsPaymentAccepted` = _IsPaymentAccepted ;
END $$
DELIMITER ;
GO


/** Services.Packages.CustomerUserEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuUsEnRead` 
	(_Id int)
BEGIN
    SELECT *
	FROM `SePaCuUsEn`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnDelete` 
	(_Id int)
BEGIN
	DELETE FROM `SePaCuUsEn`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnCreate` 
	(_UserLogin_Name varchar(128), _Customer_Name varchar(256), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaCuUsEn`
	(`UserLogin_Name`, `Customer_Name`, `Owner_Name`)
	VALUES (_UserLogin_Name, _Customer_Name, _Owner_Name);
	
	SELECT * FROM `SePaCuUsEn` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnUpdate` 
	(_Id int, _UserLoginHasChanged bit, _UserLogin_Name varchar(128), _CustomerHasChanged bit, _Customer_Name varchar(256), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	IF (CAST(_UserLoginHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaCuUsEn`
		SET `UserLogin_Name` = _UserLogin_Name
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_CustomerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaCuUsEn`
		SET `Customer_Name` = _Customer_Name
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaCuUsEn`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



/** Services.Packages.Purchase CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuRead` 
	(_Id int)
BEGIN
    SELECT *
	FROM `SePaPu`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuDelete` 
	(_Id int)
BEGIN
	DELETE FROM `SePaPu`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuCreate` 
	(_CreationDate datetime, _ApiKey_Id char(36), _Client_Name varchar(128), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaPu`
	(`CreationDate`, `ApiKey_Id`, `Client_Name`, `Owner_Name`)
	VALUES (_CreationDate, _ApiKey_Id, _Client_Name, _Owner_Name);
	
	SELECT * FROM `SePaPu` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuUpdate` 
	(_Id int, _CreationDate datetime, _ApiKeyHasChanged bit, _ApiKey_Id char(36), _ClientHasChanged bit, _Client_Name varchar(128), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaPu`
	SET `CreationDate` = _CreationDate
	WHERE ((`Id` = _Id));
	
	IF (CAST(_ApiKeyHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPu`
		SET `ApiKey_Id` = _ApiKey_Id
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_ClientHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPu`
		SET `Client_Name` = _Client_Name
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPu`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `PuGeAl` 
	(_dummy text)
BEGIN
    SELECT *
	FROM `SePaPu`
	
	;
END $$
GO

CREATE PROCEDURE `PuGeAlPaged` 
	(_dummy text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPu`
	
	
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuGeAlCount` 
	(_dummy text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPu`
	;
END $$
DELIMITER ;
GO


/** Services.Packages.PurchaseLine CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuLiRead` 
	(_Id int)
BEGIN
    SELECT *
	FROM `SePaPuLi`
	WHERE (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiDelete` 
	(_Id int)
BEGIN
	DELETE FROM `SePaPuLi`
	WHERE ((`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiCreate` 
	(_ProductKey varchar(256), _ProductDescription text, _PricePurchased double, _RecurrentFeePurchased double, _IsPaid bit, _PurchaseOrder_Id int, _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaPuLi`
	(`ProductKey`, `ProductDescription`, `PricePurchased`, `RecurrentFeePurchased`, `IsPaid`, `PurchaseOrder_Id`, `Owner_Name`)
	VALUES (_ProductKey, _ProductDescription, _PricePurchased, _RecurrentFeePurchased, _IsPaid, _PurchaseOrder_Id, _Owner_Name);
	
	SELECT * FROM `SePaPuLi` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiUpdate` 
	(_Id int, _ProductKey varchar(256), _ProductDescription text, _PricePurchased double, _RecurrentFeePurchased double, _IsPaid bit, _PurchaseOrderHasChanged bit, _PurchaseOrder_Id int, _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaPuLi`
	SET `ProductKey` = _ProductKey, `ProductDescription` = _ProductDescription, `PricePurchased` = _PricePurchased, `RecurrentFeePurchased` = _RecurrentFeePurchased, `IsPaid` = _IsPaid
	WHERE ((`Id` = _Id));
	
	IF (CAST(_PurchaseOrderHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPuLi`
		SET `PurchaseOrder_Id` = _PurchaseOrder_Id
		WHERE ((`Id` = _Id));
	END	IF;
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaPuLi`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Id` = _Id));
	END	IF;
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ModelUser CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `MoUsRead` 
	(_Name varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeMoUs`
	WHERE (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsDelete` 
	(_Name varchar(128))
BEGIN
	DELETE FROM `SePaSeMoUs`
	WHERE ((`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsCreate` 
	(_Name varchar(128), _PasswordHash varchar(256), _Email varchar(256), _Enabled bit, _SecretQuestion varchar(512), _SecretAnswer varchar(512), _Owner_Name varchar(128))
BEGIN
	INSERT INTO `SePaSeMoUs`
	(`Name`, `PasswordHash`, `Email`, `Enabled`, `SecretQuestion`, `SecretAnswer`, `Owner_Name`)
	VALUES (_Name, _PasswordHash, _Email, _Enabled, _SecretQuestion, _SecretAnswer, _Owner_Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsUpdate` 
	(_Name varchar(128), _PasswordHash varchar(256), _Email varchar(256), _Enabled bit, _SecretQuestion varchar(512), _SecretAnswer varchar(512), _OwnerHasChanged bit, _Owner_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaSeMoUs`
	SET `Name` = _Name, `PasswordHash` = _PasswordHash, `Email` = _Email, `Enabled` = _Enabled, `SecretQuestion` = _SecretQuestion, `SecretAnswer` = _SecretAnswer
	WHERE ((`Name` = _Name));
	
	IF (CAST(_OwnerHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaSeMoUs`
		SET `Owner_Name` = _Owner_Name
		WHERE ((`Name` = _Name));
	END	IF;
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `MoUsSeByNa` 
	(_Name text)
BEGIN
    SELECT *
	FROM `SePaSeMoUs`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC;
END $$
GO

CREATE PROCEDURE `MoUsSeByNaPaged` 
	(_Name text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUs`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsSeByNaCount` 
	(_Name text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUs`
	WHERE `Name` LIKE _Name ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsSeByEm` 
	(_Email text)
BEGIN
    SELECT *
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email 
	ORDER BY `Email` ASC;
END $$
GO

CREATE PROCEDURE `MoUsSeByEmPaged` 
	(_Email text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email 
	ORDER BY `Email` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsSeByEmCount` 
	(_Email text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsSeEnByNaAnEm` 
	(_Name text, _Email text, _Enabled bit)
BEGIN
    SELECT *
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email AND `Name` LIKE _Name AND `Enabled` = _Enabled 
	ORDER BY `Name` ASC;
END $$
GO

CREATE PROCEDURE `MoUsSeEnByNaAnEmPaged` 
	(_Name text, _Email text, _Enabled bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email AND `Name` LIKE _Name AND `Enabled` = _Enabled 
	ORDER BY `Name` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsSeEnByNaAnEmCount` 
	(_Name text, _Email text, _Enabled bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUs`
	WHERE `Email` LIKE _Email AND `Name` LIKE _Name AND `Enabled` = _Enabled ;
END $$
DELIMITER ;
GO


/** Services.Packages.Security.ModelSession CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `MoSeRead` 
	(_SessionToken varchar(384))
BEGIN
    SELECT *
	FROM `SePaSeMoSe`
	WHERE (`SessionToken` = _SessionToken);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoSeDelete` 
	(_SessionToken varchar(384))
BEGIN
	DELETE FROM `SePaSeMoSe`
	WHERE ((`SessionToken` = _SessionToken));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoSeCreate` 
	(_SessionToken varchar(384), _TimeIssued datetime, _TimeIssuedFor int, _User_Name varchar(128))
BEGIN
	INSERT INTO `SePaSeMoSe`
	(`SessionToken`, `TimeIssued`, `TimeIssuedFor`, `User_Name`)
	VALUES (_SessionToken, _TimeIssued, _TimeIssuedFor, _User_Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoSeUpdate` 
	(_SessionToken varchar(384), _TimeIssued datetime, _TimeIssuedFor int, _UserHasChanged bit, _User_Name varchar(128))
BEGIN
	
	
	UPDATE `SePaSeMoSe`
	SET `SessionToken` = _SessionToken, `TimeIssued` = _TimeIssued, `TimeIssuedFor` = _TimeIssuedFor
	WHERE ((`SessionToken` = _SessionToken));
	
	IF (CAST(_UserHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaSeMoSe`
		SET `User_Name` = _User_Name
		WHERE ((`SessionToken` = _SessionToken));
	END	IF;
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ModelUserRights CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `MoUsRiRead` 
	(_Name varchar(128), _UserName varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeMoUsRi`
	WHERE (`Name` = _Name) AND (`UserName` = _UserName);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsRiDelete` 
	(_Name varchar(128), _UserName varchar(128))
BEGIN
	DELETE FROM `SePaSeMoUsRi`
	WHERE ((`Name` = _Name) AND (`UserName` = _UserName));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsRiCreate` 
	(_Name varchar(128), _UserName varchar(128))
BEGIN
	INSERT INTO `SePaSeMoUsRi`
	(`Name`, `UserName`)
	VALUES (_Name, _UserName);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsRiUpdate` 
	(_Name varchar(128), _UserName varchar(128), _UserHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeMoUsRi`
	SET `Name` = _Name, `UserName` = _UserName
	WHERE ((`Name` = _Name) AND (`UserName` = _UserName));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `MoUsRiGeByNa` 
	(_Name text)
BEGIN
    SELECT *
	FROM `SePaSeMoUsRi`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC;
END $$
GO

CREATE PROCEDURE `MoUsRiGeByNaPaged` 
	(_Name text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUsRi`
	WHERE `Name` LIKE _Name 
	ORDER BY `Name` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsRiGeByNaCount` 
	(_Name text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUsRi`
	WHERE `Name` LIKE _Name ;
END $$
DELIMITER ;
GO


/** Services.Packages.Security.Securable CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `SeRead` 
	(_Type varchar(256))
BEGIN
    SELECT *
	FROM `SePaSeSe`
	WHERE (`Type` = _Type);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `SeDelete` 
	(_Type varchar(256))
BEGIN
	DELETE FROM `SePaSeSe`
	WHERE ((`Type` = _Type));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `SeCreate` 
	(_Type varchar(256), _Enabled bit, _TimeSessionIsIssued int, _AllowAnonymousAccess bit, _GenerationPasswordLength int, _IPsMustBePreregistered bit, _AllowedIPFailures int, _IPFailureTimeDenying int, _DisableIPFiltering bit, _SessionsPerIPAllowed int)
BEGIN
	INSERT INTO `SePaSeSe`
	(`Type`, `Enabled`, `TimeSessionIsIssued`, `AllowAnonymousAccess`, `GenerationPasswordLength`, `IPsMustBePreregistered`, `AllowedIPFailures`, `IPFailureTimeDenying`, `DisableIPFiltering`, `SessionsPerIPAllowed`)
	VALUES (_Type, _Enabled, _TimeSessionIsIssued, _AllowAnonymousAccess, _GenerationPasswordLength, _IPsMustBePreregistered, _AllowedIPFailures, _IPFailureTimeDenying, _DisableIPFiltering, _SessionsPerIPAllowed);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `SeUpdate` 
	(_Type varchar(256), _Enabled bit, _TimeSessionIsIssued int, _AllowAnonymousAccess bit, _GenerationPasswordLength int, _IPsMustBePreregistered bit, _AllowedIPFailures int, _IPFailureTimeDenying int, _DisableIPFiltering bit, _SessionsPerIPAllowed int)
BEGIN
	
	
	UPDATE `SePaSeSe`
	SET `Type` = _Type, `Enabled` = _Enabled, `TimeSessionIsIssued` = _TimeSessionIsIssued, `AllowAnonymousAccess` = _AllowAnonymousAccess, `GenerationPasswordLength` = _GenerationPasswordLength, `IPsMustBePreregistered` = _IPsMustBePreregistered, `AllowedIPFailures` = _AllowedIPFailures, `IPFailureTimeDenying` = _IPFailureTimeDenying, `DisableIPFiltering` = _DisableIPFiltering, `SessionsPerIPAllowed` = _SessionsPerIPAllowed
	WHERE ((`Type` = _Type));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.IPRegistered CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `IPReRead` 
	(_IP varchar(64))
BEGIN
    SELECT *
	FROM `SePaSeIPRe`
	WHERE (`IP` = _IP);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `IPReDelete` 
	(_IP varchar(64))
BEGIN
	DELETE FROM `SePaSeIPRe`
	WHERE ((`IP` = _IP));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `IPReCreate` 
	(_IP varchar(64), _Allowed bit, _Failures int, _DenialIssuedUntilTime datetime)
BEGIN
	INSERT INTO `SePaSeIPRe`
	(`IP`, `Allowed`, `Failures`, `DenialIssuedUntilTime`)
	VALUES (_IP, _Allowed, _Failures, _DenialIssuedUntilTime);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `IPReUpdate` 
	(_IP varchar(64), _Allowed bit, _Failures int, _DenialIssuedUntilTime datetime)
BEGIN
	
	
	UPDATE `SePaSeIPRe`
	SET `IP` = _IP, `Allowed` = _Allowed, `Failures` = _Failures, `DenialIssuedUntilTime` = _DenialIssuedUntilTime
	WHERE ((`IP` = _IP));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.IPSessionRegistration CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `IPSeReRead` 
	(_HostName varchar(128), _UserAgent varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeIPSeRe`
	WHERE (`HostName` = _HostName) AND (`UserAgent` = _UserAgent);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `IPSeReDelete` 
	(_HostName varchar(128), _UserAgent varchar(128))
BEGIN
	DELETE FROM `SePaSeIPSeRe`
	WHERE ((`HostName` = _HostName) AND (`UserAgent` = _UserAgent));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `IPSeReCreate` 
	(_HostName varchar(128), _UserAgent varchar(128), _IP_IP varchar(64), _Session_SessionToken varchar(384))
BEGIN
	INSERT INTO `SePaSeIPSeRe`
	(`HostName`, `UserAgent`, `IP_IP`, `Session_SessionToken`)
	VALUES (_HostName, _UserAgent, _IP_IP, _Session_SessionToken);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `IPSeReUpdate` 
	(_HostName varchar(128), _UserAgent varchar(128), _IPHasChanged bit, _IP_IP varchar(64), _SessionHasChanged bit, _Session_SessionToken varchar(384))
BEGIN
	
	
	UPDATE `SePaSeIPSeRe`
	SET `HostName` = _HostName, `UserAgent` = _UserAgent
	WHERE ((`HostName` = _HostName) AND (`UserAgent` = _UserAgent));
	
	IF (CAST(_IPHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaSeIPSeRe`
		SET `IP_IP` = _IP_IP
		WHERE ((`HostName` = _HostName) AND (`UserAgent` = _UserAgent));
	END	IF;
	
	IF (CAST(_SessionHasChanged AS UNSIGNED) = 1) THEN
		UPDATE `SePaSeIPSeRe`
		SET `Session_SessionToken` = _Session_SessionToken
		WHERE ((`HostName` = _HostName) AND (`UserAgent` = _UserAgent));
	END	IF;
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PackageAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PaAcCoLiRead` 
	(_UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePaAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaAcCoLiDelete` 
	(_UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePaAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaAcCoLiCreate` 
	(_UserName varchar(128), _Id int)
BEGIN
	INSERT INTO `SePaSePaAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PaAcCoLiUpdate` 
	(_UserName varchar(128), _Id int, _UserHasChanged bit, _PackageHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePaAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PackageAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PaAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePaAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePaAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PaAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int)
BEGIN
	INSERT INTO `SePaSePaAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PaAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int, _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePaAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ApiKeyAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApKeAcCoLiRead` 
	(_UserName varchar(128), _Id char(36))
BEGIN
    SELECT *
	FROM `SePaSeApKeAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeAcCoLiDelete` 
	(_UserName varchar(128), _Id char(36))
BEGIN
	DELETE FROM `SePaSeApKeAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeAcCoLiCreate` 
	(_UserName varchar(128), _Id char(36))
BEGIN
	INSERT INTO `SePaSeApKeAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApKeAcCoLiUpdate` 
	(_UserName varchar(128), _Id char(36), _UserHasChanged bit, _ApiKeyHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeApKeAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ApiKeyAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApKeAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id char(36))
BEGIN
    SELECT *
	FROM `SePaSeApKeAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id char(36))
BEGIN
	DELETE FROM `SePaSeApKeAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApKeAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id char(36))
BEGIN
	INSERT INTO `SePaSeApKeAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApKeAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id char(36), _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeApKeAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApExAcCoLiRead` 
	(_UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaLoSeApExAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExAcCoLiDelete` 
	(_UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaLoSeApExAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExAcCoLiCreate` 
	(_UserName varchar(128), _Id int)
BEGIN
	INSERT INTO `SePaLoSeApExAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExAcCoLiUpdate` 
	(_UserName varchar(128), _Id int, _UserHasChanged bit, _ApplicationExceptionHasChanged bit)
BEGIN
	
	
	UPDATE `SePaLoSeApExAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `ApExAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaLoSeApExAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaLoSeApExAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `ApExAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int)
BEGIN
	INSERT INTO `SePaLoSeApExAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int, _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaLoSeApExAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.CustomerAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuAcCoLiRead` 
	(_UserName varchar(128), _Name varchar(256))
BEGIN
    SELECT *
	FROM `SePaSeCuAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuAcCoLiDelete` 
	(_UserName varchar(128), _Name varchar(256))
BEGIN
	DELETE FROM `SePaSeCuAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuAcCoLiCreate` 
	(_UserName varchar(128), _Name varchar(256))
BEGIN
	INSERT INTO `SePaSeCuAcCoLi`
	(`UserName`, `Name`)
	VALUES (_UserName, _Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuAcCoLiUpdate` 
	(_UserName varchar(128), _Name varchar(256), _UserHasChanged bit, _CustomerHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeCuAcCoLi`
	SET `UserName` = _UserName, `Name` = _Name
	WHERE ((`UserName` = _UserName) AND (`Name` = _Name));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.CustomerAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Name varchar(256))
BEGIN
    SELECT *
	FROM `SePaSeCuAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Name varchar(256))
BEGIN
	DELETE FROM `SePaSeCuAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Name varchar(256))
BEGIN
	INSERT INTO `SePaSeCuAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Name`)
	VALUES (_Descriptor, _UserName, _Allow, _Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Name varchar(256), _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeCuAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Name` = _Name
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.CustomerUserEntryAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoLiRead` 
	(_UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSeCuUsEnAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoLiDelete` 
	(_UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSeCuUsEnAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoLiCreate` 
	(_UserName varchar(128), _Id int)
BEGIN
	INSERT INTO `SePaSeCuUsEnAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnAcCoLiUpdate` 
	(_UserName varchar(128), _Id int, _UserHasChanged bit, _CustomerUserEntryHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeCuUsEnAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.CustomerUserEntryAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSeCuUsEnAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSeCuUsEnAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int)
BEGIN
	INSERT INTO `SePaSeCuUsEnAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int, _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeCuUsEnAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PurchaseAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuAcCoLiRead` 
	(_UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePuAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuAcCoLiDelete` 
	(_UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePuAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuAcCoLiCreate` 
	(_UserName varchar(128), _Id int)
BEGIN
	INSERT INTO `SePaSePuAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuAcCoLiUpdate` 
	(_UserName varchar(128), _Id int, _UserHasChanged bit, _PurchaseHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePuAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PurchaseAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePuAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePuAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int)
BEGIN
	INSERT INTO `SePaSePuAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int, _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePuAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PurchaseLineAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuLiAcCoLiRead` 
	(_UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePuLiAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiAcCoLiDelete` 
	(_UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePuLiAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiAcCoLiCreate` 
	(_UserName varchar(128), _Id int)
BEGIN
	INSERT INTO `SePaSePuLiAcCoLi`
	(`UserName`, `Id`)
	VALUES (_UserName, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiAcCoLiUpdate` 
	(_UserName varchar(128), _Id int, _UserHasChanged bit, _PurchaseLineHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePuLiAcCoLi`
	SET `UserName` = _UserName, `Id` = _Id
	WHERE ((`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PurchaseLineAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuLiAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
    SELECT *
	FROM `SePaSePuLiAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Id int)
BEGIN
	DELETE FROM `SePaSePuLiAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int)
BEGIN
	INSERT INTO `SePaSePuLiAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Id`)
	VALUES (_Descriptor, _UserName, _Allow, _Id);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Id int, _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSePuLiAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Id` = _Id
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Id` = _Id));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.Security.ModelUserAccessControlList CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `MoUsAcCoLiRead` 
	(_UserName varchar(128), _Name varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeSeMoUsAcCoLi`
	WHERE (`UserName` = _UserName) AND (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsAcCoLiDelete` 
	(_UserName varchar(128), _Name varchar(128))
BEGIN
	DELETE FROM `SePaSeSeMoUsAcCoLi`
	WHERE ((`UserName` = _UserName) AND (`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsAcCoLiCreate` 
	(_UserName varchar(128), _Name varchar(128))
BEGIN
	INSERT INTO `SePaSeSeMoUsAcCoLi`
	(`UserName`, `Name`)
	VALUES (_UserName, _Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsAcCoLiUpdate` 
	(_UserName varchar(128), _Name varchar(128), _UserHasChanged bit, _ModelUserHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeSeMoUsAcCoLi`
	SET `UserName` = _UserName, `Name` = _Name
	WHERE ((`UserName` = _UserName) AND (`Name` = _Name));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.Security.ModelUserAccessControlEntry CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `MoUsAcCoEnRead` 
	(_Descriptor varchar(128), _UserName varchar(128), _Name varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeSeMoUsAcCoEn`
	WHERE (`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsAcCoEnDelete` 
	(_Descriptor varchar(128), _UserName varchar(128), _Name varchar(128))
BEGIN
	DELETE FROM `SePaSeSeMoUsAcCoEn`
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `MoUsAcCoEnCreate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Name varchar(128))
BEGIN
	INSERT INTO `SePaSeSeMoUsAcCoEn`
	(`Descriptor`, `UserName`, `Allow`, `Name`)
	VALUES (_Descriptor, _UserName, _Allow, _Name);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsAcCoEnUpdate` 
	(_Descriptor varchar(128), _UserName varchar(128), _Allow bit, _Name varchar(128), _ACLHasChanged bit)
BEGIN
	
	
	UPDATE `SePaSeSeMoUsAcCoEn`
	SET `Descriptor` = _Descriptor, `UserName` = _UserName, `Allow` = _Allow, `Name` = _Name
	WHERE ((`Descriptor` = _Descriptor) AND (`UserName` = _UserName) AND (`Name` = _Name));
END $$

DELIMITER ;
GO



/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `UnReOpRead` 
	(_EntityType varchar(128))
BEGIN
    SELECT *
	FROM `PlMoUnReSePaUnReOp`
	WHERE (`EntityType` = _EntityType);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `UnReOpDelete` 
	(_EntityType varchar(128))
BEGIN
	DELETE FROM `PlMoUnReSePaUnReOp`
	WHERE ((`EntityType` = _EntityType));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `UnReOpCreate` 
	(_EntityType varchar(128), _ItemsAllowed bigint, _IsEnabled bit)
BEGIN
	INSERT INTO `PlMoUnReSePaUnReOp`
	(`EntityType`, `ItemsAllowed`, `IsEnabled`)
	VALUES (_EntityType, _ItemsAllowed, _IsEnabled);
	
	
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `UnReOpUpdate` 
	(_EntityType varchar(128), _ItemsAllowed bigint, _IsEnabled bit)
BEGIN
	
	
	UPDATE `PlMoUnReSePaUnReOp`
	SET `EntityType` = _EntityType, `ItemsAllowed` = _ItemsAllowed, `IsEnabled` = _IsEnabled
	WHERE ((`EntityType` = _EntityType));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `UnReOpSeByEnTy` 
	(_EntityType text)
BEGIN
    SELECT *
	FROM `PlMoUnReSePaUnReOp`
	WHERE `EntityType` LIKE _EntityType 
	ORDER BY `EntityType` ASC;
END $$
GO

CREATE PROCEDURE `UnReOpSeByEnTyPaged` 
	(_EntityType text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `PlMoUnReSePaUnReOp`
	WHERE `EntityType` LIKE _EntityType 
	ORDER BY `EntityType` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `UnReOpSeByEnTyCount` 
	(_EntityType text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `PlMoUnReSePaUnReOp`
	WHERE `EntityType` LIKE _EntityType ;
END $$
DELIMITER ;
GO


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `UnReGrRead` 
	(_Id bigint, _UndoRedoEntityType varchar(128))
BEGIN
    SELECT *
	FROM `PlMoUnReSePaUnReGr`
	WHERE (`Id` = _Id) AND (`UndoRedoEntityType` = _UndoRedoEntityType);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `UnReGrDelete` 
	(_Id bigint, _UndoRedoEntityType varchar(128))
BEGIN
	DELETE FROM `PlMoUnReSePaUnReGr`
	WHERE ((`Id` = _Id) AND (`UndoRedoEntityType` = _UndoRedoEntityType));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `UnReGrCreate` 
	(_EntryName varchar(128), _UndoRedoEntityType varchar(128), _UndoRedoRecordId bigint)
BEGIN
	INSERT INTO `PlMoUnReSePaUnReGr`
	(`EntryName`, `UndoRedoEntityType`, `UndoRedoRecordId`)
	VALUES (_EntryName, _UndoRedoEntityType, _UndoRedoRecordId);
	
	SELECT * FROM `PlMoUnReSePaUnReGr` WHERE `Id` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `UnReGrUpdate` 
	(_Id bigint, _EntryName varchar(128), _UndoRedoEntityType varchar(128), _UndoRedoRecordId bigint)
BEGIN
	
	
	UPDATE `PlMoUnReSePaUnReGr`
	SET `EntryName` = _EntryName, `UndoRedoEntityType` = _UndoRedoEntityType, `UndoRedoRecordId` = _UndoRedoRecordId
	WHERE ((`Id` = _Id) AND (`UndoRedoEntityType` = _UndoRedoEntityType));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `UnReGrSeByEnTy` 
	(_UndoRedoEntityType text)
BEGIN
    SELECT *
	FROM `PlMoUnReSePaUnReGr`
	WHERE `UndoRedoEntityType` LIKE _UndoRedoEntityType 
	ORDER BY `UndoRedoEntityType` ASC;
END $$
GO

CREATE PROCEDURE `UnReGrSeByEnTyPaged` 
	(_UndoRedoEntityType text,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `PlMoUnReSePaUnReGr`
	WHERE `UndoRedoEntityType` LIKE _UndoRedoEntityType 
	ORDER BY `UndoRedoEntityType` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `UnReGrSeByEnTyCount` 
	(_UndoRedoEntityType text)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `PlMoUnReSePaUnReGr`
	WHERE `UndoRedoEntityType` LIKE _UndoRedoEntityType ;
END $$
DELIMITER ;
GO


/** Services.Packages.CustomerUndoRedo CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `CuUnReRead` 
	(_UndoRedoId bigint)
BEGIN
    SELECT *
	FROM `SePaCuUnRe`
	WHERE (`UndoRedoId` = _UndoRedoId);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUnReDelete` 
	(_UndoRedoId bigint)
BEGIN
	DELETE FROM `SePaCuUnRe`
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `CuUnReCreate` 
	(_IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Name varchar(256), _FullNameOfResponsible varchar(512), _EmailOfResponsible varchar(256), _Description varchar(256), _IsPartner bit, _CompanyName varchar(256), _VATNo varchar(256), _Phone varchar(128), _Address varchar(256), _PostCode varchar(64), _City varchar(128), _Country varchar(256), _InvoiceAddress varchar(256), _InvoicePostCode varchar(64), _InvoiceCity varchar(128), _InvoiceCountry varchar(256), _IsPaymentAccepted bit, _LastPaymentDate datetime, _Partner_Name text, _Owner_Name text)
BEGIN
	INSERT INTO `SePaCuUnRe`
	(`IsCreatedUndoDeletes`, `IsDeletedUndoCreates`, `IsUpdatedUndoUpdates`, `IsUndone`, `Name`, `FullNameOfResponsible`, `EmailOfResponsible`, `Description`, `IsPartner`, `CompanyName`, `VATNo`, `Phone`, `Address`, `PostCode`, `City`, `Country`, `InvoiceAddress`, `InvoicePostCode`, `InvoiceCity`, `InvoiceCountry`, `IsPaymentAccepted`, `LastPaymentDate`, `Partner_Name`, `Owner_Name`)
	VALUES (_IsCreatedUndoDeletes, _IsDeletedUndoCreates, _IsUpdatedUndoUpdates, _IsUndone, _Name, _FullNameOfResponsible, _EmailOfResponsible, _Description, _IsPartner, _CompanyName, _VATNo, _Phone, _Address, _PostCode, _City, _Country, _InvoiceAddress, _InvoicePostCode, _InvoiceCity, _InvoiceCountry, _IsPaymentAccepted, _LastPaymentDate, _Partner_Name, _Owner_Name);
	
	SELECT * FROM `SePaCuUnRe` WHERE `UndoRedoId` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUnReUpdate` 
	(_UndoRedoId bigint, _IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Name varchar(256), _FullNameOfResponsible varchar(512), _EmailOfResponsible varchar(256), _Description varchar(256), _IsPartner bit, _CompanyName varchar(256), _VATNo varchar(256), _Phone varchar(128), _Address varchar(256), _PostCode varchar(64), _City varchar(128), _Country varchar(256), _InvoiceAddress varchar(256), _InvoicePostCode varchar(64), _InvoiceCity varchar(128), _InvoiceCountry varchar(256), _IsPaymentAccepted bit, _LastPaymentDate datetime, _Partner_Name text, _Owner_Name text)
BEGIN
	
	
	UPDATE `SePaCuUnRe`
	SET `IsCreatedUndoDeletes` = _IsCreatedUndoDeletes, `IsDeletedUndoCreates` = _IsDeletedUndoCreates, `IsUpdatedUndoUpdates` = _IsUpdatedUndoUpdates, `IsUndone` = _IsUndone, `Name` = _Name, `FullNameOfResponsible` = _FullNameOfResponsible, `EmailOfResponsible` = _EmailOfResponsible, `Description` = _Description, `IsPartner` = _IsPartner, `CompanyName` = _CompanyName, `VATNo` = _VATNo, `Phone` = _Phone, `Address` = _Address, `PostCode` = _PostCode, `City` = _City, `Country` = _Country, `InvoiceAddress` = _InvoiceAddress, `InvoicePostCode` = _InvoicePostCode, `InvoiceCity` = _InvoiceCity, `InvoiceCountry` = _InvoiceCountry, `IsPaymentAccepted` = _IsPaymentAccepted, `LastPaymentDate` = _LastPaymentDate, `Partner_Name` = _Partner_Name, `Owner_Name` = _Owner_Name
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `CuUnReGeAlFiByIsUn` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlFiByIsUnPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlFiByIsUnCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUnReGeAlFiByIsUnOpOr` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlFiByIsUnOpOrPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlFiByIsUnOpOrCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUnReGeAlWiNoFiOpSo` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaCuUnRe`
	
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlWiNoFiOpSoPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUnRe`
	
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlWiNoFiOpSoCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUnRe`
	;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUnReGeAlWiNoFi` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaCuUnRe`
	
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlWiNoFiPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUnRe`
	
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUnReGeAlWiNoFiCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUnRe`
	;
END $$
DELIMITER ;
GO


/** Services.Packages.PurchaseUndoRedo CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuUnReRead` 
	(_UndoRedoId bigint)
BEGIN
    SELECT *
	FROM `SePaPuUnRe`
	WHERE (`UndoRedoId` = _UndoRedoId);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuUnReDelete` 
	(_UndoRedoId bigint)
BEGIN
	DELETE FROM `SePaPuUnRe`
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuUnReCreate` 
	(_IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Id int, _CreationDate datetime, _ApiKey_Id char(36), _Client_Name text, _Owner_Name text)
BEGIN
	INSERT INTO `SePaPuUnRe`
	(`IsCreatedUndoDeletes`, `IsDeletedUndoCreates`, `IsUpdatedUndoUpdates`, `IsUndone`, `Id`, `CreationDate`, `ApiKey_Id`, `Client_Name`, `Owner_Name`)
	VALUES (_IsCreatedUndoDeletes, _IsDeletedUndoCreates, _IsUpdatedUndoUpdates, _IsUndone, _Id, _CreationDate, _ApiKey_Id, _Client_Name, _Owner_Name);
	
	SELECT * FROM `SePaPuUnRe` WHERE `UndoRedoId` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuUnReUpdate` 
	(_UndoRedoId bigint, _IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Id int, _CreationDate datetime, _ApiKey_Id char(36), _Client_Name text, _Owner_Name text)
BEGIN
	
	
	UPDATE `SePaPuUnRe`
	SET `IsCreatedUndoDeletes` = _IsCreatedUndoDeletes, `IsDeletedUndoCreates` = _IsDeletedUndoCreates, `IsUpdatedUndoUpdates` = _IsUpdatedUndoUpdates, `IsUndone` = _IsUndone, `Id` = _Id, `CreationDate` = _CreationDate, `ApiKey_Id` = _ApiKey_Id, `Client_Name` = _Client_Name, `Owner_Name` = _Owner_Name
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `PuUnReGeAlFiByIsUn` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlFiByIsUnPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlFiByIsUnCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuUnReGeAlFiByIsUnOpOr` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlFiByIsUnOpOrPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlFiByIsUnOpOrCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuUnReGeAlWiNoFiOpSo` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaPuUnRe`
	
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlWiNoFiOpSoPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuUnRe`
	
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlWiNoFiOpSoCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuUnRe`
	;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuUnReGeAlWiNoFi` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaPuUnRe`
	
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlWiNoFiPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuUnRe`
	
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuUnReGeAlWiNoFiCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuUnRe`
	;
END $$
DELIMITER ;
GO


/** Services.Packages.PurchaseLineUndoRedo CRUD sp's **/

DELIMITER $$
CREATE PROCEDURE `PuLiUnReRead` 
	(_UndoRedoId bigint)
BEGIN
    SELECT *
	FROM `SePaPuLiUnRe`
	WHERE (`UndoRedoId` = _UndoRedoId);
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiUnReDelete` 
	(_UndoRedoId bigint)
BEGIN
	DELETE FROM `SePaPuLiUnRe`
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$
DELIMITER ;
GO


DELIMITER $$
CREATE PROCEDURE `PuLiUnReCreate` 
	(_IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Id int, _ProductKey varchar(256), _ProductDescription text, _PricePurchased double, _RecurrentFeePurchased double, _IsPaid bit, _PurchaseOrder_Id int, _Owner_Name text)
BEGIN
	INSERT INTO `SePaPuLiUnRe`
	(`IsCreatedUndoDeletes`, `IsDeletedUndoCreates`, `IsUpdatedUndoUpdates`, `IsUndone`, `Id`, `ProductKey`, `ProductDescription`, `PricePurchased`, `RecurrentFeePurchased`, `IsPaid`, `PurchaseOrder_Id`, `Owner_Name`)
	VALUES (_IsCreatedUndoDeletes, _IsDeletedUndoCreates, _IsUpdatedUndoUpdates, _IsUndone, _Id, _ProductKey, _ProductDescription, _PricePurchased, _RecurrentFeePurchased, _IsPaid, _PurchaseOrder_Id, _Owner_Name);
	
	SELECT * FROM `SePaPuLiUnRe` WHERE `UndoRedoId` = LAST_INSERT_ID();
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiUnReUpdate` 
	(_UndoRedoId bigint, _IsCreatedUndoDeletes bit, _IsDeletedUndoCreates bit, _IsUpdatedUndoUpdates bit, _IsUndone bit, _Id int, _ProductKey varchar(256), _ProductDescription text, _PricePurchased double, _RecurrentFeePurchased double, _IsPaid bit, _PurchaseOrder_Id int, _Owner_Name text)
BEGIN
	
	
	UPDATE `SePaPuLiUnRe`
	SET `IsCreatedUndoDeletes` = _IsCreatedUndoDeletes, `IsDeletedUndoCreates` = _IsDeletedUndoCreates, `IsUpdatedUndoUpdates` = _IsUpdatedUndoUpdates, `IsUndone` = _IsUndone, `Id` = _Id, `ProductKey` = _ProductKey, `ProductDescription` = _ProductDescription, `PricePurchased` = _PricePurchased, `RecurrentFeePurchased` = _RecurrentFeePurchased, `IsPaid` = _IsPaid, `PurchaseOrder_Id` = _PurchaseOrder_Id, `Owner_Name` = _Owner_Name
	WHERE ((`UndoRedoId` = _UndoRedoId));
END $$

DELIMITER ;
GO



DELIMITER $$

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUn` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUnPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUnCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUnOpOr` 
	(_IsUndone bit)
BEGIN
    SELECT *
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUnOpOrPaged` 
	(_IsUndone bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone 
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlFiByIsUnOpOrCount` 
	(_IsUndone bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLiUnRe`
	WHERE `IsUndone` = _IsUndone ;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiUnReGeAlWiNoFiOpSo` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaPuLiUnRe`
	
	ORDER BY `UndoRedoId` ASC;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlWiNoFiOpSoPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLiUnRe`
	
	ORDER BY `UndoRedoId` ASC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlWiNoFiOpSoCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLiUnRe`
	;
END $$
DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiUnReGeAlWiNoFi` 
	(_dummy bit)
BEGIN
    SELECT *
	FROM `SePaPuLiUnRe`
	
	ORDER BY `UndoRedoId` DESC;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlWiNoFiPaged` 
	(_dummy bit,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLiUnRe`
	
	ORDER BY `UndoRedoId` DESC
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiUnReGeAlWiNoFiCount` 
	(_dummy bit)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLiUnRe`
	;
END $$
DELIMITER ;
GO


/** Services.Packages.Package Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PaGetByApKe` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PaGetByApKePaged` 
	(_Id char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaGetByApKeCount` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PaGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PaGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PaSeByPaNaFoApKe` 
	(_PackageName text, _ApKeId char(36))
BEGIN
    SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`PackageName` LIKE _PackageName );
END $$
GO

CREATE PROCEDURE `PaSeByPaNaFoApKePaged` 
	(_PackageName text, _ApKeId char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`PackageName` LIKE _PackageName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PaSeByPaNaFoApKeCount`
	(_PackageName text, _ApKeId char(36))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaPa` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`PackageName` LIKE _PackageName )
END $$
DELIMITER ;
GO

/** Services.Packages.LocalPackage Relations SPs **/


/** Services.Packages.ApiKey Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApKeGetByCu` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `ApKeGetByCuPaged` 
	(_Name varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeGetByCuCount` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApKeGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `ApKeGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApKeSeByCoInOnCu` 
	(_CompanyInfo text, _CuNa varchar(256))
BEGIN
    SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`CompanyInfo` LIKE _CompanyInfo );
END $$
GO

CREATE PROCEDURE `ApKeSeByCoInOnCuPaged` 
	(_CompanyInfo text, _CuNa varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`CompanyInfo` LIKE _CompanyInfo )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApKeSeByCoInOnCuCount`
	(_CompanyInfo text, _CuNa varchar(256))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaApKe` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`CompanyInfo` LIKE _CompanyInfo )
END $$
DELIMITER ;
GO

/** Services.Packages.Log.ApplicationException Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApExGetByApKe` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExGetByApKePaged` 
	(_Id char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExGetByApKeCount` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExGetByPaEx` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`ParentException_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExGetByPaExPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`ParentException_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`ParentException_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExGetByPaExCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`ParentException_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApExSeByNaOnApKe` 
	(_Message text, _ApKeId char(36))
BEGIN
    SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message );
END $$
GO

CREATE PROCEDURE `ApExSeByNaOnApKePaged` 
	(_Message text, _ApKeId char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApExSeByNaOnApKeCount`
	(_Message text, _ApKeId char(36))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message )
END $$
DELIMITER ;
GO

DELIMITER $$
CREATE PROCEDURE `ApExSeByNaSoOnApKe` 
	(_Message text, _IsSolved bit, _ApKeId char(36))
BEGIN
    SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message AND a.`IsSolved` = _IsSolved );
END $$
GO

CREATE PROCEDURE `ApExSeByNaSoOnApKePaged` 
	(_Message text, _IsSolved bit, _ApKeId char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message AND a.`IsSolved` = _IsSolved )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApExSeByNaSoOnApKeCount`
	(_Message text, _IsSolved bit, _ApKeId char(36))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoApEx` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`Message` LIKE _Message AND a.`IsSolved` = _IsSolved )
END $$
DELIMITER ;
GO

/** Services.Packages.Customer Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuGetByPa` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuGetByPaPaged` 
	(_Name varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuGetByPaCount` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `CuSeByNaOnPa` 
	(_Name text, _CuNa varchar(256))
BEGIN
    SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name );
END $$
GO

CREATE PROCEDURE `CuSeByNaOnPaPaged` 
	(_Name text, _CuNa varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuSeByNaOnPaCount`
	(_Name text, _CuNa varchar(256))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name )
END $$
DELIMITER ;
GO

DELIMITER $$
CREATE PROCEDURE `CuSeByNaAnPaOnPa` 
	(_Name text, _IsPaymentAccepted bit, _CuNa varchar(256))
BEGIN
    SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name AND a.`IsPaymentAccepted` = _IsPaymentAccepted );
END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaOnPaPaged` 
	(_Name text, _IsPaymentAccepted bit, _CuNa varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name AND a.`IsPaymentAccepted` = _IsPaymentAccepted )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuSeByNaAnPaOnPaCount`
	(_Name text, _IsPaymentAccepted bit, _CuNa varchar(256))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaCu` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Partner_Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name AND a.`IsPaymentAccepted` = _IsPaymentAccepted )
END $$
DELIMITER ;
GO

/** Services.Packages.CustomerUserEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuUsEnGetByUsLo` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserLogin_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnGetByUsLoPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserLogin_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserLogin_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnGetByUsLoCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserLogin_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnGetByCu` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnGetByCuPaged` 
	(_Name varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnGetByCuCount` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Customer_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaCuUsEn` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.Purchase Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuGetByApKe` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuGetByApKePaged` 
	(_Id char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuGetByApKeCount` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`ApiKey_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuGetByCl` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Client_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PuGetByClPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Client_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Client_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuGetByClCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Client_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PuGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPu` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.PurchaseLine Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuLiGetByPuOr` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`PurchaseOrder_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuLiGetByPuOrPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`PurchaseOrder_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`PurchaseOrder_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiGetByPuOrCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`PurchaseOrder_Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PuLiGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaPuLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ModelUser Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `MoUsGetByOw` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeMoUs` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoUsGetByOwPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeMoUs` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUs` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsGetByOwCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUs` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Owner_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ModelSession Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `MoSeGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeMoSe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`User_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoSeGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeMoSe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`User_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoSe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`User_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoSeGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoSe` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`User_Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.ModelUserRights Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `MoUsRiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoUsRiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsRiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `MoUsRiGeByNaAnUs` 
	(_Name text, _MoUsNa varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name );
END $$
GO

CREATE PROCEDURE `MoUsRiGeByNaAnUsPaged` 
	(_Name text, _MoUsNa varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `MoUsRiGeByNaAnUsCount`
	(_Name text, _MoUsNa varchar(128))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeMoUsRi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`Name` LIKE _Name )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.Securable Relations SPs **/


/** Services.Packages.Security.IPRegistered Relations SPs **/


/** Services.Packages.Security.IPSessionRegistration Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `IPSeReGetByIP` 
	(_IP varchar(64))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeIPRe` as b
		ON a.`IP_IP` = b.`IP`
	WHERE (b.`IP` = _IP OR (_IP IS NULL AND b.`IP` IS NULL));
END $$
GO

CREATE PROCEDURE `IPSeReGetByIPPaged` 
	(_IP varchar(64),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeIPRe` as b
		ON a.`IP_IP` = b.`IP`
	WHERE (b.`IP` = _IP OR (_IP IS NULL AND b.`IP` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeIPRe` as b
		ON a.`IP_IP` = b.`IP`
	WHERE (b.`IP` = _IP OR (_IP IS NULL AND b.`IP` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `IPSeReGetByIPCount` 
	(_IP varchar(64))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeIPRe` as b
		ON a.`IP_IP` = b.`IP`
	WHERE (b.`IP` = _IP OR (_IP IS NULL AND b.`IP` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `IPSeReGetBySe` 
	(_SessionToken varchar(384))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeMoSe` as b
		ON a.`Session_SessionToken` = b.`SessionToken`
	WHERE (b.`SessionToken` = _SessionToken OR (_SessionToken IS NULL AND b.`SessionToken` IS NULL));
END $$
GO

CREATE PROCEDURE `IPSeReGetBySePaged` 
	(_SessionToken varchar(384),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeMoSe` as b
		ON a.`Session_SessionToken` = b.`SessionToken`
	WHERE (b.`SessionToken` = _SessionToken OR (_SessionToken IS NULL AND b.`SessionToken` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeMoSe` as b
		ON a.`Session_SessionToken` = b.`SessionToken`
	WHERE (b.`SessionToken` = _SessionToken OR (_SessionToken IS NULL AND b.`SessionToken` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `IPSeReGetBySeCount` 
	(_SessionToken varchar(384))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeIPSeRe` as a LEFT OUTER JOIN `SePaSeMoSe` as b
		ON a.`Session_SessionToken` = b.`SessionToken`
	WHERE (b.`SessionToken` = _SessionToken OR (_SessionToken IS NULL AND b.`SessionToken` IS NULL));
END $$

DELIMITER ;
GO



/** Services.Packages.Security.PackageAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PaAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PaAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PaAcCoLiGetByPa` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PaAcCoLiGetByPaPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaAcCoLiGetByPaCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PaAcCoLiGeACLs` 
	(_UserName text, _PaId int)
BEGIN
    SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PaId OR (_PaId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `PaAcCoLiGeACLsPaged` 
	(_UserName text, _PaId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PaId OR (_PaId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PaAcCoLiGeACLsCount`
	(_UserName text, _PaId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePaAcCoLi` as a LEFT OUTER JOIN `SePaPa` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PaId OR (_PaId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.PackageAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PaAcCoEnGetByACL` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PaAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PaAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PaAcCoEnGeEn` 
	(_Descriptor text, _PaAcCoLiUsNa varchar(128), _PaAcCoLiId int)
BEGIN
    SELECT *
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PaAcCoLiUsNa OR (_PaAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PaAcCoLiId OR (_PaAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `PaAcCoEnGeEnPaged` 
	(_Descriptor text, _PaAcCoLiUsNa varchar(128), _PaAcCoLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PaAcCoLiUsNa OR (_PaAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PaAcCoLiId OR (_PaAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PaAcCoEnGeEnCount`
	(_Descriptor text, _PaAcCoLiUsNa varchar(128), _PaAcCoLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePaAcCoEn` as a LEFT OUTER JOIN `SePaSePaAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PaAcCoLiUsNa OR (_PaAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PaAcCoLiId OR (_PaAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.ApiKeyAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApKeAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApKeAcCoLiGetByApKe` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGetByApKePaged` 
	(_Id char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGetByApKeCount` 
	(_Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApKeAcCoLiGeACLs` 
	(_UserName text, _ApKeId char(36))
BEGIN
    SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGeACLsPaged` 
	(_UserName text, _ApKeId char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApKeAcCoLiGeACLsCount`
	(_UserName text, _ApKeId char(36))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeApKeAcCoLi` as a LEFT OUTER JOIN `SePaApKe` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApKeId OR (_ApKeId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.ApiKeyAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApKeAcCoEnGetByACL` 
	(_UserName varchar(128), _Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApKeAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApKeAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id char(36))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApKeAcCoEnGeEn` 
	(_Descriptor text, _ApKeAcCoLiUsNa varchar(128), _ApKeAcCoLiId char(36))
BEGIN
    SELECT *
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApKeAcCoLiUsNa OR (_ApKeAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApKeAcCoLiId OR (_ApKeAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `ApKeAcCoEnGeEnPaged` 
	(_Descriptor text, _ApKeAcCoLiUsNa varchar(128), _ApKeAcCoLiId char(36),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApKeAcCoLiUsNa OR (_ApKeAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApKeAcCoLiId OR (_ApKeAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApKeAcCoEnGeEnCount`
	(_Descriptor text, _ApKeAcCoLiUsNa varchar(128), _ApKeAcCoLiId char(36))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeApKeAcCoEn` as a LEFT OUTER JOIN `SePaSeApKeAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApKeAcCoLiUsNa OR (_ApKeAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApKeAcCoLiId OR (_ApKeAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApExAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `ApExAcCoLiGetByApEx` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExAcCoLiGetByApExPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExAcCoLiGetByApExCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApExAcCoLiGeACLs` 
	(_UserName text, _ApExId int)
BEGIN
    SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApExId OR (_ApExId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `ApExAcCoLiGeACLsPaged` 
	(_UserName text, _ApExId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApExId OR (_ApExId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApExAcCoLiGeACLsCount`
	(_UserName text, _ApExId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoSeApExAcCoLi` as a LEFT OUTER JOIN `SePaLoApEx` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _ApExId OR (_ApExId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `ApExAcCoEnGetByACL` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `ApExAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `ApExAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `ApExAcCoEnGeEn` 
	(_Descriptor text, _ApExAcCoLiUsNa varchar(128), _ApExAcCoLiId int)
BEGIN
    SELECT *
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApExAcCoLiUsNa OR (_ApExAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApExAcCoLiId OR (_ApExAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `ApExAcCoEnGeEnPaged` 
	(_Descriptor text, _ApExAcCoLiUsNa varchar(128), _ApExAcCoLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApExAcCoLiUsNa OR (_ApExAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApExAcCoLiId OR (_ApExAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `ApExAcCoEnGeEnCount`
	(_Descriptor text, _ApExAcCoLiUsNa varchar(128), _ApExAcCoLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaLoSeApExAcCoEn` as a LEFT OUTER JOIN `SePaLoSeApExAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _ApExAcCoLiUsNa OR (_ApExAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _ApExAcCoLiId OR (_ApExAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.CustomerAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuAcCoLiGetByCu` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuAcCoLiGetByCuPaged` 
	(_Name varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuAcCoLiGetByCuCount` 
	(_Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `CuAcCoLiGeACLs` 
	(_UserName text, _CuNa varchar(256))
BEGIN
    SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `CuAcCoLiGeACLsPaged` 
	(_UserName text, _CuNa varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuAcCoLiGeACLsCount`
	(_UserName text, _CuNa varchar(256))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuAcCoLi` as a LEFT OUTER JOIN `SePaCu` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _CuNa OR (_CuNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.CustomerAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuAcCoEnGetByACL` 
	(_UserName varchar(128), _Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Name varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Name varchar(256))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `CuAcCoEnGeEn` 
	(_Descriptor text, _CuAcCoLiUsNa varchar(128), _CuAcCoLiNa varchar(256))
BEGIN
    SELECT *
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _CuAcCoLiUsNa OR (_CuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _CuAcCoLiNa OR (_CuAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `CuAcCoEnGeEnPaged` 
	(_Descriptor text, _CuAcCoLiUsNa varchar(128), _CuAcCoLiNa varchar(256),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _CuAcCoLiUsNa OR (_CuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _CuAcCoLiNa OR (_CuAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuAcCoEnGeEnCount`
	(_Descriptor text, _CuAcCoLiUsNa varchar(128), _CuAcCoLiNa varchar(256))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuAcCoEn` as a LEFT OUTER JOIN `SePaSeCuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _CuAcCoLiUsNa OR (_CuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _CuAcCoLiNa OR (_CuAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuUsEnAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `CuUsEnAcCoLiGetByCuUsEn` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGetByCuUsEnPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGetByCuUsEnCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoLiGeACLs` 
	(_UserName text, _CuUsEnId int)
BEGIN
    SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _CuUsEnId OR (_CuUsEnId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGeACLsPaged` 
	(_UserName text, _CuUsEnId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _CuUsEnId OR (_CuUsEnId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuUsEnAcCoLiGeACLsCount`
	(_UserName text, _CuUsEnId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuUsEnAcCoLi` as a LEFT OUTER JOIN `SePaCuUsEn` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _CuUsEnId OR (_CuUsEnId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `CuUsEnAcCoEnGetByACL` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `CuUsEnAcCoEnGeEn` 
	(_Descriptor text, _CuUsEnAcCoLiUsNa varchar(128), _CuUsEnAcCoLiId int)
BEGIN
    SELECT *
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _CuUsEnAcCoLiUsNa OR (_CuUsEnAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _CuUsEnAcCoLiId OR (_CuUsEnAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `CuUsEnAcCoEnGeEnPaged` 
	(_Descriptor text, _CuUsEnAcCoLiUsNa varchar(128), _CuUsEnAcCoLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _CuUsEnAcCoLiUsNa OR (_CuUsEnAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _CuUsEnAcCoLiId OR (_CuUsEnAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `CuUsEnAcCoEnGeEnCount`
	(_Descriptor text, _CuUsEnAcCoLiUsNa varchar(128), _CuUsEnAcCoLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeCuUsEnAcCoEn` as a LEFT OUTER JOIN `SePaSeCuUsEnAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _CuUsEnAcCoLiUsNa OR (_CuUsEnAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _CuUsEnAcCoLiId OR (_CuUsEnAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.PurchaseAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PuAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuAcCoLiGetByPu` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuAcCoLiGetByPuPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuAcCoLiGetByPuCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PuAcCoLiGeACLs` 
	(_UserName text, _PuId int)
BEGIN
    SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuId OR (_PuId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `PuAcCoLiGeACLsPaged` 
	(_UserName text, _PuId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuId OR (_PuId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PuAcCoLiGeACLsCount`
	(_UserName text, _PuId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuAcCoLi` as a LEFT OUTER JOIN `SePaPu` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuId OR (_PuId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.PurchaseAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuAcCoEnGetByACL` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PuAcCoEnGeEn` 
	(_Descriptor text, _PuAcCoLiUsNa varchar(128), _PuAcCoLiId int)
BEGIN
    SELECT *
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuAcCoLiUsNa OR (_PuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuAcCoLiId OR (_PuAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `PuAcCoEnGeEnPaged` 
	(_Descriptor text, _PuAcCoLiUsNa varchar(128), _PuAcCoLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuAcCoLiUsNa OR (_PuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuAcCoLiId OR (_PuAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PuAcCoEnGeEnCount`
	(_Descriptor text, _PuAcCoLiUsNa varchar(128), _PuAcCoLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuAcCoEn` as a LEFT OUTER JOIN `SePaSePuAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuAcCoLiUsNa OR (_PuAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuAcCoLiId OR (_PuAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.PurchaseLineAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuLiAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `PuLiAcCoLiGetByPuLi` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGetByPuLiPaged` 
	(_Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGetByPuLiCount` 
	(_Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PuLiAcCoLiGeACLs` 
	(_UserName text, _PuLiId int)
BEGIN
    SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuLiId OR (_PuLiId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGeACLsPaged` 
	(_UserName text, _PuLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuLiId OR (_PuLiId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PuLiAcCoLiGeACLsCount`
	(_UserName text, _PuLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuLiAcCoLi` as a LEFT OUTER JOIN `SePaPuLi` as b
		ON a.`Id` = b.`Id`
	WHERE (b.`Id` = _PuLiId OR (_PuLiId IS NULL AND b.`Id` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.PurchaseLineAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `PuLiAcCoEnGetByACL` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$
GO

CREATE PROCEDURE `PuLiAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Id int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `PuLiAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Id int)
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _Id OR (_Id IS NULL AND b.`Id` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `PuLiAcCoEnGeEn` 
	(_Descriptor text, _PuLiAcCoLiUsNa varchar(128), _PuLiAcCoLiId int)
BEGIN
    SELECT *
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuLiAcCoLiUsNa OR (_PuLiAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuLiAcCoLiId OR (_PuLiAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `PuLiAcCoEnGeEnPaged` 
	(_Descriptor text, _PuLiAcCoLiUsNa varchar(128), _PuLiAcCoLiId int,
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuLiAcCoLiUsNa OR (_PuLiAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuLiAcCoLiId OR (_PuLiAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `PuLiAcCoEnGeEnCount`
	(_Descriptor text, _PuLiAcCoLiUsNa varchar(128), _PuLiAcCoLiId int)
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSePuLiAcCoEn` as a LEFT OUTER JOIN `SePaSePuLiAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Id` = b.`Id`
	WHERE (b.`UserName` = _PuLiAcCoLiUsNa OR (_PuLiAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Id` = _PuLiAcCoLiId OR (_PuLiAcCoLiId IS NULL AND b.`Id` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.Security.ModelUserAccessControlList Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `MoUsAcCoLiGetByUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGetByUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGetByUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO


DELIMITER $$

CREATE PROCEDURE `MoUsAcCoLiGetByMoUs` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGetByMoUsPaged` 
	(_Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGetByMoUsCount` 
	(_Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`Name` = b.`Name`
	WHERE (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `MoUsAcCoLiGeACLs` 
	(_UserName text, _MoUsNa varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName );
END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGeACLsPaged` 
	(_UserName text, _MoUsNa varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `MoUsAcCoLiGeACLsCount`
	(_UserName text, _MoUsNa varchar(128))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeSeMoUsAcCoLi` as a LEFT OUTER JOIN `SePaSeMoUs` as b
		ON a.`UserName` = b.`Name`
	WHERE (b.`Name` = _MoUsNa OR (_MoUsNa IS NULL AND b.`Name` IS NULL)) AND (a.`UserName` LIKE _UserName )
END $$
DELIMITER ;
GO

/** Services.Packages.Security.Security.ModelUserAccessControlEntry Relations SPs **/

DELIMITER $$

CREATE PROCEDURE `MoUsAcCoEnGetByACL` 
	(_UserName varchar(128), _Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT *
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$
GO

CREATE PROCEDURE `MoUsAcCoEnGetByACLPaged` 
	(_UserName varchar(128), _Name varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;

    /*SELECT *
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT @PagingStart, @total;*/
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL))
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;
END $$
GO

CREATE PROCEDURE `MoUsAcCoEnGetByACLCount` 
	(_UserName varchar(128), _Name varchar(128))
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS `Count`
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _UserName OR (_UserName IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _Name OR (_Name IS NULL AND b.`Name` IS NULL));
END $$

DELIMITER ;
GO



DELIMITER $$
CREATE PROCEDURE `MoUsAcCoEnGeEn` 
	(_Descriptor text, _MoUsAcCoLiUsNa varchar(128), _MoUsAcCoLiNa varchar(128))
BEGIN
    SELECT *
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _MoUsAcCoLiUsNa OR (_MoUsAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _MoUsAcCoLiNa OR (_MoUsAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor );
END $$
GO

CREATE PROCEDURE `MoUsAcCoEnGeEnPaged` 
	(_Descriptor text, _MoUsAcCoLiUsNa varchar(128), _MoUsAcCoLiNa varchar(128),
	_PagingStart BIGINT,
	_PagingCount BIGINT)
BEGIN
	SET @_total = _PagingStart + _PagingCount;
	SET @_PagingStart = _PagingStart;
	
	PREPARE STMT FROM 'SELECT *
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _MoUsAcCoLiUsNa OR (_MoUsAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _MoUsAcCoLiNa OR (_MoUsAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
	LIMIT ?, ?';
	EXECUTE STMT USING @_PagingStart, @_total;

END $$
GO

CREATE PROCEDURE `MoUsAcCoEnGeEnCount`
	(_Descriptor text, _MoUsAcCoLiUsNa varchar(128), _MoUsAcCoLiNa varchar(128))
BEGIN
    SELECT COUNT(*) AS `Count`
	FROM `SePaSeSeMoUsAcCoEn` as a LEFT OUTER JOIN `SePaSeSeMoUsAcCoLi` as b
		ON a.`UserName` = b.`UserName` AND a.`Name` = b.`Name`
	WHERE (b.`UserName` = _MoUsAcCoLiUsNa OR (_MoUsAcCoLiUsNa IS NULL AND b.`UserName` IS NULL)) AND (b.`Name` = _MoUsAcCoLiNa OR (_MoUsAcCoLiNa IS NULL AND b.`Name` IS NULL)) AND (a.`Descriptor` LIKE _Descriptor )
END $$
DELIMITER ;
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions Relations SPs **/


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup Relations SPs **/


/** Services.Packages.CustomerUndoRedo Relations SPs **/


/** Services.Packages.PurchaseUndoRedo Relations SPs **/


/** Services.Packages.PurchaseLineUndoRedo Relations SPs **/


