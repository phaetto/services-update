/** Services.Packages.Package DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PaGetByApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByApKe];
GO

IF (OBJECT_ID('[dbo].[PaGetByApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByApKePaged];
GO

IF (OBJECT_ID('[dbo].[PaGetByApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByApKeCount];
GO

IF (OBJECT_ID('[dbo].[PaGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByOw];
GO

IF (OBJECT_ID('[dbo].[PaGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[PaGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[PaSeByPaNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNa];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaPaged];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaCount];
GO


IF (OBJECT_ID('[dbo].[PaSeByPaNaFoApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaFoApKe];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaFoApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaFoApKePaged];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaFoApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaFoApKeCount];
GO

/** Services.Packages.LocalPackage DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[LoPaSeByPaNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNa];
GO

IF (OBJECT_ID('[dbo].[LoPaSeByPaNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNaPaged];
GO

IF (OBJECT_ID('[dbo].[LoPaSeByPaNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNaCount];
GO


/** Services.Packages.ApiKey DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApKeGetByCu]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByCu];
GO

IF (OBJECT_ID('[dbo].[ApKeGetByCuPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByCuPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeGetByCuCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByCuCount];
GO

IF (OBJECT_ID('[dbo].[ApKeGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByOw];
GO

IF (OBJECT_ID('[dbo].[ApKeGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[ApKeSeByCoIn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoIn];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInCount];
GO


IF (OBJECT_ID('[dbo].[ApKeSeByCoInOnCu]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInOnCu];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInOnCuPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInOnCuPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInOnCuCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInOnCuCount];
GO

/** Services.Packages.Log.ApplicationException DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApExGetByApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByApKe];
GO

IF (OBJECT_ID('[dbo].[ApExGetByApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByApKePaged];
GO

IF (OBJECT_ID('[dbo].[ApExGetByApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByApKeCount];
GO

IF (OBJECT_ID('[dbo].[ApExGetByPaEx]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByPaEx];
GO

IF (OBJECT_ID('[dbo].[ApExGetByPaExPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByPaExPaged];
GO

IF (OBJECT_ID('[dbo].[ApExGetByPaExCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByPaExCount];
GO

IF (OBJECT_ID('[dbo].[ApExGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByOw];
GO

IF (OBJECT_ID('[dbo].[ApExGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[ApExGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[ApExSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNa];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSo];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoPaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoCount];
GO


IF (OBJECT_ID('[dbo].[ApExSeByNaOnApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaOnApKe];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaOnApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaOnApKePaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaOnApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaOnApKeCount];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoOnApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoOnApKe];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoOnApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoOnApKePaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoOnApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoOnApKeCount];
GO

/** Services.Packages.Customer DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuGetByPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByPa];
GO

IF (OBJECT_ID('[dbo].[CuGetByPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuGetByPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByPaCount];
GO

IF (OBJECT_ID('[dbo].[CuGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByOw];
GO

IF (OBJECT_ID('[dbo].[CuGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[CuGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[CuSeByNaAnPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaCount];
GO

IF (OBJECT_ID('[dbo].[CuSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaCount];
GO


IF (OBJECT_ID('[dbo].[CuSeByNaOnPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaOnPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaOnPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaOnPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaOnPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaOnPaCount];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaOnPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaOnPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaOnPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaOnPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaOnPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaOnPaCount];
GO

/** Services.Packages.CustomerUserEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuUsEnGetByUsLo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByUsLo];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByUsLoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByUsLoPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByUsLoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByUsLoCount];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByCu]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByCu];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByCuPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByCuPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByCuCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByCuCount];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByOw];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnGetByOwCount];
GO



/** Services.Packages.Purchase DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuGetByApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByApKe];
GO

IF (OBJECT_ID('[dbo].[PuGetByApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByApKePaged];
GO

IF (OBJECT_ID('[dbo].[PuGetByApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByApKeCount];
GO

IF (OBJECT_ID('[dbo].[PuGetByCl]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByCl];
GO

IF (OBJECT_ID('[dbo].[PuGetByClPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByClPaged];
GO

IF (OBJECT_ID('[dbo].[PuGetByClCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByClCount];
GO

IF (OBJECT_ID('[dbo].[PuGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByOw];
GO

IF (OBJECT_ID('[dbo].[PuGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[PuGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[PuGeAl]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAl];
GO

IF (OBJECT_ID('[dbo].[PuGeAlPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAlPaged];
GO

IF (OBJECT_ID('[dbo].[PuGeAlCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAlCount];
GO


/** Services.Packages.PurchaseLine DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuLiGetByPuOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByPuOr];
GO

IF (OBJECT_ID('[dbo].[PuLiGetByPuOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByPuOrPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiGetByPuOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByPuOrCount];
GO

IF (OBJECT_ID('[dbo].[PuLiGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByOw];
GO

IF (OBJECT_ID('[dbo].[PuLiGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiGetByOwCount];
GO



/** Services.Packages.Security.ModelUser DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[MoUsGetByOw]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsGetByOw];
GO

IF (OBJECT_ID('[dbo].[MoUsGetByOwPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsGetByOwPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsGetByOwCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsGetByOwCount];
GO


IF (OBJECT_ID('[dbo].[MoUsSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNa];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEm]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEm];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEmPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEmPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEmCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEmCount];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEm]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEm];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEmPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEmPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEmCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEmCount];
GO


/** Services.Packages.Security.ModelSession DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[MoSeGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeGetByUs];
GO

IF (OBJECT_ID('[dbo].[MoSeGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[MoSeGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeGetByUsCount];
GO



/** Services.Packages.Security.ModelUserRights DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[MoUsRiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGetByUs];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGetByUsCount];
GO


IF (OBJECT_ID('[dbo].[MoUsRiGeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNa];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaCount];
GO


IF (OBJECT_ID('[dbo].[MoUsRiGeByNaAnUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaAnUs];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaAnUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaAnUsPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaAnUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaAnUsCount];
GO

/** Services.Packages.Security.Securable DROP Relation SPs **/



/** Services.Packages.Security.IPRegistered DROP Relation SPs **/



