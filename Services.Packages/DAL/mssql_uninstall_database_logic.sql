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

