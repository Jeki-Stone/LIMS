USE [LIMS]
GO
/****** Object:  User [test]    Script Date: 11.03.2021 19:03:03 ******/
CREATE USER [test] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[xxx]
GO
ALTER ROLE [TestG] ADD MEMBER [test]
GO
