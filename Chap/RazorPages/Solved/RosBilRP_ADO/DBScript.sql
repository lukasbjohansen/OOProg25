
DROP TABLE IF EXISTS [dbo].[Opgave];
DROP TABLE IF EXISTS [dbo].[Leje];
DROP TABLE IF EXISTS [dbo].[Kunde];
DROP TABLE IF EXISTS [dbo].[Bil];
DROP TABLE IF EXISTS [dbo].[Ansat];
GO

CREATE TABLE [dbo].[Kunde] (
    [Id]        INT           NOT NULL,
    [Navn]      NVARCHAR (50) NOT NULL,
    [Telefon]   INT           NOT NULL,
    [VIP]       BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Kunde] VALUES (1, N'Anne', 12341234, 0)
INSERT INTO [dbo].[Kunde] VALUES (2, N'Bent', 11223344, 1)
INSERT INTO [dbo].[Kunde] VALUES (3, N'Carl', 13572468, 0)
INSERT INTO [dbo].[Kunde] VALUES (4, N'Dina', 86427531, 1)
INSERT INTO [dbo].[Kunde] VALUES (5, N'Erik', 65544332, 1)


CREATE TABLE [dbo].[Bil] (
    [Id]            INT           NOT NULL,
    [Nummerplade]   NVARCHAR (50) NOT NULL,
    [Model]         NVARCHAR (50) NOT NULL,
    [PrisPrDag]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Bil] VALUES (1, N'AX 32109', N'Skoda Octavia', 450)
INSERT INTO [dbo].[Bil] VALUES (2, N'BK 88662', N'BMW 318i', 550)
INSERT INTO [dbo].[Bil] VALUES (3, N'CJ 33801', N'Hyundai IONIQ 6', 600)
INSERT INTO [dbo].[Bil] VALUES (4, N'DE 22519', N'Skoda Fabia', 380)
INSERT INTO [dbo].[Bil] VALUES (5, N'EQ 40912', N'Peugeot 208', 430)


CREATE TABLE [dbo].[Leje] (
    [Id]            INT           NOT NULL,
    [KundeId]       INT           NOT NULL,
    [BilId]         INT           NOT NULL,
    [Dato]          DATE          NOT NULL,
    [AntalDage]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_KundeId] FOREIGN KEY ([KundeId]) REFERENCES [Kunde] ([Id]),
    CONSTRAINT [FK_BilId] FOREIGN KEY ([BilId]) REFERENCES [Bil] ([Id])
);

INSERT INTO [dbo].[Leje] VALUES (1, 1, 2, '2025-02-17', 3)
INSERT INTO [dbo].[Leje] VALUES (2, 1, 4, '2025-02-22', 4)
INSERT INTO [dbo].[Leje] VALUES (3, 2, 1, '2025-03-02', 8)
INSERT INTO [dbo].[Leje] VALUES (4, 3, 2, '2025-02-04', 6)
INSERT INTO [dbo].[Leje] VALUES (5, 3, 3, '2025-02-11', 6)
INSERT INTO [dbo].[Leje] VALUES (6, 3, 1, '2025-03-18', 7)
INSERT INTO [dbo].[Leje] VALUES (7, 5, 2, '2025-03-02', 3)
INSERT INTO [dbo].[Leje] VALUES (8, 5, 4, '2025-03-21', 3)


CREATE TABLE [dbo].[Ansat] (
    [Id]        INT           NOT NULL,
    [Navn]      NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Ansat] VALUES (1, N'Zenia', N'zenia@rosbil.dk')
INSERT INTO [dbo].[Ansat] VALUES (2, N'Xavier', N'xavier@rosbil.dk')
INSERT INTO [dbo].[Ansat] VALUES (3, N'Zimon', N'zimon@rosbil.dk')


CREATE TABLE [dbo].[Opgave] (
    [Id]            INT           NOT NULL,
    [AnsatId]       INT           NOT NULL,
    [LejeId]        INT           NOT NULL,
    [Beskrivelse]   NVARCHAR (50) NOT NULL,
    [Afsluttet]     BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AnsatId] FOREIGN KEY ([AnsatId]) REFERENCES [Ansat] ([Id]),
    CONSTRAINT [FK_LejeId] FOREIGN KEY ([LejeId]) REFERENCES [Leje] ([Id])
);

INSERT INTO [dbo].[Opgave] VALUES (1, 1, 2, N'Rengør bil', 1)
INSERT INTO [dbo].[Opgave] VALUES (2, 2, 2, N'Se bil efter for skader', 0)
INSERT INTO [dbo].[Opgave] VALUES (3, 3, 5, N'Rengør bil', 0)
INSERT INTO [dbo].[Opgave] VALUES (4, 1, 5, N'Se bil efter for skader', 0)


CREATE TABLE [dbo].[User] (
    [Id]        INT           NOT NULL,
    [Navn]      NVARCHAR (50) NOT NULL,
    [Rolle]     NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[User] VALUES (1, N'admin', N'admin', N'admin')
INSERT INTO [dbo].[User] VALUES (2, N'per', N'ansat', N'abc')