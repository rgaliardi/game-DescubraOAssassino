﻿CREATE TABLE [dbo].[Weapons] (
    [Code]          INT        NOT NULL IDENTITY,
    [Name]          NCHAR (25) NOT NULL,
    [Description]   NVARCHAR (250) NULL,
    [Enabled]       BIT        DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Weapons_Name]
    ON [dbo].Weapons([Name] ASC);

