CREATE TABLE [dbo].[EncounterPlayers] (
    [EncounterId] INT            NOT NULL,
    [UserId]      NVARCHAR (128) NOT NULL,
    CONSTRAINT [pk_EncounterPlayersId] PRIMARY KEY CLUSTERED ([EncounterId] ASC, [UserId] ASC),
    CONSTRAINT [fk_EncPlayersEncId] FOREIGN KEY ([EncounterId]) REFERENCES [dbo].[Encounters] ([Id])
);