/** Services.Packages.Security.IPSessionRegistration DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[IPSeReGetByIP]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetByIP];
GO

IF (OBJECT_ID('[dbo].[IPSeReGetByIPPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetByIPPaged];
GO

IF (OBJECT_ID('[dbo].[IPSeReGetByIPCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetByIPCount];
GO

IF (OBJECT_ID('[dbo].[IPSeReGetBySe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetBySe];
GO

IF (OBJECT_ID('[dbo].[IPSeReGetBySePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetBySePaged];
GO

IF (OBJECT_ID('[dbo].[IPSeReGetBySeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReGetBySeCount];
GO



/** Services.Packages.Security.PackageAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByPa];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByPaPaged];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGetByPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGetByPaCount];
GO



IF (OBJECT_ID('[dbo].[PaAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.PackageAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PaAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[PaAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnGeEnCount];
GO

/** Services.Packages.Security.ApiKeyAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByApKe]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByApKe];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByApKePaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByApKePaged];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGetByApKeCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGetByApKeCount];
GO



IF (OBJECT_ID('[dbo].[ApKeAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.ApiKeyAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApKeAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[ApKeAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnGeEnCount];
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByApEx]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByApEx];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByApExPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByApExPaged];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGetByApExCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGetByApExCount];
GO



IF (OBJECT_ID('[dbo].[ApExAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiGeACLsCount];
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[ApExAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[ApExAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnGeEnCount];
GO

/** Services.Packages.Security.CustomerAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByCu]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByCu];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByCuPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByCuPaged];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGetByCuCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGetByCuCount];
GO



IF (OBJECT_ID('[dbo].[CuAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.CustomerAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[CuAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnGeEnCount];
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByCuUsEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEn];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByCuUsEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEnPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGetByCuUsEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEnCount];
GO



IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnGeEnCount];
GO

/** Services.Packages.Security.PurchaseAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByPu]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByPu];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByPuPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByPuPaged];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGetByPuCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGetByPuCount];
GO



IF (OBJECT_ID('[dbo].[PuAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.PurchaseAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[PuAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnGeEnCount];
GO

/** Services.Packages.Security.PurchaseLineAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByPuLi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByPuLi];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByPuLiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByPuLiPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGetByPuLiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGetByPuLiCount];
GO



IF (OBJECT_ID('[dbo].[PuLiAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.PurchaseLineAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[PuLiAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[PuLiAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnGeEnCount];
GO

/** Services.Packages.Security.Security.ModelUserAccessControlList DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByUs];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByUsPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByUsCount];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByMoUs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByMoUs];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByMoUsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByMoUsPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGetByMoUsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGetByMoUsCount];
GO



IF (OBJECT_ID('[dbo].[MoUsAcCoLiGeACLs]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGeACLs];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGeACLsPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGeACLsPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiGeACLsCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiGeACLsCount];
GO

/** Services.Packages.Security.Security.ModelUserAccessControlEntry DROP Relation SPs **/

