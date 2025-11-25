
SET @EducatorPassword = dbo.BCrypt('seesaw', 4);
SET @StudentPassword = dbo.BCrypt('password', 4);

SET @EducatorPassword = '$2a$04$cBuXEnRq6SKHGbeHHbYXfefBIDM5z67unCErrZA5BetgSZEuUTy/G';
SET @StudentPassword = '$2a$04$5B32.2bZL9CLw6MTAbk/K.DWZ/d8VLJZ.rxgylwkixNt0sU1RWafC';

ua.Password = dbo.BCrypt(CAST(NEWID() AS VARCHAR(4000)), 4),
ua.Password = dbo.udf_GetHashedPassword(),


SELECT s.UserName, dbo.udf_GetHashedPassword(), 1 	FROM #Students s 
SELECT s.UserName, dbo.BCrypt(s.[Password], 4), 1	FROM #Students s 
	
EXEC dbo.ProvisionScalarFunction 'dbo', 'udf_GetHashedPassword'
GO

ALTER FUNCTION dbo.udf_GetHashedPassword()
RETURNS VARCHAR(255)
AS
BEGIN

DECLARE @HashedPassword VARCHAR(255)

SET @HashedPassword = (SELECT * FROM dbo.vwHashedPassword)

RETURN @HashedPassword;

END


EXEC dbo.ProvisionView 'dbo', 'vwHashedPassword'
GO
 
ALTER VIEW [dbo].[vwHashedPassword]
AS

SELECT TOP 1 HashedPassword FROM dbo.HashedPasswords
ORDER BY CHECKSUM(NEWID())


CREATE TABLE [dbo].[HashedPasswords]
(
	HashedPasswordId INTEGER NOT NULL PRIMARY KEY IDENTITY(1, 1),
	HashedPassword VARCHAR(255) NOT NULL,
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
)


