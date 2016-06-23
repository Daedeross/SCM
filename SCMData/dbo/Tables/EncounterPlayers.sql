CREATE TABLE [dbo].[EncounterPlayers]
(
	[EncounterId] INT NOT NULL,
	[UserId] nvarchar(450) NOT NULL,

	CONSTRAINT [fk_EncPlayersUserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]),
	CONSTRAINT [fk_EncPlayersEncId] FOREIGN KEY ([EncounterId]) REFERENCES [Encounters]([Id]),
	CONSTRAINT [pk_EncounterPlayersId] PRIMARY KEY ([EncounterId], [UserId])
)