IF (OBJECT_ID('[dbo].[MoUsAcCoEnGetByACL]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGetByACL];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnGetByACLPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGetByACLPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnGetByACLCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGetByACLCount];
GO



IF (OBJECT_ID('[dbo].[MoUsAcCoEnGeEn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGeEn];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnGeEnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGeEnPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnGeEnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnGeEnCount];
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[UnReOpSeByEnTy]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTy];
GO

IF (OBJECT_ID('[dbo].[UnReOpSeByEnTyPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTyPaged];
GO

IF (OBJECT_ID('[dbo].[UnReOpSeByEnTyCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTyCount];
GO


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[UnReGrSeByEnTy]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTy];
GO

IF (OBJECT_ID('[dbo].[UnReGrSeByEnTyPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTyPaged];
GO

IF (OBJECT_ID('[dbo].[UnReGrSeByEnTyCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTyCount];
GO


/** Services.Packages.CustomerUndoRedo DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiCount];
GO


/** Services.Packages.PurchaseUndoRedo DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiCount];
GO


/** Services.Packages.PurchaseLineUndoRedo DROP Relation SPs **/


IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiCount];
GO


/** Services.Packages.Package DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PaCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaCreate];
GO

IF (OBJECT_ID('[dbo].[PaDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaDelete];
GO

IF (OBJECT_ID('[dbo].[PaRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaRead];
GO

IF (OBJECT_ID('[dbo].[PaUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaUpdate];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNa];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaPaged];
GO

IF (OBJECT_ID('[dbo].[PaSeByPaNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaSeByPaNaCount];
GO

/** Services.Packages.LocalPackage DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[LoPaCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaCreate];
GO

IF (OBJECT_ID('[dbo].[LoPaDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaDelete];
GO

IF (OBJECT_ID('[dbo].[LoPaRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaRead];
GO

IF (OBJECT_ID('[dbo].[LoPaUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaUpdate];
GO

IF (OBJECT_ID('[dbo].[LoPaSeByPaNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNa];
GO

IF (OBJECT_ID('[dbo].[LoPaSeByPaNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNaPaged];
GO

IF (OBJECT_ID('[dbo].[LoPaSeByPaNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[LoPaSeByPaNaCount];
GO

/** Services.Packages.ApiKey DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApKeCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeCreate];
GO

IF (OBJECT_ID('[dbo].[ApKeDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeDelete];
GO

IF (OBJECT_ID('[dbo].[ApKeRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeRead];
GO

IF (OBJECT_ID('[dbo].[ApKeUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeUpdate];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoIn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoIn];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInPaged];
GO

IF (OBJECT_ID('[dbo].[ApKeSeByCoInCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeSeByCoInCount];
GO

/** Services.Packages.Log.ApplicationException DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApExCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExCreate];
GO

IF (OBJECT_ID('[dbo].[ApExDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExDelete];
GO

IF (OBJECT_ID('[dbo].[ApExRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExRead];
GO

IF (OBJECT_ID('[dbo].[ApExUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExUpdate];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNa];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSo];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoPaged];
GO

IF (OBJECT_ID('[dbo].[ApExSeByNaSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExSeByNaSoCount];
GO

/** Services.Packages.Customer DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuCreate];
GO

IF (OBJECT_ID('[dbo].[CuDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuDelete];
GO

IF (OBJECT_ID('[dbo].[CuRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuRead];
GO

IF (OBJECT_ID('[dbo].[CuUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUpdate];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaCount];
GO

IF (OBJECT_ID('[dbo].[CuSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPa];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaPaged];
GO

IF (OBJECT_ID('[dbo].[CuSeByNaAnPaPaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuSeByNaAnPaPaCount];
GO

/** Services.Packages.CustomerUserEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuUsEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnCreate];
GO

IF (OBJECT_ID('[dbo].[CuUsEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnDelete];
GO

IF (OBJECT_ID('[dbo].[CuUsEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnRead];
GO

IF (OBJECT_ID('[dbo].[CuUsEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnUpdate];
GO

/** Services.Packages.Purchase DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuCreate];
GO

IF (OBJECT_ID('[dbo].[PuDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuDelete];
GO

IF (OBJECT_ID('[dbo].[PuRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuRead];
GO

IF (OBJECT_ID('[dbo].[PuUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUpdate];
GO

IF (OBJECT_ID('[dbo].[PuGeAl]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAl];
GO

IF (OBJECT_ID('[dbo].[PuGeAlPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAlPaged];
GO

IF (OBJECT_ID('[dbo].[PuGeAlCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuGeAlCount];
GO

/** Services.Packages.PurchaseLine DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiCreate];
GO

IF (OBJECT_ID('[dbo].[PuLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiDelete];
GO

IF (OBJECT_ID('[dbo].[PuLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiRead];
GO

IF (OBJECT_ID('[dbo].[PuLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUpdate];
GO

/** Services.Packages.Security.ModelUser DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[MoUsCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsCreate];
GO

IF (OBJECT_ID('[dbo].[MoUsDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsDelete];
GO

IF (OBJECT_ID('[dbo].[MoUsRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRead];
GO

IF (OBJECT_ID('[dbo].[MoUsUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsUpdate];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNa];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByNaCount];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEm]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEm];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEmPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEmPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeByEmCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeByEmCount];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEm]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEm];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEmPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEmPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsSeEnByNaAnEmCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsSeEnByNaAnEmCount];
GO

/** Services.Packages.Security.ModelSession DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[MoSeCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeCreate];
GO

IF (OBJECT_ID('[dbo].[MoSeDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeDelete];
GO

IF (OBJECT_ID('[dbo].[MoSeRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeRead];
GO

IF (OBJECT_ID('[dbo].[MoSeUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoSeUpdate];
GO

/** Services.Packages.Security.ModelUserRights DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[MoUsRiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiCreate];
GO

IF (OBJECT_ID('[dbo].[MoUsRiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiDelete];
GO

IF (OBJECT_ID('[dbo].[MoUsRiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiRead];
GO

IF (OBJECT_ID('[dbo].[MoUsRiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiUpdate];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNa]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNa];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaPaged];
GO

IF (OBJECT_ID('[dbo].[MoUsRiGeByNaCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsRiGeByNaCount];
GO

/** Services.Packages.Security.Securable DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[SeCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[SeCreate];
GO

IF (OBJECT_ID('[dbo].[SeDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[SeDelete];
GO

IF (OBJECT_ID('[dbo].[SeRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[SeRead];
GO

IF (OBJECT_ID('[dbo].[SeUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[SeUpdate];
GO

/** Services.Packages.Security.IPRegistered DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[IPReCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPReCreate];
GO

IF (OBJECT_ID('[dbo].[IPReDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPReDelete];
GO

IF (OBJECT_ID('[dbo].[IPReRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPReRead];
GO

IF (OBJECT_ID('[dbo].[IPReUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPReUpdate];
GO

/** Services.Packages.Security.IPSessionRegistration DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[IPSeReCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReCreate];
GO

IF (OBJECT_ID('[dbo].[IPSeReDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReDelete];
GO

IF (OBJECT_ID('[dbo].[IPSeReRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReRead];
GO

IF (OBJECT_ID('[dbo].[IPSeReUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[IPSeReUpdate];
GO

/** Services.Packages.Security.PackageAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PaAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[PaAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoLiUpdate];
GO

/** Services.Packages.Security.PackageAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PaAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[PaAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PaAcCoEnUpdate];
GO

/** Services.Packages.Security.ApiKeyAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApKeAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoLiUpdate];
GO

/** Services.Packages.Security.ApiKeyAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApKeAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[ApKeAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApKeAcCoEnUpdate];
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApExAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoLiUpdate];
GO

/** Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[ApExAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[ApExAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[ApExAcCoEnUpdate];
GO

/** Services.Packages.Security.CustomerAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[CuAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoLiUpdate];
GO

/** Services.Packages.Security.CustomerAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[CuAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuAcCoEnUpdate];
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoLiUpdate];
GO

/** Services.Packages.Security.CustomerUserEntryAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[CuUsEnAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUsEnAcCoEnUpdate];
GO

/** Services.Packages.Security.PurchaseAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[PuAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoLiUpdate];
GO

/** Services.Packages.Security.PurchaseAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[PuAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuAcCoEnUpdate];
GO

/** Services.Packages.Security.PurchaseLineAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuLiAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoLiUpdate];
GO

/** Services.Packages.Security.PurchaseLineAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuLiAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[PuLiAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiAcCoEnUpdate];
GO

/** Services.Packages.Security.Security.ModelUserAccessControlList DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[MoUsAcCoLiCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiCreate];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiDelete];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiRead];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoLiUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoLiUpdate];
GO

/** Services.Packages.Security.Security.ModelUserAccessControlEntry DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[MoUsAcCoEnCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnCreate];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnDelete];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnRead];
GO

IF (OBJECT_ID('[dbo].[MoUsAcCoEnUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[MoUsAcCoEnUpdate];
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[UnReOpCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpCreate];
GO

IF (OBJECT_ID('[dbo].[UnReOpDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpDelete];
GO

IF (OBJECT_ID('[dbo].[UnReOpRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpRead];
GO

IF (OBJECT_ID('[dbo].[UnReOpUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpUpdate];
GO

IF (OBJECT_ID('[dbo].[UnReOpSeByEnTy]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTy];
GO

IF (OBJECT_ID('[dbo].[UnReOpSeByEnTyPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTyPaged];
GO

IF (OBJECT_ID('[dbo].[UnReOpSeByEnTyCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReOpSeByEnTyCount];
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[UnReGrCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrCreate];
GO

IF (OBJECT_ID('[dbo].[UnReGrDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrDelete];
GO

IF (OBJECT_ID('[dbo].[UnReGrRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrRead];
GO

IF (OBJECT_ID('[dbo].[UnReGrUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrUpdate];
GO

IF (OBJECT_ID('[dbo].[UnReGrSeByEnTy]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTy];
GO

IF (OBJECT_ID('[dbo].[UnReGrSeByEnTyPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTyPaged];
GO

IF (OBJECT_ID('[dbo].[UnReGrSeByEnTyCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[UnReGrSeByEnTyCount];
GO

/** Services.Packages.CustomerUndoRedo DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[CuUnReCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReCreate];
GO

IF (OBJECT_ID('[dbo].[CuUnReDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReDelete];
GO

IF (OBJECT_ID('[dbo].[CuUnReRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReRead];
GO

IF (OBJECT_ID('[dbo].[CuUnReUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReUpdate];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[CuUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[CuUnReGeAlWiNoFiCount];
GO

/** Services.Packages.PurchaseUndoRedo DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuUnReCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReCreate];
GO

IF (OBJECT_ID('[dbo].[PuUnReDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReDelete];
GO

IF (OBJECT_ID('[dbo].[PuUnReRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReRead];
GO

IF (OBJECT_ID('[dbo].[PuUnReUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReUpdate];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[PuUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuUnReGeAlWiNoFiCount];
GO

/** Services.Packages.PurchaseLineUndoRedo DROP CRUD sp's **/
IF (OBJECT_ID('[dbo].[PuLiUnReCreate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReCreate];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReDelete]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReDelete];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReRead]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReRead];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReUpdate]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReUpdate];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUn]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUn];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOr]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOr];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOrPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlFiByIsUnOpOrCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlFiByIsUnOpOrCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSo]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSo];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSoPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiOpSoCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiOpSoCount];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFi]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFi];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiPaged]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiPaged];
GO

IF (OBJECT_ID('[dbo].[PuLiUnReGeAlWiNoFiCount]') IS NOT NULL)
	DROP PROCEDURE [dbo].[PuLiUnReGeAlWiNoFiCount];
GO

/** Create / Update Services.Packages.Package Table **/

IF (OBJECT_ID('[dbo].[SePaPa]') IS NULL)
	CREATE TABLE [dbo].[SePaPa] ( [Id] [int] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPa'AND COLUMN_NAME = 'PackageName' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPa] WITH CHECK ADD [PackageName] [nvarchar](1024) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPa'AND COLUMN_NAME = 'VersionLabel' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPa] WITH CHECK ADD [VersionLabel] [nvarchar](1024) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPa'AND COLUMN_NAME = 'UploadDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPa] WITH CHECK ADD [UploadDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPa'AND COLUMN_NAME = 'ApiKey_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPa] WITH CHECK ADD [ApiKey_Id] [uniqueidentifier] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPa'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPa] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaPa'))
	ALTER TABLE [dbo].[SePaPa] ADD CONSTRAINT [PK.SePaPa] PRIMARY KEY
		([Id] DESC);
GO


/** Create / Update Services.Packages.LocalPackage Table **/

IF (OBJECT_ID('[dbo].[SePaLoPa]') IS NULL)
	CREATE TABLE [dbo].[SePaLoPa] ( [PackageName] [nvarchar](1024) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoPa'AND COLUMN_NAME = 'Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoPa] WITH CHECK ADD [Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoPa'AND COLUMN_NAME = 'VersionLabel' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoPa] WITH CHECK ADD [VersionLabel] [nvarchar](1024) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaLoPa'))
	ALTER TABLE [dbo].[SePaLoPa] ADD CONSTRAINT [PK.SePaLoPa] PRIMARY KEY
		([PackageName] ASC);
GO


/** Create / Update Services.Packages.ApiKey Table **/

IF (OBJECT_ID('[dbo].[SePaApKe]') IS NULL)
	CREATE TABLE [dbo].[SePaApKe] ( [Id] [uniqueidentifier] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'CompanyInfo' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [CompanyInfo] [nvarchar](1024) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'IssueDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [IssueDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'FromDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [FromDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'ToDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [ToDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'IsTest' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [IsTest] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'Customer_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [Customer_Name] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaApKe'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaApKe] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaApKe'))
	ALTER TABLE [dbo].[SePaApKe] ADD CONSTRAINT [PK.SePaApKe] PRIMARY KEY
		([Id] ASC);
GO


/** Create / Update Services.Packages.Log.ApplicationException Table **/

IF (OBJECT_ID('[dbo].[SePaLoApEx]') IS NULL)
	CREATE TABLE [dbo].[SePaLoApEx] ( [Id] [int] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'Message' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [Message] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'Source' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [Source] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'StackTrace' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [StackTrace] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'Page' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [Page] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'OnDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [OnDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'IsSolved' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [IsSolved] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'ApiKey_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [ApiKey_Id] [uniqueidentifier] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'ParentException_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [ParentException_Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoApEx'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoApEx] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaLoApEx'))
	ALTER TABLE [dbo].[SePaLoApEx] ADD CONSTRAINT [PK.SePaLoApEx] PRIMARY KEY
		([Id] ASC);
GO


/** Create / Update Services.Packages.Customer Table **/

IF (OBJECT_ID('[dbo].[SePaCu]') IS NULL)
	CREATE TABLE [dbo].[SePaCu] ( [Name] [nvarchar](256) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'FullNameOfResponsible' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [FullNameOfResponsible] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'EmailOfResponsible' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [EmailOfResponsible] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Description' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Description] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'IsPartner' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [IsPartner] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'CompanyName' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [CompanyName] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'VATNo' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [VATNo] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Phone' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Phone] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Address' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Address] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'PostCode' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [PostCode] [nvarchar](64) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'City' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [City] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Country' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Country] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'InvoiceAddress' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [InvoiceAddress] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'InvoicePostCode' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [InvoicePostCode] [nvarchar](64) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'InvoiceCity' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [InvoiceCity] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'InvoiceCountry' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [InvoiceCountry] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'IsPaymentAccepted' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [IsPaymentAccepted] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'LastPaymentDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [LastPaymentDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Partner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Partner_Name] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCu'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCu] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaCu'))
	ALTER TABLE [dbo].[SePaCu] ADD CONSTRAINT [PK.SePaCu] PRIMARY KEY
		([Name] ASC);
GO


/** Create / Update Services.Packages.CustomerUserEntry Table **/

IF (OBJECT_ID('[dbo].[SePaCuUsEn]') IS NULL)
	CREATE TABLE [dbo].[SePaCuUsEn] ( [Id] [int] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUsEn'AND COLUMN_NAME = 'UserLogin_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUsEn] WITH CHECK ADD [UserLogin_Name] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUsEn'AND COLUMN_NAME = 'Customer_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUsEn] WITH CHECK ADD [Customer_Name] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUsEn'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUsEn] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaCuUsEn'))
	ALTER TABLE [dbo].[SePaCuUsEn] ADD CONSTRAINT [PK.SePaCuUsEn] PRIMARY KEY
		([Id] ASC);
GO


/** Create / Update Services.Packages.Purchase Table **/

IF (OBJECT_ID('[dbo].[SePaPu]') IS NULL)
	CREATE TABLE [dbo].[SePaPu] ( [Id] [int] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPu'AND COLUMN_NAME = 'CreationDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPu] WITH CHECK ADD [CreationDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPu'AND COLUMN_NAME = 'ApiKey_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPu] WITH CHECK ADD [ApiKey_Id] [uniqueidentifier] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPu'AND COLUMN_NAME = 'Client_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPu] WITH CHECK ADD [Client_Name] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPu'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPu] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaPu'))
	ALTER TABLE [dbo].[SePaPu] ADD CONSTRAINT [PK.SePaPu] PRIMARY KEY
		([Id] DESC);
