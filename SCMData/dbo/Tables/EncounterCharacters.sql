CREATE TABLE [dbo].[EncounterCharacters] (
    [Id]                    INT IDENTITY (1, 1) NOT NULL,
    [CharacterId]           INT NOT NULL,
    [EncounterId]           INT NOT NULL,
    [TempBody]              INT NULL,
    [TempAgility]           INT NULL,
    [TempReaction]          INT NULL,
    [TempStrength]          INT NULL,
    [TempWillpower]         INT NULL,
    [TempLogic]             INT NULL,
    [TempIntuition]         INT NULL,
    [TempCharisma]          INT NULL,
    [TempEdge]              INT NULL,
    [TempPhysicalInitBonus] INT NULL,
    [TempAstralalInitBonus] INT NULL,
    [TempMatrixInitBonus]   INT NULL,
    [TempPhysicalDiceBonus] INT NULL,
    [TempAstralalDiceBonus] INT NULL,
    [TempMatrixDiceBonus]   INT NULL,
    [PhysicalDamage]        INT NULL,
    [StunDamage]            INT NULL,
    CONSTRAINT [pk_EncCharsId] PRIMARY KEY CLUSTERED ([CharacterId] ASC, [EncounterId] ASC, [Id] ASC),
    CONSTRAINT [fk_EncCharsCharId] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Characters] ([Id]),
    CONSTRAINT [fk_EncCharsEncId] FOREIGN KEY ([EncounterId]) REFERENCES [dbo].[Encounters] ([Id])
);


