CREATE TABLE [dbo].[CharacterGMs] (
    [CharacterId] INT            NOT NULL,
    [GMId]        NVARCHAR (128) NOT NULL,
    CONSTRAINT [pk_CharGmId] PRIMARY KEY CLUSTERED ([CharacterId] ASC, [GMId] ASC),
    CONSTRAINT [fk_CharGmCharId] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Characters] ([Id]),
	CONSTRAINT [fk_CharGmGMId] FOREIGN KEY ([GMId]) REFERENCES [AspNetUsers] ([Id])
);