GO


/** Create / Update Services.Packages.PurchaseLine Table **/

IF (OBJECT_ID('[dbo].[SePaPuLi]') IS NULL)
	CREATE TABLE [dbo].[SePaPuLi] ( [Id] [int] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'ProductKey' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [ProductKey] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'ProductDescription' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [ProductDescription] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'PricePurchased' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [PricePurchased] [float] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'RecurrentFeePurchased' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [RecurrentFeePurchased] [float] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'IsPaid' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [IsPaid] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'PurchaseOrder_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [PurchaseOrder_Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLi'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLi] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaPuLi'))
	ALTER TABLE [dbo].[SePaPuLi] ADD CONSTRAINT [PK.SePaPuLi] PRIMARY KEY
		([Id] ASC);
GO


/** Create / Update Services.Packages.Security.ModelUser Table **/

IF (OBJECT_ID('[dbo].[SePaSeMoUs]') IS NULL)
	CREATE TABLE [dbo].[SePaSeMoUs] ( [Name] [nvarchar](128) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'PasswordHash' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [PasswordHash] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'Email' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [Email] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'Enabled' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [Enabled] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'SecretQuestion' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [SecretQuestion] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'SecretAnswer' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [SecretAnswer] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoUs'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoUs] WITH CHECK ADD [Owner_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeMoUs'))
	ALTER TABLE [dbo].[SePaSeMoUs] ADD CONSTRAINT [PK.SePaSeMoUs] PRIMARY KEY
		([Name] ASC);
GO


/** Create / Update Services.Packages.Security.ModelSession Table **/

IF (OBJECT_ID('[dbo].[SePaSeMoSe]') IS NULL)
	CREATE TABLE [dbo].[SePaSeMoSe] ( [SessionToken] [nvarchar](384) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoSe'AND COLUMN_NAME = 'TimeIssued' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoSe] WITH CHECK ADD [TimeIssued] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoSe'AND COLUMN_NAME = 'TimeIssuedFor' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoSe] WITH CHECK ADD [TimeIssuedFor] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeMoSe'AND COLUMN_NAME = 'User_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeMoSe] WITH CHECK ADD [User_Name] [nvarchar](128) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeMoSe'))
	ALTER TABLE [dbo].[SePaSeMoSe] ADD CONSTRAINT [PK.SePaSeMoSe] PRIMARY KEY
		([SessionToken] ASC);
