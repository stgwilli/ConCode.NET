﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [Bio] NVARCHAR(500) NULL, 
    [PhotoUri] NVARCHAR(200) NULL, 
    [BlogUri] NVARCHAR(200) NULL, 
    [TwitterHandle] NVARCHAR(50) NULL, 
    [LinkedInUri] NVARCHAR(200) NULL, 
    [FacebookUri] NVARCHAR(200) NULL, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL, 
    [ModifiedBy] NVARCHAR(50) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [UserType] CHAR(10) NOT NULL, 
    [Tagline] NVARCHAR(200) NULL
)
