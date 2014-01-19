/** Services.Packages.Package CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PaRead"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPa"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PaDelete"
	(Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaPa"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PaCreate"
	(PackageName VARCHAR2, VersionLabel VARCHAR2, UploadDate TIMESTAMP, ApiKey_Id CHAR, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaPa.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaPa"
	("Id", "PackageName", "VersionLabel", "UploadDate", "ApiKey_Id", "Owner_Name")
	VALUES (n, PackageName, VersionLabel, UploadDate, ApiKey_Id, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaPa"
	WHERE ("Id" = n);
END;
/


CREATE OR REPLACE PROCEDURE "PaUpdate"
	(Id NUMBER, PackageName VARCHAR2, VersionLabel VARCHAR2, UploadDate TIMESTAMP, ApiKeyHasChanged NUMBER, ApiKey_Id CHAR, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaPa"
	SET "PackageName" = PackageName, "VersionLabel" = VersionLabel, "UploadDate" = UploadDate
	WHERE (("Id" = Id));
	
	IF (ApiKeyHasChanged = 1) THEN
		UPDATE "SePaPa"
		SET "ApiKey_Id" = ApiKey_Id
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaPa"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "PaSeByPaNa"
	(PackageName CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPa"
	WHERE "PackageName" LIKE PackageName 
	ORDER BY "UploadDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PaSeByPaNaPaged"
	(PackageName CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPa"
	WHERE "PackageName" LIKE PackageName 
	ORDER BY "UploadDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PaSeByPaNaCount"
	(PackageName CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPa"
	WHERE "PackageName" LIKE PackageName ;
END
/


/** Services.Packages.LocalPackage CRUD sp's **/

