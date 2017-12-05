﻿Create Table dbo.Tracker(

	UserID	Int Identity(1,1) Not null,
	Search	nvarchar(100) Not Null,
	Stamp	DateTime not null,
	UserIP	nvarchar(128) not null,
	Browser	Nvarchar(128) not null,

	Constraint [PK_dbo.Tracker] Primary Key clustered (UserID Asc)

);
