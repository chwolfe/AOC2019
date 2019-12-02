USE [AOC19]
GO

/****** Object:  UserDefinedFunction [dbo].[CalcFuel]    Script Date: 12/2/2019 11:44:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[CalcFuel] 
(
	@Mass int
)
RETURNS int
AS
BEGIN
		if ((@Mass/3) - 2) <= 0 	  
			return 0
		
		return ((@Mass/3) - 2 + (dbo.CalcFuel((@Mass/3) - 2)))
END
GO