CREATE OR REPLACE PROCEDURE "LoPaRead"
	(PackageName VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoPa"
	WHERE ("PackageName" = PackageName);
END;
/


CREATE OR REPLACE PROCEDURE "LoPaDelete"
	(PackageName VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaLoPa"
	WHERE (("PackageName" = PackageName));
END;
/


CREATE OR REPLACE PROCEDURE "LoPaCreate"
	(PackageName VARCHAR2, Id NUMBER, VersionLabel VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaLoPa.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaLoPa"
	("PackageName", "Id", "VersionLabel")
	VALUES (PackageName, Id, VersionLabel);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaLoPa"
	WHERE ("PackageName" = PackageName);
END;
/


CREATE OR REPLACE PROCEDURE "LoPaUpdate"
	(PackageName VARCHAR2, Id NUMBER, VersionLabel VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaLoPa"
	SET "PackageName" = PackageName, "Id" = Id, "VersionLabel" = VersionLabel
	WHERE (("PackageName" = PackageName));
END;
/



CREATE OR REPLACE PROCEDURE "LoPaSeByPaNa"
	(PackageName CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoPa"
	WHERE "PackageName" LIKE PackageName 
	;
END;
/

CREATE OR REPLACE PROCEDURE "LoPaSeByPaNaPaged"
	(PackageName CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoPa"
	WHERE "PackageName" LIKE PackageName 
	;
END;
/

CREATE OR REPLACE PROCEDURE "LoPaSeByPaNaCount"
	(PackageName CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoPa"
	WHERE "PackageName" LIKE PackageName ;
END
/


/** Services.Packages.ApiKey CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApKeRead"
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeDelete"
	(Id CHAR)
IS
BEGIN
	DELETE FROM "SePaApKe"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApKeCreate"
	(Id CHAR, CompanyInfo VARCHAR2, IssueDate TIMESTAMP, FromDate TIMESTAMP, ToDate TIMESTAMP, IsTest NUMBER, Customer_Name VARCHAR2, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaApKe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaApKe"
	("Id", "CompanyInfo", "IssueDate", "FromDate", "ToDate", "IsTest", "Customer_Name", "Owner_Name")
	VALUES (Id, CompanyInfo, IssueDate, FromDate, ToDate, IsTest, Customer_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaApKe"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeUpdate"
	(Id CHAR, CompanyInfo VARCHAR2, IssueDate TIMESTAMP, FromDate TIMESTAMP, ToDate TIMESTAMP, IsTest NUMBER, CustomerHasChanged NUMBER, Customer_Name VARCHAR2, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaApKe"
	SET "Id" = Id, "CompanyInfo" = CompanyInfo, "IssueDate" = IssueDate, "FromDate" = FromDate, "ToDate" = ToDate, "IsTest" = IsTest
	WHERE (("Id" = Id));
	
	IF (CustomerHasChanged = 1) THEN
		UPDATE "SePaApKe"
		SET "Customer_Name" = Customer_Name
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaApKe"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "ApKeSeByCoIn"
	(CompanyInfo CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe"
	WHERE "CompanyInfo" LIKE CompanyInfo 
	ORDER BY "IssueDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApKeSeByCoInPaged"
	(CompanyInfo CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe"
	WHERE "CompanyInfo" LIKE CompanyInfo 
	ORDER BY "IssueDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApKeSeByCoInCount"
	(CompanyInfo CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaApKe"
	WHERE "CompanyInfo" LIKE CompanyInfo ;
END
/


/** Services.Packages.Log.ApplicationException CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApExRead"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApExDelete"
	(Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaLoApEx"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApExCreate"
	(Message VARCHAR2, Source VARCHAR2, StackTrace CLOB, Page CLOB, OnDate TIMESTAMP, IsSolved NUMBER, ApiKey_Id CHAR, ParentException_Id NUMBER, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaLoApEx.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaLoApEx"
	("Id", "Message", "Source", "StackTrace", "Page", "OnDate", "IsSolved", "ApiKey_Id", "ParentException_Id", "Owner_Name")
	VALUES (n, Message, Source, StackTrace, Page, OnDate, IsSolved, ApiKey_Id, ParentException_Id, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE ("Id" = n);
END;
/


CREATE OR REPLACE PROCEDURE "ApExUpdate"
	(Id NUMBER, Message VARCHAR2, Source VARCHAR2, StackTrace CLOB, Page CLOB, OnDate TIMESTAMP, IsSolved NUMBER, ApiKeyHasChanged NUMBER, ApiKey_Id CHAR, ParentExceptionHasChanged NUMBER, ParentException_Id NUMBER, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaLoApEx"
	SET "Message" = Message, "Source" = Source, "StackTrace" = StackTrace, "Page" = Page, "OnDate" = OnDate, "IsSolved" = IsSolved
	WHERE (("Id" = Id));
	
	IF (ApiKeyHasChanged = 1) THEN
		UPDATE "SePaLoApEx"
		SET "ApiKey_Id" = ApiKey_Id
		WHERE (("Id" = Id));
	END IF;
	
	IF (ParentExceptionHasChanged = 1) THEN
		UPDATE "SePaLoApEx"
		SET "ParentException_Id" = ParentException_Id
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaLoApEx"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "ApExSeByNa"
	(Message CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message 
	ORDER BY "OnDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaPaged"
	(Message CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message 
	ORDER BY "OnDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaCount"
	(Message CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message ;
END
/


CREATE OR REPLACE PROCEDURE "ApExSeByNaSo"
	(Message CLOB, IsSolved NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message AND "IsSolved" = IsSolved 
	ORDER BY "OnDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaSoPaged"
	(Message CLOB, IsSolved NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message AND "IsSolved" = IsSolved 
	ORDER BY "OnDate" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaSoCount"
	(Message CLOB, IsSolved NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoApEx"
	WHERE "Message" LIKE Message AND "IsSolved" = IsSolved ;
END
/


/** Services.Packages.Customer CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuRead"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuDelete"
	(Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaCu"
	WHERE (("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "CuCreate"
	(Name VARCHAR2, FullNameOfResponsible VARCHAR2, EmailOfResponsible VARCHAR2, Description VARCHAR2, IsPartner NUMBER, CompanyName VARCHAR2, VATNo VARCHAR2, Phone VARCHAR2, Address VARCHAR2, PostCode VARCHAR2, City VARCHAR2, Country VARCHAR2, InvoiceAddress VARCHAR2, InvoicePostCode VARCHAR2, InvoiceCity VARCHAR2, InvoiceCountry VARCHAR2, IsPaymentAccepted NUMBER, LastPaymentDate TIMESTAMP, Partner_Name VARCHAR2, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaCu.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaCu"
	("Name", "FullNameOfResponsible", "EmailOfResponsible", "Description", "IsPartner", "CompanyName", "VATNo", "Phone", "Address", "PostCode", "City", "Country", "InvoiceAddress", "InvoicePostCode", "InvoiceCity", "InvoiceCountry", "IsPaymentAccepted", "LastPaymentDate", "Partner_Name", "Owner_Name")
	VALUES (Name, FullNameOfResponsible, EmailOfResponsible, Description, IsPartner, CompanyName, VATNo, Phone, Address, PostCode, City, Country, InvoiceAddress, InvoicePostCode, InvoiceCity, InvoiceCountry, IsPaymentAccepted, LastPaymentDate, Partner_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuUpdate"
	(Name VARCHAR2, FullNameOfResponsible VARCHAR2, EmailOfResponsible VARCHAR2, Description VARCHAR2, IsPartner NUMBER, CompanyName VARCHAR2, VATNo VARCHAR2, Phone VARCHAR2, Address VARCHAR2, PostCode VARCHAR2, City VARCHAR2, Country VARCHAR2, InvoiceAddress VARCHAR2, InvoicePostCode VARCHAR2, InvoiceCity VARCHAR2, InvoiceCountry VARCHAR2, IsPaymentAccepted NUMBER, LastPaymentDate TIMESTAMP, PartnerHasChanged NUMBER, Partner_Name VARCHAR2, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaCu"
	SET "Name" = Name, "FullNameOfResponsible" = FullNameOfResponsible, "EmailOfResponsible" = EmailOfResponsible, "Description" = Description, "IsPartner" = IsPartner, "CompanyName" = CompanyName, "VATNo" = VATNo, "Phone" = Phone, "Address" = Address, "PostCode" = PostCode, "City" = City, "Country" = Country, "InvoiceAddress" = InvoiceAddress, "InvoicePostCode" = InvoicePostCode, "InvoiceCity" = InvoiceCity, "InvoiceCountry" = InvoiceCountry, "IsPaymentAccepted" = IsPaymentAccepted, "LastPaymentDate" = LastPaymentDate
	WHERE (("Name" = Name));
	
	IF (PartnerHasChanged = 1) THEN
		UPDATE "SePaCu"
		SET "Partner_Name" = Partner_Name
		WHERE (("Name" = Name));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaCu"
		SET "Owner_Name" = Owner_Name
		WHERE (("Name" = Name));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "CuSeByNaAnPa"
	(Name CLOB, IsPartner NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPartner" LIKE IsPartner 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaPaged"
	(Name CLOB, IsPartner NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPartner" LIKE IsPartner 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaCount"
	(Name CLOB, IsPartner NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPartner" LIKE IsPartner ;
END
/


CREATE OR REPLACE PROCEDURE "CuSeByNa"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaPaged"
	(Name CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaCount"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCu"
	WHERE "Name" LIKE Name ;
END
/


CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaPa"
	(Name CLOB, IsPaymentAccepted NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPaymentAccepted" = IsPaymentAccepted 
	ORDER BY "LastPaymentDate" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaPaPaged"
	(Name CLOB, IsPaymentAccepted NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPaymentAccepted" = IsPaymentAccepted 
	ORDER BY "LastPaymentDate" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaPaCount"
	(Name CLOB, IsPaymentAccepted NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCu"
	WHERE "Name" LIKE Name AND "IsPaymentAccepted" = IsPaymentAccepted ;
END
/


/** Services.Packages.CustomerUserEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuUsEnRead"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnDelete"
	(Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaCuUsEn"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnCreate"
	(UserLogin_Name VARCHAR2, Customer_Name VARCHAR2, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaCuUsEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaCuUsEn"
	("Id", "UserLogin_Name", "Customer_Name", "Owner_Name")
	VALUES (n, UserLogin_Name, Customer_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn"
	WHERE ("Id" = n);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnUpdate"
	(Id NUMBER, UserLoginHasChanged NUMBER, UserLogin_Name VARCHAR2, CustomerHasChanged NUMBER, Customer_Name VARCHAR2, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	IF (UserLoginHasChanged = 1) THEN
		UPDATE "SePaCuUsEn"
		SET "UserLogin_Name" = UserLogin_Name
		WHERE (("Id" = Id));
	END IF;
	
	IF (CustomerHasChanged = 1) THEN
		UPDATE "SePaCuUsEn"
		SET "Customer_Name" = Customer_Name
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaCuUsEn"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



/** Services.Packages.Purchase CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuRead"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPu"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuDelete"
	(Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaPu"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuCreate"
	(CreationDate TIMESTAMP, ApiKey_Id CHAR, Client_Name VARCHAR2, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaPu.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaPu"
	("Id", "CreationDate", "ApiKey_Id", "Client_Name", "Owner_Name")
	VALUES (n, CreationDate, ApiKey_Id, Client_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaPu"
	WHERE ("Id" = n);
END;
/


CREATE OR REPLACE PROCEDURE "PuUpdate"
	(Id NUMBER, CreationDate TIMESTAMP, ApiKeyHasChanged NUMBER, ApiKey_Id CHAR, ClientHasChanged NUMBER, Client_Name VARCHAR2, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaPu"
	SET "CreationDate" = CreationDate
	WHERE (("Id" = Id));
	
	IF (ApiKeyHasChanged = 1) THEN
		UPDATE "SePaPu"
		SET "ApiKey_Id" = ApiKey_Id
		WHERE (("Id" = Id));
	END IF;
	
	IF (ClientHasChanged = 1) THEN
		UPDATE "SePaPu"
		SET "Client_Name" = Client_Name
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaPu"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "PuGeAl"
	(dummy CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPu"
	
	;
END;
/

CREATE OR REPLACE PROCEDURE "PuGeAlPaged"
	(dummy CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPu"
	
	;
END;
/

CREATE OR REPLACE PROCEDURE "PuGeAlCount"
	(dummy CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPu"
	;
END
/


/** Services.Packages.PurchaseLine CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuLiRead"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi"
	WHERE ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiDelete"
	(Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaPuLi"
	WHERE (("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuLiCreate"
	(ProductKey VARCHAR2, ProductDescription CLOB, PricePurchased FLOAT, RecurrentFeePurchased FLOAT, IsPaid NUMBER, PurchaseOrder_Id NUMBER, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaPuLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaPuLi"
	("Id", "ProductKey", "ProductDescription", "PricePurchased", "RecurrentFeePurchased", "IsPaid", "PurchaseOrder_Id", "Owner_Name")
	VALUES (n, ProductKey, ProductDescription, PricePurchased, RecurrentFeePurchased, IsPaid, PurchaseOrder_Id, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi"
	WHERE ("Id" = n);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiUpdate"
	(Id NUMBER, ProductKey VARCHAR2, ProductDescription CLOB, PricePurchased FLOAT, RecurrentFeePurchased FLOAT, IsPaid NUMBER, PurchaseOrderHasChanged NUMBER, PurchaseOrder_Id NUMBER, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaPuLi"
	SET "ProductKey" = ProductKey, "ProductDescription" = ProductDescription, "PricePurchased" = PricePurchased, "RecurrentFeePurchased" = RecurrentFeePurchased, "IsPaid" = IsPaid
	WHERE (("Id" = Id));
	
	IF (PurchaseOrderHasChanged = 1) THEN
		UPDATE "SePaPuLi"
		SET "PurchaseOrder_Id" = PurchaseOrder_Id
		WHERE (("Id" = Id));
	END IF;
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaPuLi"
		SET "Owner_Name" = Owner_Name
		WHERE (("Id" = Id));
	END IF;
END;
/



/** Services.Packages.Security.ModelUser CRUD sp's **/

CREATE OR REPLACE PROCEDURE "MoUsRead"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsDelete"
	(Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeMoUs"
	WHERE (("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "MoUsCreate"
	(Name VARCHAR2, PasswordHash VARCHAR2, Email VARCHAR2, Enabled NUMBER, SecretQuestion VARCHAR2, SecretAnswer VARCHAR2, Owner_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeMoUs.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeMoUs"
	("Name", "PasswordHash", "Email", "Enabled", "SecretQuestion", "SecretAnswer", "Owner_Name")
	VALUES (Name, PasswordHash, Email, Enabled, SecretQuestion, SecretAnswer, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsUpdate"
	(Name VARCHAR2, PasswordHash VARCHAR2, Email VARCHAR2, Enabled NUMBER, SecretQuestion VARCHAR2, SecretAnswer VARCHAR2, OwnerHasChanged NUMBER, Owner_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaSeMoUs"
	SET "Name" = Name, "PasswordHash" = PasswordHash, "Email" = Email, "Enabled" = Enabled, "SecretQuestion" = SecretQuestion, "SecretAnswer" = SecretAnswer
	WHERE (("Name" = Name));
	
	IF (OwnerHasChanged = 1) THEN
		UPDATE "SePaSeMoUs"
		SET "Owner_Name" = Owner_Name
		WHERE (("Name" = Name));
	END IF;
END;
/



CREATE OR REPLACE PROCEDURE "MoUsSeByNa"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeByNaPaged"
	(Name CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeByNaCount"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUs"
	WHERE "Name" LIKE Name ;
END
/


CREATE OR REPLACE PROCEDURE "MoUsSeByEm"
	(Email CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email 
	ORDER BY "Email" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeByEmPaged"
	(Email CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email 
	ORDER BY "Email" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeByEmCount"
	(Email CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email ;
END
/


CREATE OR REPLACE PROCEDURE "MoUsSeEnByNaAnEm"
	(Name CLOB, Email CLOB, Enabled NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email AND "Name" LIKE Name AND "Enabled" = Enabled 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeEnByNaAnEmPaged"
	(Name CLOB, Email CLOB, Enabled NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email AND "Name" LIKE Name AND "Enabled" = Enabled 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsSeEnByNaAnEmCount"
	(Name CLOB, Email CLOB, Enabled NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUs"
	WHERE "Email" LIKE Email AND "Name" LIKE Name AND "Enabled" = Enabled ;
END
/


/** Services.Packages.Security.ModelSession CRUD sp's **/

CREATE OR REPLACE PROCEDURE "MoSeRead"
	(SessionToken VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoSe"
	WHERE ("SessionToken" = SessionToken);
END;
/


CREATE OR REPLACE PROCEDURE "MoSeDelete"
	(SessionToken VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeMoSe"
	WHERE (("SessionToken" = SessionToken));
END;
/


CREATE OR REPLACE PROCEDURE "MoSeCreate"
	(SessionToken VARCHAR2, TimeIssued TIMESTAMP, TimeIssuedFor NUMBER, User_Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeMoSe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeMoSe"
	("SessionToken", "TimeIssued", "TimeIssuedFor", "User_Name")
	VALUES (SessionToken, TimeIssued, TimeIssuedFor, User_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoSe"
	WHERE ("SessionToken" = SessionToken);
END;
/


CREATE OR REPLACE PROCEDURE "MoSeUpdate"
	(SessionToken VARCHAR2, TimeIssued TIMESTAMP, TimeIssuedFor NUMBER, UserHasChanged NUMBER, User_Name VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaSeMoSe"
	SET "SessionToken" = SessionToken, "TimeIssued" = TimeIssued, "TimeIssuedFor" = TimeIssuedFor
	WHERE (("SessionToken" = SessionToken));
	
	IF (UserHasChanged = 1) THEN
		UPDATE "SePaSeMoSe"
		SET "User_Name" = User_Name
		WHERE (("SessionToken" = SessionToken));
	END IF;
END;
/



/** Services.Packages.Security.ModelUserRights CRUD sp's **/

CREATE OR REPLACE PROCEDURE "MoUsRiRead"
	(Name VARCHAR2, UserName VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi"
	WHERE ("Name" = Name) AND ("UserName" = UserName);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsRiDelete"
	(Name VARCHAR2, UserName VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeMoUsRi"
	WHERE (("Name" = Name) AND ("UserName" = UserName));
END;
/


CREATE OR REPLACE PROCEDURE "MoUsRiCreate"
	(Name VARCHAR2, UserName VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeMoUsRi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeMoUsRi"
	("Name", "UserName")
	VALUES (Name, UserName);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi"
	WHERE ("Name" = Name) AND ("UserName" = UserName);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsRiUpdate"
	(Name VARCHAR2, UserName VARCHAR2, UserHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeMoUsRi"
	SET "Name" = Name, "UserName" = UserName
	WHERE (("Name" = Name) AND ("UserName" = UserName));
END;
/



CREATE OR REPLACE PROCEDURE "MoUsRiGeByNa"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsRiGeByNaPaged"
	(Name CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi"
	WHERE "Name" LIKE Name 
	ORDER BY "Name" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "MoUsRiGeByNaCount"
	(Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUsRi"
	WHERE "Name" LIKE Name ;
END
/


/** Services.Packages.Security.Securable CRUD sp's **/

CREATE OR REPLACE PROCEDURE "SeRead"
	(Type VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSe"
	WHERE ("Type" = Type);
END;
/


CREATE OR REPLACE PROCEDURE "SeDelete"
	(Type VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeSe"
	WHERE (("Type" = Type));
END;
/


CREATE OR REPLACE PROCEDURE "SeCreate"
	(Type VARCHAR2, Enabled NUMBER, TimeSessionIsIssued NUMBER, AllowAnonymousAccess NUMBER, GenerationPasswordLength NUMBER, IPsMustBePreregistered NUMBER, AllowedIPFailures NUMBER, IPFailureTimeDenying NUMBER, DisableIPFiltering NUMBER, SessionsPerIPAllowed NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeSe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeSe"
	("Type", "Enabled", "TimeSessionIsIssued", "AllowAnonymousAccess", "GenerationPasswordLength", "IPsMustBePreregistered", "AllowedIPFailures", "IPFailureTimeDenying", "DisableIPFiltering", "SessionsPerIPAllowed")
	VALUES (Type, Enabled, TimeSessionIsIssued, AllowAnonymousAccess, GenerationPasswordLength, IPsMustBePreregistered, AllowedIPFailures, IPFailureTimeDenying, DisableIPFiltering, SessionsPerIPAllowed);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeSe"
	WHERE ("Type" = Type);
END;
/


CREATE OR REPLACE PROCEDURE "SeUpdate"
	(Type VARCHAR2, Enabled NUMBER, TimeSessionIsIssued NUMBER, AllowAnonymousAccess NUMBER, GenerationPasswordLength NUMBER, IPsMustBePreregistered NUMBER, AllowedIPFailures NUMBER, IPFailureTimeDenying NUMBER, DisableIPFiltering NUMBER, SessionsPerIPAllowed NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeSe"
	SET "Type" = Type, "Enabled" = Enabled, "TimeSessionIsIssued" = TimeSessionIsIssued, "AllowAnonymousAccess" = AllowAnonymousAccess, "GenerationPasswordLength" = GenerationPasswordLength, "IPsMustBePreregistered" = IPsMustBePreregistered, "AllowedIPFailures" = AllowedIPFailures, "IPFailureTimeDenying" = IPFailureTimeDenying, "DisableIPFiltering" = DisableIPFiltering, "SessionsPerIPAllowed" = SessionsPerIPAllowed
	WHERE (("Type" = Type));
END;
/



/** Services.Packages.Security.IPRegistered CRUD sp's **/

CREATE OR REPLACE PROCEDURE "IPReRead"
	(IP VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPRe"
	WHERE ("IP" = IP);
END;
/


CREATE OR REPLACE PROCEDURE "IPReDelete"
	(IP VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeIPRe"
	WHERE (("IP" = IP));
END;
/


CREATE OR REPLACE PROCEDURE "IPReCreate"
	(IP VARCHAR2, Allowed NUMBER, Failures NUMBER, DenialIssuedUntilTime TIMESTAMP,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeIPRe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeIPRe"
	("IP", "Allowed", "Failures", "DenialIssuedUntilTime")
	VALUES (IP, Allowed, Failures, DenialIssuedUntilTime);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPRe"
	WHERE ("IP" = IP);
END;
/


CREATE OR REPLACE PROCEDURE "IPReUpdate"
	(IP VARCHAR2, Allowed NUMBER, Failures NUMBER, DenialIssuedUntilTime TIMESTAMP)
IS
BEGIN
	
	
	UPDATE "SePaSeIPRe"
	SET "IP" = IP, "Allowed" = Allowed, "Failures" = Failures, "DenialIssuedUntilTime" = DenialIssuedUntilTime
	WHERE (("IP" = IP));
END;
/



/** Services.Packages.Security.IPSessionRegistration CRUD sp's **/

CREATE OR REPLACE PROCEDURE "IPSeReRead"
	(HostName VARCHAR2, UserAgent VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe"
	WHERE ("HostName" = HostName) AND ("UserAgent" = UserAgent);
END;
/


CREATE OR REPLACE PROCEDURE "IPSeReDelete"
	(HostName VARCHAR2, UserAgent VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeIPSeRe"
	WHERE (("HostName" = HostName) AND ("UserAgent" = UserAgent));
END;
/


CREATE OR REPLACE PROCEDURE "IPSeReCreate"
	(HostName VARCHAR2, UserAgent VARCHAR2, IP_IP VARCHAR2, Session_SessionToken VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeIPSeRe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeIPSeRe"
	("HostName", "UserAgent", "IP_IP", "Session_SessionToken")
	VALUES (HostName, UserAgent, IP_IP, Session_SessionToken);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe"
	WHERE ("HostName" = HostName) AND ("UserAgent" = UserAgent);
END;
/


CREATE OR REPLACE PROCEDURE "IPSeReUpdate"
	(HostName VARCHAR2, UserAgent VARCHAR2, IPHasChanged NUMBER, IP_IP VARCHAR2, SessionHasChanged NUMBER, Session_SessionToken VARCHAR2)
IS
BEGIN
	
	
	UPDATE "SePaSeIPSeRe"
	SET "HostName" = HostName, "UserAgent" = UserAgent
	WHERE (("HostName" = HostName) AND ("UserAgent" = UserAgent));
	
	IF (IPHasChanged = 1) THEN
		UPDATE "SePaSeIPSeRe"
		SET "IP_IP" = IP_IP
		WHERE (("HostName" = HostName) AND ("UserAgent" = UserAgent));
	END IF;
	
	IF (SessionHasChanged = 1) THEN
		UPDATE "SePaSeIPSeRe"
		SET "Session_SessionToken" = Session_SessionToken
		WHERE (("HostName" = HostName) AND ("UserAgent" = UserAgent));
	END IF;
END;
/



/** Services.Packages.Security.PackageAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PaAcCoLiRead"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoLiDelete"
	(UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePaAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoLiCreate"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePaAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePaAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoLiUpdate"
	(UserName VARCHAR2, Id NUMBER, UserHasChanged NUMBER, PackageHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePaAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.PackageAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PaAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePaAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePaAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePaAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PaAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePaAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.ApiKeyAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApKeAcCoLiRead"
	(UserName VARCHAR2, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoLiDelete"
	(UserName VARCHAR2, Id CHAR)
IS
BEGIN
	DELETE FROM "SePaSeApKeAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoLiCreate"
	(UserName VARCHAR2, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeApKeAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeApKeAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoLiUpdate"
	(UserName VARCHAR2, Id CHAR, UserHasChanged NUMBER, ApiKeyHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeApKeAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.ApiKeyAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApKeAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id CHAR)
IS
BEGIN
	DELETE FROM "SePaSeApKeAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeApKeAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeApKeAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApKeAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id CHAR, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeApKeAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApExAcCoLiRead"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoLiDelete"
	(UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaLoSeApExAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoLiCreate"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaLoSeApExAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaLoSeApExAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoLiUpdate"
	(UserName VARCHAR2, Id NUMBER, UserHasChanged NUMBER, ApplicationExceptionHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaLoSeApExAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "ApExAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaLoSeApExAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaLoSeApExAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaLoSeApExAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "ApExAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaLoSeApExAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.CustomerAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuAcCoLiRead"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi"
	WHERE ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoLiDelete"
	(UserName VARCHAR2, Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeCuAcCoLi"
	WHERE (("UserName" = UserName) AND ("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoLiCreate"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeCuAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeCuAcCoLi"
	("UserName", "Name")
	VALUES (UserName, Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi"
	WHERE ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoLiUpdate"
	(UserName VARCHAR2, Name VARCHAR2, UserHasChanged NUMBER, CustomerHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeCuAcCoLi"
	SET "UserName" = UserName, "Name" = Name
	WHERE (("UserName" = UserName) AND ("Name" = Name));
END;
/



/** Services.Packages.Security.CustomerAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeCuAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeCuAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeCuAcCoEn"
	("Descriptor", "UserName", "Allow", "Name")
	VALUES (Descriptor, UserName, Allow, Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "CuAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Name VARCHAR2, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeCuAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Name" = Name
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name));
END;
/



/** Services.Packages.Security.CustomerUserEntryAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiRead"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiDelete"
	(UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSeCuUsEnAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiCreate"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeCuUsEnAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeCuUsEnAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiUpdate"
	(UserName VARCHAR2, Id NUMBER, UserHasChanged NUMBER, CustomerUserEntryHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeCuUsEnAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.CustomerUserEntryAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSeCuUsEnAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeCuUsEnAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeCuUsEnAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeCuUsEnAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.PurchaseAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuAcCoLiRead"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoLiDelete"
	(UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePuAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoLiCreate"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePuAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePuAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoLiUpdate"
	(UserName VARCHAR2, Id NUMBER, UserHasChanged NUMBER, PurchaseHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePuAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.PurchaseAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePuAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePuAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePuAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePuAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.PurchaseLineAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuLiAcCoLiRead"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoLiDelete"
	(UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePuLiAcCoLi"
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoLiCreate"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePuLiAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePuLiAcCoLi"
	("UserName", "Id")
	VALUES (UserName, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi"
	WHERE ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoLiUpdate"
	(UserName VARCHAR2, Id NUMBER, UserHasChanged NUMBER, PurchaseLineHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePuLiAcCoLi"
	SET "UserName" = UserName, "Id" = Id
	WHERE (("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.PurchaseLineAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuLiAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Id NUMBER)
IS
BEGIN
	DELETE FROM "SePaSePuLiAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSePuLiAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSePuLiAcCoEn"
	("Descriptor", "UserName", "Allow", "Id")
	VALUES (Descriptor, UserName, Allow, Id);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Id NUMBER, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSePuLiAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Id" = Id
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Id" = Id));
END;
/



/** Services.Packages.Security.Security.ModelUserAccessControlList CRUD sp's **/

CREATE OR REPLACE PROCEDURE "MoUsAcCoLiRead"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi"
	WHERE ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoLiDelete"
	(UserName VARCHAR2, Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeSeMoUsAcCoLi"
	WHERE (("UserName" = UserName) AND ("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoLiCreate"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeSeMoUsAcCoLi.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeSeMoUsAcCoLi"
	("UserName", "Name")
	VALUES (UserName, Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi"
	WHERE ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoLiUpdate"
	(UserName VARCHAR2, Name VARCHAR2, UserHasChanged NUMBER, ModelUserHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeSeMoUsAcCoLi"
	SET "UserName" = UserName, "Name" = Name
	WHERE (("UserName" = UserName) AND ("Name" = Name));
END;
/



/** Services.Packages.Security.Security.ModelUserAccessControlEntry CRUD sp's **/

CREATE OR REPLACE PROCEDURE "MoUsAcCoEnRead"
	(Descriptor VARCHAR2, UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoEnDelete"
	(Descriptor VARCHAR2, UserName VARCHAR2, Name VARCHAR2)
IS
BEGIN
	DELETE FROM "SePaSeSeMoUsAcCoEn"
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name));
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoEnCreate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaSeSeMoUsAcCoEn.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaSeSeMoUsAcCoEn"
	("Descriptor", "UserName", "Allow", "Name")
	VALUES (Descriptor, UserName, Allow, Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoEn"
	WHERE ("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name);
END;
/


CREATE OR REPLACE PROCEDURE "MoUsAcCoEnUpdate"
	(Descriptor VARCHAR2, UserName VARCHAR2, Allow NUMBER, Name VARCHAR2, ACLHasChanged NUMBER)
IS
BEGIN
	
	
	UPDATE "SePaSeSeMoUsAcCoEn"
	SET "Descriptor" = Descriptor, "UserName" = UserName, "Allow" = Allow, "Name" = Name
	WHERE (("Descriptor" = Descriptor) AND ("UserName" = UserName) AND ("Name" = Name));
END;
/



/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions CRUD sp's **/

CREATE OR REPLACE PROCEDURE "UnReOpRead"
	(EntityType VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReOp"
	WHERE ("EntityType" = EntityType);
END;
/


CREATE OR REPLACE PROCEDURE "UnReOpDelete"
	(EntityType VARCHAR2)
IS
BEGIN
	DELETE FROM "PlMoUnReSePaUnReOp"
	WHERE (("EntityType" = EntityType));
END;
/


CREATE OR REPLACE PROCEDURE "UnReOpCreate"
	(EntityType VARCHAR2, ItemsAllowed NUMBER, IsEnabled NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "PlMoUnReSePaUnReOp.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "PlMoUnReSePaUnReOp"
	("EntityType", "ItemsAllowed", "IsEnabled")
	VALUES (EntityType, ItemsAllowed, IsEnabled);
	
	OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReOp"
	WHERE ("EntityType" = EntityType);
END;
/


CREATE OR REPLACE PROCEDURE "UnReOpUpdate"
	(EntityType VARCHAR2, ItemsAllowed NUMBER, IsEnabled NUMBER)
IS
BEGIN
	
	
	UPDATE "PlMoUnReSePaUnReOp"
	SET "EntityType" = EntityType, "ItemsAllowed" = ItemsAllowed, "IsEnabled" = IsEnabled
	WHERE (("EntityType" = EntityType));
END;
/



CREATE OR REPLACE PROCEDURE "UnReOpSeByEnTy"
	(EntityType CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReOp"
	WHERE "EntityType" LIKE EntityType 
	ORDER BY "EntityType" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "UnReOpSeByEnTyPaged"
	(EntityType CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReOp"
	WHERE "EntityType" LIKE EntityType 
	ORDER BY "EntityType" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "UnReOpSeByEnTyCount"
	(EntityType CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "PlMoUnReSePaUnReOp"
	WHERE "EntityType" LIKE EntityType ;
END
/


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup CRUD sp's **/

CREATE OR REPLACE PROCEDURE "UnReGrRead"
	(Id NUMBER, UndoRedoEntityType VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReGr"
	WHERE ("Id" = Id) AND ("UndoRedoEntityType" = UndoRedoEntityType);
END;
/


CREATE OR REPLACE PROCEDURE "UnReGrDelete"
	(Id NUMBER, UndoRedoEntityType VARCHAR2)
IS
BEGIN
	DELETE FROM "PlMoUnReSePaUnReGr"
	WHERE (("Id" = Id) AND ("UndoRedoEntityType" = UndoRedoEntityType));
END;
/


CREATE OR REPLACE PROCEDURE "UnReGrCreate"
	(EntryName VARCHAR2, UndoRedoEntityType VARCHAR2, UndoRedoRecordId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "PlMoUnReSePaUnReGr.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "PlMoUnReSePaUnReGr"
	("Id", "EntryName", "UndoRedoEntityType", "UndoRedoRecordId")
	VALUES (n, EntryName, UndoRedoEntityType, UndoRedoRecordId);
	
	OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReGr"
	WHERE ("Id" = n) AND ("UndoRedoEntityType" = UndoRedoEntityType);
END;
/


CREATE OR REPLACE PROCEDURE "UnReGrUpdate"
	(Id NUMBER, EntryName VARCHAR2, UndoRedoEntityType VARCHAR2, UndoRedoRecordId NUMBER)
IS
BEGIN
	
	
	UPDATE "PlMoUnReSePaUnReGr"
	SET "EntryName" = EntryName, "UndoRedoEntityType" = UndoRedoEntityType, "UndoRedoRecordId" = UndoRedoRecordId
	WHERE (("Id" = Id) AND ("UndoRedoEntityType" = UndoRedoEntityType));
END;
/



CREATE OR REPLACE PROCEDURE "UnReGrSeByEnTy"
	(UndoRedoEntityType CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReGr"
	WHERE "UndoRedoEntityType" LIKE UndoRedoEntityType 
	ORDER BY "UndoRedoEntityType" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "UnReGrSeByEnTyPaged"
	(UndoRedoEntityType CLOB,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "PlMoUnReSePaUnReGr"
	WHERE "UndoRedoEntityType" LIKE UndoRedoEntityType 
	ORDER BY "UndoRedoEntityType" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "UnReGrSeByEnTyCount"
	(UndoRedoEntityType CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "PlMoUnReSePaUnReGr"
	WHERE "UndoRedoEntityType" LIKE UndoRedoEntityType ;
END
/


/** Services.Packages.CustomerUndoRedo CRUD sp's **/

CREATE OR REPLACE PROCEDURE "CuUnReRead"
	(UndoRedoId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE ("UndoRedoId" = UndoRedoId);
END;
/


CREATE OR REPLACE PROCEDURE "CuUnReDelete"
	(UndoRedoId NUMBER)
IS
BEGIN
	DELETE FROM "SePaCuUnRe"
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/


CREATE OR REPLACE PROCEDURE "CuUnReCreate"
	(IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Name VARCHAR2, FullNameOfResponsible VARCHAR2, EmailOfResponsible VARCHAR2, Description VARCHAR2, IsPartner NUMBER, CompanyName VARCHAR2, VATNo VARCHAR2, Phone VARCHAR2, Address VARCHAR2, PostCode VARCHAR2, City VARCHAR2, Country VARCHAR2, InvoiceAddress VARCHAR2, InvoicePostCode VARCHAR2, InvoiceCity VARCHAR2, InvoiceCountry VARCHAR2, IsPaymentAccepted NUMBER, LastPaymentDate TIMESTAMP, Partner_Name CLOB, Owner_Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaCuUnRe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaCuUnRe"
	("UndoRedoId", "IsCreatedUndoDeletes", "IsDeletedUndoCreates", "IsUpdatedUndoUpdates", "IsUndone", "Name", "FullNameOfResponsible", "EmailOfResponsible", "Description", "IsPartner", "CompanyName", "VATNo", "Phone", "Address", "PostCode", "City", "Country", "InvoiceAddress", "InvoicePostCode", "InvoiceCity", "InvoiceCountry", "IsPaymentAccepted", "LastPaymentDate", "Partner_Name", "Owner_Name")
	VALUES (n, IsCreatedUndoDeletes, IsDeletedUndoCreates, IsUpdatedUndoUpdates, IsUndone, Name, FullNameOfResponsible, EmailOfResponsible, Description, IsPartner, CompanyName, VATNo, Phone, Address, PostCode, City, Country, InvoiceAddress, InvoicePostCode, InvoiceCity, InvoiceCountry, IsPaymentAccepted, LastPaymentDate, Partner_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE ("UndoRedoId" = n);
END;
/


CREATE OR REPLACE PROCEDURE "CuUnReUpdate"
	(UndoRedoId NUMBER, IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Name VARCHAR2, FullNameOfResponsible VARCHAR2, EmailOfResponsible VARCHAR2, Description VARCHAR2, IsPartner NUMBER, CompanyName VARCHAR2, VATNo VARCHAR2, Phone VARCHAR2, Address VARCHAR2, PostCode VARCHAR2, City VARCHAR2, Country VARCHAR2, InvoiceAddress VARCHAR2, InvoicePostCode VARCHAR2, InvoiceCity VARCHAR2, InvoiceCountry VARCHAR2, IsPaymentAccepted NUMBER, LastPaymentDate TIMESTAMP, Partner_Name CLOB, Owner_Name CLOB)
IS
BEGIN
	
	
	UPDATE "SePaCuUnRe"
	SET "IsCreatedUndoDeletes" = IsCreatedUndoDeletes, "IsDeletedUndoCreates" = IsDeletedUndoCreates, "IsUpdatedUndoUpdates" = IsUpdatedUndoUpdates, "IsUndone" = IsUndone, "Name" = Name, "FullNameOfResponsible" = FullNameOfResponsible, "EmailOfResponsible" = EmailOfResponsible, "Description" = Description, "IsPartner" = IsPartner, "CompanyName" = CompanyName, "VATNo" = VATNo, "Phone" = Phone, "Address" = Address, "PostCode" = PostCode, "City" = City, "Country" = Country, "InvoiceAddress" = InvoiceAddress, "InvoicePostCode" = InvoicePostCode, "InvoiceCity" = InvoiceCity, "InvoiceCountry" = InvoiceCountry, "IsPaymentAccepted" = IsPaymentAccepted, "LastPaymentDate" = LastPaymentDate, "Partner_Name" = Partner_Name, "Owner_Name" = Owner_Name
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/



CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUn"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUnPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUnCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUnOpOr"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUnOpOrPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlFiByIsUnOpOrCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFiOpSo"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFiOpSoPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFiOpSoCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUnRe"
	;
END
/


CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFi"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFiPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "CuUnReGeAlWiNoFiCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUnRe"
	;
END
/


/** Services.Packages.PurchaseUndoRedo CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuUnReRead"
	(UndoRedoId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE ("UndoRedoId" = UndoRedoId);
END;
/


CREATE OR REPLACE PROCEDURE "PuUnReDelete"
	(UndoRedoId NUMBER)
IS
BEGIN
	DELETE FROM "SePaPuUnRe"
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/


CREATE OR REPLACE PROCEDURE "PuUnReCreate"
	(IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Id NUMBER, CreationDate TIMESTAMP, ApiKey_Id CHAR, Client_Name CLOB, Owner_Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaPuUnRe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaPuUnRe"
	("UndoRedoId", "IsCreatedUndoDeletes", "IsDeletedUndoCreates", "IsUpdatedUndoUpdates", "IsUndone", "Id", "CreationDate", "ApiKey_Id", "Client_Name", "Owner_Name")
	VALUES (n, IsCreatedUndoDeletes, IsDeletedUndoCreates, IsUpdatedUndoUpdates, IsUndone, Id, CreationDate, ApiKey_Id, Client_Name, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE ("UndoRedoId" = n);
END;
/


CREATE OR REPLACE PROCEDURE "PuUnReUpdate"
	(UndoRedoId NUMBER, IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Id NUMBER, CreationDate TIMESTAMP, ApiKey_Id CHAR, Client_Name CLOB, Owner_Name CLOB)
IS
BEGIN
	
	
	UPDATE "SePaPuUnRe"
	SET "IsCreatedUndoDeletes" = IsCreatedUndoDeletes, "IsDeletedUndoCreates" = IsDeletedUndoCreates, "IsUpdatedUndoUpdates" = IsUpdatedUndoUpdates, "IsUndone" = IsUndone, "Id" = Id, "CreationDate" = CreationDate, "ApiKey_Id" = ApiKey_Id, "Client_Name" = Client_Name, "Owner_Name" = Owner_Name
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/



CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUn"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUnPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUnCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUnOpOr"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUnOpOrPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlFiByIsUnOpOrCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFiOpSo"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFiOpSoPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFiOpSoCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuUnRe"
	;
END
/


CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFi"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFiPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuUnReGeAlWiNoFiCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuUnRe"
	;
END
/


/** Services.Packages.PurchaseLineUndoRedo CRUD sp's **/

CREATE OR REPLACE PROCEDURE "PuLiUnReRead"
	(UndoRedoId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE ("UndoRedoId" = UndoRedoId);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiUnReDelete"
	(UndoRedoId NUMBER)
IS
BEGIN
	DELETE FROM "SePaPuLiUnRe"
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/


CREATE OR REPLACE PROCEDURE "PuLiUnReCreate"
	(IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Id NUMBER, ProductKey VARCHAR2, ProductDescription CLOB, PricePurchased FLOAT, RecurrentFeePurchased FLOAT, IsPaid NUMBER, PurchaseOrder_Id NUMBER, Owner_Name CLOB,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
	n NUMBER;
BEGIN
	SELECT "SePaPuLiUnRe.Sequence".NEXTVAL INTO n FROM dual;
	
	INSERT INTO "SePaPuLiUnRe"
	("UndoRedoId", "IsCreatedUndoDeletes", "IsDeletedUndoCreates", "IsUpdatedUndoUpdates", "IsUndone", "Id", "ProductKey", "ProductDescription", "PricePurchased", "RecurrentFeePurchased", "IsPaid", "PurchaseOrder_Id", "Owner_Name")
	VALUES (n, IsCreatedUndoDeletes, IsDeletedUndoCreates, IsUpdatedUndoUpdates, IsUndone, Id, ProductKey, ProductDescription, PricePurchased, RecurrentFeePurchased, IsPaid, PurchaseOrder_Id, Owner_Name);
	
	OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE ("UndoRedoId" = n);
END;
/


CREATE OR REPLACE PROCEDURE "PuLiUnReUpdate"
	(UndoRedoId NUMBER, IsCreatedUndoDeletes NUMBER, IsDeletedUndoCreates NUMBER, IsUpdatedUndoUpdates NUMBER, IsUndone NUMBER, Id NUMBER, ProductKey VARCHAR2, ProductDescription CLOB, PricePurchased FLOAT, RecurrentFeePurchased FLOAT, IsPaid NUMBER, PurchaseOrder_Id NUMBER, Owner_Name CLOB)
IS
BEGIN
	
	
	UPDATE "SePaPuLiUnRe"
	SET "IsCreatedUndoDeletes" = IsCreatedUndoDeletes, "IsDeletedUndoCreates" = IsDeletedUndoCreates, "IsUpdatedUndoUpdates" = IsUpdatedUndoUpdates, "IsUndone" = IsUndone, "Id" = Id, "ProductKey" = ProductKey, "ProductDescription" = ProductDescription, "PricePurchased" = PricePurchased, "RecurrentFeePurchased" = RecurrentFeePurchased, "IsPaid" = IsPaid, "PurchaseOrder_Id" = PurchaseOrder_Id, "Owner_Name" = Owner_Name
	WHERE (("UndoRedoId" = UndoRedoId));
END;
/



CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUn"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUnPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUnCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUnOpOr"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUnOpOrPaged"
	(IsUndone NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone 
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlFiByIsUnOpOrCount"
	(IsUndone NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLiUnRe"
	WHERE "IsUndone" = IsUndone ;
END
/


CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFiOpSo"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFiOpSoPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	
	ORDER BY "UndoRedoId" ASC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFiOpSoCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLiUnRe"
	;
END
/


CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFi"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFiPaged"
	(dummy NUMBER,
	@PagingStart NUMBER,
	@PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS NUMBER;
	SET @total = @PagingStart + @PagingCount

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLiUnRe"
	
	ORDER BY "UndoRedoId" DESC;
END;
/

CREATE OR REPLACE PROCEDURE "PuLiUnReGeAlWiNoFiCount"
	(dummy NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLiUnRe"
	;
END
/


/** Services.Packages.Package Relations SPs **/

CREATE OR REPLACE PROCEDURE "PackageGetByApiKey"
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PackageGetByApiKeyPaged"
	(Id CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PackageGetByApiKeyCount] 
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PackageGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PackageGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PackageGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPa" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PaSeByPaNaFoApKe"
	(PackageName CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Package" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."PackageName" LIKE PackageName );
END;
/

CREATE OR REPLACE PROCEDURE "PaSeByPaNaFoApKePaged"
	(PackageName CLOB, ApKeId CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Package" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."PackageName" LIKE PackageName );
END;
/

CREATE PROCEDURE "PaSeByPaNaFoApKeCount"
	(PackageName CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Package" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."PackageName" LIKE PackageName )
END;
/

/** Services.Packages.LocalPackage Relations SPs **/


/** Services.Packages.ApiKey Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApiKeyGetByCustomer"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApiKeyGetByCustomerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApiKeyGetByCustomerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ApiKeyGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApiKeyGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApiKeyGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaApKe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApKeSeByCoInOnCu"
	(CompanyInfo CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.ApiKey" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."CustomerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."CompanyInfo" LIKE CompanyInfo );
END;
/

CREATE OR REPLACE PROCEDURE "ApKeSeByCoInOnCuPaged"
	(CompanyInfo CLOB, CuNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.ApiKey" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."CustomerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."CompanyInfo" LIKE CompanyInfo );
END;
/

CREATE PROCEDURE "ApKeSeByCoInOnCuCount"
	(CompanyInfo CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.ApiKey" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."CustomerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."CompanyInfo" LIKE CompanyInfo )
END;
/

/** Services.Packages.Log.ApplicationException Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByApiKey"
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByApiKeyPaged"
	(Id CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionGetByApiKeyCount] 
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByParentException"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."ParentException_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByParentExceptionPaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."ParentException_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionGetByParentExceptionCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."ParentException_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoApEx" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApExSeByNaOnApKe"
	(Message CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message );
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaOnApKePaged"
	(Message CLOB, ApKeId CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message );
END;
/

CREATE PROCEDURE "ApExSeByNaOnApKeCount"
	(Message CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message )
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaSoOnApKe"
	(Message CLOB, IsSolved NUMBER, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message AND a."IsSolved" = IsSolved );
END;
/

CREATE OR REPLACE PROCEDURE "ApExSeByNaSoOnApKePaged"
	(Message CLOB, IsSolved NUMBER, ApKeId CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message AND a."IsSolved" = IsSolved );
END;
/

CREATE PROCEDURE "ApExSeByNaSoOnApKeCount"
	(Message CLOB, IsSolved NUMBER, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Log.ApplicationException" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKeyId" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."Message" LIKE Message AND a."IsSolved" = IsSolved )
END;
/

/** Services.Packages.Customer Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerGetByPartner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Partner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerGetByPartnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Partner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerGetByPartnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Partner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "CustomerGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "CuSeByNaOnPa"
	(Name CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name );
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaOnPaPaged"
	(Name CLOB, CuNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name );
END;
/

CREATE PROCEDURE "CuSeByNaOnPaCount"
	(Name CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name )
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaOnPa"
	(Name CLOB, IsPaymentAccepted NUMBER, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name AND a."IsPaymentAccepted" = IsPaymentAccepted );
END;
/

CREATE OR REPLACE PROCEDURE "CuSeByNaAnPaOnPaPaged"
	(Name CLOB, IsPaymentAccepted NUMBER, CuNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name AND a."IsPaymentAccepted" = IsPaymentAccepted );
END;
/

CREATE PROCEDURE "CuSeByNaAnPaOnPaCount"
	(Name CLOB, IsPaymentAccepted NUMBER, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Customer" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."PartnerName" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name AND a."IsPaymentAccepted" = IsPaymentAccepted )
END;
/

/** Services.Packages.CustomerUserEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByUserLogin"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserLogin_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByUserLoginPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserLogin_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryGetByUserLoginCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserLogin_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByCustomer"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByCustomerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryGetByCustomerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Customer_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaCuUsEn" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



/** Services.Packages.Purchase Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseGetByApiKey"
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseGetByApiKeyPaged"
	(Id CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseGetByApiKeyCount] 
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."ApiKey_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PurchaseGetByClient"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Client_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseGetByClientPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Client_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseGetByClientCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Client_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PurchaseGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPu" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



/** Services.Packages.PurchaseLine Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseLineGetByPurchaseOrder"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."PurchaseOrder_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseLineGetByPurchaseOrderPaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."PurchaseOrder_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseLineGetByPurchaseOrderCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."PurchaseOrder_Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PurchaseLineGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseLineGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseLineGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaPuLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



/** Services.Packages.Security.ModelUser Relations SPs **/

CREATE OR REPLACE PROCEDURE "ModelUserGetByOwner"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelUserGetByOwnerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUs" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelUserGetByOwnerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUs" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Owner_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



/** Services.Packages.Security.ModelSession Relations SPs **/

CREATE OR REPLACE PROCEDURE "ModelSessionGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoSe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."User_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelSessionGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoSe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."User_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelSessionGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoSe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."User_Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



/** Services.Packages.Security.ModelUserRights Relations SPs **/

CREATE OR REPLACE PROCEDURE "ModelUserRightsGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelUserRightsGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeMoUsRi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelUserRightsGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeMoUsRi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "MoUsRiGeByNaAnUs"
	(Name CLOB, MoUsNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ModelUserRights" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name );
END;
/

CREATE OR REPLACE PROCEDURE "MoUsRiGeByNaAnUsPaged"
	(Name CLOB, MoUsNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ModelUserRights" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name );
END;
/

CREATE PROCEDURE "MoUsRiGeByNaAnUsCount"
	(Name CLOB, MoUsNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.ModelUserRights" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."Name" LIKE Name )
END;
/

/** Services.Packages.Security.Securable Relations SPs **/


/** Services.Packages.Security.IPRegistered Relations SPs **/


/** Services.Packages.Security.IPSessionRegistration Relations SPs **/

CREATE OR REPLACE PROCEDURE "IPSessionRegistrationGetByIP"
	(IP VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.IPRegistered" as b
		ON a."IP_IP" = b."IP"
	WHERE (b."IP" = IP OR (IP IS NULL AND b."IP" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "IPSessionRegistrationGetByIPPaged"
	(IP VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.IPRegistered" as b
		ON a."IP_IP" = b."IP"
	WHERE (b."IP" = IP OR (IP IS NULL AND b."IP" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [IPSessionRegistrationGetByIPCount] 
	(IP VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.IPRegistered" as b
		ON a."IP_IP" = b."IP"
	WHERE (b."IP" = IP OR (IP IS NULL AND b."IP" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "IPSessionRegistrationGetBySession"
	(SessionToken VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelSession" as b
		ON a."Session_SessionToken" = b."SessionToken"
	WHERE (b."SessionToken" = SessionToken OR (SessionToken IS NULL AND b."SessionToken" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "IPSessionRegistrationGetBySessionPaged"
	(SessionToken VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelSession" as b
		ON a."Session_SessionToken" = b."SessionToken"
	WHERE (b."SessionToken" = SessionToken OR (SessionToken IS NULL AND b."SessionToken" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [IPSessionRegistrationGetBySessionCount] 
	(SessionToken VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeIPSeRe" as a LEFT OUTER JOIN "Services.Packages.Security.ModelSession" as b
		ON a."Session_SessionToken" = b."SessionToken"
	WHERE (b."SessionToken" = SessionToken OR (SessionToken IS NULL AND b."SessionToken" IS NULL));
END;
/



/** Services.Packages.Security.PackageAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "PackageAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PackageAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PackageAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PackageAccessControlListGetByPackage"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PackageAccessControlListGetByPackagePaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PackageAccessControlListGetByPackageCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePaAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PaAcCoLiGeACLs"
	(UserName CLOB, PaId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PackageAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PaId OR (PaId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "PaAcCoLiGeACLsPaged"
	(UserName CLOB, PaId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PackageAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PaId OR (PaId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "PaAcCoLiGeACLsCount"
	(UserName CLOB, PaId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PackageAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Package" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PaId OR (PaId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.PackageAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "PackageAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PackageAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePaAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PackageAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePaAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PaAcCoEnGeEn"
	(Descriptor CLOB, PaAcCoLiUsNa VARCHAR2, PaAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PackageAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PaAcCoLiUsNa OR (PaAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PaAcCoLiId OR (PaAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "PaAcCoEnGeEnPaged"
	(Descriptor CLOB, PaAcCoLiUsNa VARCHAR2, PaAcCoLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PackageAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PaAcCoLiUsNa OR (PaAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PaAcCoLiId OR (PaAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "PaAcCoEnGeEnCount"
	(Descriptor CLOB, PaAcCoLiUsNa VARCHAR2, PaAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PackageAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PackageAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PaAcCoLiUsNa OR (PaAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PaAcCoLiId OR (PaAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.ApiKeyAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApiKeyAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlListGetByApiKey"
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlListGetByApiKeyPaged"
	(Id CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApiKeyAccessControlListGetByApiKeyCount] 
	(Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeApKeAcCoLi" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApKeAcCoLiGeACLs"
	(UserName CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ApiKeyAccessControlList" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "ApKeAcCoLiGeACLsPaged"
	(UserName CLOB, ApKeId CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ApiKeyAccessControlList" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "ApKeAcCoLiGeACLsCount"
	(UserName CLOB, ApKeId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.ApiKeyAccessControlList" as a LEFT OUTER JOIN "Services.Packages.ApiKey" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApKeId OR (ApKeId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.ApiKeyAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApiKeyAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeApKeAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApiKeyAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeApKeAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApKeAcCoEnGeEn"
	(Descriptor CLOB, ApKeAcCoLiUsNa VARCHAR2, ApKeAcCoLiId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ApiKeyAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApKeAcCoLiUsNa OR (ApKeAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApKeAcCoLiId OR (ApKeAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "ApKeAcCoEnGeEnPaged"
	(Descriptor CLOB, ApKeAcCoLiUsNa VARCHAR2, ApKeAcCoLiId CHAR,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.ApiKeyAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApKeAcCoLiUsNa OR (ApKeAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApKeAcCoLiId OR (ApKeAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "ApKeAcCoEnGeEnCount"
	(Descriptor CLOB, ApKeAcCoLiUsNa VARCHAR2, ApKeAcCoLiId CHAR,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.ApiKeyAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.ApiKeyAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApKeAcCoLiUsNa OR (ApKeAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApKeAcCoLiId OR (ApKeAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlListGetByApplicationException"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlListGetByApplicationExceptionPaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionAccessControlListGetByApplicationExceptionCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoSeApExAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApExAcCoLiGeACLs"
	(UserName CLOB, ApExId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApExId OR (ApExId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "ApExAcCoLiGeACLsPaged"
	(UserName CLOB, ApExId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApExId OR (ApExId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "ApExAcCoLiGeACLsCount"
	(UserName CLOB, ApExId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Log.ApplicationException" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = ApExId OR (ApExId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ApplicationExceptionAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaLoSeApExAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ApplicationExceptionAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaLoSeApExAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "ApExAcCoEnGeEn"
	(Descriptor CLOB, ApExAcCoLiUsNa VARCHAR2, ApExAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApExAcCoLiUsNa OR (ApExAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApExAcCoLiId OR (ApExAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "ApExAcCoEnGeEnPaged"
	(Descriptor CLOB, ApExAcCoLiUsNa VARCHAR2, ApExAcCoLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApExAcCoLiUsNa OR (ApExAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApExAcCoLiId OR (ApExAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "ApExAcCoEnGeEnCount"
	(Descriptor CLOB, ApExAcCoLiUsNa VARCHAR2, ApExAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Log.Security.ApplicationExceptionAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = ApExAcCoLiUsNa OR (ApExAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = ApExAcCoLiId OR (ApExAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.CustomerAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "CustomerAccessControlListGetByCustomer"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerAccessControlListGetByCustomerPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerAccessControlListGetByCustomerCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "CuAcCoLiGeACLs"
	(UserName CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "CuAcCoLiGeACLsPaged"
	(UserName CLOB, CuNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "CuAcCoLiGeACLsCount"
	(UserName CLOB, CuNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.CustomerAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Customer" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = CuNa OR (CuNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.CustomerAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerAccessControlEntryGetByACL"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "CuAcCoEnGeEn"
	(Descriptor CLOB, CuAcCoLiUsNa VARCHAR2, CuAcCoLiNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = CuAcCoLiUsNa OR (CuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = CuAcCoLiNa OR (CuAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "CuAcCoEnGeEnPaged"
	(Descriptor CLOB, CuAcCoLiUsNa VARCHAR2, CuAcCoLiNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = CuAcCoLiUsNa OR (CuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = CuAcCoLiNa OR (CuAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "CuAcCoEnGeEnCount"
	(Descriptor CLOB, CuAcCoLiUsNa VARCHAR2, CuAcCoLiNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.CustomerAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = CuAcCoLiUsNa OR (CuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = CuAcCoLiNa OR (CuAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.CustomerUserEntryAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlListGetByCustomerUserEntry"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlListGetByCustomerUserEntryPaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryAccessControlListGetByCustomerUserEntryCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuUsEnAcCoLi" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiGeACLs"
	(UserName CLOB, CuUsEnId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlList" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = CuUsEnId OR (CuUsEnId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "CuUsEnAcCoLiGeACLsPaged"
	(UserName CLOB, CuUsEnId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlList" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = CuUsEnId OR (CuUsEnId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "CuUsEnAcCoLiGeACLsCount"
	(UserName CLOB, CuUsEnId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlList" as a LEFT OUTER JOIN "Services.Packages.CustomerUserEntry" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = CuUsEnId OR (CuUsEnId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.CustomerUserEntryAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "CustomerUserEntryAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeCuUsEnAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [CustomerUserEntryAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeCuUsEnAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnGeEn"
	(Descriptor CLOB, CuUsEnAcCoLiUsNa VARCHAR2, CuUsEnAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = CuUsEnAcCoLiUsNa OR (CuUsEnAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = CuUsEnAcCoLiId OR (CuUsEnAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "CuUsEnAcCoEnGeEnPaged"
	(Descriptor CLOB, CuUsEnAcCoLiUsNa VARCHAR2, CuUsEnAcCoLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = CuUsEnAcCoLiUsNa OR (CuUsEnAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = CuUsEnAcCoLiId OR (CuUsEnAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "CuUsEnAcCoEnGeEnCount"
	(Descriptor CLOB, CuUsEnAcCoLiUsNa VARCHAR2, CuUsEnAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.CustomerUserEntryAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.CustomerUserEntryAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = CuUsEnAcCoLiUsNa OR (CuUsEnAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = CuUsEnAcCoLiId OR (CuUsEnAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.PurchaseAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PurchaseAccessControlListGetByPurchase"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseAccessControlListGetByPurchasePaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseAccessControlListGetByPurchaseCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PuAcCoLiGeACLs"
	(UserName CLOB, PuId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuId OR (PuId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "PuAcCoLiGeACLsPaged"
	(UserName CLOB, PuId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuId OR (PuId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "PuAcCoLiGeACLsCount"
	(UserName CLOB, PuId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PurchaseAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Purchase" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuId OR (PuId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.PurchaseAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PuAcCoEnGeEn"
	(Descriptor CLOB, PuAcCoLiUsNa VARCHAR2, PuAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuAcCoLiUsNa OR (PuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuAcCoLiId OR (PuAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "PuAcCoEnGeEnPaged"
	(Descriptor CLOB, PuAcCoLiUsNa VARCHAR2, PuAcCoLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuAcCoLiUsNa OR (PuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuAcCoLiId OR (PuAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "PuAcCoEnGeEnCount"
	(Descriptor CLOB, PuAcCoLiUsNa VARCHAR2, PuAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PurchaseAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuAcCoLiUsNa OR (PuAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuAcCoLiId OR (PuAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.PurchaseLineAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseLineAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlListGetByPurchaseLine"
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlListGetByPurchaseLinePaged"
	(Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseLineAccessControlListGetByPurchaseLineCount] 
	(Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuLiAcCoLi" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PuLiAcCoLiGeACLs"
	(UserName CLOB, PuLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseLineAccessControlList" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuLiId OR (PuLiId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "PuLiAcCoLiGeACLsPaged"
	(UserName CLOB, PuLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseLineAccessControlList" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuLiId OR (PuLiId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "PuLiAcCoLiGeACLsCount"
	(UserName CLOB, PuLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PurchaseLineAccessControlList" as a LEFT OUTER JOIN "Services.Packages.PurchaseLine" as b
		ON a."Id" = b."Id"
	WHERE (b."Id" = PuLiId OR (PuLiId IS NULL AND b."Id" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.PurchaseLineAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlEntryGetByACL"
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "PurchaseLineAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Id NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSePuLiAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [PurchaseLineAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Id NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSePuLiAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Id" = Id OR (Id IS NULL AND b."Id" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "PuLiAcCoEnGeEn"
	(Descriptor CLOB, PuLiAcCoLiUsNa VARCHAR2, PuLiAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseLineAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuLiAcCoLiUsNa OR (PuLiAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuLiAcCoLiId OR (PuLiAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "PuLiAcCoEnGeEnPaged"
	(Descriptor CLOB, PuLiAcCoLiUsNa VARCHAR2, PuLiAcCoLiId NUMBER,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.PurchaseLineAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuLiAcCoLiUsNa OR (PuLiAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuLiAcCoLiId OR (PuLiAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "PuLiAcCoEnGeEnCount"
	(Descriptor CLOB, PuLiAcCoLiUsNa VARCHAR2, PuLiAcCoLiId NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.PurchaseLineAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.PurchaseLineAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Id" = b."Id"
	WHERE (b."UserName" = PuLiAcCoLiUsNa OR (PuLiAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Id" = PuLiAcCoLiId OR (PuLiAcCoLiId IS NULL AND b."Id" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Services.Packages.Security.Security.ModelUserAccessControlList Relations SPs **/

CREATE OR REPLACE PROCEDURE "ModelUserAccessControlListGetByUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelUserAccessControlListGetByUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelUserAccessControlListGetByUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/


CREATE OR REPLACE PROCEDURE "ModelUserAccessControlListGetByModelUser"
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelUserAccessControlListGetByModelUserPaged"
	(Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelUserAccessControlListGetByModelUserCount] 
	(Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeSeMoUsAcCoLi" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."Name" = b."Name"
	WHERE (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "MoUsAcCoLiGeACLs"
	(UserName CLOB, MoUsNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.Security.ModelUserAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE OR REPLACE PROCEDURE "MoUsAcCoLiGeACLsPaged"
	(UserName CLOB, MoUsNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.Security.ModelUserAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName );
END;
/

CREATE PROCEDURE "MoUsAcCoLiGeACLsCount"
	(UserName CLOB, MoUsNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.Security.ModelUserAccessControlList" as a LEFT OUTER JOIN "Services.Packages.Security.ModelUser" as b
		ON a."UserName" = b."Name"
	WHERE (b."Name" = MoUsNa OR (MoUsNa IS NULL AND b."Name" IS NULL)) AND (a."UserName" LIKE UserName )
END;
/

/** Services.Packages.Security.Security.ModelUserAccessControlEntry Relations SPs **/

CREATE OR REPLACE PROCEDURE "ModelUserAccessControlEntryGetByACL"
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE "ModelUserAccessControlEntryGetByACLPaged"
	(UserName VARCHAR2, Name VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	--DECLARE @total AS BIGINT;
	--SET @total = @PagingStart + @PagingCount
	--SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "SePaSeSeMoUsAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/

CREATE OR REPLACE PROCEDURE [ModelUserAccessControlEntryGetByACLCount] 
	(UserName VARCHAR2, Name VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "SePaSeSeMoUsAcCoEn" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = UserName OR (UserName IS NULL AND b."UserName" IS NULL)) AND (b."Name" = Name OR (Name IS NULL AND b."Name" IS NULL));
END;
/



CREATE OR REPLACE PROCEDURE "MoUsAcCoEnGeEn"
	(Descriptor CLOB, MoUsAcCoLiUsNa VARCHAR2, MoUsAcCoLiNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.Security.ModelUserAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = MoUsAcCoLiUsNa OR (MoUsAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = MoUsAcCoLiNa OR (MoUsAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE OR REPLACE PROCEDURE "MoUsAcCoEnGeEnPaged"
	(Descriptor CLOB, MoUsAcCoLiUsNa VARCHAR2, MoUsAcCoLiNa VARCHAR2,
	_PagingStart NUMBER,
	_PagingCount NUMBER,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
IS
BEGIN
	DECLARE @total AS BIGINT;
	SET @total = @PagingStart + @PagingCount
	SET ROWCOUNT @total

    OPEN RecordSet FOR SELECT *
	FROM "Services.Packages.Security.Security.ModelUserAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = MoUsAcCoLiUsNa OR (MoUsAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = MoUsAcCoLiNa OR (MoUsAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor );
END;
/

CREATE PROCEDURE "MoUsAcCoEnGeEnCount"
	(Descriptor CLOB, MoUsAcCoLiUsNa VARCHAR2, MoUsAcCoLiNa VARCHAR2,
	RecordSet OUT PlatformCreatorTypes.RefCursor)
AS
BEGIN
    OPEN RecordSet FOR SELECT COUNT(*) AS "Count"
	FROM "Services.Packages.Security.Security.ModelUserAccessControlEntry" as a LEFT OUTER JOIN "Services.Packages.Security.Security.ModelUserAccessControlList" as b
		ON a."UserName" = b."UserName" AND a."Name" = b."Name"
	WHERE (b."UserName" = MoUsAcCoLiUsNa OR (MoUsAcCoLiUsNa IS NULL AND b."UserName" IS NULL)) AND (b."Name" = MoUsAcCoLiNa OR (MoUsAcCoLiNa IS NULL AND b."Name" IS NULL)) AND (a."Descriptor" LIKE Descriptor )
END;
/

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions Relations SPs **/


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup Relations SPs **/


/** Services.Packages.CustomerUndoRedo Relations SPs **/


/** Services.Packages.PurchaseUndoRedo Relations SPs **/


/** Services.Packages.PurchaseLineUndoRedo Relations SPs **/