GO


/** Create / Update Services.Packages.Security.ModelUserRights Table **/

IF (OBJECT_ID('[dbo].[SePaSeMoUsRi]') IS NULL)
	CREATE TABLE [dbo].[SePaSeMoUsRi] ( [Name] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeMoUsRi'))
	ALTER TABLE [dbo].[SePaSeMoUsRi] ADD CONSTRAINT [PK.SePaSeMoUsRi] PRIMARY KEY
		([Name] ASC, [UserName] ASC);
GO


/** Create / Update Services.Packages.Security.Securable Table **/

IF (OBJECT_ID('[dbo].[SePaSeSe]') IS NULL)
	CREATE TABLE [dbo].[SePaSeSe] ( [Type] [nvarchar](256) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'Enabled' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [Enabled] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'TimeSessionIsIssued' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [TimeSessionIsIssued] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'AllowAnonymousAccess' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [AllowAnonymousAccess] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'GenerationPasswordLength' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [GenerationPasswordLength] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'IPsMustBePreregistered' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [IPsMustBePreregistered] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'AllowedIPFailures' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [AllowedIPFailures] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'IPFailureTimeDenying' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [IPFailureTimeDenying] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'DisableIPFiltering' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [DisableIPFiltering] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSe'AND COLUMN_NAME = 'SessionsPerIPAllowed' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSe] WITH CHECK ADD [SessionsPerIPAllowed] [int] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeSe'))
	ALTER TABLE [dbo].[SePaSeSe] ADD CONSTRAINT [PK.SePaSeSe] PRIMARY KEY
		([Type] ASC);
GO


/** Create / Update Services.Packages.Security.IPRegistered Table **/

IF (OBJECT_ID('[dbo].[SePaSeIPRe]') IS NULL)
	CREATE TABLE [dbo].[SePaSeIPRe] ( [IP] [nvarchar](64) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeIPRe'AND COLUMN_NAME = 'Allowed' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeIPRe] WITH CHECK ADD [Allowed] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeIPRe'AND COLUMN_NAME = 'Failures' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeIPRe] WITH CHECK ADD [Failures] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeIPRe'AND COLUMN_NAME = 'DenialIssuedUntilTime' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeIPRe] WITH CHECK ADD [DenialIssuedUntilTime] [datetime] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeIPRe'))
	ALTER TABLE [dbo].[SePaSeIPRe] ADD CONSTRAINT [PK.SePaSeIPRe] PRIMARY KEY
		([IP] ASC);
GO


/** Create / Update Services.Packages.Security.IPSessionRegistration Table **/

IF (OBJECT_ID('[dbo].[SePaSeIPSeRe]') IS NULL)
	CREATE TABLE [dbo].[SePaSeIPSeRe] ( [HostName] [nvarchar](128) NOT NULL, [UserAgent] [nvarchar](128) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeIPSeRe'AND COLUMN_NAME = 'IP_IP' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeIPSeRe] WITH CHECK ADD [IP_IP] [nvarchar](64) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeIPSeRe'AND COLUMN_NAME = 'Session_SessionToken' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeIPSeRe] WITH CHECK ADD [Session_SessionToken] [nvarchar](384) NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeIPSeRe'))
	ALTER TABLE [dbo].[SePaSeIPSeRe] ADD CONSTRAINT [PK.SePaSeIPSeRe] PRIMARY KEY
		([HostName] ASC, [UserAgent] ASC);
GO


/** Create / Update Services.Packages.Security.PackageAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSePaAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSePaAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePaAcCoLi'))
	ALTER TABLE [dbo].[SePaSePaAcCoLi] ADD CONSTRAINT [PK.SePaSePaAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] DESC);
GO


/** Create / Update Services.Packages.Security.PackageAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSePaAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSePaAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSePaAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSePaAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePaAcCoEn'))
	ALTER TABLE [dbo].[SePaSePaAcCoEn] ADD CONSTRAINT [PK.SePaSePaAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] DESC);
GO


/** Create / Update Services.Packages.Security.ApiKeyAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSeApKeAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSeApKeAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [uniqueidentifier] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeApKeAcCoLi'))
	ALTER TABLE [dbo].[SePaSeApKeAcCoLi] ADD CONSTRAINT [PK.SePaSeApKeAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.ApiKeyAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSeApKeAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSeApKeAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [uniqueidentifier] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeApKeAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeApKeAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeApKeAcCoEn'))
	ALTER TABLE [dbo].[SePaSeApKeAcCoEn] ADD CONSTRAINT [PK.SePaSeApKeAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Log.Security.ApplicationExceptionAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaLoSeApExAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaLoSeApExAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaLoSeApExAcCoLi'))
	ALTER TABLE [dbo].[SePaLoSeApExAcCoLi] ADD CONSTRAINT [PK.SePaLoSeApExAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaLoSeApExAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaLoSeApExAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaLoSeApExAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaLoSeApExAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaLoSeApExAcCoEn'))
	ALTER TABLE [dbo].[SePaLoSeApExAcCoEn] ADD CONSTRAINT [PK.SePaLoSeApExAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.CustomerAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSeCuAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSeCuAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Name] [nvarchar](256) NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeCuAcCoLi'))
	ALTER TABLE [dbo].[SePaSeCuAcCoLi] ADD CONSTRAINT [PK.SePaSeCuAcCoLi] PRIMARY KEY
		([UserName] ASC, [Name] ASC);
GO


/** Create / Update Services.Packages.Security.CustomerAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSeCuAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSeCuAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Name] [nvarchar](256) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeCuAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeCuAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeCuAcCoEn'))
	ALTER TABLE [dbo].[SePaSeCuAcCoEn] ADD CONSTRAINT [PK.SePaSeCuAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Name] ASC);
GO


/** Create / Update Services.Packages.Security.CustomerUserEntryAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSeCuUsEnAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSeCuUsEnAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeCuUsEnAcCoLi'))
	ALTER TABLE [dbo].[SePaSeCuUsEnAcCoLi] ADD CONSTRAINT [PK.SePaSeCuUsEnAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.CustomerUserEntryAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSeCuUsEnAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSeCuUsEnAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeCuUsEnAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeCuUsEnAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeCuUsEnAcCoEn'))
	ALTER TABLE [dbo].[SePaSeCuUsEnAcCoEn] ADD CONSTRAINT [PK.SePaSeCuUsEnAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.PurchaseAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSePuAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSePuAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePuAcCoLi'))
	ALTER TABLE [dbo].[SePaSePuAcCoLi] ADD CONSTRAINT [PK.SePaSePuAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] DESC);
GO


/** Create / Update Services.Packages.Security.PurchaseAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSePuAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSePuAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSePuAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSePuAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePuAcCoEn'))
	ALTER TABLE [dbo].[SePaSePuAcCoEn] ADD CONSTRAINT [PK.SePaSePuAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] DESC);
GO


/** Create / Update Services.Packages.Security.PurchaseLineAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSePuLiAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSePuLiAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePuLiAcCoLi'))
	ALTER TABLE [dbo].[SePaSePuLiAcCoLi] ADD CONSTRAINT [PK.SePaSePuLiAcCoLi] PRIMARY KEY
		([UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.PurchaseLineAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSePuLiAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSePuLiAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Id] [int] NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSePuLiAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSePuLiAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSePuLiAcCoEn'))
	ALTER TABLE [dbo].[SePaSePuLiAcCoEn] ADD CONSTRAINT [PK.SePaSePuLiAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Id] ASC);
GO


/** Create / Update Services.Packages.Security.Security.ModelUserAccessControlList Table **/

