CREATE TABLE [dbo].[EncounterCharacters]
(
	-- Keys
	[Id] INT IDENTITY(1,1) NOT NULL UNIQUE,
	[CharacterId] INT NOT NULL,
	[EncounterId] INT NOT NULL,
	-- Attributes
	[TempBody] INT,
	[TempAgility] INT,
	[TempReaction] INT,
	[TempStrength] INT,
	[TempWillpower] INT,
	[TempLogic] INT,
	[TempIntuition] INT,
	[TempCharisma] INT,
	[TempEdge] INT,
	-- Initative
	[TempPhysicalInitBonus] INT,
	[TempAstralalInitBonus] INT,
	[TempMatrixInitBonus] INT,
	[TempPhysicalDiceBonus] INT,
	[TempAstralalDiceBonus] INT,
	[TempMatrixDiceBonus] INT,
	[InitiativeRoll] INT,

	-- Condition Monitor
	[PhysicalDamage] INT,
	[StunDamage] INT,

	CONSTRAINT [fk_EncCharsCharId] FOREIGN KEY ([CharacterId]) REFERENCES [Characters]([Id]),
	CONSTRAINT [fk_EncCharsEncId] FOREIGN KEY ([EncounterId]) REFERENCES [Encounters]([Id]),
	CONSTRAINT [pk_EncCharsId] PRIMARY KEY ([CharacterId], [EncounterId], [Id])

)
