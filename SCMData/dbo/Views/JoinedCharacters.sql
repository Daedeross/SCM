CREATE VIEW [dbo].[JoinedCharacters]
AS
SELECT
	 ec.Id
	,c.Name
	,c.OwnerId
	,c.Body
	,c.Agility
	,c.Reaction
	,c.Strength
	,c.Willpower
	,c.Logic
	,c.Intuition
	,c.Charisma
	,c.Edge
FROM [Characters] c
INNER JOIN [EncounterCharacters] ec ON ec.CharacterId = c.Id;