IF (OBJECT_ID('[dbo].[SePaSeSeMoUsAcCoLi]') IS NULL)
	CREATE TABLE [dbo].[SePaSeSeMoUsAcCoLi] ( [UserName] [nvarchar](128) NOT NULL, [Name] [nvarchar](128) NOT NULL );

GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeSeMoUsAcCoLi'))
	ALTER TABLE [dbo].[SePaSeSeMoUsAcCoLi] ADD CONSTRAINT [PK.SePaSeSeMoUsAcCoLi] PRIMARY KEY
		([UserName] ASC, [Name] ASC);
GO


/** Create / Update Services.Packages.Security.Security.ModelUserAccessControlEntry Table **/

IF (OBJECT_ID('[dbo].[SePaSeSeMoUsAcCoEn]') IS NULL)
	CREATE TABLE [dbo].[SePaSeSeMoUsAcCoEn] ( [Descriptor] [nvarchar](128) NOT NULL, [UserName] [nvarchar](128) NOT NULL, [Name] [nvarchar](128) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaSeSeMoUsAcCoEn'AND COLUMN_NAME = 'Allow' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaSeSeMoUsAcCoEn] WITH CHECK ADD [Allow] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaSeSeMoUsAcCoEn'))
	ALTER TABLE [dbo].[SePaSeSeMoUsAcCoEn] ADD CONSTRAINT [PK.SePaSeSeMoUsAcCoEn] PRIMARY KEY
		([Descriptor] ASC, [UserName] ASC, [Name] ASC);
GO


/** Create / Update Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions Table **/

IF (OBJECT_ID('[dbo].[PlMoUnReSePaUnReOp]') IS NULL)
	CREATE TABLE [dbo].[PlMoUnReSePaUnReOp] ( [EntityType] [nvarchar](128) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'PlMoUnReSePaUnReOp'AND COLUMN_NAME = 'ItemsAllowed' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReOp] WITH CHECK ADD [ItemsAllowed] [bigint] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'PlMoUnReSePaUnReOp'AND COLUMN_NAME = 'IsEnabled' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReOp] WITH CHECK ADD [IsEnabled] [bit] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'PlMoUnReSePaUnReOp'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReOp] ADD CONSTRAINT [PK.PlMoUnReSePaUnReOp] PRIMARY KEY
		([EntityType] ASC);
GO


/** Create / Update Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup Table **/

IF (OBJECT_ID('[dbo].[PlMoUnReSePaUnReGr]') IS NULL)
	CREATE TABLE [dbo].[PlMoUnReSePaUnReGr] ( [Id] [bigint] IDENTITY(1,1) NOT NULL, [UndoRedoEntityType] [nvarchar](128) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'PlMoUnReSePaUnReGr'AND COLUMN_NAME = 'EntryName' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReGr] WITH CHECK ADD [EntryName] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'PlMoUnReSePaUnReGr'AND COLUMN_NAME = 'UndoRedoRecordId' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReGr] WITH CHECK ADD [UndoRedoRecordId] [bigint] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'PlMoUnReSePaUnReGr'))
	ALTER TABLE [dbo].[PlMoUnReSePaUnReGr] ADD CONSTRAINT [PK.PlMoUnReSePaUnReGr] PRIMARY KEY
		([Id] DESC, [UndoRedoEntityType] ASC);
GO


/** Create / Update Services.Packages.CustomerUndoRedo Table **/

IF (OBJECT_ID('[dbo].[SePaCuUnRe]') IS NULL)
	CREATE TABLE [dbo].[SePaCuUnRe] ( [UndoRedoId] [bigint] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsCreatedUndoDeletes' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsCreatedUndoDeletes] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsDeletedUndoCreates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsDeletedUndoCreates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsUpdatedUndoUpdates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsUpdatedUndoUpdates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsUndone' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsUndone] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Name] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'FullNameOfResponsible' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [FullNameOfResponsible] [nvarchar](512) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'EmailOfResponsible' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [EmailOfResponsible] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Description' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Description] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsPartner' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsPartner] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'CompanyName' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [CompanyName] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'VATNo' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [VATNo] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Phone' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Phone] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Address' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Address] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'PostCode' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [PostCode] [nvarchar](64) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'City' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [City] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Country' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Country] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'InvoiceAddress' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [InvoiceAddress] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'InvoicePostCode' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [InvoicePostCode] [nvarchar](64) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'InvoiceCity' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [InvoiceCity] [nvarchar](128) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'InvoiceCountry' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [InvoiceCountry] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'IsPaymentAccepted' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [IsPaymentAccepted] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'LastPaymentDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [LastPaymentDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Partner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Partner_Name] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaCuUnRe'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaCuUnRe] WITH CHECK ADD [Owner_Name] [ntext] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaCuUnRe'))
	ALTER TABLE [dbo].[SePaCuUnRe] ADD CONSTRAINT [PK.SePaCuUnRe] PRIMARY KEY
		([UndoRedoId] DESC);
GO


/** Create / Update Services.Packages.PurchaseUndoRedo Table **/

IF (OBJECT_ID('[dbo].[SePaPuUnRe]') IS NULL)
	CREATE TABLE [dbo].[SePaPuUnRe] ( [UndoRedoId] [bigint] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'IsCreatedUndoDeletes' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [IsCreatedUndoDeletes] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'IsDeletedUndoCreates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [IsDeletedUndoCreates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'IsUpdatedUndoUpdates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [IsUpdatedUndoUpdates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'IsUndone' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [IsUndone] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'CreationDate' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [CreationDate] [datetime] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'ApiKey_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [ApiKey_Id] [uniqueidentifier] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'Client_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [Client_Name] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuUnRe'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuUnRe] WITH CHECK ADD [Owner_Name] [ntext] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaPuUnRe'))
	ALTER TABLE [dbo].[SePaPuUnRe] ADD CONSTRAINT [PK.SePaPuUnRe] PRIMARY KEY
		([UndoRedoId] DESC);
GO


/** Create / Update Services.Packages.PurchaseLineUndoRedo Table **/

IF (OBJECT_ID('[dbo].[SePaPuLiUnRe]') IS NULL)
	CREATE TABLE [dbo].[SePaPuLiUnRe] ( [UndoRedoId] [bigint] IDENTITY(1,1) NOT NULL );

GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'IsCreatedUndoDeletes' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [IsCreatedUndoDeletes] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'IsDeletedUndoCreates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [IsDeletedUndoCreates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'IsUpdatedUndoUpdates' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [IsUpdatedUndoUpdates] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'IsUndone' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [IsUndone] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'ProductKey' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [ProductKey] [nvarchar](256) NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'ProductDescription' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [ProductDescription] [ntext] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'PricePurchased' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [PricePurchased] [float] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'RecurrentFeePurchased' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [RecurrentFeePurchased] [float] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'IsPaid' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [IsPaid] [bit] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'PurchaseOrder_Id' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [PurchaseOrder_Id] [int] NULL;
GO

