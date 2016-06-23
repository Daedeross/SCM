CREATE TABLE [dbo].[Encounters]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [GMId] NVARCHAR(450) NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    [CurrentCharacterId] INT NULL, 
    CONSTRAINT [fk_Encounters_ToAspNetUsers] FOREIGN KEY ([GMId]) REFERENCES [AspNetUsers]([Id]),
	CONSTRAINT [fk_Encounters_EncCharId] FOREIGN KEY ([CurrentCharacterId]) REFERENCES [EncounterCharacters]([Id])
)

GO

CREATE INDEX [Name_Index] ON [dbo].[Encounters] ([Name])
