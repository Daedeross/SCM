CREATE TABLE [dbo].[Encounters] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (100) NOT NULL,
    [GMId]   NVARCHAR (128) NOT NULL,
    [Active] BIT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Encounters_Users] FOREIGN KEY ([GMId]) REFERENCES [AspNetUsers]([Id]),
);



GO

CREATE INDEX [Name_Index] ON [dbo].[Encounters] ([Name])