IF (NOT EXISTS(SELECT TOP 1 COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'SePaPuLiUnRe'AND COLUMN_NAME = 'Owner_Name' AND TABLE_SCHEMA = 'dbo'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] WITH CHECK ADD [Owner_Name] [ntext] NULL;
GO



IF (NOT EXISTS(SELECT 
		i2.COLUMN_NAME
	FROM 
		INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 
		INNER JOIN 
		INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 
		ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME
	WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' AND i1.TABLE_NAME = 'SePaPuLiUnRe'))
	ALTER TABLE [dbo].[SePaPuLiUnRe] ADD CONSTRAINT [PK.SePaPuLiUnRe] PRIMARY KEY
		([UndoRedoId] DESC);
GO


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
	FROM [dbo].[SePaPa]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaPa]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaPa]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPa]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPa]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([PackageName] LIKE @PackageName ESCAPE '\' )
	ORDER BY [UploadDate] DESC;
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
	FROM [dbo].[SePaPa]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([PackageName] LIKE @PackageName ESCAPE '\' )
	ORDER BY [UploadDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaSeByPaNaFoApKeCount] 
	@PackageName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPa]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([PackageName] LIKE @PackageName ESCAPE '\' );
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
	FROM [dbo].[SePaApKe]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
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
	FROM [dbo].[SePaApKe]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
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
	FROM [dbo].[SePaApKe]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaApKe]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaApKe]
	WHERE ([Customer_Name] = @CuNa OR (@CuNa IS NULL AND [Customer_Name] IS NULL)) AND ([CompanyInfo] LIKE @CompanyInfo ESCAPE '\' )
	ORDER BY [IssueDate] DESC;
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
	FROM [dbo].[SePaApKe]
	WHERE ([Customer_Name] = @CuNa OR (@CuNa IS NULL AND [Customer_Name] IS NULL)) AND ([CompanyInfo] LIKE @CompanyInfo ESCAPE '\' )
	ORDER BY [IssueDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeSeByCoInOnCuCount] 
	@CompanyInfo [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaApKe]
	WHERE ([Customer_Name] = @CuNa OR (@CuNa IS NULL AND [Customer_Name] IS NULL)) AND ([CompanyInfo] LIKE @CompanyInfo ESCAPE '\' );
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
	FROM [dbo].[SePaLoApEx]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE [ParentException_Id] = @Id OR (@Id IS NULL AND [ParentException_Id] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE [ParentException_Id] = @Id OR (@Id IS NULL AND [ParentException_Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExGetByPaExCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE [ParentException_Id] = @Id OR (@Id IS NULL AND [ParentException_Id] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' )
	ORDER BY [OnDate] DESC;
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
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' )
	ORDER BY [OnDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaOnApKeCount] 
	@Message [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' );
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
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved )
	ORDER BY [OnDate] DESC;
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
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved )
	ORDER BY [OnDate] DESC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExSeByNaSoOnApKeCount] 
	@Message [ntext], @IsSolved [bit], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoApEx]
	WHERE ([ApiKey_Id] = @ApKeId OR (@ApKeId IS NULL AND [ApiKey_Id] IS NULL)) AND ([Message] LIKE @Message ESCAPE '\' AND [IsSolved] = @IsSolved );
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
	FROM [dbo].[SePaCu]
	WHERE [Partner_Name] = @Name OR (@Name IS NULL AND [Partner_Name] IS NULL);
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
	FROM [dbo].[SePaCu]
	WHERE [Partner_Name] = @Name OR (@Name IS NULL AND [Partner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuGetByPaCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE [Partner_Name] = @Name OR (@Name IS NULL AND [Partner_Name] IS NULL);
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
	FROM [dbo].[SePaCu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaCu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' )
	ORDER BY [IsPaymentAccepted] DESC, [LastPaymentDate] ASC;
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
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' )
	ORDER BY [IsPaymentAccepted] DESC, [LastPaymentDate] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaOnPaCount] 
	@Name [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' );
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
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted )
	ORDER BY [LastPaymentDate] ASC;
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
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted )
	ORDER BY [LastPaymentDate] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuSeByNaAnPaOnPaCount] 
	@Name [ntext], @IsPaymentAccepted [bit], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCu]
	WHERE ([Partner_Name] = @CuNa OR (@CuNa IS NULL AND [Partner_Name] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' AND [IsPaymentAccepted] = @IsPaymentAccepted );
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [UserLogin_Name] = @Name OR (@Name IS NULL AND [UserLogin_Name] IS NULL);
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [UserLogin_Name] = @Name OR (@Name IS NULL AND [UserLogin_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByUsLoCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn]
	WHERE [UserLogin_Name] = @Name OR (@Name IS NULL AND [UserLogin_Name] IS NULL);
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn]
	WHERE [Customer_Name] = @Name OR (@Name IS NULL AND [Customer_Name] IS NULL);
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaCuUsEn]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaCuUsEn]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu]
	WHERE [ApiKey_Id] = @Id OR (@Id IS NULL AND [ApiKey_Id] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [Client_Name] = @Name OR (@Name IS NULL AND [Client_Name] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [Client_Name] = @Name OR (@Name IS NULL AND [Client_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuGetByClCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu]
	WHERE [Client_Name] = @Name OR (@Name IS NULL AND [Client_Name] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPu]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPuLi]
	WHERE [PurchaseOrder_Id] = @Id OR (@Id IS NULL AND [PurchaseOrder_Id] IS NULL);
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
	FROM [dbo].[SePaPuLi]
	WHERE [PurchaseOrder_Id] = @Id OR (@Id IS NULL AND [PurchaseOrder_Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiGetByPuOrCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLi]
	WHERE [PurchaseOrder_Id] = @Id OR (@Id IS NULL AND [PurchaseOrder_Id] IS NULL);
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
	FROM [dbo].[SePaPuLi]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaPuLi]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaPuLi]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaSeMoUs]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaSeMoUs]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsGetByOwCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUs]
	WHERE [Owner_Name] = @Name OR (@Name IS NULL AND [Owner_Name] IS NULL);
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
	FROM [dbo].[SePaSeMoSe]
	WHERE [User_Name] = @Name OR (@Name IS NULL AND [User_Name] IS NULL);
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
	FROM [dbo].[SePaSeMoSe]
	WHERE [User_Name] = @Name OR (@Name IS NULL AND [User_Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoSeGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoSe]
	WHERE [User_Name] = @Name OR (@Name IS NULL AND [User_Name] IS NULL);
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
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUsRi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeMoUsRi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' )
	ORDER BY [Name] ASC;
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
	FROM [dbo].[SePaSeMoUsRi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' )
	ORDER BY [Name] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsRiGeByNaAnUsCount] 
	@Name [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeMoUsRi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] LIKE @Name ESCAPE '\' );
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
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [IP_IP] = @IP OR (@IP IS NULL AND [IP_IP] IS NULL);
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
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [IP_IP] = @IP OR (@IP IS NULL AND [IP_IP] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[IPSeReGetByIPCount] 
	@IP [nvarchar](64)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [IP_IP] = @IP OR (@IP IS NULL AND [IP_IP] IS NULL);
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
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [Session_SessionToken] = @SessionToken OR (@SessionToken IS NULL AND [Session_SessionToken] IS NULL);
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
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [Session_SessionToken] = @SessionToken OR (@SessionToken IS NULL AND [Session_SessionToken] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[IPSeReGetBySeCount] 
	@SessionToken [nvarchar](384)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeIPSeRe]
	WHERE [Session_SessionToken] = @SessionToken OR (@SessionToken IS NULL AND [Session_SessionToken] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGetByPaCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE ([Id] = @PaId OR (@PaId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE ([Id] = @PaId OR (@PaId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoLiGeACLsCount] 
	@UserName [ntext], @PaId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoLi]
	WHERE ([Id] = @PaId OR (@PaId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE ([UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE ([UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PaAcCoEnGeEnCount] 
	@Descriptor [ntext], @PaAcCoLiUsNa [nvarchar](128), @PaAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePaAcCoEn]
	WHERE ([UserName] = @PaAcCoLiUsNa OR (@PaAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PaAcCoLiId OR (@PaAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGetByApKeCount] 
	@Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE ([Id] = @ApKeId OR (@ApKeId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE ([Id] = @ApKeId OR (@ApKeId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoLiGeACLsCount] 
	@UserName [ntext], @ApKeId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoLi]
	WHERE ([Id] = @ApKeId OR (@ApKeId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE ([UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE ([UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApKeAcCoEnGeEnCount] 
	@Descriptor [ntext], @ApKeAcCoLiUsNa [nvarchar](128), @ApKeAcCoLiId [uniqueidentifier]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeApKeAcCoEn]
	WHERE ([UserName] = @ApKeAcCoLiUsNa OR (@ApKeAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApKeAcCoLiId OR (@ApKeAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGetByApExCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE ([Id] = @ApExId OR (@ApExId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE ([Id] = @ApExId OR (@ApExId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoLiGeACLsCount] 
	@UserName [ntext], @ApExId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoLi]
	WHERE ([Id] = @ApExId OR (@ApExId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE ([UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE ([UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[ApExAcCoEnGeEnCount] 
	@Descriptor [ntext], @ApExAcCoLiUsNa [nvarchar](128), @ApExAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaLoSeApExAcCoEn]
	WHERE ([UserName] = @ApExAcCoLiUsNa OR (@ApExAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @ApExAcCoLiId OR (@ApExAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGetByCuCount] 
	@Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE ([Name] = @CuNa OR (@CuNa IS NULL AND [Name] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE ([Name] = @CuNa OR (@CuNa IS NULL AND [Name] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoLiGeACLsCount] 
	@UserName [ntext], @CuNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoLi]
	WHERE ([Name] = @CuNa OR (@CuNa IS NULL AND [Name] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Name [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE ([UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE ([UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuAcCoEnGeEnCount] 
	@Descriptor [ntext], @CuAcCoLiUsNa [nvarchar](128), @CuAcCoLiNa [nvarchar](256)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuAcCoEn]
	WHERE ([UserName] = @CuAcCoLiUsNa OR (@CuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @CuAcCoLiNa OR (@CuAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGetByCuUsEnCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE ([Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE ([Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoLiGeACLsCount] 
	@UserName [ntext], @CuUsEnId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoLi]
	WHERE ([Id] = @CuUsEnId OR (@CuUsEnId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE ([UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE ([UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[CuUsEnAcCoEnGeEnCount] 
	@Descriptor [ntext], @CuUsEnAcCoLiUsNa [nvarchar](128), @CuUsEnAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeCuUsEnAcCoEn]
	WHERE ([UserName] = @CuUsEnAcCoLiUsNa OR (@CuUsEnAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @CuUsEnAcCoLiId OR (@CuUsEnAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGetByPuCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE ([Id] = @PuId OR (@PuId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE ([Id] = @PuId OR (@PuId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoLiGeACLsCount] 
	@UserName [ntext], @PuId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoLi]
	WHERE ([Id] = @PuId OR (@PuId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE ([UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE ([UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuAcCoEnGeEnCount] 
	@Descriptor [ntext], @PuAcCoLiUsNa [nvarchar](128), @PuAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuAcCoEn]
	WHERE ([UserName] = @PuAcCoLiUsNa OR (@PuAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuAcCoLiId OR (@PuAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGetByPuLiCount] 
	@Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE ([Id] = @PuLiId OR (@PuLiId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE ([Id] = @PuLiId OR (@PuLiId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoLiGeACLsCount] 
	@UserName [ntext], @PuLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoLi]
	WHERE ([Id] = @PuLiId OR (@PuLiId IS NULL AND [Id] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Id [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Id] = @Id OR (@Id IS NULL AND [Id] IS NULL);
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
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE ([UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE ([UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[PuLiAcCoEnGeEnCount] 
	@Descriptor [ntext], @PuLiAcCoLiUsNa [nvarchar](128), @PuLiAcCoLiId [int]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSePuLiAcCoEn]
	WHERE ([UserName] = @PuLiAcCoLiUsNa OR (@PuLiAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Id] = @PuLiAcCoLiId OR (@PuLiAcCoLiId IS NULL AND [Id] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [UserName] = @Name OR (@Name IS NULL AND [UserName] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGetByMoUsCount] 
	@Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
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
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' )
	ORDER BY [UserName] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoLiGeACLsCount] 
	@UserName [ntext], @MoUsNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoLi]
	WHERE ([UserName] = @MoUsNa OR (@MoUsNa IS NULL AND [UserName] IS NULL)) AND ([UserName] LIKE @UserName ESCAPE '\' );
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
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGetByACLCount] 
	@UserName [nvarchar](128), @Name [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE [UserName] = @UserName OR (@UserName IS NULL AND [UserName] IS NULL) AND [Name] = @Name OR (@Name IS NULL AND [Name] IS NULL);
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
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE ([UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
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
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE ([UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' )
	ORDER BY [Descriptor] ASC;
	
	SET ROWCOUNT 0
END
GO

CREATE PROCEDURE [dbo].[MoUsAcCoEnGeEnCount] 
	@Descriptor [ntext], @MoUsAcCoLiUsNa [nvarchar](128), @MoUsAcCoLiNa [nvarchar](128)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT COUNT(*) AS [Count]
	FROM [dbo].[SePaSeSeMoUsAcCoEn]
	WHERE ([UserName] = @MoUsAcCoLiUsNa OR (@MoUsAcCoLiUsNa IS NULL AND [UserName] IS NULL)) AND ([Name] = @MoUsAcCoLiNa OR (@MoUsAcCoLiNa IS NULL AND [Name] IS NULL)) AND ([Descriptor] LIKE @Descriptor ESCAPE '\' );
END
GO

/** Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions Relations SPs **/


/** Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup Relations SPs **/


/** Services.Packages.CustomerUndoRedo Relations SPs **/


/** Services.Packages.PurchaseUndoRedo Relations SPs **/


/** Services.Packages.PurchaseLineUndoRedo Relations SPs **/


