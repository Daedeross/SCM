CREATE TABLE [dbo].[CharacterGMs]
(
	[CharacterId] INT NOT NULL, 
    [GMId] NVARCHAR(450) NOT NULL,

	CONSTRAINT [fk_CharGmGmId] FOREIGN KEY ([GMId]) REFERENCES [AspNetUsers]([Id]),
	CONSTRAINT [fk_CharGmCharId] FOREIGN KEY ([CharacterId]) REFERENCES [Characters]([Id]),
	CONSTRAINT [pk_CharGmId] PRIMARY KEY ([CharacterId], [GMId])
)
