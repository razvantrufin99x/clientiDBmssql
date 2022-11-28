CREATE TABLE [dbo].[Clienti]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nume] NCHAR(10) NULL, 
    [prenume] NCHAR(10) NULL, 
    [telefon] NCHAR(10) NULL, 
    [email] NCHAR(10) NULL, 
    [website] NCHAR(10) NULL, 
    [adresa] NCHAR(10) NULL, 
    [foto] NCHAR(10) NULL, 
    CONSTRAINT [PK_Clienti] PRIMARY KEY ([Id])
)