SET NOCOUNT ON;
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$TwQI7105AHlQ2dDpU9mATOwhZ.YJ2sKtFTKzGUCtxlQ2kKFDSTE9O');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$83wOAOuJ5rXDnHAGMJp/VulmlKFAn0mK9n3XHnaEqwjCqXkjjmC/6');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$bFL031xQOfZwbfBERp4BeuxmwXlctkG4FKiZDi1gL1f3SvyDerLKS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$gKtbs65IYCDYC4N/gkjBXul2wz0OdSoj9QhrBqOPQWeiF9Lc6TsjO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$/mxiv9ghgCaZfjcqyU5s9e4A5KHxVlrcDOsB5AkQxD6V4dj5YDSzu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$cx1fZi.6n4LZChPj.LaDKuVY23oR4blTYrWK8byiI2Nu8kobp0iqS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$AWh3pRxtToFOh/BQ41DVzeTfwzqZwLkWeLZJ8KFxxm7o3LWWQohcK');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$covmrgqWh6jObJvCYsKwsuQ78SKtJIYc59vMHwaqaZT0Rvxp7JVb2');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$0RavWfS7mWMZi96OdUvWF.pogdQGAlZmubLJTNFQQ6A8UEuDYq6ze');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ez/4fEe040qR2U8nMhh5OOU0zgh7zMZvnqmU5In7gouW/NnzWaatO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$TvcCw0kjUgAb1oakLenAXu0uaar6Y2b.ZbwmThDL7IGTdHcHeJ3Sm');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$2heeV1ucXv6r4z6XlPDHaOwblP0Rz7Z2RKHak22tRyCEw245Wi7cu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$eBlPMcfSwCZ507QTQdjdHeX7/LceMNACBH62zGnLsVXiNxsN8PtQy');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$1S1z/CKHfY3L0e1OqvFNOePNKfg.aaQQf9mAUvWVgvxu1q4Iy.mYW');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$.foC6A38OA1furwckXJ23OtPhfXkRCGFr0cRkoNsVB1pppNsqCEi2');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$imli5WaWA/FQ4AEQ59Ksd.3Wo.bRtEUiEnCUg5P8CosuHyJYGlf8m');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$k3Fk7ePomr4GQ9APd2hIReyaFvC9xOq3d37FQJ5MfK2/s34Movezi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$I/uzWswJxXW73oUvyEY42.4tJcinua2tDkhP0xMIR1tzaY787iR8.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$YpwcpsXWJh69C/mtSySOGuxVtoSbJLt4EPvsAsh6iXN34eiSlmJ0u');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Dev2sc8MG6LPbPLtfpLfN.MvwrZARzlSV/4Vy0Z7G9jnfCiEoNHbG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$6Qoe4Jt2vh6nSL9m/t5OpeELCdV4njZw7ss5z0/y6LkGFxo7sONUi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$OrZG4IQdhQDTqoNvWeoYe.1LZxXAEawQ32wv73ikOULw.8WA7yfBi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$SNojEghpzi2hMda/5t0xKesoVY6rhrdToQ0MG7n8H4Ji2qecGqBaG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$dM2btFl/XHOiNPhk/F07L.lR7DXNUO6WAfJwn2FqLklBpefj4CJye');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$TIcoS8hs5tTEQ77EayedzO/arOXvCPVJAf08E7wLWmWMD5OdSJ/V6');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$yCcCRDzuepTCy1Y1pY8umuMsS81mP4OpEUGs2rXk/Ua97eKV99oRC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$vESMs9nEDv8x76YJxtK.c.myYn.VX3BUqeklcSC.Z0iDfOwD3pmS6');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$xOofH83YUqf8CVmQSV6AVOx2U5ijAjKY4Grt5Cgp0HchgHzQHCqEq');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$etNJzw3TFHNLcUj3kTNdEO3X2ZVjJio9365oDNsSTyW2Lm5Db17dC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$teSCq8iaeir7G0CE/K/8HOqkWYnChDAvwMyOYauPWZRlIWgtlQlvm');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$LWC60n4/x6w1pyL/IqhYFOB6rNR9nI0ex/nOCsnBXzM.KUtHyQrim');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Z8.3angkn95utiOO9E0QxeWQfmkE6lX4PJnP1cLu9CYmeUujHovuq');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$48oF39YC5H5rrWLlgHgvuuDQ3Tl9l/IkDzK5PO2WJyNlJft1/PgMC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$XLmpcVJW/z0657VIREVds.3U6JY0pNys5.kgy9.srlHDsOHLBWSz2');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ReAYqzbdNMsvSv9xph7v8ugsf/kVwP/cbqUjkNcaRiVEfjfCS9fZG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$gdVReTzHfOmmThkFZPm.WOxA/wjKatj.5qMBZLmiyGX/N/sS1hJ6i');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Bwea44cZA7DOFNaQVMNNiuuuV5QjD/3Qy96Siv7gxYmFRVTyBeIWq');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Z2UgrKIv.gS5NwPhKxSihewW5FMLog4kEao9YdAxTogKZ4BE1iLiW');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ECwj2WazK9AEJgejHT6uJu/oUTac6Sa68vGDFuOkQA8xeZvEC9lFy');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$UeQRBB3rfWb07h1zEGOt6eCXDSPSTE4str4tfbrILD0m9G6o1lah6');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$SQmZpAY/PaYbg45VWLbPYu.ig9aJSSB9cnBN5tHourGX2NNFAvajW');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$QGE.4qDx3KPO9DJ29CW9qeA4mSP0QYk5NDCiFkS5ztZdqGyff8YES');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$tnmS7LfKUL7nBD/aMgsBSese9aKptWXTiVdtAW/YHDHkuzECi/JzW');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$x/mb6rRsz7EsT8QD94ad5.aHnNfgXaRfPkhdDnpyF55bMKct5oA7y');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$LlSDCv5YorU3h.Lsyc1Yru.U/0MjABjP7ML5xDHj3mOt3notzRqee');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$VDUpZGYk6RDSPPAoZrLn0uaa3VwsxHr04aZ4pOFr6PVBl/9Bq7C4K');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$uJKXsyea0a5XQ7rsu/p9bOojTGmiy.lW3.PpWU8mVc2/7DPrBsMia');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$2kMRLGUiiA6OrqudDS3rzeWweY3lKKoWLCDhh1y9/yX7W2y.h0i9.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$MBmMRldrhSCJdxd9gMTvSuYAUgzDd7cMuUBLN/E.EZ.r5Eh4aIuAi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$hGJDWcD9iHH1BYVmoD39y.Nkm2Ub68H7KP9atve62todAI5Xd3Qb.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$sePlwNPjcwpACRK4Dtrmzuzujhtxs0H9r8FzUr8iLE96Fu1/DyVoO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$.zmBaXpIk/xEwF1LvEc9C.UzpT48H0DcCIm7WRpg0PiOaKsQ2wSpm');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ApWGlNC75HumCRtDnu0y0OPxIo.uZdpuup3Wipn7/qBgS1P0lNSxy');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Y399gTJ3fi8OfbGZB9EVbuKR7lKkoCxjKSlwz4ZpNlZurtS.3T5z.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$VcOvuqJb1P9f7RhGk/97TezubB3qeYgzx5TsMg0MAvstELzkj6nYC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$mEn9pjbQtzcduJZ4/KDc1OtdSTE6cgen6Gzgx/07.ghguhplTIaAG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Ibd/GMesZc7zFH8Z4EZHVeLSYBjWZVsYn63Nlhrx4sbPisncbOoIK');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$3FOyE1IJsHakXa3Yqe8Abe3SkTyW6zosaFlBs51LdtxQq8kUNrRbS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$.Oy62F0zcnb0yQLJBW1cfeZuVK8nGlCjtKHsdq4fcf0TodAmXniFG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Sf/1TlPysoparTFsaimvZuBbBf/y5nCsaBTBC12GwLoprSTJUmT/O');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$d7fGWw0ngAM3gM9uP5papOsSb2I8CJ35wxY21jWTgAo5hp4KCwUam');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$rVneqs8GZhsi1jG79Wie.elVblKaeJobKzP5g7QVBAyvYgmpMGzEu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$uuDxYxHtbBqJN6gMQTQDgOmp1DCQQjcyNHn.fGiNW6U9AT0Kw/WC2');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$uvzKNPqD.pRwtq/kbs8q9ORKD8UwssK0AlzG32FdPcNiaBmL5cVpu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$0YYgpc12Kvy3edC6xfemKeqAaOG8f/ZW9CgZBBbf9bwXaabuQpm52');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$SDg7UEclrfDyC8ruB2ddi.EhFR5XyoLquAMxVju9P.fBkbP05GdZm');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ACezYZuWZQ4aJ53PJYjm0O8YNqHuXIoeGehv1QX3H/.QCrSoV4nRi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$TPI0OZGU6YO3flUarX2gx.AnW/Qn8jpjDP0jrgas0dlfjNFTEGAlS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$to7V8aWbckBBDtUc2/2Nwu.ZtOiAPr8uYfvo3ZMEpZxBlcnd.wfya');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$TzmH1DyM8kVJuOeHrmDNnuGMZTTxCnNQKjMUHzWcgnr7KU7.1sspu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$PxY3bD6zcXb43XWDQk0qRu.N0Ea1S0/BTcnA30dTIvvdSDsOzj9Xu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$tUtge3A.YJoOVqLksI4DPOsIanDEFJygCD8Y6qGUieSdbcLFk7rf.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$cAmhUs3kcRPfcYahUa39f.lO9hFRObpFW3WgukMpzX.BdPhheh/RC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$gITSiizzDndg0/5pOrEaBucFVooPCDNCRLcCi58.jyqS31sVh6Gna');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$RuAVM3uj9xc.8Pj4.wlNjOOnSv8Gezpva6jbG3fbWyAG94j2rZ3tG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$hO4.WjX8hCI0R0gk3tybQOJnutNKJ0gx4AHY4HK.vdZua54N4SocG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$NuIkrGpOwT37rHx0RcnVZ.ERI6fYNsD45ywmtVPlz4E52bDQwdMOO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$B8Tf0th/o83tuGF4MoUCTOm7R6EeahDKs676I9I92jchGxqdkOj5y');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$bInoffRiGUTKpceUEIdX1e6CJxBNW3EjcAAgyLIUxiI1r06Xyxs2W');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$Q5pE.sOAJYa79xj19IMMT.lf5MrsrAWSdsYI0dLbtnV9UN0MNB2KO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$KA4fFdNvrzJUUEwVVrFao.QDUYoPOn6dRxSdOyxAN467d02MLMJg.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$A7wsrUSAn90FBFaXr3JIs.n.GnAT8ohauTvlYX5zwFS8uiqbjsBuy');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$lY.aIWd78Ky6xrGBTM8H4.o9P7GowqGGtQSrk7QEDxJRpA7wikycm');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$6LrFRAr2PLAvyJsyg3g4kudsYUewSs1ehx56EfyVZ30dP9P8iCsum');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$X.WU4LuZMq6xD2bG2yVqEuP4zm544C3migXlrS6ahzX3qUOS56tDW');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$76oijq0y8N39N4my34U.aey3ZfLgyZYSjmKrwa3htkigpQXH01TpO');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$s.J6hSLvYABk6GmBcRwo5umfUV5NgiLRKrbIoT.46TfBUtdQEmK36');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$9wsx0N7ZD2bbn/nAgJEtwO7bVbzpv.8qWjumnGF10fLnDrWpVEA76');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$W5vcwLvL0MkOShIft42MCOJuWmRk5ixf0niTUw84S.FNJ4zFgdeDS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$/eLMkYLTaaIfylv/6boo6uhE5Sc8QtbmfNXuWMYMfRey5k0OrOgR6');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$N6YUE.PmxRfY2nL6ifDgV.mHK3bWim47X6j0if8WTdbhz7qOOH3ga');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$WZCVkSdY/duo9HNiVyNa4.fIlyWEpwWa4/Vqym0u9WvCMqPr3mAHS');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$i.8dktEK165qRLazze6xMeDEFlbVGrBppH5wsQgZoMqLAswcXgTRG');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$dxKgzCFhTw5C3GNQJrWx5ujE1wVNEsmP9Z/pMVtxj2rgWqidHWqaC');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$d1O1z6X0G0S6ULb.3iAnze2GqSdeby0jpcUbHTVpXSSoMICexonYu');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$RZomRPc02jeB7TI3m5TqieOg6fdRiABdxKkxGh2qOCOeONwQ4iE0y');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$RXOybJ7/z.yBFXynFDjscO6D6ZdNrqckv0ZCyF65.m4wnb4xQqTWK');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$JkWwkQ0HSLIcBnpeMgVsOeBQNkPvDraGDzDE4MHwW40geGHVQfWF.');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$QvQEec6PpF2y.MR54X/YPO1fqtV4jJCU8lAWJH5vruH/CJPxPCHbi');
INSERT INTO dbo.HashedPasswords(HashedPassword) VALUES('$2a$04$ntM07WqCZgviLbEr4fE48OQ.SnioAPhsqn8WBQJX13fGyrRiLFW2y');


